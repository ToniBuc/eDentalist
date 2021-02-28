using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class RequisitionService : BaseCRUDService<Model.Requisition, RequisitionSearchRequest, Database.Requisition, RequisitionUpsertRequest, RequisitionUpsertRequest>
    {
        public RequisitionService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Requisition> Get(RequisitionSearchRequest search)
        {
            var query = _context.Set<Database.Requisition>().AsQueryable();

            if (search?.RequisitionID.HasValue == true)
            {
                query = query.Where(x => x.RequisitionID == search.RequisitionID);
            }
            query = query.OrderBy(x => x.DateRequisitioned);

            var list = query.ToList();

            return _mapper.Map<List<Model.Requisition>>(list);
        }
    }
}
