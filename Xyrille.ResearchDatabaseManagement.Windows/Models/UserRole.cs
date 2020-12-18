using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.Enums;

namespace Xyrille.ResearchDatabaseManagement.Windows.Models
{
    public class UserRole
    {
        public Guid? Id { get; set; }

        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
