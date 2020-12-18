using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.Enums;

namespace Xyrille.ResearchDatabaseManagement.Windows.Models
{
   public class User
    {
        public Guid? UserID { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string UserEmail { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

        public Status Status { get; set; }

 
        public bool IsActive { get; set; }
    }
}

