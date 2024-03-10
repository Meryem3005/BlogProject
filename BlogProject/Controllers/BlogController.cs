using BLL;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	public class BlogController : Controller
	{
		static BlogService bs = new BlogService();
		public IActionResult Index(int id)
		{
			if(id == 0 || id == null)
			{
				return NotFound();
			}
			return View(bs.ListBlog(id));
		}

		public IActionResult Detail(int id) 
		{
			return View(bs.DetailBlog(id));
		}
	}
}
