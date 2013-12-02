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

        public User connectUser(string username, string password)
        {
            return bl.getUser(username, password);
        }

        public List<New> getNews()
        {
            return bl.getNews();
        }

        public List<New> getHistoric(User user)
        {
            return bl.getNews(user);
        }
    }
}
