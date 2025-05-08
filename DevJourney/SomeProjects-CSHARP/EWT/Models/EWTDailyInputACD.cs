using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    public class EWTDailyInputACD
    {

        public int Id { get; set; }
        public int EWT_DailyInput_Id { get; set; }
        public string Pers_No { get; set; }
        public int WastedPersonPerHour { get; set; }
        public string AccidentDesc { get; set; }

    }
}
