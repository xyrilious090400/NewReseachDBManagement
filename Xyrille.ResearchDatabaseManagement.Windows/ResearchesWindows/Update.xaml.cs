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
using Xyrille.ResearchDatabaseManagement.Windows.DTO;
using Xyrille.ResearchDatabaseManagement.Windows.Models;

namespace Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        List myParentWindow = new List();
        private ResearchDTO thisResearch;

        public Update(List parentWindow,ResearchDTO research)
        {
            InitializeComponent();

            thisResearch = research;
            myParentWindow = parentWindow;


            txtAuthor.Text = thisResearch.Author;
            txtTitle.Text = thisResearch.Title;
            txtAbstract.Text = thisResearch.Abstract;
            txtLeadline.Text = thisResearch.Leadline;
            txtYear.Text = thisResearch.Year;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                errors.Add("Author Name is required.");
            };

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errors.Add("Title is required.");
            };

            if (string.IsNullOrEmpty(txtAbstract.Text))
            {
                errors.Add("Paragraph Abstract is required.");
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



            var op = ResearchesBBL.Update(new Research()
            {
                ResearchID = thisResearch.ResearchID,
                Author = txtAuthor.Text,
                Title = txtTitle.Text,
                Abstract = txtAbstract.Text,
                Leadline = txtLeadline.Text,
                Year = txtYear.Text,

               
            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Employee is successfully updated");
            }

            myParentWindow.showData();
            this.Close();
        }
    }
}
