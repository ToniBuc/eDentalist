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
    public class ProcedureController : BaseCRUDController<Model.Procedure, ProcedureSearchRequest, ProcedureUpsertRequest, ProcedureUpsertRequest>
    {
        public ProcedureController(ICRUDService<Procedure, ProcedureSearchRequest, ProcedureUpsertRequest, ProcedureUpsertRequest> service) : base(service)
        {

        }
    }
}