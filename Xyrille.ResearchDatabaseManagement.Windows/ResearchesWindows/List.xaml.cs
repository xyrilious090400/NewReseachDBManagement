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

namespace Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private string sortBy = "FirstName";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize = 5;
        private int pageIndex = 1;
        private long pageCount = 1;


        public List()
        {
            InitializeComponent();
            cboSortBy.ItemsSource = new List<string>() { "FirstName", "LastName" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };

            showData();
        }

        public void showData()
        {


            var research = ResearchesBBL.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);

            dgEmployees.ItemsSource = research.Items;
            pageCount = research.PageCount;
        }

     




        private void BtnFirst_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void BtnPrevious_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();
        }

        private void BtnNext_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void BtnLast_Click_1(object sender, RoutedEventArgs e)
        {

            pageIndex = (int)pageCount;
            showData();
        }

        private void TxtPageSize_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
            }

            showData();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Add addWindow = new ResearchesWindows.Add(this);
            addWindow.Show();
        }

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtKeyword.Text;
                showData();
            }
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ResearchDTO researchDTO = ((FrameworkElement)sender).DataContext as ResearchDTO;
            //Research research = new Research();
            //Update updateForm = new Update(researchDTO,this);
            this.Show(); 
            ////Update update = new Update(List parentWindow, ResearchDTO research);
            //update.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ResearchDTO research = ((FrameworkElement)sender).DataContext as ResearchDTO;

            if (MessageBox.Show("Are you sure you want to delete " + research.Author + " " + research.Abstract + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = ResearchesBBL.Delete(research.ResearchID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Research is successfully deleted from table");
                    showData();
                }
            };
        }

        private void btnDeactivate_Click(object sender, RoutedEventArgs e)
        {
            ResearchDTO research = ((FrameworkElement)sender).DataContext as ResearchDTO;

            if (MessageBox.Show("Are you sure you want to deactivate " + research.Author + " " + research.Abstract + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = ResearchesBBL.Deactivate(research.ResearchID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Research is successfully deactivated from table");
                    showData();
                }
            };
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
            }
            else
            {
                sortOrder = "desc";
            }
            showData();
        }

    
    }
}
