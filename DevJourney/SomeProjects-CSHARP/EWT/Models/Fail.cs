using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Models
{
    public class Fail
    {
        public int Id { get; set; }

        public string FailDesc { get; set; }

        public string ReasonDesc { get; set; }

        public bool IsForNR { get; set; }

        public bool IsForNP { get; set; }

        public bool IsForNQc { get; set; }

        public bool IsForNQa { get; set; }

        public bool IsForSTP { get; set; }

        public bool IsForREW { get; set; }

        public bool IsForWAS { get; set; }

        public bool IsForZVA { get; set; }

        public bool IsForASPECT { get; set; }

    }
}
