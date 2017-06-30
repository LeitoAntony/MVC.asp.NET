using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using MVCTutorial1.Models;

namespace MVCTutorial1.Context
{
    public class StoreContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}