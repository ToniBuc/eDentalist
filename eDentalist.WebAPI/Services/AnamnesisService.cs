using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
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
            var query = _context.Set<Database.Anamnesis>().AsQueryable();

            if (search?.AnamnesisID.HasValue == true)
            {
                query = query.Where(x => x.AnamnesisID == search.AnamnesisID);
            }
            query = query.OrderBy(x => x.Appointment.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.Anamnesis>>(list);
        }
    }
}
