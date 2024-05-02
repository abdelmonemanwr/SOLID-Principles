using SOLID_Soln.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Services
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Process credit card payment
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }
}
