using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_App
{
    public class User
    {
        public string foreName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string status { get; }
        public string imageLink { get;}

        public DateTime lastActive { get; }

        public User(string foreName, string surName, string email, string phoneNumber, string status, string imageLink, DateTime lastActive)
        {
            this.foreName = foreName;
            this.surName = surName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.status = status;
            this.imageLink = imageLink;
            this.lastActive = lastActive;
        }

        //Returns the user's full name as a string
        public string GetNameAsString()
        {
            return $"{foreName} {surName}";
        }
    }
}
