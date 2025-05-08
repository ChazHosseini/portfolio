using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Structs
{
    public class UserInfoStruct
    {
        public int UserId { get; set; }
        public string PersNo { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }

        public EWT.Enums.BusinessRoleEnum UserBusinessRole  { get; set; }

        public string PictureAddress { get { return @"\\main\Picturs\" + PersNo.Substring(0, 1) + @"\" + PersNo + ".jpg"; } }
    }
}
