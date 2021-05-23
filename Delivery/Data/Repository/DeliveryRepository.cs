using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repository
{
    public class DeliveryRepository
    {

        private readonly AppDBContext context;


        public DeliveryRepository(AppDBContext context)
        {
            this.context = context;
        }

        public IQueryable<Models.Delivery> AllDeliveries()
        {
            return context.Deliveries;
        }


        public void Add(Models.Delivery delivery)
        {
            context.Entry(delivery).State = EntityState.Added;
            context.SaveChanges();
        }

    }
}
