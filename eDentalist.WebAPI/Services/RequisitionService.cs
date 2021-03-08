using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
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
            var query = _context.Set<Database.Requisition>().Include(i => i.User).Include(i => i.Material).Include(i => i.Equipment).AsQueryable();

            if (search.RequisitionType != "All")
            {
                if (search.RequisitionType.Equals("Equipment"))
                {
                    query = query.Where(x => x.EquipmentID != null);
                }
                else if (search.RequisitionType.Equals("Material"))
                {
                    query = query.Where(x => x.MaterialID != null);
                }
            }

            query = query.OrderBy(x => x.DateRequisitioned);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Requisition>>(list);

            foreach(var x in result)
            {
                x.RequisitionedBy = x.User.FirstName + " " + x.User.LastName;
                if (x.EquipmentID != null)
                {
                    x.ItemName = x.Equipment.Name;
                }
                else if (x.MaterialID != null)
                {
                    x.ItemName = x.Material.Name;
                }
            }

            return result;
        }
    }
}
