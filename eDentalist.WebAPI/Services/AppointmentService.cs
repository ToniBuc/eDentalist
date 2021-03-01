using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
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
            var query = _context.Set<Database.Appointment>().AsQueryable();

            if (search?.AppointmentID.HasValue == true)
            {
                query = query.Where(x => x.AppointmentID == search.AppointmentID);
            }
            query = query.OrderBy(x => x.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.Appointment>>(list);
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
    }
}
