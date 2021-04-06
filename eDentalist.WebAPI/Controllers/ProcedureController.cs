using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDentalist.Model;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using eDentalist.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDentalist.WebAPI.Controllers
{
    public class ProcedureController : BaseCRUDController<Model.Procedure, ProcedureSearchRequest, ProcedureUpsertRequest, ProcedureUpsertRequest>
    {
        private static eDentalistDbContext _context;
        private static IMapper _mapper;
        private readonly IRecommendationService<Model.Procedure> _recommendationService;
        public ProcedureController(eDentalistDbContext context, IMapper mapper, IRecommendationService<Model.Procedure> recommendationService, ICRUDService<Model.Procedure, ProcedureSearchRequest, ProcedureUpsertRequest, ProcedureUpsertRequest> service) : base(service)
        {
            _context = context;
            _mapper = mapper;
            _recommendationService = recommendationService;
        }
        [HttpGet("RecommendedProcedures/{ProcedureID}")]
        public List<Model.Procedure> RecommendedProcedures(int ProcedureID)
        {
            //keep in mind
            return _recommendationService.GetSimilarProcedures(ProcedureID).Take(3).ToList();
        }
    }
}