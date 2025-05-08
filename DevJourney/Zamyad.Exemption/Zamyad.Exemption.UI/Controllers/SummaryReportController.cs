using Microsoft.AspNetCore.Mvc;
using Zamyad.Exemption.Service;
using Zamyad.Exemption.UI.Models;
using Zamyad.Exemption.UI.Models.Enums;

namespace Zamyad.Exemption.UI.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class SummaryReportController : Controller
    {
        PersonnelManagementService _personnelService;


        public SummaryReportController()
        {
            _personnelService = new PersonnelManagementService();
        }


        [HttpGet]
        public IActionResult GetSummaryReport()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetSummaryReport(string searchKey)
        {
            var model = _personnelService.GetPersonnelByFilter(searchKey).Select(s => new PersonnelInfoViewModel()
            {
                FatherName = s.FatherName,
                LastName = s.LastName,
                PersNo = s.PersNo,
                Picture = s.Picture
            });

            return PartialView("_ListOfFoundePersonnel", model);
        }

        [HttpGet]
        public IActionResult GetFullSummaryReport(string id)
        {
            ViewBag.commentandbehdasht = _personnelService.GetBadvEstekhdamByPersNo(id);

            var edari = _personnelService.GetPersonnelByFilter(id).Select(s => new PersonnelInfoViewModel()
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                BirthDate = s.BirthDate,
                FatherName = s.FatherName,
                JobDesc = s.JobDesc,
                CostCode = s.CostCode,
                //SAVABEGH E DAKHEL
                SodCityDesc = s.SodCityDesc,
                MarriedCode = s.MarriedCode,
                MarriedDesc = (int.Parse(s.MarriedCode) == (int)MarryStatusEnum.Married) ? "متاهل" : (int.Parse(s.MarriedCode) == (int)MarryStatusEnum.Single) ? "مجرد" :
    (int.Parse(s.MarriedCode) == (int)MarryStatusEnum.Divorced) ? "مطلقه" : (int.Parse(s.MarriedCode) == (int)MarryStatusEnum.SingleParent) ? "معيل" : "",

                //savabegh isar gari
                PostDesc = s.PostDesc,
                TotCostDesc = s.TotCostDesc,
                OutInsuDays = s.OutInsuDays,
                MilitaryCode = s.MilitaryCode, //needs to change
                EmpDate = s.EmpDate,
                EmployDesc = s.EmployDesc,
                StudyGradeDesc = s.StudyGradeDesc,
                //vahed es sazmani
                //saf-setad
                NationalCode = s.NationalCode,
                IdNo = s.IdNo,
                InsuNo = s.InsuNo,
                CourseDesc = s.CourseDesc,
                RankDesc = s.RankDesc,
                //tedade farzand
                HomeAddress = s.HomeAddress,
                PostalCode = s.PostalCode,
                HomePhoneNo = s.HomePhoneNo,
                MobileNo = s.MobileNo,
                PersNo = s.PersNo,
                exemptionlist = GetTop5Mahdoodiat(s.PersNo),
                hadeselist = GetTop5Hadese(s.PersNo),
                Restlist = GetTop5Rest(s.PersNo),
                PersImage = File(_personnelService.GetPersonnelImage(id), "image/jpeg")


            }).FirstOrDefault();
            return View(edari);

            
            //    return View(edari);
        }

            public List<Data.SocialDB.PersExemptionsView> GetTop5Mahdoodiat(string persNo)
        {
            return  _personnelService.GetTop5ExemptionsFilterByPersNo(persNo).ToList();
        }

        public List<Data.SocialDB.PersHadeseView> GetTop5Hadese(string persNo)
        {
            return _personnelService.GetTop5HadeseFilterByPersNo(persNo).ToList();
        }

        public List<Data.SocialDB.PersRestView> GetTop5Rest(string persNo)
        {
            return _personnelService.GetTop5RestFilterByPersNo(persNo).ToList();
        }

       



    }
}
