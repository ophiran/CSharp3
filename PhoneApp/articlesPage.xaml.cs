using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class articlesPage : PhoneApplicationPage
    {
        ObservableCollection<Paper> listPapers;
        public articlesPage()
        {
            InitializeComponent();
            MainPage.proxy.getPapersCompleted += new EventHandler<NewsService.getPapersCompletedEventArgs>(getPapersCallback);
            MainPage.proxy.getPapersAsync();
            
        }

        public void getPapersCallback(Object sender, NewsService.getPapersCompletedEventArgs e) {
            listPapers = e.Result;
            papersListBox.ItemsSource = listPapers;
        }

        private void commentButton_Click(object sender, RoutedEventArgs e)
        {
            if (papersListBox.SelectedItem != null)
            {
                PhoneApplicationService.Current.State["selectedPaper"] = (Paper) papersListBox.SelectedItem;
                NavigationService.Navigate(new Uri("/CommentPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Please select an article");
            }
        }
    }
}