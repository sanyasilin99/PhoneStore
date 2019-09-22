using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWebApplication.Models
{
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchare> Purchares { get; set; }
    }

    public class PhoneDbInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone { Model = "Samsung", Color = "White", Price = 15000 });
            context.Phones.Add(new Phone { Model = "Apple", Color = "White", Price = 25000 });
            context.Phones.Add(new Phone { Model = "Nokia", Color = "Black", Price = 5000 });

            base.Seed(context);
        }
    }
}