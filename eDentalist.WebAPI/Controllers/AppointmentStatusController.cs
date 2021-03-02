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
    public class AppointmentStatusController : BaseController<Model.AppointmentStatus, object>
    {
        public AppointmentStatusController(IService<AppointmentStatus, object> service) : base(service)
        {

        }
    }
}