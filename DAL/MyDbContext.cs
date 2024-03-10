using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;

namespace DAL
{
	public class MyDbContext : DbContext
	{
		public DbSet<Categorie> Categories { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		
		public DbSet<User> Users { get; set; }
		protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer
				(@"Data Source=localhost;Initial Catalog=BlogProject;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
		}
	}
}
