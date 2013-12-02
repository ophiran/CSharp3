using System;
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
            User user = bl.getUser(username, password);
            if (user != null)
                return new People(user);
            else
                return null;
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

        public List<News> getHistoric(People people)
        {
            User user = new User();
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


        public List<News> getNewsStub()
        {
            return null;
        }
    }
}
