using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp
{
    public partial class ArticlesList : PhoneApplicationPage
    {
        public ArticlesList()
        {
            InitializeComponent();
            //papersListBox
            //papersList.ItemsSource = MainWindow.proxy.getNews().ToList<News>();
        }

        private void papersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}