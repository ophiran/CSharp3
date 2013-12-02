using System;
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
        User connectUser(String username, String password);

        [OperationContract]
        List<New> getNews();

        [OperationContract]
        List<New> getHistoric(int userId);
    }
}
