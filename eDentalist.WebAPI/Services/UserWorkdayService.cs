using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class UserWorkdayService : BaseCRUDService<Model.UserWorkday, UserWorkdaySearchRequest, Database.UserWorkday, UserWorkdayUpsertRequest, UserWorkdayUpsertRequest>
    {
        public UserWorkdayService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.UserWorkday> Get(UserWorkdaySearchRequest search)
        {
            var query = _context.Set<Database.UserWorkday>().AsQueryable();

            if (search?.UserWorkdayID.HasValue == true)
            {
                query = query.Where(x => x.UserWorkdayID == search.UserWorkdayID);
            }
            query = query.OrderBy(x => x.Workday.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.UserWorkday>>(list);
        }
    }
}
