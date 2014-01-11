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
        protected void Page_Load(object sender, EventArgs e)
        {

            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");

            Menu1.Items.Clear();
            MenuItem temp = new MenuItem("Menu");
            temp.Selectable = false;

            MenuItem addedItem = new MenuItem("Disconnect");
            addedItem.NavigateUrl = strUrl + "default.aspx";

            temp.ChildItems.Add(addedItem);

            //Creating Theme menu
            MenuItem themeItem = new MenuItem("Theme");
            themeItem.Selectable = false;

            temp.ChildItems.Add(themeItem);

            Menu1.Items.Add(temp);


        }
    }
}