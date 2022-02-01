using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFadeev
{
    public class Manager
    {
        public static void UserLogout(OfficeClass user, UActivity uActivity, string logoutRizon)
        {
            uActivity.LogoutTime = DateTime.Now.TimeOfDay;

            uActivity.LogoutRizon = logoutRizon;

            uActivity.TimeInSystem = uActivity.LogoutTime.Subtract(uActivity.LoginTime);

            user.FullTimeInSystem = user.FullTimeInSystem.Add(uActivity.LogoutTime.Subtract(uActivity.LoginTime));

            GetbdClass getD = new GetbdClass();

            getD.InsertUActivity(uActivity);

            getD.UpdateUserTimeInSystem(user.FullTimeInSystem, user.EmailAddress);

            if (logoutRizon == "WindowsShutDown")
            {
                getD.IncrementCrashes(user.EmailAddress);
            }
        }
    }
}
