using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public partial class MgmStats : System.Web.UI.Page
    {
        BLL_Library.blAccess dbAccess;

        protected void Page_Load(object sender, EventArgs e)
        {
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            MenuLoader.loadMenu(Menu1, strUrl, UserType.ADMIN);
            dbAccess = new BLL_Library.blAccess();
            if(!IsPostBack)
            {
                MultiView1.SetActiveView(JournalistView);
                
                Session["fromDate"] = DateTime.MinValue;
                Session["toDate"] = DateTime.MaxValue;
            }
            DropDownList1.SelectedIndexChanged += DropDownList1_SelectedIndexChanged;
            Calendar1.SelectionChanged += fromCalendarChanged;
            Calendar2.SelectionChanged += toCalendarChanged;
            
        }

        private void toCalendarChanged(object sender, EventArgs e)
        {
            Session["toDate"] = Calendar2.SelectedDate;
        }

        private void fromCalendarChanged(object sender, EventArgs e)
        {
            Session["fromDate"] = Calendar1.SelectedDate;
        }

        void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0)
            {
                MultiView1.SetActiveView(JournalistView);
                MultiView1.ActiveViewIndex = 0;
            }
            else if(DropDownList1.SelectedIndex == 1)
            {
                MultiView1.SetActiveView(ThemeView);
                MultiView1.ActiveViewIndex = 1;
            }
            else if(DropDownList1.SelectedIndex == 2)
            {
                MultiView1.SetActiveView(ConnectedView);
                MultiView1.ActiveViewIndex = 2;
            }
            else
            {
                MultiView1.SetActiveView(ArticlesStatView);
                MultiView1.ActiveViewIndex = 3;
            }

            
        }

    }
}