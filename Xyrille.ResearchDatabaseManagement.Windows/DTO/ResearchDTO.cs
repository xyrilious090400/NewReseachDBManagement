using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyrille.ResearchDatabaseManagement.Windows.DTO
{
    public class ResearchDTO
    {
        public Guid? ResearchID { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public string Author { get; set; }

        public string Leadline { get; set; }

        public string Year { get; set; }


        public bool IsPublish { get; set; }
    }
}
