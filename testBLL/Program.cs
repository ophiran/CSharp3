using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Library;
using DAL_Library;

namespace testBLL
{
    class Program
    {
        static void Main(string[] args)
        {
            blAccess bl = new blAccess();
            Console.Out.WriteLine("Please enter your login :");
            string userLogin = Console.In.ReadLine();
            Console.Out.WriteLine("Please enter your password :");
            string userPassword = Console.In.ReadLine();
            User loggedUser = bl.getUser(userLogin, userPassword);
            if (loggedUser != null)
            {
                if (bl.isJournalist(loggedUser)) 
                {
                    List<New> userNews = bl.getNews(loggedUser);
                    foreach (New n in userNews)
                    {
                        Console.Out.WriteLine(n.Title);
                    }
                }
                else
                {
                    Console.Out.WriteLine("Only journalist are authorized");
                }
            }
            else
            {
                Console.Out.WriteLine("Could not find a user with such credentials...");
            }
            Console.In.ReadLine();
        }
    }
}
