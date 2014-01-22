using BLL_Library;
using DAL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public partial class MainForm : System.Web.UI.Page
    {
        List<New> listNews;
        List<Article> listArticles;
        blAccess dbAccess;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.TreeView1.Load += TreeView1_Load;
            dbAccess = new blAccess();
            
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            DAL_Library.User connectedUser = Session["ConnectedUser"] as DAL_Library.User;


            if (Session["ConnectedUser"] == null)
            {
                MenuLoader.loadMenu(Menu1, strUrl, UserType.NONE);
            }
            else if(connectedUser.Right == dbAccess.getRight("Admin").Id)
            {
                MenuLoader.loadMenu(Menu1, strUrl, UserType.ADMIN);
            }
            else if(connectedUser.Status == dbAccess.getStatus("Active").Id)
            {
                MenuLoader.loadMenu(Menu1, strUrl, UserType.READER);
            }
            else 
            {
                MenuLoader.loadMenu(Menu1, strUrl, UserType.NONE);
            }
            
        }

        private void TreeView1_Load(object sender, EventArgs e)
        {
            listNews = new List<New>(dbAccess.getNews());
            listArticles = new List<Article>(dbAccess.getArticles());

            TreeNodeCollection newsNodes = TreeView1.FindNode("News.Root").ChildNodes;
            TreeNodeCollection articlesNodes = TreeView1.FindNode("Articles.Root").ChildNodes;

            newsNodes.Clear();
            foreach (New news in listNews)
            {
                TreeNode newNode = new TreeNode(news.Title);
                newNode.ChildNodes.Add(new TreeNode(news.Text));
                newsNodes.Add(newNode);
            }

            articlesNodes.Clear();
            foreach (Article article in listArticles)
            {
                TreeNode newNode = new TreeNode(article.Title);
                newNode.ChildNodes.Add(new TreeNode(article.Text));
                articlesNodes.Add(newNode);
            }
        }

        


    }
}