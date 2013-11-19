using DAL_Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
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

namespace ViewTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BindingListWRemove<New> newsList { get; set; }
        public BindingList<Article> articlesList { get; set; }
        public BindingList<Right> rightsList { get; set; }
        public BindingList<DAL_Library.Type> typesList { get; set; }
        public BindingList<User> usersList { get; set; }

        DbAccess db;
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = this;
            db = new DbAccess();

            newsList = new BindingListWRemove<New>(db.getNews());
            /*
            articlesList = new BindingList<Article>(db.getArticles());
            rightsList = new BindingList<Right>(db.getRights());
            typesList = new BindingList<DAL_Library.Type>(db.getTypes());
            usersList = new BindingList<User>(db.getUsers());
            */

            newsList.ListChanged += onNewsListChanged;
            newsList.BeforeRemove += onNewsDelete;
            /*
            articlesList.ListChanged += onArticlesListChanged;
            rightsList.ListChanged += onRightsListChanged;
            typesList.ListChanged += onTypesListChanged;
            usersList.ListChanged += onUsersListChanged;
            */


        }

        public void onNewsDelete(object sender, ListChangedEventArgs e)
        {
            New n = newsList.ElementAt<New>(e.NewIndex);
            db.delNews(n);
        }

        public void onNewsListChanged(object sender, ListChangedEventArgs e)
        {
            if (!e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                New n = newsList.ElementAt<New>(e.NewIndex);

                if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
                {
                    db.addNews(n);
                }
                else if (e.ListChangedType.Equals(ListChangedType.ItemChanged))
                {
                    db.updNews(n);
                }
            }
        }
    }
}
