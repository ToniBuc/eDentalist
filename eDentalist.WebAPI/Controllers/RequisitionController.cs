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
    public class RequisitionController : BaseCRUDController<Model.Requisition, RequisitionSearchRequest, RequisitionInsertRequest, RequisitionUpdateRequest>
    {
        public RequisitionController(ICRUDService<Requisition, RequisitionSearchRequest, RequisitionInsertRequest, RequisitionUpdateRequest> service) : base(service)
        {

        }
    }
}