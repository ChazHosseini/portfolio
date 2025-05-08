using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    public class EWTDailyInputREW
    {
        public int Id { get; set; }
        public int EWT_DailyInput_Id { get; set; }
        public int Fail_Id { get; set; }
        public string FailDesc { get; set; }
        public string Part_Code { get; set; }
        public string Part_Desc { get; set; }
        public int Quantity { get; set; }
        public int Person_Per_Hour { get; set; }

    }
}
