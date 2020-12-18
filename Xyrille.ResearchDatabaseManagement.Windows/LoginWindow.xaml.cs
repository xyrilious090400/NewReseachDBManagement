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
using System.Windows.Shapes;
using Xyrille.ResearchDatabaseManagement.Windows.BBL;
using Xyrille.ResearchDatabaseManagement.Windows.Helpers;

namespace Xyrille.ResearchDatabaseManagement.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            lblError.Content = "";

            if(string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                lblError.Content = "Invalid Login";
                return;

            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Content = "Invalid Login";
                return;
            };


            var op = UsersBBL.Login(txtEmailAddress.Text, txtPassword.Text);

            if (op.Code == "200")
            {
                var users = UsersBBL.GetById(op.ReferenceId);
                var roles = UsersBBL.GetRoles(op.ReferenceId);

                ProgramUser.Id = op.ReferenceId;
                ProgramUser.FirstName = users.FirstName;
                ProgramUser.LastName = users.Lastname;
                ProgramUser.EmailAddress = users.UserEmail;
                ProgramUser.Roles = roles;

                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                lblError.Content = "Invalid Login";
            }


        }
    }
}
