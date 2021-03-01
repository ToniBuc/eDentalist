﻿using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class RatingService : BaseCRUDService<Model.Rating, RatingSearchRequest, Database.Rating, RatingUpsertRequest, RatingUpsertRequest>
    {
        public RatingService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Rating> Get(RatingSearchRequest search)
        {
            var query = _context.Set<Database.Rating>().AsQueryable();

            if (search?.RatingID.HasValue == true)
            {
                query = query.Where(x => x.RatingID == search.RatingID);
            }
            query = query.OrderBy(x => x.Procedure.Name);

            var list = query.ToList();

            return _mapper.Map<List<Model.Rating>>(list);
        }
    }
}
