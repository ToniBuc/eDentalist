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
    public class BillController : BaseCRUDController<Model.Bill, BillSearchRequest, BillInsertRequest, BillUpdateRequest>
    {
        public BillController(ICRUDService<Bill, BillSearchRequest, BillInsertRequest, BillUpdateRequest> service) : base(service)
        {

        }
    }
}