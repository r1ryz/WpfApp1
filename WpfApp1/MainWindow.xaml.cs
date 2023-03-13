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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_auth_Click(object sender, RoutedEventArgs e)
        {
            ProviderDb ef = new ProviderDb();

            Account find_account = ef.Accounts
                .FirstOrDefault(x => x.Login == tb_login.Text && x.Password == tb_password.Password);
            if (find_account == null)
            {
                MessageBox.Show("Учетная запись неверна!");
            }
            else
            {
                MessageBox.Show($"Добро пожаловать, {find_account.Name}");
            }
        }
    }
}
