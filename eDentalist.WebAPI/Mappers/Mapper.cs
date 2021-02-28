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
        }
    }
}
