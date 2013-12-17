using System;
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
    public partial class CommentPage : PhoneApplicationPage
    {
        public CommentPage()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            Commentary c = new Commentary();
            c.Content = commentTb.Text;
            c.Rating = (int) ratingSlider.Value;
            People people = (People) PhoneApplicationService.Current.State["loggedUser"];
            Paper paper = (Paper) PhoneApplicationService.Current.State["selectedPaper"];
            MainPage.proxy.sendCommentAsync(c, people, paper);
            MessageBox.Show("Message sent");
        }
    }
}