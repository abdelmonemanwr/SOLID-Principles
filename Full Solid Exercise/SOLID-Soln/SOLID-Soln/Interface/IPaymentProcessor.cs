using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Interface
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
