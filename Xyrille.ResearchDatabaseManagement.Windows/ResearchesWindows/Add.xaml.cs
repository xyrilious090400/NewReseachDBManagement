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

namespace Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        List myParentWindow = new List();

        public Add(List parentWindow)
        {
            InitializeComponent();

        
            myParentWindow = parentWindow;
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errors.Add("Title is required.");
            };

            if (string.IsNullOrEmpty(txtAbstract.Text))
            {
                errors.Add("Abstract is required.");
            };

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                errors.Add("Author is required.");
            };

            if (string.IsNullOrEmpty(txtLeadline.Text))
            {
                errors.Add("Leadline is required.");
            };

            if (string.IsNullOrEmpty(txtYear.Text))
            {
                errors.Add("Year is required.");
            };

            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    txtbErrors.Text = txtbErrors.Text + error + "\n";
                }

                return;
            }


            var op = ResearchesBBL.Add(new Research()
            {
                ResearchID = Guid.NewGuid(),
                Author = txtAuthor.Text,
                Title = txtTitle.Text,
                Abstract = txtAbstract.Text,
                Leadline = txtLeadline.Text,
                IsPublish = true,
                Year = txtYear.Text,
            });


            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Research is successfully added to table");
            }



         
            this.Close();
         

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
