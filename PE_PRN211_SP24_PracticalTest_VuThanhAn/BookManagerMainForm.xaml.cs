using Repositories.Entities;
using Services;
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

namespace PE_PRN211_SP24_PracticalTest_VuThanhAn
{
    /// <summary>
    /// Interaction logic for BookManagerMainForm.xaml
    /// </summary>
    public partial class BookManagerMainForm : Window
    {
        public BookManagerMainForm()
        {
            InitializeComponent();
            Load_All_Books();
        }

        public void Load_All_Books()
        {
            BookService bookService = new BookService();
            ListBookDataGrid.ItemsSource = bookService.GetAllBooks();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListBookDataGrid.SelectedItem is Book selectedBook)
            {
                // Show a confirmation dialog
                MessageBoxResult result = MessageBox.Show(
                    $"Are you sure you want to delete the book '{selectedBook.BookName}'?",
                    "Delete Confirmation",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                // Check the user's response
                if (result == MessageBoxResult.Yes)
                {
                    // Remove the selected book and save changes
                    BookService bookService = new BookService();
                    bookService.DeleteBook(selectedBook);
                    Load_All_Books();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListBookDataGrid.SelectedItem is Book selectedBook)
            {
                // Pass the selected book and refresh method to the InputForm
                InputForm inputForm = new InputForm(selectedBook, Load_All_Books);
                inputForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            InputForm inputForm = new InputForm(Load_All_Books);
            inputForm.ShowDialog();
        }
    }
}
