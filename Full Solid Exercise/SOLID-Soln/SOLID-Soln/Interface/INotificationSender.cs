using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Interface
{
    public interface INotificationSender
    {
        void SendNotification(string message);
    }
}
