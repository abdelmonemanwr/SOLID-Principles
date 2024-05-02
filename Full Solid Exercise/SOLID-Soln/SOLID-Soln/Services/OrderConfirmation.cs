using SOLID_Soln.Interface;
using SOLID_Soln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Services
{
    public class OrderConfirmation : IOrderConfirmation
    {
        public void SendOrderConfirmationEmail(Order order)
        {
            string message = $"Order confirmation for {order.CustomerName}:\n";
            message += $"Total Cost: ${order.TotalCost}\n";
            message += "Products:\n";
            foreach (Product product in order.Products)
            {
                message += $"- {product.Name} (${product.Price})\n";
            }
            // Send email
            Console.WriteLine(message);
        }
    }
}
