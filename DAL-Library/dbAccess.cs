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
        public DataClasses2DataContext dc = new DataClasses2DataContext();

        #region News
        public List<New> getNews()
        {
            IEnumerable<New> newsList = from news in dc.News
                                        select news;
            //List<New> newsList = listNews.ToList<New>();
                
            return newsList.ToList<New>();
        }

        /*
        public List<New> getNews(User user)
        {
            List<New> newsList = null;
            var rightType = from rights in dc.Rights
                            where rights.Name == "Journalist"
                            select rights.Id;
            var userRightType = from users in dc.Users
                                where users.UserName == user.UserName
                                select users.Right;
            Console.Out.WriteLine(rightType.ToString()); // DEBUG
            Console.Out.WriteLine(userRightType.ToString()); // DEBUG
            if (userRightType == rightType)
            {
                IEnumerable<New> listNews = from news in dc.News
                                            where news.Author == user.Id
                                            select news;
                newsList = listNews.ToList<New>();
            }

            return newsList;
        }*/

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
            
            if (!dc.News.Contains(news))
            {
                news.Id = getMaxIdNews() + 1;
                dc.News.InsertOnSubmit(news);
                dc.SubmitChanges();
            }
        }

        public void delNews(New news)
        {
            
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
            
            //List<Article> articlesList = dc.Articles.ToList<Article>();
            IEnumerable<Article> articlesList = from articles in dc.Articles
                                                select articles;

            return articlesList.ToList<Article>();
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
            
            if (!dc.Articles.Contains(articles))
            {
                articles.Id = getMaxIdArticles() + 1;
                dc.Articles.InsertOnSubmit(articles);
                dc.SubmitChanges();
            }
        }

        public void delArticles(Article articles)
        {
            
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

        #region Comments
        public List<Comment> getComments()
        {

            IEnumerable<Comment> commentsList = from comments in dc.Comments
                                                select comments;

            return commentsList.ToList<Comment>();
        }

        public int getMaxIdComments()
        {
            if (dc.Comments.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.Comments.Max(n => n.Id);
            }
        }

        public void addComments(Comment comments)
        {

            if (!dc.Comments.Contains(comments))
            {
                comments.Id = getMaxIdComments() + 1;
                dc.Comments.InsertOnSubmit(comments);
                dc.SubmitChanges();
            }
        }

        public void delComments(Comment comments)
        {

            if (dc.Comments.Contains(comments))
            {
                dc.Comments.DeleteOnSubmit(comments);
                dc.SubmitChanges();
            }
        }

        public void updComments(Comment comments)
        {
            dc.SubmitChanges();
        }
        #endregion

        #region Rights
        public List<Right> getRights()
        {
            
            //List<Right> rightsList = dc.Rights.ToList<Right>();
            IEnumerable<Right> rightsList = from rights in dc.Rights
                                            select rights;
            return rightsList.ToList<Right>();
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
            
            if (!dc.Rights.Contains(rights))
            {
                rights.Id = getMaxIdRights() + 1;
                dc.Rights.InsertOnSubmit(rights);
                dc.SubmitChanges();
            }
        }

        public void delRights(Right rights)
        {
            
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
            
            //List<Type> typesList = dc.Types.ToList<Type>();
            IEnumerable<Type> typesList = from types in dc.Types
                                          select types;
            return typesList.ToList<Type>();
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
            
            if (!dc.Types.Contains(types))
            {
                types.Id = getMaxIdTypes() + 1;
                dc.Types.InsertOnSubmit(types);
                dc.SubmitChanges();
            }
        }

        public void delTypes(Type types)
        {
            
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
            
            //List<User> usersList = dc.Users.ToList<User>();
            IEnumerable<User> usersList = from users in dc.Users
                                          select users;
            return usersList.ToList<User>();
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
            
            if (!dc.Users.Contains(users))
            {
                users.Id = getMaxIdUsers() + 1;
                dc.Users.InsertOnSubmit(users);
                dc.SubmitChanges();
            }
        }

        public void delUsers(User users)
        {
            
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

        #region Status
        public List<Status> getStatus()
        {
            IEnumerable<Status> statusList = from status in dc.Status select status;
            return statusList.ToList<Status>();
        }

        public int getMaxIdStatus()
        {
            if (dc.Status.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.Status.Max(n => n.Id);
            }
        }

        public void addStatus(Status status)
        {
            if (!dc.Status.Contains(status))
            {
                status.Id = getMaxIdStatus() + 1;
                dc.Status.InsertOnSubmit(status);
                dc.SubmitChanges();
            }
        }

        public void delStatus(Status status)
        {

            if (dc.Status.Contains(status))
            {
                dc.Status.DeleteOnSubmit(status);
                dc.SubmitChanges();
            }
        }

        public void updStatus(Status status)
        {
            dc.SubmitChanges();
        }
        #endregion

        #region LogConnection
        public List<LogConnection> getLogConnection()
        {
            IEnumerable<LogConnection> logList = from log in dc.LogConnections select log;
            return logList.ToList<LogConnection>();
        }

        public int getMaxIdLogConnection()
        {
            if (dc.LogConnections.Count() == 0)
            {
                return 0;
            }
            else
            {
                return dc.LogConnections.Max(n => n.Id);
            }
        }

        public void addLogConnection(LogConnection logConn)
        {
            if (!dc.LogConnections.Contains(logConn))
            {
                logConn.Id = getMaxIdStatus() + 1;
                dc.LogConnections.InsertOnSubmit(logConn);
                dc.SubmitChanges();
            }
        }

        public void delLogConnection(LogConnection logConn)
        {

            if (dc.LogConnections.Contains(logConn))
            {
                dc.LogConnections.DeleteOnSubmit(logConn);
                dc.SubmitChanges();
            }
        }

        public void updLogConnection(LogConnection logConn)
        {
            dc.SubmitChanges();
        }
        #endregion
    }
}
