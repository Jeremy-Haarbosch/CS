﻿using System;
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

namespace h6
{
    /// <summary>
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
            btnNext.Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window10 win = new Window10();
            win.Show();
            this.Close();
        }


    }
}
