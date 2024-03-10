using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Models;
using Admin.Models;

namespace Admin.Controllers
{
    public class BlogController : Controller
    {
        static BlogService blogservice = new BlogService();
        public IActionResult Index(int id)
        {
            return View(blogservice.ListBlog(id));
        }

        public IActionResult Create()
        {
			CategorieService categorieservice = new CategorieService();
			BlogViewModel vm = new BlogViewModel();
            vm.Categories = categorieservice.ListVM();
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(BlogVM blog)
        {
            blogservice.Create(blog);
			var service = new CategorieService();

			return RedirectToAction("Index","Blog");
        }

        public IActionResult Delete(int id)
        {
            blogservice.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            return View(blogservice.Get(id));
        }

        [HttpPost]
        public IActionResult Update(BlogVM blog)
        {
            blogservice.Update(blog);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            return View(blogservice.DetailBlog(id));
        }
    }
}
