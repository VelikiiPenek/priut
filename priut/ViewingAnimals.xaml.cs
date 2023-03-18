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
    /// Логика взаимодействия для ViewingAnimals.xaml
    /// </summary>
    public partial class ViewingAnimals : Window
    {
        public ViewingAnimals()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow firstWindow = new FirstWindow();
            this.Close();
            firstWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
