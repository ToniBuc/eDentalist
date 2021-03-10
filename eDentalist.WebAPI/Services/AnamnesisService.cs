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
    public class AnamnesisService : BaseCRUDService<Model.Anamnesis, AnamnesisSearchRequest, Database.Anamnesis, AnamnesisUpsertRequest, AnamnesisUpsertRequest>
    {
        public AnamnesisService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Anamnesis> Get(AnamnesisSearchRequest search)
        {
            var query = _context.Set<Database.Anamnesis>().Include(i => i.Appointment).Include(i => i.Appointment.Procedure).Include(i => i.Appointment.Workday).AsQueryable();

            //if (search?.AnamnesisID.HasValue == true)
            //{
            //    query = query.Where(x => x.AnamnesisID == search.AnamnesisID);
            //}
            if (search?.PatientID.HasValue == true)
            {
                query = query.Where(x => x.Appointment.PatientID == search.PatientID);
            }
            query = query.OrderBy(x => x.Appointment.Workday.Date);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Anamnesis>>(list);

            foreach(var x in result)
            {
                x.Procedure = x.Appointment.Procedure.Name;
                x.Date = x.Appointment.Workday.Date;
            }

            return result;
        }

        public override Model.Anamnesis GetById(int id)
        {
            var entity = _context.Set<Database.Anamnesis>().Where(i => i.AnamnesisID == id).Include(i => i.Appointment).Include(i => i.Appointment.Procedure)
                .Include(i => i.Appointment.Dentist).Include(i => i.Appointment.Workday).FirstOrDefault();

            var result = _mapper.Map<Model.Anamnesis>(entity);

            result.Procedure = result.Appointment.Procedure.Name;
            result.Date = result.Appointment.Workday.Date;
            result.DentistFullName = result.Appointment.Dentist.FirstName + " " + result.Appointment.Dentist.LastName;

            return result;
        }
    }
}
