using AutoMapper;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Country, Model.Country>();
            CreateMap<Database.EquipmentType, Model.EquipmentType>();
            CreateMap<Database.HygieneProcessType, Model.HygieneProcessType>();
            CreateMap<Database.UserRole, Model.UserRole>();
            CreateMap<Database.Gender, Model.Gender>();
            CreateMap<Database.Shift, Model.Shift>();
            CreateMap<Database.AppointmentStatus, Model.AppointmentStatus>();

            CreateMap<Database.Material, Model.Material>();
            CreateMap<Database.Material, MaterialUpsertRequest>().ReverseMap();
            CreateMap<Database.Equipment, Model.Equipment>();
            CreateMap<Database.Equipment, EquipmentUpsertRequest>().ReverseMap();
            CreateMap<Database.Procedure, Model.Procedure>();
            CreateMap<Database.Procedure, ProcedureUpsertRequest>().ReverseMap();
            CreateMap<Database.HygieneProcess, Model.HygieneProcess>();
            CreateMap<Database.HygieneProcess, HygieneProcessUpsertRequest>().ReverseMap();
            CreateMap<Database.Requisition, Model.Requisition>();
            CreateMap<Database.Requisition, RequisitionUpsertRequest>().ReverseMap();
            CreateMap<Database.City, Model.City>();
            CreateMap<Database.City, CityUpsertRequest>().ReverseMap();
            CreateMap<Database.Bill, Model.Bill>();
            CreateMap<Database.Bill, BillUpsertRequest>().ReverseMap();
            CreateMap<Database.Workday, Model.Workday>();
            CreateMap<Database.Workday, WorkdayUpsertRequest>().ReverseMap();
            CreateMap<Database.UserWorkday, Model.UserWorkday>();
            CreateMap<Database.UserWorkday, UserWorkdayUpsertRequest>().ReverseMap();
            CreateMap<Database.Rating, Model.Rating>();
            CreateMap<Database.Rating, RatingUpsertRequest>().ReverseMap();
            CreateMap<Database.Appointment, Model.Appointment>();
            CreateMap<Database.Appointment, AppointmentInsertRequest>().ReverseMap();
            CreateMap<Database.Appointment, AppointmentUpdateRequest>().ReverseMap();
            CreateMap<Database.Anamnesis, Model.Anamnesis>();
            CreateMap<Database.Anamnesis, AnamnesisUpsertRequest>().ReverseMap();
        }
    }
}
