using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL_Library;
using System.Xml.Serialization;
using System.IO;
using WcfService;

namespace XMLCreator
{
    class Program
    {
        static void Main(string[] args)
        {/*
            XElement doc = new XElement("Documents",
                new XElement("News",
                    new XElement("Title","a title"),
                    new XElement("SubTitle","my subtitle"),
                    new XElement("Body","bla bla bla")));
            doc.Save("C:\\xmlFileWatcherCSharp\\test.xml");

            New test = new New();
            test.Id = 5;
            test.DepositDate = new DateTime();
            test.SubTitle = "a test subtitle 2";
            test.Text = "bla bla bla 2";
            test.Title = "Title num 2";*/

            News news = new News();
            news.Title = "test3";
            news.SubTitle = "subtitle 3";
            news.Body = "Body 3";/*
            XmlSerializer ser = new XmlSerializer(typeof(News));
            TextWriter textWriter = new StreamWriter("C:\\xmlFileWatcherCSharp\\test3.xml");
            ser.Serialize(textWriter, news);
            textWriter.Close();*/

            List<News> newsList = new List<News>();
            for (int i = 0; i < 6; i++)
            {
                newsList.Add(news);
            }

            XmlSerializer serList = new XmlSerializer(typeof(List<News>));
            TextWriter textWriterList = new StreamWriter("C:\\xmlFileWatcherCSharp\\testList.xml");
            serList.Serialize(textWriterList, newsList);
            textWriterList.Close();

        }
    }
}
