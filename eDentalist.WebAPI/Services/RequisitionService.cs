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
    public class RequisitionService : BaseCRUDService<Model.Requisition, RequisitionSearchRequest, Database.Requisition, RequisitionInsertRequest, RequisitionUpdateRequest>
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

            //query = query.OrderBy(x => x.DateRequisitioned);
            query = query.OrderBy(x => x.Status);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Requisition>>(list);

            foreach(var x in result)
            {
                x.RequisitionedBy = x.User.FirstName + " " + x.User.LastName;
                x.DateRequisitionedString = x.DateRequisitioned.ToShortDateString();
                if (x.EquipmentID != null)
                {
                    x.ItemName = x.Equipment.Name;
                    x.ItemType = "Equipment";
                }
                else if (x.MaterialID != null)
                {
                    x.ItemName = x.Material.Name;
                    x.ItemType = "Material";
                }
            }

            return result;
        }

        public override Model.Requisition Insert(RequisitionInsertRequest request)
        {
            var matTemp = _context.Set<Database.Material>().AsQueryable();
            var equTemp = _context.Set<Database.Equipment>().AsQueryable();

            var reqMat = matTemp.Where(i => i.MaterialID == request.MaterialID && i.Name == request.ItemName).FirstOrDefault();
            var reqEqu = equTemp.Where(i => i.EquipmentID == request.EquipmentID && i.Name == request.ItemName).FirstOrDefault();

            var entity = new Requisition()
            {
                Amount = request.Amount,
                DateRequisitioned = request.DateRequisitioned,
                UserID = request.UserID
            };

            if (reqMat != null)
            {
                entity.MaterialID = request.MaterialID;
            }
            else if (reqEqu != null)
            {
                entity.EquipmentID = request.EquipmentID;
            }

            _context.Requisition.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Requisition>(entity);
        }
    }
}
