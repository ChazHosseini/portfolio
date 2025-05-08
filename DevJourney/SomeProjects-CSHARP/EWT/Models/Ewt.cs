using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
   public class Ewt
    {
        public int Id { get; set; }

        public int CostGroup_Id { get; set; }
        public string Title { get; set; }
        public string GroupIndex { get; set; }
        public string CostCode { get; set; }
        public int DepartmentIndex_Id { get; set; }
    }
}
