using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFadeev
{
    public class UActivity
    {
        public int UserID { get; set; }
        public TimeSpan LoginTime { get; set; }
        public TimeSpan LogoutTime { get; set; }
        public TimeSpan TimeInSystem { get; set; }
        public string LogoutRizon { get; set; }
    }
}
