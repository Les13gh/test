using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFadeev
{
       public class OfficeClass
       {
        public Color ColorInDg { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 99;
        public string UserRole { get; set; }
        public string EmailAddress { get; set; }
        public string Office { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public int NumberOfCrashes { get; set; }
        public TimeSpan FullTimeInSystem { get; set; }
        public int ID { get; set; }

        public string[] offices = new string[]
        {
            "Abu dhabi",
            "Cairo",
            "Bahrain",
            "Doha",
            "Riyadh"
        };
        public OfficeClass() { }
        public OfficeClass(int active, int roleid)
        {
            if (active == 0)
            {
                ColorInDg = Color.Red;
            }
            else
            {
                ColorInDg = roleid == 2 ? Color.White: Color.Gold;
            }
        }
    
    }
}
