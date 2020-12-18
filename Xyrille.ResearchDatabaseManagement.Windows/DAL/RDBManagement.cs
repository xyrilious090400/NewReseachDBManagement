using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.Models;

namespace Xyrille.ResearchDatabaseManagement.Windows.DAL
{
    public class RDBManagementDBContext : DbContext
    {

            public RDBManagementDBContext() : base("myConnectionString")
            {
            Database.SetInitializer(new Xyrille.ResearchDatabaseManagement.Windows.DAL.DataInitializer());
            }
        public DbSet<Models.Author> Authors { get; set; }

        public DbSet<Models.User> Users { get; set; }


        public DbSet<Models.UserRole> UserRoles { get; set; }

        public DbSet<Models.Research> Researches { get; set; }

        public DbSet<Models.Research_Author> ResearchAuthors { get; set; }

    }

}
