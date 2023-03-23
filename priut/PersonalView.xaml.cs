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
    /// Логика взаимодействия для PersonalView.xaml
    /// </summary>
    public partial class PersonalView : Window
    {
        public PersonalView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personal personal = new Personal();
            this.Close();
            personal.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PerViewGrid.ItemsSource = AppData.db.Sotrudniki.ToList();
        }
    }
}
