using BlogMVCApp.infrastrucure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class TravelController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _itemsPerPage;
        public TravelController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _itemsPerPage = 4;
        }
        // GET: Fashion
        public async Task<ActionResult> Index(int page = 1)
        {

            return View(await _blogDbContext.GetPaginatableTravelArticleDataAsync(page, _itemsPerPage));
        }
    }
}