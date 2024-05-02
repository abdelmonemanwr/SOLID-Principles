using SOLID_Soln.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Services
{
    public class EmailNotifier : INotificationSender
    {
        public void SendNotification(string message)
        {
            // Send email notification
            Console.WriteLine(message);
        }
    }
}
