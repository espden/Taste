using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(OrderHeader orderHeader)
        {
            var objFromDb = _db.OrderHeader.FirstOrDefault(s => s.Id == orderHeader.Id);
            _db.OrderHeader.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
