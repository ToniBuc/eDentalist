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
    public class CityService : BaseCRUDService<Model.City, CitySearchRequest, Database.City, CityUpsertRequest, CityUpsertRequest>
    {
        public CityService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.City> Get(CitySearchRequest search)
        {
            var query = _context.Set<Database.City>().Include(i => i.Country).AsQueryable();

            //if (!string.IsNullOrWhiteSpace(search.CityName) && !string.IsNullOrWhiteSpace(search.CountryName))
            //{
            //    query = query.Where(x => x.Name.Contains(search.CityName) && x.Country.Name.Contains(search.CountryName));
            //}
            //else if (!string.IsNullOrWhiteSpace(search.CityName) && string.IsNullOrWhiteSpace(search.CountryName))
            //{
            //    query = query.Where(x => x.Name.Contains(search.CityName));
            //}
            //else if (!string.IsNullOrWhiteSpace(search.CountryName) && string.IsNullOrWhiteSpace(search.CityName))
            //{
            //    query = query.Where(x => x.Country.Name.Contains(search.CountryName));
            //}

            bool isRequestNull = !string.IsNullOrWhiteSpace(search.CityName) || !string.IsNullOrWhiteSpace(search.CountryName);

            if (isRequestNull)
            {
                query = query.Where(x => x.Name.Contains(search.CityName) || search.CityName.Contains(x.Name) ||
                x.Country.Name.Contains(search.CountryName) || search.CountryName.Contains(x.Country.Name));
            }
            query = query.OrderBy(x => x.Country.Name); // !! KEEP IN MIND

            var list = query.ToList();

            return _mapper.Map<List<Model.City>>(list);
        }
    }
}
