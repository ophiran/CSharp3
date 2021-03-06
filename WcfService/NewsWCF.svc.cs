﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_Library;
using BLL_Library;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NewsWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NewsWCF.svc or NewsWCF.svc.cs at the Solution Explorer and start debugging.
    public class NewsWCF : INewsWCF
    {
        private blAccess bl = new blAccess();

        public void createUser(string firstname, string lastname, string username, string password)
        {
            bl.addJournalist(firstname, lastname, username, password);
        }

        public People connectUser(string username, string password)
        {
            People connectedUser = null;
            User user = bl.getUser(username, password);
            if (user != null){
                if (bl.isJournalist(user)) {
                    connectedUser = new People(user);
                }
            }
            return connectedUser;
        }

        public People connectReader(string username, string password)
        {
            People connectedUser = null;
            User user = bl.getUser(username, password);
            if (user != null)
            {
                connectedUser = new People(user);
            }
            return connectedUser;
        }

        public List<News> getNews()
        {
            List<News> newsList = new List<News>();
            foreach (New n in bl.getNews())
            {
                if (n != null)
                    newsList.Add(new News(n));
            }
            return newsList;
        }

        public List<Paper> getPapers()
        {
            List<Paper> papersList = new List<Paper>();
            foreach (Article a in bl.getArticles())
            {
                if (a != null)
                    papersList.Add(new Paper(a));
            }
            return papersList;
        }

        public List<News> getHistoric(People people)
        {
            User user = new User();
            user.Id = people.Id;
            user.FirstName = people.FirstName;
            user.LastName = people.LastName;
            user.UserName = people.UserName;
            user.Password = people.Password;
            user.Right = people.Right;

            List<News> newsList = new List<News>();
            foreach (New n in bl.getNews(user))
            {
                if (n != null)
                    newsList.Add(new News(n));
            }
            return newsList;
        }

        public void sendNews(News news, People people)
        {
            New newsDb = new New();
            User user = new User();
            user.Id = people.Id;
            user.FirstName = people.FirstName;
            user.LastName = people.LastName;
            user.UserName = people.UserName;
            user.Password = people.Password;
            user.Right = people.Right;
            newsDb.User = user;
            newsDb.Title = news.Title;
            newsDb.SubTitle = news.SubTitle;
            newsDb.Text = news.Body;
            bl.addNews(newsDb);
        }

        public void sendNewsA(News news, string author)
        {
            User user = bl.getJournalist(author);
            New newsDb = new New();
            newsDb.User = user;
            newsDb.Title = news.Title;
            newsDb.SubTitle = news.SubTitle;
            newsDb.Text = news.Body;
            bl.addNews(newsDb);
        }

        public void sendComment(Commentary commentary, People people, Paper paper)
        {
            Comment commentDb = new Comment();
            User user = bl.getUser(people.UserName,people.Password);
            Article article = bl.getArticle((int)paper.Id);/*
            user.Id = people.Id;
            user.FirstName = people.FirstName;
            user.LastName = people.LastName;
            user.UserName = people.UserName;
            user.Password = people.Password;
            user.Right = people.Right;/*
            article.Author = paper.Author;
            article.Id = (int)paper.Id;
            article.Overview = paper.Overview;
            article.SubTitle = paper.SubTitle;
            article.Text = paper.Body;*/
            commentDb.User = user;
            commentDb.Rating = commentary.Rating;
            commentDb.Content = commentary.Content;
            commentDb.Article1 = article;
            bl.addComment(commentDb);
        }
    }
}
