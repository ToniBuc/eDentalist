using System;
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
    public class CityController : BaseCRUDController<Model.City, CitySearchRequest, CityUpsertRequest, CityUpsertRequest>
    {
        public CityController(ICRUDService<City, CitySearchRequest, CityUpsertRequest, CityUpsertRequest> service) : base(service)
        {

        }
    }
}