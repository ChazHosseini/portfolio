using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Zamyad.Exemption.UI.Models;
using Zamyad.Exemption.Service;
using Zamyad.Exemption.Data.SocialDB;

namespace Zamyad.Exemption.UI.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class AccountController : Controller
    {
        PersonnelManagementService _personnelService;


        public AccountController()
        {
            _personnelService = new PersonnelManagementService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Login")]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]

        public ActionResult Login(bool EditProfile = false)
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public ActionResult Login(WebSystemUserViewModel model, string ReturnUrl = "/")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            var user = _personnelService.UserLogin(new WebSystemUser()
            {
               Password=model.Password,
               Username=model.Username

            });


            if (user!=null)
            {
                var claims = new List<Claim>()
                {

                      new Claim(ClaimTypes.NameIdentifier,user.Username),
                      //new Claim(ClaimTypes.Name,user.Result.UserName+"\\"+user.Result.Name+" "+user.Result.Family)

                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    IsPersistent = true
                };
                HttpContext.SignInAsync(principal);

                ViewBag.IsSuccess = true;
                if (ReturnUrl != "/")
                {
                    return Redirect(ReturnUrl);
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("UserName", "کد کاربری یا رمز عبور اشتباه می باشد");
                return View(model);
            }
           
        }
       
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
    }
}
