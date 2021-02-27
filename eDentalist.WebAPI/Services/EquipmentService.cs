using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
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
            var query = _context.Set<Database.Equipment>().AsQueryable();

            if (search?.EquipmentID.HasValue == true)
            {
                query = query.Where(x => x.EquipmentID == search.EquipmentID);
            }
            query = query.OrderBy(x => x.Name);

            var list = query.ToList();

            return _mapper.Map<List<Model.Equipment>>(list);
        }
    }
}
