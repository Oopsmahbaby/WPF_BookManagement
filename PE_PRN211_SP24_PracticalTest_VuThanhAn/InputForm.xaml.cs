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
    /// Interaction logic for InputForm.xaml
    /// </summary>
    public partial class InputForm : Window
    {
        private readonly Action _refreshBookList;
        private readonly bool _isEditing;

        public InputForm(Action refreshBookList)
        {
            InitializeComponent();
            LoadBookCate();
            _refreshBookList = refreshBookList; // Assign the delegate
        }

        public InputForm(Book book, Action refreshBookList)
        {
            InitializeComponent();
            LoadBookCate();
            _refreshBookList = refreshBookList;
            _isEditing = true;
            PopulateFields(book);
        }

        public void LoadBookCate()
        {
            BookCategoryService bookCategoryService = new BookCategoryService();
            BookCategoryComboBox.ItemsSource = bookCategoryService.LoadAllBookCate();
            BookCategoryComboBox.SelectedIndex = 0;
        }

        private void PopulateFields(Book book)
        {
            // Set field values based on the book being edited
            BookIdTextBox.Text = book.BookId.ToString();
            BookIdTextBox.IsReadOnly = true; // Make BookId read-only when editing
            BookNameTextBox.Text = book.BookName;
            DescriptionTextBox.Text = book.Description;
            PublicationDatePicker.SelectedDate = book.PublicationDate;
            QuantityTextBox.Text = book.Quantity.ToString();
            PriceTextBox.Text = book.Price.ToString();
            AuthorTextBox.Text = book.Author;
            BookCategoryComboBox.SelectedValue = book.BookCategoryId;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BookIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(BookNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                !PublicationDatePicker.SelectedDate.HasValue ||
                string.IsNullOrWhiteSpace(QuantityTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(AuthorTextBox.Text) ||
                BookCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(BookIdTextBox.Text, out int id))
            {
                MessageBox.Show("Invalid Book ID.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string name = BookNameTextBox.Text;
            string description = DescriptionTextBox.Text;
            DateTime publicationDate = PublicationDatePicker.SelectedDate.Value;


            if (!int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Invalid Quantity.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(PriceTextBox.Text, out double price))
            {
                MessageBox.Show("Invalid Price.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            string author = AuthorTextBox.Text;
            int bookCate = (int)BookCategoryComboBox.SelectedValue;
            BookService bookService = new BookService();
            if (_isEditing)
            {
                // Update the existing book
                Book book = bookService.CheckIdExist(id);
                if (book == null)
                {
                    MessageBox.Show("Book not found. It might have been deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                book.BookName = name;
                book.Description = description;
                book.PublicationDate = publicationDate;
                book.Quantity = quantity;
                book.Price = price;
                book.Author = author;
                book.BookCategoryId = bookCate;

                bookService.UpdateBook(book);
                MessageBox.Show("Book updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {


                Book? book = bookService.CheckIdExist(id);
                if (book != null)
                {
                    MessageBox.Show("ID cannot be duplicated! Try again please");
                    return;
                }
                book = new Book
                {
                    BookId = id,
                    BookName = name,
                    Description = description,
                    PublicationDate = publicationDate,
                    Quantity = quantity,
                    Price = price,
                    Author = author,
                    BookCategoryId = bookCate,
                };
                bookService.AddBook(book);
                MessageBox.Show("Book added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            _refreshBookList?.Invoke();
            ClearFields();

        }

        public void ClearFields()
        {
            BookIdTextBox.Clear();
            BookNameTextBox.Clear();
            DescriptionTextBox.Clear();
            PublicationDatePicker.SelectedDate = null;
            QuantityTextBox.Clear();
            PriceTextBox.Clear();
            AuthorTextBox.Clear();
            BookCategoryComboBox.SelectedIndex = 0; // Reset to the first item
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
