using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyrille.ResearchDatabaseManagement.Windows.Models
{
    public class Research_Author
    {
        
        [Key]
        public Guid? ResearchAuthorID { get; set; }

        public string Year { get; set; }

    }
}
  