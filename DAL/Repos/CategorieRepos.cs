using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repos
{
	public class CategorieRepos
	{
		static MyDbContext db = new MyDbContext();
		public List<Categorie> All()
		{
			return db.Categories.ToList();
		}

		public void Create(Categorie categorie)
		{
			db.Categories.Add(categorie);
			db.SaveChanges();
		}

		public void Delete(int id)
		{
			Categorie? categorie = db.Categories.Find(id);
			if(categorie != null)
			{
				db.Categories.Remove(categorie);
				db.SaveChanges();
			}
		}

		public void Update(Categorie categorie)
		{
			db.Categories.Update(categorie);
			db.SaveChanges();
		}

		public Categorie? Get(int id)
		{
			Categorie? categorie = db.Categories.Find(id);
			return categorie;
		}

	}
}
