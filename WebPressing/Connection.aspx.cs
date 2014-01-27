using BLL_Library;
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
        blAccess dbAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            MenuLoader.loadMenu(Menu1, strUrl, UserType.NONE);

            TextBoxPassword.TextMode = TextBoxMode.Password;
            dbAccess = new blAccess();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String password = TextBoxPassword.Text;
            String username = TextBoxUsername.Text;
            Session["ConnectedUser"] = dbAccess.getUser(username, password);

            String redirectUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            redirectUrl += "default.aspx";

            if (Session["ConnectedUser"] != null)
            {
                /*
                if (Request.Cookies.Get("Username") == null)
                {
                    Response.AppendCookie(new HttpCookie("Username", ((DAL_Library.User)Session["ConnectedUser"]).UserName));
                }*/
                dbAccess.incConnectionCount(DateTime.Today.Date);
                Response.Redirect(redirectUrl);
            }
        }
    }
}