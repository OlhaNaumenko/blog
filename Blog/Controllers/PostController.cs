using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var posts = StaticData.Posts.Select(post => new PostViewModel
            {
                ShortDescription = post.ShortDescription,
                Name = post.Name,
                Author = post.Author
            }).ToList();
            return View(posts);
        }

        public IActionResult Post() 
        { 
            return View(); 
        }


    }
}
