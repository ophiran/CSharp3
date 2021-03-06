﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_Library;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INewsWCF" in both code and config file together.
    [ServiceContract]
    public interface INewsWCF
    {
        [OperationContract]
        void createUser(String firstname, String lastname, String username, String password);

        [OperationContract]
        People connectUser(String username, String password);

        [OperationContract]
        People connectReader(String username, String password);

        [OperationContract]
        List<News> getNews();

        [OperationContract]
        List<Paper> getPapers();

        [OperationContract]
        void sendComment(Commentary commentary, People people, Paper paper);

        [OperationContract]
        List<News> getHistoric(People user);

        [OperationContract]
        void sendNews(News news, People people);

        [OperationContract]
        void sendNewsA(News news, string author);
    }


    [DataContract]
    public class News
    {
        public News()
        {

        }
        public News(New n)
        {
            this.Author = n.Author;
            this.Title = n.Title;
            this.SubTitle = n.SubTitle;
            this.Body = n.Text;
            this.Author = n.Author;
        }
        [DataMember]
        public String Title { get; set; }

        [DataMember]
        public String SubTitle { get; set; }
        
        [DataMember]
        public String Body { get; set; }

        [DataMember]
        public int? Author { get; set; }

    }

    [DataContract]
    public class Commentary
    {
        public Commentary()
        {

        }
        public Commentary(Comment c)
        {
            this.Content = c.Content;
            this.Rating = c.Rating;
            this.Paper = c.Article;
            this.Author = c.Author;
        }
        [DataMember]
        public String Content { get; set; }

        [DataMember]
        public int? Rating { get; set; }

        [DataMember]
        public int? Paper { get; set; }

        [DataMember]
        public int? Author { get; set; }

    }

    [DataContract]
    public class Paper
    {
        public Paper()
        {

        }
        public Paper(Article a)
        {
            this.Id = a.Id;
            this.Author = a.Author;
            this.Title = a.Title;
            this.SubTitle = a.SubTitle;
            this.Body = a.Text;
            this.Overview = a.Overview;
            this.Author = a.Author;
        }
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public String Title { get; set; }

        [DataMember]
        public String SubTitle { get; set; }
        
        [DataMember]
        public String Body { get; set; }

        [DataMember]
        public String Overview { get; set; }


        [DataMember]
        public int? Author { get; set; }

    }

    [DataContract]
    public class People
    {
        public People()
        {

        }
        public People(User user)
        {
            this.Id = user.Id;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Password = user.Password;
            this.UserName = user.UserName;
            this.Right = user.Right;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String LastName { get; set; }

        [DataMember]
        public String UserName { get; set; }

        [DataMember]
        public String Password { get; set; }

        [DataMember]
        public int Right { get; set; }
    }
}
