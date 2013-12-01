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
        public BindingListWRemove<Article> articlesList { get; set; }
        public BindingListWRemove<Right> rightsList { get; set; }
        public BindingListWRemove<DAL_Library.Type> typesList { get; set; }
        public BindingListWRemove<User> usersList { get; set; }

        DbAccess db;
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = this;
            db = new DbAccess();

            newsList = new BindingListWRemove<New>(db.getNews());
            articlesList = new BindingListWRemove<Article>(db.getArticles());
            rightsList = new BindingListWRemove<Right>(db.getRights());
            typesList = new BindingListWRemove<DAL_Library.Type>(db.getTypes());
            usersList = new BindingListWRemove<User>(db.getUsers());

            newsList.ListChanged += onNewsListChanged;
            newsList.BeforeRemove += onNewsDelete;
            articlesList.ListChanged += onArticlesListChanged;
            articlesList.BeforeRemove += onArticlesDelete;
            rightsList.ListChanged += onRightsListChanged;
            rightsList.BeforeRemove += onRightsDelete;
            typesList.ListChanged += onTypesListChanged;
            typesList.BeforeRemove += onTypesDelete;
            usersList.ListChanged += onUsersListChanged;
            usersList.BeforeRemove += onUsersDelete;

            
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

        public void onArticlesDelete(object sender, ListChangedEventArgs e)
        {
            Article n = articlesList.ElementAt<Article>(e.NewIndex);
            db.delArticles(n);
        }

        public void onArticlesListChanged(object sender, ListChangedEventArgs e)
        {
            if (!e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                Article n = articlesList.ElementAt<Article>(e.NewIndex);

                if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
                {
                    db.addArticles(n);
                }
                else if (e.ListChangedType.Equals(ListChangedType.ItemChanged))
                {
                    db.updArticles(n);
                }
            }
        }

        public void onRightsDelete(object sender, ListChangedEventArgs e)
        {
            Right n = rightsList.ElementAt<Right>(e.NewIndex);
            db.delRights(n);
        }

        public void onRightsListChanged(object sender, ListChangedEventArgs e)
        {
            if (!e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                Right n = rightsList.ElementAt<Right>(e.NewIndex);

                if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
                {
                    db.addRights(n);
                }
                else if (e.ListChangedType.Equals(ListChangedType.ItemChanged))
                {
                    db.updRights(n);
                }
            }
        }

        public void onTypesDelete(object sender, ListChangedEventArgs e)
        {
            DAL_Library.Type n = typesList.ElementAt<DAL_Library.Type>(e.NewIndex);
            db.delTypes(n);
        }

        public void onTypesListChanged(object sender, ListChangedEventArgs e)
        {
            if (!e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                DAL_Library.Type n = typesList.ElementAt<DAL_Library.Type>(e.NewIndex);

                if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
                {
                    db.addTypes(n);
                }
                else if (e.ListChangedType.Equals(ListChangedType.ItemChanged))
                {
                    db.updTypes(n);
                }
            }
        }

        public void onUsersDelete(object sender, ListChangedEventArgs e)
        {
            User n = usersList.ElementAt<User>(e.NewIndex);
            db.delUsers(n);
        }

        public void onUsersListChanged(object sender, ListChangedEventArgs e)
        {
            if (!e.ListChangedType.Equals(ListChangedType.ItemDeleted))
            {
                User n = usersList.ElementAt<User>(e.NewIndex);

                if (e.ListChangedType.Equals(ListChangedType.ItemAdded))
                {
                    db.addUsers(n);
                }
                else if (e.ListChangedType.Equals(ListChangedType.ItemChanged))
                {
                    db.updUsers(n);
                }
            }
        }
    }
}
