using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private BlogDbContext _blogDbContext;
        private int _itemsPerPage;
        public AccountController()
        {
            _blogDbContext = new BlogDbContext();
            _itemsPerPage = 4;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _blogDbContext.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
                if (user == null)
                {
                    ModelState.AddModelError("", "Given email or password is wrong!");
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                        
                }
            }
            return View();
        }
    }
}