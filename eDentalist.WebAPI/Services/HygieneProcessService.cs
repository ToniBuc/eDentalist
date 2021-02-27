using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class HygieneProcessService : BaseCRUDService<Model.HygieneProcess, HygieneProcessSearchRequest, Database.HygieneProcess, HygieneProcessUpsertRequest, HygieneProcessUpsertRequest>
    {
        public HygieneProcessService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.HygieneProcess> Get(HygieneProcessSearchRequest search)
        {
            var query = _context.Set<Database.HygieneProcess>().AsQueryable();

            if (search?.HygieneProcessID.HasValue == true)
            {
                query = query.Where(x => x.HygieneProcessID == search.HygieneProcessID);
            }
            query = query.OrderBy(x => x.HygieneProcessType.Name); // !! KEEP IN MIND

            var list = query.ToList();

            return _mapper.Map<List<Model.HygieneProcess>>(list);
        }
    }
}
