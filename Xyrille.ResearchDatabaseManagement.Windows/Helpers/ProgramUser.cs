using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.Enums;

namespace Xyrille.ResearchDatabaseManagement.Windows.Helpers
{
    public static class ProgramUser
    {
        public static Guid? Id { get; set; }
        public static string EmailAddress { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public static List<Role> Roles { get; set; }
    }
}
