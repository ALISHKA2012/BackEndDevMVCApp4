using BlogMVCApp.infrastrucure;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _itemsPerPage;
        public HomeController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _itemsPerPage = 4;
        }

        // GET: Home
        public ActionResult Index(int page = 1)
        {
        
            return View(_blogDbContext.GetPaginatableArticleData(page, _itemsPerPage));
        }
        public ActionResult Travel()
        {
            return View();
        }
        public ActionResult Fashion()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult Categories()
        {
            return View(_blogDbContext.GetCategoriesData());
        }
    }
}