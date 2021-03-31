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
    public class BillService : BaseCRUDService<Model.Bill, BillSearchRequest, Database.Bill, BillInsertRequest, BillUpdateRequest>
    {
        public BillService(eDentalistDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Bill> Get(BillSearchRequest search)
        {
            var query = _context.Set<Database.Bill>().Include(i => i.Appointment).Include(i => i.Appointment.Procedure).AsQueryable();

            if (search?.PatientID.HasValue == true)
            {
                query = query.Where(x => x.Appointment.PatientID == search.PatientID);
            }
            query = query.OrderBy(x => x.Date);

            var list = query.ToList();

            var result = _mapper.Map<List<Model.Bill>>(list);

            foreach (var x in result)
            {
                x.ProcedureName = x.Appointment.Procedure.Name;
                x.DateString = x.Date.ToShortDateString();
                if (x.IsPaid)
                {
                    x.IsPaidString = "Paid";
                }
                else
                {
                    x.IsPaidString = "Not paid";
                }
            }

            return result;
        }

        public override Model.Bill Insert(BillInsertRequest request)
        {
            var entity = _mapper.Map<Database.Bill>(request);

            _context.Add(entity);

            var appointment = _context.Appointment.Include(i => i.Procedure).FirstOrDefault(i => i.AppointmentID == request.AppointmentID);

            entity.IsPaid = false;
            entity.Date = DateTime.Now;
            entity.PaymentAmount = appointment.Procedure.Price;

            _context.SaveChanges();

            return _mapper.Map<Model.Bill>(entity);
        }

        public override Model.Bill Update(int id, BillUpdateRequest request)
        {
            var entity = _context.Bill.Find(id);

            _mapper.Map(request, entity);
            entity.IsPaid = request.IsPaid;
            _context.SaveChanges();

            return _mapper.Map<Model.Bill>(entity);
        }
    }
}
