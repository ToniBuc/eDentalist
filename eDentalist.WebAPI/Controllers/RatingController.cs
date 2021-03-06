﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDentalist.Model;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDentalist.WebAPI.Controllers
{
    public class RatingController : BaseCRUDController<Model.Rating, RatingSearchRequest, RatingUpsertRequest, RatingUpsertRequest>
    {
        public RatingController(ICRUDService<Rating, RatingSearchRequest, RatingUpsertRequest, RatingUpsertRequest> service) : base(service)
        {

        }
    }
}