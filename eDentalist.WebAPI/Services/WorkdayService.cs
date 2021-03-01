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
            var query = _context.Set<Database.Workday>().AsQueryable();

            if (search?.WorkdayID.HasValue == true)
            {
                query = query.Where(x => x.WorkdayID == search.WorkdayID);
            }
            query = query.OrderBy(x => x.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.Workday>>(list);
        }
    }
}
