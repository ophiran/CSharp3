using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public partial class MgmtNewsArticles : System.Web.UI.Page
    {
        BLL_Library.blAccess dbAccess;

        protected void Page_Load(object sender, EventArgs e)
        {
            String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");
            MenuLoader.loadMenu(Menu1, strUrl, UserType.ADMIN);

            dbAccess = new BLL_Library.blAccess();
            if (!IsPostBack)
            {
                MultiView1.SetActiveView(NewsView);

            }

            DropDownList1.SelectedIndexChanged += DropDownList1_SelectedIndexChanged;

            GridView1.RowCommand += GridView1_RowCommand;
            GridView2.RowCommand += GridView2_RowCommand;
            GridView3.RowCommand += GridView3_RowCommand;
        }


        //News gridview event
        void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridView grid = sender as GridView;
            TableCellCollection tc = grid.Rows[(grid.PageSize - 1) * grid.PageIndex + Int32.Parse((String)e.CommandArgument)].Cells;

            switch (e.CommandName)
            {
                case "Enable":
                    dbAccess.setNewsStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Active"));
                    tc[5].Text = "2";
                    break;
                case "Disable":
                    dbAccess.setNewsStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Disabled"));
                    tc[5].Text = "3";
                    break;
                default:
                    break;
            }
        }

        //Articles gridview event
        private void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            GridView grid = sender as GridView;
            TableCellCollection tc = grid.Rows[(grid.PageSize - 1) * grid.PageIndex + Int32.Parse((String)e.CommandArgument)].Cells;

            switch (e.CommandName)
            {
                case "Enable":
                    dbAccess.setArticleStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Active"));
                    tc[5].Text = "2";
                    break;
                case "Disable":
                    dbAccess.setArticleStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Disabled"));
                    tc[5].Text = "3";
                    break;
                default:
                    break;
            }
        }

        //Theme gridview event
        private void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            GridView grid = sender as GridView;
            TableCellCollection tc = grid.Rows[(grid.PageSize - 1) * grid.PageIndex + Int32.Parse((String)e.CommandArgument)].Cells;

            switch (e.CommandName)
            {
                case "Enable":
                    dbAccess.setThemeStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Active"));
                    tc[2].Text = "2";
                    break;
                case "Disable":
                    dbAccess.setThemeStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Disabled"));
                    tc[2].Text = "3";
                    break;
                default:
                    break;
            }
        }




        void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                MultiView1.SetActiveView(NewsView);
                MultiView1.ActiveViewIndex = 0;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                MultiView1.SetActiveView(ArticlesView);
                MultiView1.ActiveViewIndex = 1;
            }
            else
            {
                MultiView1.SetActiveView(ThemeView);
                MultiView1.ActiveViewIndex = 2;
            }
        }
    }
}