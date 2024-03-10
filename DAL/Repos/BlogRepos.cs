using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repos
{
	public class BlogRepos
	{
		static MyDbContext db = new MyDbContext();
		public List<Blog> All()
		{
			return db.Blogs.ToList();
		}

		public Blog? Read(int id)
		{
			return db.Blogs.Find(id);
		}

		public void Create(Blog blog)
		{
			db.Blogs.Add(blog);
			db.SaveChanges();
		}

		public void Update(Blog blog)
		{
			db.Blogs.Update(blog);
			db.SaveChanges();
		}

		public void Delete(int id)
		{
			db.Blogs.Remove(db.Blogs.Find(id));
			db.SaveChanges();
		}

		public Blog? Get(int id)
		{
			return db.Blogs.Find(id);
		}
	}
}
