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

            Menu1.Items.Clear();
            MenuItem temp = new MenuItem("Menu");
            temp.Selectable = false;

            MenuItem addedItem = new MenuItem("Connect");
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            strUrl += "Connection.aspx";
            addedItem.NavigateUrl = strUrl;

            temp.ChildItems.Add(addedItem);

            addedItem = new MenuItem("Create Account");
            strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            strUrl += "CreateAcc.aspx";
            addedItem.NavigateUrl = strUrl;

            temp.ChildItems.Add(addedItem);
            Menu1.Items.Add(temp);
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