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
    [Route("api/[controller]")]
    [ApiController]
    public class HygieneProcessController : BaseCRUDController<Model.HygieneProcess, HygieneProcessSearchRequest, HygieneProcessUpsertRequest, HygieneProcessUpsertRequest>
    {
        public HygieneProcessController(ICRUDService<HygieneProcess, HygieneProcessSearchRequest, HygieneProcessUpsertRequest, HygieneProcessUpsertRequest> service) : base(service)
        {

        }
    }
}