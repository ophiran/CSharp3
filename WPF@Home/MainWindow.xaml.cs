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
using WPF_Home.NewsService;

namespace WPF_Home
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public NewsWCFClient proxy;
        public MainWindow()
        {
            InitializeComponent();
            proxy = new NewsWCFClient();


        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            People p = proxy.connectUser(this.userTb.Text, this.passwordTb.Password);
            if (p != null)
            {
                Console.Out.WriteLine("Your are sucessfully connected");
                this.Content = new MainPage(p);
            }
            else
            {
                Console.Out.WriteLine("Wrong credentials");
            }

        }
    }
}
