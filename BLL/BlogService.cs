using DAL.Repos;
using DAL.Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL
{
	public class BlogService
	{
		static BlogRepos blogRepos = new BlogRepos();

		public List<BlogVM> ListBlog(int idCategorie)
		{
			List<BlogVM> l = new List<BlogVM>();
			foreach (var item in blogRepos.All().Where(a => a.CategorieId == idCategorie))
			{
				BlogVM v = new BlogVM();
				v.Id = item.Id;
				v.Name = item.Name;
				v.CategorieId = item.CategorieId;
				v.Content = item.Content;
				l.Add(v);
			}
			return l;
		}
		public BlogVM DetailBlog(int id)
		{
			BlogVM obj = new BlogVM();
			Blog src = blogRepos.Read(id);
			obj.Id = src.Id;
			obj.Name = src.Name;
			obj.Content = src.Content;
			obj.CategorieId = src.CategorieId;

			return obj;
		}

		public void Create(BlogVM blog)
		{
			Blog blog1 = new Blog
			{
				Id = blog.Id,
				Name = blog.Name,
				Content = blog.Content,
				CategorieId = blog.CategorieId
			};
			blogRepos.Create(blog1);
		}

		public void Delete(int id)
		{
			blogRepos.Delete(id);
		}


		public void Update(BlogVM blog)
		{
			Blog blog1 = blogRepos.Get(blog.Id);
			if(blog1 != null)
			{
				blog1.Name = blog.Name;
				blog1.Content = blog.Content;
				blog1.CategorieId = blog.CategorieId;
				blogRepos.Update(blog1);
			}
		}

		public BlogVM Get(int Id)
		{
			Blog rep = blogRepos.Get(Id);
			BlogVM b = new BlogVM();
			b.Id = Id;
			b.Name = rep.Name;
			b.Content = rep.Content;
			b.CategorieId= rep.CategorieId;
			return b;
		}





	}

	
}
