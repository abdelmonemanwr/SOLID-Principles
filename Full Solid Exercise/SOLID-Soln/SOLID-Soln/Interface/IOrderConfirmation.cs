using SOLID_Soln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Interface
{
    public interface IOrderConfirmation
    {
        public void SendOrderConfirmationEmail(Order order);
    }
}
