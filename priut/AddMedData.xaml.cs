﻿using priut.Model;
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
    /// Логика взаимодействия для AddMedData.xaml
    /// </summary>
    public partial class AddMedData : Window
    {
        public AddMedData()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MedData medData = new MedData();
            this.Close();
            medData.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow firstWindow = new FirstWindow();
            this.Close();
            firstWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddMedDataGrid.ItemsSource = AppData.db.Passport.ToList();
        }
    }
}
