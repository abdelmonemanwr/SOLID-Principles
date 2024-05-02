using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID_Soln.Models
{
    public class EcommerceContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}