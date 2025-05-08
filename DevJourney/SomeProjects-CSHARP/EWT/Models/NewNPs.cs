using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    public class NewNPs
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int DepartmentIndex_Id { get; set; }
        public int MeetingMinutes { get; set; }
        public string BossExplanation { get; set; }
    }
}
