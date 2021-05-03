﻿using BlogMVCApp.infrastrucure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class FashionController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _itemsPerPage;
        public FashionController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _itemsPerPage = 4;
        }
        // GET: Fashion
        public ActionResult Index(int page = 1)
        {

            return View(_blogDbContext.GetPaginatableArticleData(page, _itemsPerPage));
        }
    }
}