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
using DAL_Library;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ViewTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BindingList<New> newsList { get; set; }
        DbAccess db;
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = this;
            db = new DbAccess();
            newsList = new BindingList<New>(db.getNews());
            newsList.ListChanged += onListChanged;

        }

        public void onListChanged(object sender, ListChangedEventArgs e)
        {
            Console.Out.WriteLine("EVENNNNNNNNNNNNTTTTTTTTTTTTTT");
            New n = newsList.ElementAt<New>(e.NewIndex);
            Console.Out.WriteLine(n.Id);
            Console.Out.WriteLine(n.Title);

            if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
            {
                db.addNews(n);
            }
            else if (e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                db.delNews(n);
            }
        }
    }
}
