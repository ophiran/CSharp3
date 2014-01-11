using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public partial class Connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

            addedItem = new MenuItem("Home");
            strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            strUrl += "default.aspx";
            addedItem.NavigateUrl = strUrl;

            temp.ChildItems.Add(addedItem);
            Menu1.Items.Add(temp);

            TextBox2.TextMode = TextBoxMode.Password;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}