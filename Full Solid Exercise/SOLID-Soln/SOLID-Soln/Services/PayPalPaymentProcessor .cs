using SOLID_Soln.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Services
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Process PayPal payment
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
