using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailsRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(OrderDetails orderDetails)
        {
            var objFromDb = _db.OrderDetails.FirstOrDefault(s => s.Id == orderDetails.Id);
            _db.OrderDetails.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
