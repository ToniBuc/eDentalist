using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class AppointmentService : BaseCRUDService<Model.Appointment, AppointmentSearchRequest, Database.Appointment, AppointmentInsertRequest, AppointmentUpdateRequest>
    {
        public AppointmentService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Appointment> Get(AppointmentSearchRequest search)
        {
            var query = _context.Set<Database.Appointment>().Include(i => i.Workday).Include(i => i.Dentist).Include(i => i.Patient)
                .Include(i => i.AppointmentStatus).Include(i => i.Procedure).AsQueryable();
            
            bool isRequestNull = !string.IsNullOrWhiteSpace(search.Name);
            query = query.OrderByDescending(x => x.Workday.Date);

            if (isRequestNull)
            {
                query = query.Where(x => x.Dentist.FirstName.Contains(search.Name) || x.Dentist.LastName.Contains(search.Name)
                || x.Patient.FirstName.Contains(search.Name) || x.Patient.LastName.Contains(search.Name));
            }

            //if (search.WorkdayID != null)
            //{
            //    query = query.Where(x => x.WorkdayID == search.WorkdayID);
            //}

            //if (search.DentistID != null)
            //{
            //    query = query.Where(x => x.DentistID == search.DentistID);
            //}

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
            }

            return result;
        }

        public override Model.Appointment GetById(int id)
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

        public override Model.Appointment Insert(AppointmentInsertRequest request)
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

        public override Model.Appointment Update(int id, AppointmentUpdateRequest request)
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
