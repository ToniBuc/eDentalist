﻿using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    //public class AppointmentService : BaseCRUDService<Model.Appointment, AppointmentSearchRequest, Database.Appointment, AppointmentInsertRequest, AppointmentUpdateRequest>
    public class AppointmentService : IAppointmentService
    {
        private readonly eDentalistDbContext _context;
        private readonly IMapper _mapper;
        public AppointmentService(eDentalistDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Appointment> Get(AppointmentSearchRequest search)
        {
            var query = _context.Set<Database.Appointment>().Include(i => i.Workday).Include(i => i.Dentist).Include(i => i.Patient)
                .Include(i => i.AppointmentStatus).Include(i => i.Procedure).AsQueryable();
            
            bool isRequestNull = !string.IsNullOrWhiteSpace(search.Name) || !string.IsNullOrWhiteSpace(search.PatientName);
            query = query.OrderByDescending(x => x.Workday.Date);

            //search bar in the desktop app
            if (isRequestNull)
            {
                query = query.Where(x => x.Dentist.FirstName.Contains(search.Name) || x.Dentist.LastName.Contains(search.Name) || search.Name.Contains(x.Dentist.FirstName) || search.Name.Contains(x.Dentist.LastName)
                || x.Patient.FirstName.Contains(search.PatientName) || x.Patient.LastName.Contains(search.PatientName) 
                || search.PatientName.Contains(x.Patient.FirstName) || search.PatientName.Contains(x.Patient.LastName));
            }

            if (search.DentistID != null && search.WorkdayID != null)
            {
                query = query.Where(x => x.WorkdayID == search.WorkdayID && x.DentistID == search.DentistID);
            }
            else if (search.WorkdayID != null && search.DentistID == null)
            {
                query = query.Where(x => x.WorkdayID == search.WorkdayID);
            }
            else if (search.DentistID != null && search.WorkdayID == null)
            {
                query = query.Where(x => x.DentistID == search.DentistID);
            }

            //for retrieving a patient's appointments in the mobile app
            if (search.PatientID != null)
            {
                query = query.Where(x => x.PatientID == search.PatientID);
            }

            //bug that needs fixing, related to date sent through being one hour ahead than what it should be
            if (search.Date.Date == DateTime.Now.Date)
            {
                query = query.Where(x => x.Workday.Date.Date == search.Date.Date && x.From > search.Time);
                query = query.OrderBy(x => x.From);
            }

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Appointment>>(list);

            foreach(var x in result)
            {
                x.AppointmentStatusName = x.AppointmentStatus.Name;
                x.ProcedureName = x.Procedure.Name;
                if (x.DentistID != null)
                {
                    x.DentistName = x.Dentist.FirstName + " " + x.Dentist.LastName;
                }
                else
                {
                    x.DentistName = "(unassigned)";
                }
                x.PatientName = x.Patient.FirstName + " " + x.Patient.LastName;
                x.Date = x.Workday.Date;
                x.FromTo = x.From + " - " + x.To;
                x.DateString = x.Workday.Date.ToShortDateString();

                //specific for mobile, used to display different things in listviews for patients and staff roles
                if (search.PatientID != null)
                {
                    x.PatientOrStatus = x.AppointmentStatus.Name;
                    x.TimeframeOrDatetime = x.Date.ToShortDateString() + " - " + x.From;
                }
                else
                {
                    x.PatientOrStatus = x.Patient.FirstName + " " + x.Patient.LastName;
                    x.TimeframeOrDatetime = x.From + " - " + x.To; 
                }
            }

            return result;
        }

        public Model.Appointment GetById(int id)
        {
            var entity = _context.Appointment.Where(i => i.AppointmentID == id).Include(i => i.AppointmentStatus).Include(i => i.Dentist)
                .Include(i => i.Patient).Include(i => i.Procedure).Include(i => i.Workday).FirstOrDefault();

            var result = _mapper.Map<Model.Appointment>(entity);
            result.AppointmentStatusName = result.AppointmentStatus.Name;
            result.ProcedureName = result.Procedure.Name;
            if (result.DentistID.HasValue)
            {
                result.DentistName = result.Dentist.FirstName + " " + result.Dentist.LastName;
            }
            result.PatientName = result.Patient.FirstName + " " + result.Patient.LastName;
            result.Date = result.Workday.Date;

            return result;
        }

        public List<Model.Appointment> GetReportAppointments(AppointmentSearchRequest search)
        {
            var query = _context.Set<Database.Appointment>().Include(i => i.Workday).Include(i => i.Dentist).Include(i => i.Patient)
                .Include(i => i.AppointmentStatus).Include(i => i.Procedure).AsQueryable();

            if (search.ProcedureID != null && search.From != null && search.To != null)
            {
                query = query.Where(x => x.ProcedureID == search.ProcedureID && x.Workday.Date.Date >= search.From.Value.Date && x.Workday.Date.Date <= search.To.Value.Date);
            }
            else if (search.ProcedureID == null && search.From != null && search.To != null)
            {
                query = query.Where(x => x.Workday.Date.Date >= search.From.Value.Date && x.Workday.Date.Date <= search.To.Value.Date);
            }
            else if (search.ProcedureID != null && search.From == null && search.To == null)
            {
                query = query.Where(x => x.ProcedureID == search.ProcedureID);
            }
            else if (search.ProcedureID != null && search.From != null && search.To == null)
            {
                query = query.Where(x => x.ProcedureID == search.ProcedureID && x.Workday.Date.Date >= search.From.Value.Date);
            }
            else if (search.ProcedureID != null && search.From == null && search.To != null)
            {
                query = query.Where(x => x.ProcedureID == search.ProcedureID && x.Workday.Date.Date <= search.To.Value.Date);
            }
            else if (search.ProcedureID == null && search.From != null && search.To == null)
            {
                query = query.Where(x => x.Workday.Date.Date >= search.From.Value.Date);
            }
            else if (search.ProcedureID == null && search.From == null && search.To != null)
            {
                query = query.Where(x => x.Workday.Date.Date <= search.To.Value.Date);
            }

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Appointment>>(list);

            foreach (var x in result)
            {
                x.AppointmentStatusName = x.AppointmentStatus.Name;
                x.ProcedureName = x.Procedure.Name;
                x.PatientName = x.Patient.FirstName + " " + x.Patient.LastName;
                x.DateString = x.Workday.Date.ToShortDateString();
                x.ProcedurePriceDecimal = x.Procedure.Price;
            }

            return result;
        }
        public List<Model.Appointment> GetTodaysAppointment(AppointmentSearchRequest search)
        {
            var query = _context.Set<Database.Appointment>().Include(i => i.Workday).Include(i => i.Dentist).Include(i => i.Patient)
                .Include(i => i.AppointmentStatus).Include(i => i.Procedure).AsQueryable();

            if (search.PatientID != null)
            {
                query = query.Where(x => x.Workday.Date.Date == search.Date.Date && x.PatientID == search.PatientID && x.AppointmentStatus.Name == "Approved");
            }
            else
            {
                query = query.Where(x => x.Workday.Date.Date == search.Date.Date && x.DentistID == search.DentistID && x.From > DateTime.Now.TimeOfDay && x.AppointmentStatus.Name == "Approved");
                query = query.OrderBy(x => x.From);
            }

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Appointment>>(list);

            foreach (var x in result)
            {
                x.ProcedureName = x.Procedure.Name;
                x.DateString = x.Workday.Date.ToShortDateString();
                x.TimeframeOrDatetime = x.From + " - " + x.To;
            }

            return result;
        }

        public Model.Appointment Insert(AppointmentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Appointment>(request);

            //_context.Set<TDatabase>().Add(entity);
            entity.AppointmentStatusID = 1; // AppointmentStatus = Pending
            //DentistID is null until assigned to appointment through desktop app, this is done in Update
            //PatientID assigned based on user creating the appointment

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Appointment>(entity);
        }

        public Model.Appointment Update(int id, AppointmentUpdateRequest request)
        {

            var entity = _context.Appointment.Find(id);
            _context.Appointment.Attach(entity);
            _context.Appointment.Update(entity);

            if (request.DentistID == 0)
            {
                entity.AppointmentStatusID = request.AppointmentStatusID;
                entity.DentistID = null;
            }
            else
            {
                _mapper.Map(request, entity);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Appointment>(entity);
        }
    }
}
