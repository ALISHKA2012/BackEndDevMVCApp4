using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        private Data.BlogDbContext _blogDbContext;
        public ArticlesController()
        {
            _blogDbContext = new Data.BlogDbContext();
        }
         
        [HttpGet]
        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var articles = await _blogDbContext.Articles.FindAsync(id);

            ArticleDetailsModel model = new ArticleDetailsModel
            {
                Id = articles.Id,
                Title = articles.Title,
                ImagePath = articles.ImagePath,
                Description = articles.Description,
                ShortDescription = articles.ShortDescription,
                Author = new AuthorModel
                {
                    UserId = articles.Author.UserId,
                    Description = articles.Author.Description,
                    ProFilePicture = articles.Author.ProfilePicture,
                    Name = articles.Author.Name,
                    Surname = articles.Author.Surname
                },
                Tags = articles.Tags.Select(t => new TagModel
                {
                    Id = t.Id,
                    Name = t.Name
                }).ToList(),
            };

            if (articles == null)
                return RedirectToAction("Error", "Home");

            return View(model);
        }
    }
}