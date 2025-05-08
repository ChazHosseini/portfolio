using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
   public class EWTDailyInputNR
    {
        public int Id { get; set; }
        public int EWT_DailyInput_Id { get; set; }
        public int Fail_Id { get; set; }
        public int Quantity { get; set; }
        public string FailDesc { get; set; }
        public string ReasonDesc { get; set; }
    }
}
