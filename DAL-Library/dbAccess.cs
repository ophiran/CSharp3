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
            if (!dc.News.Contains(news))
            {
                dc.News.InsertOnSubmit(news);
                dc.SubmitChanges();
            }
        }

        public void delNews(New news)
        {
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.News.Contains(news))
            {
                dc.News.DeleteOnSubmit(news);
                dc.SubmitChanges();
            }
        }

        public void updNews(New news)
        {
            if (dc.News.Contains(news))
            {
                delNews(news);
                addNews(news);
            }
        }

    }
}
