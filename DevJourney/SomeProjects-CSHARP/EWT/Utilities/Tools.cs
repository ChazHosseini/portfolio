using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Utilities
{
    public static class Tools
    {
        public static string GetEWTDBConnection { get { return "User ID=sql_hosseini;Password=******;Persist Security Info=True;Initial Catalog=EWTDB2;Data Source=a-server"; } }

        public static Structs.UserInfoStruct UserInfo { get; set; }
        public static string CurrentDate
        {
            get
            {

                System.Globalization.PersianCalendar persianCalendar =
                  new System.Globalization.PersianCalendar();

                System.DateTime currentDateTime = System.DateTime.Now;

                string year = persianCalendar.GetYear(currentDateTime).ToString();
                string month = persianCalendar.GetMonth(currentDateTime).ToString();
                string day = persianCalendar.GetDayOfMonth(currentDateTime).ToString();


                string todayPersianDate =
                    string.Format("{0}/{1}/{2}", year, (month.Length == 1 ? "0" + month : month), (day.Length == 1 ? "0" + day : day));

                return todayPersianDate;
            }
        }

    }
}
