using priut.Model;
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

namespace priut
{
    /// <summary>
    /// Логика взаимодействия для Aut.xaml
    /// </summary>
    public partial class Aut : Window
    {
        public Aut()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == LoginBox.Text && u.Password == PassBox.Password);
            if (CurrentUser != null)
            {
                FirstWindow firstWindow = new FirstWindow();
                this.Close();
                firstWindow.Show();
            } 
            else
            {
                MessageBox.Show("Данного пользователя не существует"); 
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            this.Close();
            reg.Show();

        }
    }
}
