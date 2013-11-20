using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DAL_Library
{
    public class DbAccess
    {
        public DataClasses1DataContext dc = new DataClasses1DataContext();

        #region News
        public List<New> getNews()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<New> newsList = dc.News.ToList<New>();
            return newsList;
        }

        public int getMaxIdNews()
        {
            if (dc.News.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.News.Max(n => n.Id);
            }
        }

        public void addNews(New news)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (!dc.News.Contains(news))
            {
                news.Id = getMaxIdNews() + 1;
                dc.News.InsertOnSubmit(news);
                dc.SubmitChanges();
            }
        }

        public void delNews(New news)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.News.Contains(news))
            {
                dc.News.DeleteOnSubmit(news);
                dc.SubmitChanges();
            }
        }

        public void updNews(New news)
        {
            dc.SubmitChanges();
        }

        #endregion

        #region Articles
        public List<Article> getArticles()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Article> articlesList = dc.Articles.ToList<Article>();
            return articlesList;
        }

        public int getMaxIdArticles()
        {
            if (dc.Articles.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.Articles.Max(n => n.Id);
            }
        }

        public void addArticles(Article articles)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (!dc.Articles.Contains(articles))
            {
                articles.Id = getMaxIdArticles() + 1;
                dc.Articles.InsertOnSubmit(articles);
                dc.SubmitChanges();
            }
        }

        public void delArticles(Article articles)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.Articles.Contains(articles))
            {
                dc.Articles.DeleteOnSubmit(articles);
                dc.SubmitChanges();
            }
        }

        public void updArticles(Article articles)
        {
            dc.SubmitChanges();
        }
        #endregion

        #region Rights
        public List<Right> getRights()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Right> rightsList = dc.Rights.ToList<Right>();
            return rightsList;
        }

        public int getMaxIdRights()
        {
            if (dc.Rights.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.Rights.Max(n => n.Id);
            }
        }

        public void addRights(Right rights)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (!dc.Rights.Contains(rights))
            {
                rights.Id = getMaxIdRights() + 1;
                dc.Rights.InsertOnSubmit(rights);
                dc.SubmitChanges();
            }
        }

        public void delRights(Right rights)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.Rights.Contains(rights))
            {
                dc.Rights.DeleteOnSubmit(rights);
                dc.SubmitChanges();
            }
        }

        public void updRights(Right rights)
        {
            dc.SubmitChanges();
        }
        #endregion

        #region Types
        public List<Type> getTypes()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Type> typesList = dc.Types.ToList<Type>();
            return typesList;
        }

        public int getMaxIdTypes()
        {
            if (dc.Types.Count() == 0)
            {
                return 0;
            } 
            else 
            {
                return dc.Types.Max(n => n.Id);
            }
        }

        public void addTypes(Type types)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (!dc.Types.Contains(types))
            {
                types.Id = getMaxIdTypes() + 1;
                dc.Types.InsertOnSubmit(types);
                dc.SubmitChanges();
            }
        }

        public void delTypes(Type types)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.Types.Contains(types))
            {
                dc.Types.DeleteOnSubmit(types);
                dc.SubmitChanges();
            }
        }

        public void updTypes(Type types)
        {
            dc.SubmitChanges();
        }
        #endregion

        #region Users
        public List<User> getUsers()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<User> usersList = dc.Users.ToList<User>();
            return usersList;
        }

        public int getMaxIdUsers()
        {
            if (dc.Users.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.Users.Max(n => n.Id);
            }
        }

        public void addUsers(User users)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (!dc.Users.Contains(users))
            {
                users.Id = getMaxIdTypes() + 1;
                dc.Users.InsertOnSubmit(users);
                dc.SubmitChanges();
            }
        }

        public void delUsers(User users)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.Users.Contains(users))
            {
                dc.Users.DeleteOnSubmit(users);
                dc.SubmitChanges();
            }
        }

        public void updUsers(User users)
        {
            dc.SubmitChanges();
        }
        #endregion
    }
}
