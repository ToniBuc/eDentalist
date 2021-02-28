using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class CityService : BaseCRUDService<Model.City, CitySearchRequest, Database.City, CityUpsertRequest, CityUpsertRequest>
    {
        public CityService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.City> Get(CitySearchRequest search)
        {
            var query = _context.Set<Database.City>().AsQueryable();

            if (search?.CityID.HasValue == true)
            {
                query = query.Where(x => x.CityID == search.CityID);
            }
            query = query.OrderBy(x => x.Country.Name); // !! KEEP IN MIND

            var list = query.ToList();

            return _mapper.Map<List<Model.City>>(list);
        }
    }
}
