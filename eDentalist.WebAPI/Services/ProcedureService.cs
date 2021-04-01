using AutoMapper;
using eDentalist.Model;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class ProcedureService : BaseCRUDService<Model.Procedure, ProcedureSearchRequest, Database.Procedure, ProcedureUpsertRequest, ProcedureUpsertRequest>
    {
        public ProcedureService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Procedure> Get(ProcedureSearchRequest search)
        {
            var query = _context.Set<Database.Procedure>().AsQueryable();

            if (search?.ProcedureID.HasValue == true)
            {
                query = query.Where(x => x.ProcedureID == search.ProcedureID);
            }
            query = query.OrderBy(x => x.Name);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Procedure>>(list);

            foreach(var x in result)
            {
                x.PriceString = x.Price.ToString() + " KM";
            }

            return result;
        }
    }
}
