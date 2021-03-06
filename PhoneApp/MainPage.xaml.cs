﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp.Resources;
using PhoneApp.NewsService;

namespace PhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        static public NewsWCFClient proxy;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            proxy = new NewsWCFClient("BasicHttpBinding_INewsWCF1");
            proxy.connectReaderCompleted += new EventHandler<NewsService.connectReaderCompletedEventArgs>(connectReaderCallback);
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            proxy.connectReaderAsync(this.loginTb.Text, this.passwordTb.Text);
        }

        private void connectReaderCallback(object sender, connectReaderCompletedEventArgs e)
        {
            People user = e.Result;
            //Console.Out.WriteLine(user.FirstName + user.LastName);
            if (user != null)
            {
                PhoneApplicationService.Current.State["loggedUser"] = user;
                NavigationService.Navigate(new Uri("/articlesPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Wrong credentials...");
            }
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}