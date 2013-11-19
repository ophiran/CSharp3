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
using System.Collections.ObjectModel;
using System.ComponentModel;
using DAL_Library;
using System.Collections.Specialized;

namespace News_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbAccess db;
        public ObservableCollection<New> x { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            db = new DbAccess();
            List<New> newsList = db.getNews();
            x = new ObservableCollection<New>(newsList);
            //newsGrid.ItemsSource = obsCol;
            x.CollectionChanged += this.onCollectionChanged;
            //Console.Out.WriteLine(newsGrid.ItemsSource.ToString());


        }

        public void onCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.Out.WriteLine("OKKKKKKKKKKKKKKKKKKKKKKKKKKK");
            foreach (New n in e.NewItems)
            {
                Console.Out.WriteLine(n.Title);
            }


        }
    }
}
