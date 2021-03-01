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
    public class UserWorkdayController : BaseCRUDController<Model.UserWorkday, UserWorkdaySearchRequest, UserWorkdayUpsertRequest, UserWorkdayUpsertRequest>
    {
        public UserWorkdayController(ICRUDService<UserWorkday, UserWorkdaySearchRequest, UserWorkdayUpsertRequest, UserWorkdayUpsertRequest> service) : base(service)
        {

        }
    }
}