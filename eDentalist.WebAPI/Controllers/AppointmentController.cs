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
    //public class AppointmentController : BaseCRUDController<Model.Appointment, AppointmentSearchRequest, AppointmentInsertRequest, AppointmentUpdateRequest>
    //{
    //    public AppointmentController(ICRUDService<Appointment, AppointmentSearchRequest, AppointmentInsertRequest, AppointmentUpdateRequest> service) : base(service)
    //    {

    //    }
    //}
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _service;
        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Appointment> Get([FromQuery]AppointmentSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Appointment GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet("GetReportAppointments")]
        public List<Model.Appointment> GetReportAppointments([FromQuery]AppointmentSearchRequest request)
        {
            return _service.GetReportAppointments(request);
        }
        [HttpGet("GetTodaysAppointment")]
        public List<Model.Appointment> GetTodaysAppointment([FromQuery]AppointmentSearchRequest request)
        {
            return _service.GetTodaysAppointment(request);
        }
        [HttpPost]
        public Model.Appointment Insert(AppointmentInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Appointment Update(int id, [FromBody]AppointmentUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}