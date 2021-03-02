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
    public class AnamnesisController : BaseCRUDController<Model.Anamnesis, AnamnesisSearchRequest, AnamnesisUpsertRequest, AnamnesisUpsertRequest>
    {
        public AnamnesisController(ICRUDService<Anamnesis, AnamnesisSearchRequest, AnamnesisUpsertRequest, AnamnesisUpsertRequest> service) : base(service)
        {

        }
    }
}