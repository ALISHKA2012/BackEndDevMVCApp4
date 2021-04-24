namespace BlogMVCApp.Migrations
{
    using BlogMVCApp.Models;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogMVCApp.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BlogMVCApp.Data.BlogDbContext context)
        {
            context.Menus.AddOrUpdate(
                new Models.Menu
                {
                    Id = 1,
                    IsActive = true,
                    Name = "Travel",
                    ControllerName = "Home",
                    ActionName = "Travel",
                    Order = 1
                },
                new Models.Menu
                                {
                                    Id = 2,
                                    IsActive = true,
                                    Name = "Fashion",
                                    ControllerName = "Home",
                                    ActionName = "Fashion",
                                    Order = 2
                                },
                new Models.Menu
                                                {
                                                    Id = 3,
                                                    IsActive = true,
                                                    Name = "About",
                                                    ControllerName = "Home",
                                                    ActionName = "About",
                                                    Order = 3
                                                },
                new Models.Menu
                {
                    Id = 4,
                    IsActive = true,
                    Name = "Contact",
                    ControllerName = "Home",
                    ActionName = "Contact",
                    Order = 3
                }

                
                
           );

            string email = ConfigurationManager.AppSettings["email"];
            string password = ConfigurationManager.AppSettings["email"];
            string username = ConfigurationManager.AppSettings["username"];

            context.Users.AddOrUpdate(new User
            {
                Id = 1,
                IsActive = true,
                IsAuthor = true,
                Email = email,
                Password = password,
                UserName = username
            });
            context.Authors.AddOrUpdate(new Author
            {
               UserId = 1,
                Id = 1
            });
            context.Articles.AddOrUpdate(new Article
            {
                Id = 1,
                AuthorId = 1,
                ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath = "image_1.jpg",
                MenuId = 1,
                PublishDate = DateTime.Now,
                Title = "A Loving Heart is the Truest Wisdom",
                ViewCount = 1,
                WrittenDate = DateTime.Now,

            },
            new Article
            {
                Id = 2,
                AuthorId = 1,
                ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath = "image_2.jpg",
                MenuId = 1,
                PublishDate = DateTime.Now,
                Title = "Great Things Never Came from Comfort Zone",
                ViewCount = 1,
                WrittenDate = DateTime.Now,

            },
            new Article
            {
                Id = 3,
                AuthorId = 1,
                ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath = "image_3.jpg",
                MenuId = 1,
                PublishDate = DateTime.Now,
                Title = "Paths Are Made by Walking",
                ViewCount = 1,
                WrittenDate = DateTime.Now,

            }
            );
            context.Categories.AddOrUpdate(new Category
            {
                Id = 1,
                Name = "Fashion"
            },
            new Category
            {
                Id = 2,
                Name = "Technology"
            },
            new Category
            {
                Id = 3,
                Name = "Travel"

            },
            new Category
            {
                Id = 4,
                Name = "Food"
            },
            new Category
            {
                Id = 5,
                Name = "Photography"

            },
            new Category
            {
                Id = 6,
                Name = "LifeStyle"

            });

        }
    }
}
