using AutoMapper;
using eDentalist.WebAPI.Database;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class WorkdayService : BaseCRUDService<Model.Workday, WorkdaySearchRequest, Database.Workday, WorkdayUpsertRequest, WorkdayUpsertRequest>
    {
        public WorkdayService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Workday> Get(WorkdaySearchRequest search)
        {
            var query = _context.Workday.AsQueryable();

            if (search.Date != null)
            {
                query = query.Where(i => i.Date.Date == search.Date.Date);
            }

            query = query.OrderBy(x => x.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.Workday>>(list);
        }
    }
}
