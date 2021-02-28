using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDentalist.Model;
using eDentalist.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDentalist.WebAPI.Controllers
{
    public class GenderController : BaseController<Model.Gender, object>
    {
        public GenderController(IService<Gender, object> service) : base(service)
        {

        }
    }
}