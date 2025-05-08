using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
   public class EwtMember
    {
        public int Id { get; set; }
        public int EWT_Id { get; set; }
        public string Pers_No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
