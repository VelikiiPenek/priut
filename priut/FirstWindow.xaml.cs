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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace priut
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewingAnimals viewingAnimals = new ViewingAnimals();
            this.Close();
            viewingAnimals.Show(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddMedData addMedData = new AddMedData();
            this.Close();
            addMedData.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataAn dataAn = new DataAn();
            this.Close();
            dataAn.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Personal personal = new Personal();
            this.Close();
            personal.Show();
        }
    }
}
