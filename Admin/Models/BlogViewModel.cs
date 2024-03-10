using DAL.Entity;
using Models;

namespace Admin.Models
{
	public class BlogViewModel
	{
		public List<CategorieVM> Categories { get; set; }
		public BlogVM Blog { get; set; }
	}
}
