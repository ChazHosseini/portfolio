using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    public class EWTDailyInput
    {
        public int Id { get; set; }

        public int EWT_Id { get; set; }

        public int TotalProduction { get; set; }

        public int FiveS { get; set; }

        public string Top5 { get; set; }

        public int Masool_User_Id { get; set; }

        public int NQaSampleQuantity { get; set; }

        public int Auditor_User_Id { get; set; }

        public int NQcSampleQuantity { get; set; }

        public int CheckMan_User_Id { get; set; }

        public string RegisterDate { get; set; }

        
    }
}
