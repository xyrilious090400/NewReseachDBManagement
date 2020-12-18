using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xyrille.ResearchDatabaseManagement.Windows.DAL;
using Xyrille.ResearchDatabaseManagement.Windows.Helpers;

namespace Xyrille.ResearchDatabaseManagement.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblUserName.Content = "Welcome, " + ProgramUser.FullName;

            RDBManagementDBContext context = new RDBManagementDBContext();

            var author = context.Authors.FirstOrDefault();
            if (author != null)
            {
                MessageBox.Show(author.AuthorID.ToString());
            };
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            ProgramUser.Id = null;
            ProgramUser.FirstName = null;
            ProgramUser.LastName = null;
            ProgramUser.EmailAddress = null;
            ProgramUser.Roles = null;

            LoginWindow login = new LoginWindow();
            login.Show();

            this.Close();

        }

        private void BtnResearch_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
