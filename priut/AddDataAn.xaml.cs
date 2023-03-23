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
    /// Логика взаимодействия для AddDataAn.xaml
    /// </summary>
    public partial class AddDataAn : Window
    {
        public AddDataAn()
        {
            InitializeComponent();

            cmbKlient.ItemsSource = AppData.db.Klient.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAn dataAn = new DataAn();
            this.Close();
            dataAn.Show();
        }

        private void AddAn_Button(object sender, RoutedEventArgs e)
        {
            //int A = AgeTxb;

            Passport An = new Passport();
            An.Name = NameTxb.Text;
            //An.Age = AgeTxb.Text;
            //An.Vid = VidTxb.Text;

            AppData.db.Passport.Add(An);
            AppData.db.SaveChanges();
            MessageBox.Show("Питомец был добавлен!");

        }
    }
}
