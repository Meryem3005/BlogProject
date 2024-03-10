using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class BlogVM
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int CategorieId { get; set; }
		public string Content { get; set; } = string.Empty;
	}
}
