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
    public class WorkdayController : BaseCRUDController<Model.Workday, WorkdaySearchRequest, WorkdayUpsertRequest, WorkdayUpsertRequest>
    {
        public WorkdayController(ICRUDService<Workday, WorkdaySearchRequest, WorkdayUpsertRequest, WorkdayUpsertRequest> service) : base(service)
        {

        }
    }
}