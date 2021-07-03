using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Data;
using BlogMVCApp.infrastrucure;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private BlogDbContext _blogDbContext;

        public AccountController()
        {
            _blogDbContext = new BlogDbContext();   
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _blogDbContext.Users.GetUserAsync(model);
                if (user == null)
                {
                    ModelState.AddModelError("", "This user does not exist!");
                    return View();
                }
                else
                    Session.Add("UserInfo", user.Email);
                    Response.Cookies.Add(new HttpCookie("myCookie")
                    {
                        Expires = DateTime.Now.AddDays(7),
                        Value = "this is my cookie"
                    });
                    return RedirectToAction(nameof(Succsess));    
            }
            return RedirectToAction(nameof(Error));
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Succsess()
        {
            if (Session["userInfo"] == null)
                return RedirectToAction(nameof(Login));
            else
                return View();
        }
            
    }
}