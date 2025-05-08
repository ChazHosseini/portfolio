using Microsoft.AspNetCore.Mvc;
using Zamyad.Exemption.UI.Models;
using Zamyad.Exemption.Service;
using Zamyad.Exemption.UI.Models.Enums;

namespace Zamyad.Exemption.UI.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class HadeseController : Controller
    {
        PersonnelManagementService _personnelService;
        public HadeseController()
        {
            _personnelService = new PersonnelManagementService();
        }

        [HttpGet]
        public IActionResult GetHadeseReport()
        {
            return View("SearchHadesePers");
        }

        [HttpPost]
        public IActionResult GetHadeseReport(string searchKey)
        {
            var model = _personnelService.GetPersonnelByFilter(searchKey).Select(s => new PersonnelInfoViewModel()
            {
                FatherName = s.FatherName,
                LastName = s.LastName,
                PersNo = s.PersNo

            });

            return PartialView("_ListOfFoundePersonnelForHadese", model);
        }

        public IActionResult GetFullHadeseReport(string id)
        {
            var hadeseInfo = _personnelService.GetPersonnelByFilter(id).Select(s => new PersonnelInfoViewModel()
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                BirthDate = s.BirthDate,
                FatherName = s.FatherName,
                InsuNo = s.InsuNo,
                IdNo = s.IdNo,
                SodCityDesc = s.SodCityDesc,
                NationalCode = s.NationalCode,
                BirCityDesc = s.BirCityDesc,
                JobDesc = s.JobDesc,
                CostCode = s.CostCode,
                MarriedCode = s.MarriedCode,
                StudyGradeDesc = s.StudyGradeDesc,
                EmpDate = s.EmpDate,
                EmployDesc = s.EmployDesc,
                HomeAddress = s.HomeAddress,
                PostalCode = s.PostalCode,
                MobileNo = s.MobileNo,
                PersNo = s.PersNo,
                PersImage = File(_personnelService.GetPersonnelImage(id), "image/jpeg")

            }).FirstOrDefault();
            return View(hadeseInfo);

        }
    }
}
