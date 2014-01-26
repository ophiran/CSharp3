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
            dbAccess = new BLL_Library.blAccess();
            if(!IsPostBack)
            {
                MultiView1.SetActiveView(JournalistView);

            }
            DropDownList1.SelectedIndexChanged += DropDownList1_SelectedIndexChanged;
            
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
                MultiView1.SetActiveView(ChartView);
                MultiView1.ActiveViewIndex = 2;
            }
            else
            {
                MultiView1.SetActiveView(ChartView);
                MultiView1.ActiveViewIndex = 2;
            }

            
        }

    }
}