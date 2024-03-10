using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using DAL.Entity;
using Models;

namespace BLL
{
	public class CategorieService
	{
		static CategorieRepos CategorieRepos = new CategorieRepos();
		public List<CategorieVM> ListVM()
		{
			List<CategorieVM> repostomodel = new List<CategorieVM>();
			foreach (var vm in CategorieRepos.All())
			{
				CategorieVM item = new CategorieVM();
				item.Name = vm.Name;
				item.Description = vm.Description;
				item.Id = vm.Id;
				repostomodel.Add(item);
			}
			return repostomodel;
		}

		public void AddCategorie(CategorieVM item)
		{

			Categorie categorie = new Categorie
			{
				Name = item.Name,
				Description = item.Description,
				Id = item.Id
			};
			CategorieRepos.Create(categorie);
		}

		public void SupprimerCategorie(int id)
		{
			CategorieRepos.Delete(id);
		}

		public CategorieVM GetCategorie(int id)
		{
			Categorie data = CategorieRepos.Get(id);
			CategorieVM ret = new CategorieVM()
			{
				Id = data.Id,
				Name = data.Name,
				Description = data.Description
			};
			return ret;
		}

		public void UpdateCategorie(CategorieVM item)
		{

			Categorie categorie = CategorieRepos.Get(item.Id);
			categorie.Name = item.Name;
			categorie.Description = item.Description;
			CategorieRepos.Update(categorie);
		}
	}
}
