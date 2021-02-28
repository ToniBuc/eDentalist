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
    public class MaterialController : BaseCRUDController<Model.Material, MaterialSearchRequest, MaterialUpsertRequest, MaterialUpsertRequest>
    {
        //private readonly IMaterialService _materialService;
        //public MaterialController(IMaterialService materialService)
        //{
        //    _materialService = materialService;
        //}
        public MaterialController(ICRUDService<Material, MaterialSearchRequest, MaterialUpsertRequest, MaterialUpsertRequest> service) : base(service)
        {

        }
    }
}