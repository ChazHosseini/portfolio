using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamyad.Exemption.Data.EdariDB;
using Zamyad.Exemption.Data.SocialDB;
using static System.Net.Mime.MediaTypeNames;

namespace Zamyad.Exemption.Service
{
    public class PersonnelManagementService
    {
        EdariDB2Context _context;
        SocialDBContext _socialDBContext;


        public PersonnelManagementService()
        {
            _context = new EdariDB2Context();  //injection fail
            _socialDBContext = new SocialDBContext();
        }

        public List<ActivePersonV> GetPersonnelByFilter(string searchParam)
        {
           return _context.ActivePersonVs.Where(s => s.PersNo.Contains(searchParam) || s.LastName.Contains(searchParam)).ToList();  //async fail
            
        }

        public List<PersExemptionsView> GetTop5ExemptionsFilterByPersNo(string persno)
        {
           return _socialDBContext.PersExemptionsViews.Where(s => s.PersNo == persno).OrderByDescending(s => s.StartDate).Take(5).ToList();
            
        }

        public List<PersHadeseView> GetTop5HadeseFilterByPersNo(string persno)
        {
          return   _socialDBContext.PersHadeseViews.Where(s => s.PersNo == persno).OrderByDescending(s => s.AccDate).Take(5).ToList();
            
        }

        public List<PersRestView> GetTop5RestFilterByPersNo(string persno) //where condition and selecting top 5 by descending order
        {
            return _socialDBContext.PersRestViews.Where(s => s.PersNo == persno).OrderByDescending(s => s.Fdate).Take(5).ToList();
        }

        public Tuple<string?,string?>? GetBadvEstekhdamByPersNo(string persno) //where condition and selecting specific columns
        {
            var mycomment =  _socialDBContext.PersExemptionsViews.Where(s => s.PersNo == persno && s.IsBadv == "+").Select(s => new { s.Comment, s.Behdasht }).FirstOrDefault();
            if (mycomment != null)
            {
                return new Tuple<string?, string?>(mycomment.Comment, mycomment.Behdasht);
            }
           else { 
                return new Tuple<string?, string?>("", "");
            }
            
        }

        public Byte[] GetPersonnelImage(string persno)
        {
            string path = @"\\main\Picturs\" + persno.Substring(0, 1) + @"\" + persno + ".jpg";
            Byte[] b = System.IO.File.ReadAllBytes(path);
            return b;
        }

        public WebSystemUser UserLogin(WebSystemUser model)
        {
           var user= _socialDBContext.WebSystemUsers.Where(u => u.IsActive == true && u.Username.Equals(model.Username) && u.Password.Equals(model.Password)).FirstOrDefault();
            if (user != null) 
            {
               return user;

            }
            return null;
        }



    }
}
 