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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Serienlook{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow{
        public MainWindow(){
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e){
            Console.WriteLine("Button clicked!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e){
            Console.WriteLine("Button Clicked");
            Console.WriteLine("Buton22");
            
            
        }

        private void combobox_search_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
             * To be Filled
             * 
             */
        }
    }
}