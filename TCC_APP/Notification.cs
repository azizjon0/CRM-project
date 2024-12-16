using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_App
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public List<User> Recipients { get; set; }

        public void SendNotification() { }
        public void ScheduleNotification() {  }
        public void PullNotifications() {  }
    }

}
