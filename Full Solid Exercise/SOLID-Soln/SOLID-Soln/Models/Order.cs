using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Models
{
    public class Order
    {
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalCost { get; set; }
    }
}
