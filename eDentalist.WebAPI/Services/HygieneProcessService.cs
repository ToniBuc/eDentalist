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
    public class HygieneProcessService : BaseCRUDService<Model.HygieneProcess, HygieneProcessSearchRequest, Database.HygieneProcess, HygieneProcessUpsertRequest, HygieneProcessUpsertRequest>
    {
        public HygieneProcessService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.HygieneProcess> Get(HygieneProcessSearchRequest search)
        {
            var query = _context.Set<Database.HygieneProcess>().Include(i => i.HygieneProcessType).Include(i => i.User).Include(i => i.User.UserRole).AsQueryable();

            //if (search?.HygieneProcessTypeID.HasValue == true)
            //{
            //    query = query.Where(x => x.HygieneProcessTypeID == search.HygieneProcessTypeID);
            //}
            if (search?.HygieneProcessTypeID != 0)
            {
                query = query.Where(x => x.HygieneProcessTypeID == search.HygieneProcessTypeID);
            }
            query = query.OrderBy(x => x.HygieneProcessType.Name); // !! KEEP IN MIND

            var list = query.ToList();

            var result = _mapper.Map<List<Model.HygieneProcess>>(list);

            foreach (var x in result)
            {
                x.HygieneProcessTypeName = x.HygieneProcessType.Name;
                x.StaffName = x.User.FirstName + " " + x.User.LastName + " (" + x.User.UserRole.Name + ")";
            }

            return result;
        }
    }
}
