using DAL_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Library
{
    public class blAccess
    {
        private DbAccess dbAccess;

        public blAccess()
        {
            this.dbAccess = new DbAccess();
        }

        public List<New> getNews()
        {
            return dbAccess.getNews();
        }

        public List<New> getNews(User author) {
            List<New> listNews = null;
            if (isJournalist(author)) {
                IEnumerable<New> news = dbAccess.getNews().Where<New>(n => n.Author == author.Id);
                listNews = news.ToList<New>();
            }
            return listNews;
        }

        public List<Article> getArticles()
        {
            return dbAccess.getArticles();

        }

        public List<Article> getArticles(string theme)
        {
            List<DAL_Library.Type> themes = dbAccess.getTypes();
            DAL_Library.Type sTheme = null;
            foreach(DAL_Library.Type item in themes)
            {
                if (item.Type1 == theme)
                    sTheme = item;
            }

            List<Article> respArticles = new List<Article>();

            if(sTheme != null)
            {
                foreach (Article item in dbAccess.getArticles())
                {
                    if (item.Type.Id == sTheme.Id)
                        respArticles.Add(item);
                }
            }

            return respArticles;
        }

        public User getUser(string name, string password)
        {
            User user = null;
            var users = dbAccess.getUsers().Where<User>(u => u.UserName == name && u.Password == password);
            if (users != null && users.Any<User>())
            {
                user = users.First<User>();
            }
            return user;
        }

        public void addComment(Comment comment)
        {
            dbAccess.addComments(comment);
        }

        public void addJournalist(string firstName, string lastName, string userName, string password)
        {

            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.Password = password;

            addJournalist(user);
        }

        public void addJournalist(User user)
        {
            dbAccess.addUsers(user);
        }

        public bool isJournalist(User user)
        {
            var results = dbAccess.getRights().Where<Right>(r => r.Name == "Journalist");
            int rightJournalist = results.First<Right>().Id;
            if (user.Right == rightJournalist)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User getJournalist(string name, string password)
        {
            User user = null;
            var users = dbAccess.getUsers().Where<User>(u => u.UserName == name && u.Password == password);
            user = users.First<User>();
            var rightJournalist = dbAccess.getRights().Where<Right>(r => r.Name == "Journalist");
            int i = rightJournalist.First<Right>().Id;
            if (user.Right != i) {
                user = null;
            }
            return user;
        }

        public User getJournalist(string name)
        {
            User user = null;
            var users = dbAccess.getUsers().Where<User>(u => u.UserName == name);
            user = users.First<User>();
            return user;
        }

        public void addNews(New news)
        {
            dbAccess.addNews(news);
        }

        public List<DAL_Library.Type> getThemes()
        {
            return dbAccess.getTypes();
        }

        public Article getArticle(int Id)
        {
            foreach(Article item in dbAccess.getArticles())
            {
                if (item.Id == Id)
                    return item;
            }
            return null;
        }

        public Right getRight(String name)
        {
            return dbAccess.getRights().Where<Right>(u => u.Name == name).First<Right>();
        }

        public Status getStatus(String name)
        {
            return dbAccess.getStatus().Where<Status>(u => u.Status1 == name).First<Status>();
        }

        public List<User> getReaders()
        {
            return dbAccess.getUsers().Where<User>(u => u.Right1.Name == "Reader").ToList();
        }

        public void setStatus(int userId,Status status)
        {
            User user = dbAccess.getUsers().Where<User>(u => u.Id == userId).First<User>();
            user.Status = status.Id;
            dbAccess.updUsers(user);
        }

        public void setArticleStatus(int articleId,Status status)
        {
            Article article = dbAccess.getArticles().Where<Article>(a => a.Id == articleId).First<Article>();
            article.Status = status.Id;
            dbAccess.updArticles(article);
        }
        public void setNewsStatus(int newsId, Status status)
        {
            New news = dbAccess.getNews().Where<New>(n => n.Id == newsId).First<New>();
            news.Status = status.Id;
            dbAccess.updNews(news);
        }
        public void setThemeStatus(int themeId, Status status)
        {

            DAL_Library.Type theme = dbAccess.getTypes().Where<DAL_Library.Type>(t => t.Id == themeId).First<DAL_Library.Type>();
            theme.Status = status.Id;
            dbAccess.updTypes(theme);
        }

        public List<Article> getStatArticlesJournalist()
        {
            IEnumerable<Article> articles = dbAccess.getArticles().GroupBy(a => a.Author).SelectMany(group => group);
            return articles.ToList();
        }

        public void incConnectionCount(DateTime time)
        {
            IEnumerable<LogConnection> logCol = dbAccess.getLogConnection().Where<LogConnection>(l => l.Date == time.Date);
            LogConnection inLog;
            if(logCol.ToList().Count == 0)
            {
                inLog = new LogConnection();
                inLog.Date = time;
                inLog.ConnectionCount = 1;
                dbAccess.addLogConnection(inLog);
            }
            else
            {
                inLog = logCol.First<LogConnection>();
                inLog.ConnectionCount++;
                dbAccess.updLogConnection(inLog);
            }
            
        }
    }
}
