using BlogMVCApp.Models;
using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class CommentsController : Controller
    {

        private Data.BlogDbContext _blogDbContext;
        public CommentsController()
        {
            _blogDbContext = new Data.BlogDbContext();
        }
        // GET: Comments
        [HttpPost]
        [ActionName("Add")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddAsync(CommentModel comment)
        {
            if (ModelState.IsValid)
            {
                comment.CommentDate = DateTime.UtcNow;
                Comment c = new Comment
                {
                    ArticleId = comment.ArticleId,
                    Email = comment.Email,
                    Name = comment.Name,
                    Text = comment.Text,
                    WebSite = comment.WebSite,
                    CommentDate = comment.CommentDate,
                };
                _blogDbContext.Comments.Add(c);
                await _blogDbContext.SaveChangesAsync();
            }
            return RedirectToAction("Details", "Articles", new { id = comment.ArticleId});
        }
    }
}