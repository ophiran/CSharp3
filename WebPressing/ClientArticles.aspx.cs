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
    public partial class ClientArticles : System.Web.UI.Page
    {

        blAccess dbAccess;

        protected void Page_Load(object sender, EventArgs e)
        {

            dbAccess = new blAccess();

            //ListBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            ListBox1.AutoPostBack = true;

            //Create Menu
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            MenuLoader.loadMenu(Menu1, strUrl, UserType.READER);

            Menu1.MenuItemClick += Menu1_MenuItemClick;
            

            if (Session["Theme"] == null)
                Session["Theme"] = dbAccess.getThemes().First().Type1;
            if (Session["ChangedTheme"] == null)
                Session["ChangedTheme"] = true;

            List<Article> articles = dbAccess.getArticles((string)Session["Theme"]);
            if ((Boolean)Session["ChangedTheme"] == true)
            {
                ListBox1.Items.Clear();
                foreach (Article item in articles)
                {
                    if (item.Status == dbAccess.getStatus("Active").Id)
                        ListBox1.Items.Add(new ListItem(item.Title, item.Id.ToString()));
                }
            }
            Session["ChangedTheme"] = false;
            Theme.Text = (string)Session["Theme"];
            ArticleImage.Visible = false;
        }


        void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            MenuItem caller = sender as MenuItem;
            Session["ChangedTheme"] = true;

            if (e.Item.Parent.Text == "Theme")
            {
                Session["Theme"] = e.Item.Text;
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem != null)
            {
                Article item = dbAccess.getArticle(Int32.Parse(ListBox1.SelectedItem.Value));
                List<Comment> comments = dbAccess.getComments(item.Id);
                ArticleTitle.Text = item.Title;
                ArticleSubtitle.Text = item.SubTitle;
                TextBox1.Text = item.Text;
                TextBoxComments.TextMode = TextBoxMode.MultiLine;

                TextBoxComments.Text = "";
                foreach(Comment itemC in comments)
                {
                    TextBoxComments.Text += itemC.Content;
                    TextBoxComments.Text += "\n\n";
                }
                //ArticleImage.ImageUrl
            }
        }
    }
}