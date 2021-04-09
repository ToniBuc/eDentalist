using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public interface IAppointmentService
    {
        List<Model.Appointment> Get(AppointmentSearchRequest request);
        List<Model.Appointment> GetReportAppointments(AppointmentSearchRequest request);
        List<Model.Appointment> GetTodaysAppointment(AppointmentSearchRequest request);
        Model.Appointment GetById(int id);
        Model.Appointment Insert(AppointmentInsertRequest request);
        Model.Appointment Update(int id, AppointmentUpdateRequest request);
    }
}
