﻿using DAL_Library;
using System;
using System.Collections.Generic;
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

    }
}
