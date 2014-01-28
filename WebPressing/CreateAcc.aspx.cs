using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Library;
using System.Data.SqlClient;
using System.Data.Linq;

namespace WebPressing
{
    public partial class CreateAcc : System.Web.UI.Page
    {
        BLL_Library.blAccess dbAccess;
        String type = String.Empty;
        String username = String.Empty;
        String password = String.Empty;
        String email = String.Empty;
        Stream file = null;
        String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.PathAndQuery, "/");

        protected void Page_Load(object sender, EventArgs e)
        {
            dbAccess = new BLL_Library.blAccess();    
            
            MenuLoader.loadMenu(Menu1, strUrl, UserType.NONE);

            Wizard1.FinishButtonClick += Wizard1_NextStep;
            Wizard1.NextButtonClick += Wizard1_NextStep;
            Wizard1.SideBarButtonClick += Wizard1_NextStep;

            if(!IsPostBack)
                RadioButtonList1.Items[0].Selected = true;
        }

        void Wizard1_NextStep(object sender, WizardNavigationEventArgs e)
        {
            DAL_Library.User newUser = null;

            //Creation d'un nouveau user dans la session(temporaire)
            if(Session["CUser"] != null)
            {
                newUser = (DAL_Library.User)Session["CUser"];
            }
            else
            {
                Session["CUser"] = new User();
            }

            //3 different etats du Wizard
            if (e.CurrentStepIndex == 0) 
            {
                if(Session["CUser.Type"] == null)
                    Session["CUser.Type"] = RadioButtonList1.SelectedValue;
                
            }
            else if (e.CurrentStepIndex == 1)
            {
                if(TextBoxPassword.Text.Equals(TextBoxPasswordConfirm.Text))
                {
                    newUser.Password = TextBoxPassword.Text;
                }
                newUser.UserName = TextBoxUsername.Text;
                newUser.MailAddress = TextBoxMail.Text;
            }
            else if (e.CurrentStepIndex == 2 && e.NextStepIndex == 2)
            {
                file = FileUpload1.FileContent;

                if (!Session["CUser.Type"].Equals(String.Empty)
                    && !newUser.UserName.Equals(String.Empty)
                    && !newUser.Password.Equals(String.Empty)
                    && !newUser.MailAddress.Equals(String.Empty)
                    && file != null)
                {

                    MemoryStream memStream = new MemoryStream();
                    file.CopyTo(memStream);
                    Binary fileRep = new Binary(memStream.ToArray());
                    newUser.File = fileRep;

                    newUser.Right1 = dbAccess.getRight((String)Session["CUser.Type"]);
                    newUser.Status1 = dbAccess.getStatus("Pending");
                    dbAccess.addJournalist(newUser);
                    Session["CUser.Type"] = null;
                    Session["CUser"] = null;

                    Response.Redirect(strUrl + "default.aspx");
                }


            }
        }


        
    }
}