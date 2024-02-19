using Blog.Models.Domain;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Posts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(NewPostViewModel model)
        {
            Post post = new Post
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                Author = model.Author,
                ShortDescription = model.ShortDescription,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                IsVisible = model.IsVisible
            };
            StaticData.AddPost(post);
            return RedirectToAction("Index", "Post");
        }
    }
}
