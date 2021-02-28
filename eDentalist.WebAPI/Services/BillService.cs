using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class BillService : BaseCRUDService<Model.Bill, BillSearchRequest, Database.Bill, BillUpsertRequest, BillUpsertRequest>
    {
        public BillService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Bill> Get(BillSearchRequest search)
        {
            var query = _context.Set<Database.Bill>().AsQueryable();

            if (search?.BillID.HasValue == true)
            {
                query = query.Where(x => x.BillID == search.BillID);
            }
            query = query.OrderBy(x => x.Date);

            var list = query.ToList();

            return _mapper.Map<List<Model.Bill>>(list);
        }
    }
}
