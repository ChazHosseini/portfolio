using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zamyad.Exemption.Service.Utility;

namespace Zamyad.Exemption.Service
{
    public static class Utility
    {

        public static ToPersianResult ToPersian(this string persianStringDate)
        {
            try
            {
                PersianCalendar persianDate = new PersianCalendar();
                var result = new ToPersianResult()
                {
                    CurentDataTime = persianDate.ToDateTime(int.Parse(persianStringDate.Substring(0, 4)),
                    int.Parse(persianStringDate.Substring(5, 2)), int.Parse(persianStringDate.Substring(8, 2)), 0, 0, 0, 0),
                    Error = "",
                    IsError = false,
                };
                return result;
            }
            catch
            {
                return  new ToPersianResult()
                {
                    CurentDataTime = null,
                    Error = "",
                    IsError = true,
                };
            }


        }

        public class ToPersianResult
        {
            public DateTime? CurentDataTime { get; set; }

            public string Error { get; set; }
            public bool IsError { get; set; }
        }


    }
}
