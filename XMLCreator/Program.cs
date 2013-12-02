using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL_Library;
using System.Xml.Serialization;
using System.IO;

namespace XMLCreator
{
    class Program
    {
        static void Main(string[] args)
        {
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
            test.Title = "Title num 2";

            //News 
        }
    }
}
