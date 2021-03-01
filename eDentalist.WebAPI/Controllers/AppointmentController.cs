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
    public class AppointmentController : BaseCRUDController<Model.Appointment, AppointmentSearchRequest, AppointmentInsertRequest, AppointmentUpdateRequest>
    {
        public AppointmentController(ICRUDService<Appointment, AppointmentSearchRequest, AppointmentInsertRequest, AppointmentUpdateRequest> service) : base(service)
        {

        }
    }
}