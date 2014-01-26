using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public partial class MgmtJournalist : System.Web.UI.Page
    {
        BLL_Library.blAccess dbAccess;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbAccess = new BLL_Library.blAccess();

            LinqDataSource1.EnableUpdate = true;

            GridView1.RowCommand += GridView1_RowCommand;
        }

        private void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridView grid = sender as GridView;
            TableCellCollection tc = grid.Rows[(grid.PageSize - 1) * grid.PageIndex + Int32.Parse((String)e.CommandArgument)].Cells;

            switch (e.CommandName)
            {
                case "Enable":
                    dbAccess.setStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Active"));
                    tc[6].Text = "2";
                    break;
                case "Disable":
                    dbAccess.setStatus(Int32.Parse(tc[0].Text), dbAccess.getStatus("Disabled"));
                    tc[6].Text = "3";
                    break;
                case "Download":
                    Binary bin = dbAccess.getJournalist(tc[4].Text).File;
                    String tmpFile = Path.GetTempFileName().Replace(".tmp", ".pdf");
                    FileStream fs = new FileStream(tmpFile, FileMode.OpenOrCreate);
                    fs.Write(bin.ToArray(), 0, bin.Length);
                    fs.Flush();
                    fs.Close();
                    Response.ContentType = "Application/pdf";
                    Response.AppendHeader("content-disposition", "attachment; filename=" + tmpFile);
                    Response.TransmitFile(tmpFile);
                    Response.End();
                    break;
                default:
                    break;
            }
        }
    }
}