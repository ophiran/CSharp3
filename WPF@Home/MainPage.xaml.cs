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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Home.NewsService;

namespace WPF_Home
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        People journalist;
        public MainPage(People journalist)
        {
            InitializeComponent();
            this.journalist = journalist;
            this.journalistNameLabel.Content = journalist.FirstName + " " + journalist.LastName;

            newsListBox.ItemsSource = MainWindow.proxy.getNews().ToList<News>();

            
        }

        private void newsButton_Click(object sender, RoutedEventArgs e)
        {
            this.newsBodyTb.Text = "No news";
            this.newsTitleLabel.Content = "No news";
            this.newsSubtitleLabel.Content = "No news";
            newsListBox.ItemsSource = MainWindow.proxy.getNews().ToList<News>();
        }

        private void historyButton_Click(object sender, RoutedEventArgs e)
        {
            this.newsBodyTb.Text = "No news";
            this.newsTitleLabel.Content = "No news";
            this.newsSubtitleLabel.Content = "No news";
            newsListBox.ItemsSource = MainWindow.proxy.getHistoric(journalist).ToList<News>();
        }

        private void newsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.newsListBox.SelectedItem != null)
            {
                this.newsTitleLabel.Content = ((News)this.newsListBox.SelectedItem).Title;
                this.newsSubtitleLabel.Content = ((News)this.newsListBox.SelectedItem).SubTitle;
                this.newsBodyTb.Text = ((News)this.newsListBox.SelectedItem).Body;
            }
        }
    }
}
