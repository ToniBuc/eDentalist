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
    public class MaterialService : BaseCRUDService<Model.Material, MaterialSearchRequest, Database.Material, MaterialUpsertRequest, MaterialUpsertRequest>
    {
        public MaterialService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Material> Get(MaterialSearchRequest search)
        {
            var query = _context.Set<Database.Material>().AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(search.Name);

            if (search?.MaterialID.HasValue == true)
            {
                query = query.Where(x => x.MaterialID == search.MaterialID);
            }
            if (isRequestNull)
            {
                query = query.Where(x => x.Name.Contains(search.Name) || search.Name.Contains(x.Name));
            }
            query = query.OrderBy(x => x.Name);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Material>>(list);

            foreach(var x in result)
            {
                x.DateAddedString = x.DateAdded.ToShortDateString();
                x.LastUsedString = x.LastUsed.ToShortDateString();
            }

            return result;
        }
    }
}
