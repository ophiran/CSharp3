using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_Library;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NewsWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NewsWCF.svc or NewsWCF.svc.cs at the Solution Explorer and start debugging.
    public class NewsWCF : INewsWCF
    {

        public int createUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int connectUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<New> getNews()
        {
            throw new NotImplementedException();
        }

        public List<New> getHistoric(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
