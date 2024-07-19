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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PE_PRN211_SP24_PracticalTest_VuThanhAn
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtboxEmail.Text;
            string password = txtboxPassword.Password;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                System.Windows.Forms.MessageBox.Show("Pleae input both email & password", "Input plz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccountService accountService = new UserAccountService();
            UserAccount? userAccount = accountService.CheckLogin(email, password);

            if (userAccount == null)
            {
                System.Windows.Forms.MessageBox.Show("Login failed. Check the email and password again!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (userAccount.Role != 1)
            {
                System.Windows.Forms.MessageBox.Show("You have no permission to access this function!", "Wrong privilege", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BookManagerMainForm bookMainForm = new BookManagerMainForm();
            bookMainForm.ShowDialog();
            this.Close();
        }
    }
}
