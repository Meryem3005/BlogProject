using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repos
{
    public class UtilisateurRepos
    {
        static MyDbContext db = new MyDbContext();
        public List<User> All()
        {
            return db.Users.ToList();
        }
    }
}
