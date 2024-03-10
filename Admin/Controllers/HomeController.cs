using Admin.Models;
using BLL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Models;

namespace Admin.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		static CategorieService categorieservice = new CategorieService();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		
		public IActionResult Index()
		{
			return View(categorieservice.ListVM());
		}


		public IActionResult Create()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Create(CategorieVM categorie)
		{
			try
			{
				categorieservice.AddCategorie(categorie);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		public IActionResult Update(int id)
		{
			CategorieVM categorie = categorieservice.GetCategorie(id);
			return View(categorie);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(CategorieVM model)
		{
			try
			{
				categorieservice.UpdateCategorie(model);
				return RedirectToAction("Index");
			}
			catch
			{ 
				return View();
			}

		}

		public IActionResult Delete(int id)
		{
			categorieservice.SupprimerCategorie(id);
			return RedirectToAction("Index");
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}