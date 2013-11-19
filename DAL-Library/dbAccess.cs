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
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public List<New> getNews()
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            List<New> newsList = dc.News.ToList<New>();
            return newsList;
        }

        public void addNews(New news)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.News.InsertOnSubmit(news);
        }

        public void delNews(int id)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.News.DeleteOnSubmit(dc.News.)
        }
    }
}
