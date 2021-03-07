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
    public class EquipmentService : BaseCRUDService<Model.Equipment, EquipmentSearchRequest, Database.Equipment, EquipmentUpsertRequest, EquipmentUpsertRequest>
    {
        public EquipmentService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Equipment> Get(EquipmentSearchRequest search)
        {
            var query = _context.Set<Database.Equipment>().Include(i => i.EquipmentType).AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(search.Name);

            if (search?.EquipmentID.HasValue == true)
            {
                query = query.Where(x => x.EquipmentID == search.EquipmentID);
            }
            if (isRequestNull)
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }
            query = query.OrderBy(x => x.Name);

            var list = query.ToList();
            var result = _mapper.Map<List<Model.Equipment>>(list);

            foreach(var x in result)
            {
                x.EquipmentTypeName = x.EquipmentType.Name;
            }

            return result;
        }
    }
}
