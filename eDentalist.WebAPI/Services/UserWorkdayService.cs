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
    public class UserWorkdayService : BaseCRUDService<Model.UserWorkday, UserWorkdaySearchRequest, Database.UserWorkday, UserWorkdayUpsertRequest, UserWorkdayUpsertRequest>
    {
        public UserWorkdayService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.UserWorkday> Get(UserWorkdaySearchRequest search)
        {
            var query = _context.Set<Database.UserWorkday>().Include(i => i.Workday).Include(i => i.Shift).Include(i => i.User).Include(i => i.User.UserRole).AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(search.Name);

            if (isRequestNull)
            {
                query = query.Where(x => x.User.FirstName.Contains(search.Name) || x.User.LastName.Contains(search.Name));
            }

            query = query.OrderByDescending(x => x.Workday.Date);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.UserWorkday>>(list);

            foreach(var x in result)
            {
                x.UserFullName = x.User.FirstName + " " + x.User.LastName;
                x.UserRole = x.User.UserRole.Name;
                x.Date = x.Workday.Date;
                x.ShiftNumber = int.Parse(x.Shift.ShiftNumber);
            }

            return result;
        }

        public override Model.UserWorkday GetById(int id)
        {
            var entity = _context.UserWorkday.Where(i => i.UserWorkdayID == id).Include(i => i.Workday).FirstOrDefault();
            var result = _mapper.Map<Model.UserWorkday>(entity);
            result.Date = result.Workday.Date;

            return result;
        }

        public override Model.UserWorkday Insert(UserWorkdayUpsertRequest request)
        {
            var workday = _context.Set<Database.Workday>().Where(i => i.Date.Date == request.Date.Date).FirstOrDefault();

            var entity = _mapper.Map<Database.UserWorkday>(request);
            entity.WorkdayID = workday.WorkdayID;

            _context.UserWorkday.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.UserWorkday>(entity);
        }

        public override Model.UserWorkday Update(int id, UserWorkdayUpsertRequest request)
        {
            var workday = _context.Set<Database.Workday>().Where(i => i.Date.Date == request.Date.Date).FirstOrDefault();

            var entity = _context.UserWorkday.Find(id);
            _context.UserWorkday.Attach(entity);
            _context.UserWorkday.Update(entity);

            _mapper.Map(request, entity);
            entity.WorkdayID = workday.WorkdayID;

            _context.SaveChanges();

            return _mapper.Map<Model.UserWorkday>(entity);
        }
    }
}
