﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("An error ocurred.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", 
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed.";
            }
            else
            {
                tbInfo.Text = "Not agreed.";
            }
        }
    }
}