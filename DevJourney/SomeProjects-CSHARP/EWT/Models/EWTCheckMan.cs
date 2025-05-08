using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    class EWTCheckMan
    {

        public int EWT_Id { get; set; }

        public string PERS_NO { get; set; }

        public string RegisterDate { get; set; }

        public bool IsActive { get; set; }

        public string Title { get; set; }

        public int CostGroup_Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Cost_Desc { get; set; }

    }
}
