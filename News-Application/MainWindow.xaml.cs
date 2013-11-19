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
using DAL_Library;

namespace News_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbAccess db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DbAccess();
            List<New> newsList = db.getNews();
            newsGrid.ItemsSource = newsList;

        }

        private void newsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        
            List<New> newsList = (List<New>) e.AddedItems;
            foreach(New n in newsList) {
                db.addNews(n);
            }
        }
    }
}
