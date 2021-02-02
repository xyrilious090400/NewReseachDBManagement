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
using Xyrille.ResearchDatabaseManagement.Windows.Models;

namespace Xyrille.ResearchDatabaseManagement.Windows.Users
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errors.Add("FirstName is required.");
            };

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errors.Add("LastName is required.");
            };

            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                errors.Add("Email is required.");
            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errors.Add("Password is required.");
            };

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errors.Add("Confirm Password is required.");
            };

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errors.Add("Address Password is required.");
            };


            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    txtErrors.Text = txtErrors.Text + error + "\n";
                }

                return;
            }

            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                errors.Add("The password and confirm password does not match");
            }


            var op = UsersBBL.Add(new User()
            {
                UserID = Guid.NewGuid(),
                FirstName = txtFirstName.Text,
                Lastname = txtLastName.Text,
                FullName = txtFirstName.Text + "" + txtLastName.Text,
                UserEmail = txtEmailAddress.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                Status = Xyrille.ResearchDatabaseManagement.Windows.Enums.Status.Probationary,
                IsActive = true
            });


            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("User is successfully added to table");
                this.ShowDialog();
            }

           
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
