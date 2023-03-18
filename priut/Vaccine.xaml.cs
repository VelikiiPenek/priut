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
    /// Логика взаимодействия для Vaccine.xaml
    /// </summary>
    public partial class Vaccine : Window
    {
        public Vaccine()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MedData medData = new MedData();
            this.Close();
            medData.Show();
        }
    }
}
