using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPressing
{
    public enum UserType
	{
	         NONE,READER,ADMIN
	}

    public class MenuLoader
    {


        private static MenuItem addChildMenu(String name,MenuItem menuItem,String url)
        {
            return addChildMenu(name, menuItem, url, true);
        }

        private static MenuItem addChildMenu(String name,MenuItem menuItem,String url,Boolean clickable)
        {
            MenuItem addedItem = new MenuItem(name);
            addedItem.NavigateUrl = url;
            menuItem.ChildItems.Add(addedItem);
            menuItem.Selectable = clickable;
            return addedItem;
        }

        public static void loadMenu(Menu menu, String baseUrl, UserType userType)
        {

            menu.Items.Clear();
            MenuItem temp = new MenuItem("Menu");
            temp.Selectable = false;

            switch (userType)
	        {
		        case UserType.NONE:
                    loadMenuBasic(temp,baseUrl);
                    break;
                case UserType.READER:
                    loadMenuReader(temp,baseUrl);
                    loadMenuCommon(temp,baseUrl);
                    break;
                case UserType.ADMIN:
                    loadMenuAdmin(temp,baseUrl);
                    loadMenuCommon(temp,baseUrl);
                    break;
                default:
                    break;
	        }
            menu.Items.Add(temp);
        }

        private static void loadMenuAdmin(MenuItem menu, String baseUrl)
        {
            MenuItem addedItem = addChildMenu("Users management", menu, "", false);
            addChildMenu("Journalist", addedItem, baseUrl + "MgmtJournalist.aspx");
            addChildMenu("Readers", addedItem, baseUrl + "MgmtReaders.aspx");

            addedItem = addChildMenu("Infos management", menu, "", false);
            addChildMenu("News-Articles", addedItem, baseUrl + "MgmtNewsArticles.aspx");
            addChildMenu("Statistics", addedItem, baseUrl + "MgmStats.aspx");
        }

        private static void loadMenuBasic(MenuItem menu, String baseUrl)
        {
            addChildMenu("Connect", menu, baseUrl + "Connection.aspx");
            addChildMenu("Create User", menu, baseUrl + "CreateAcc.aspx");
            addChildMenu("Home", menu, baseUrl + "default.aspx");
        }

        private static void loadMenuReader(MenuItem menu, String baseUrl)
        {
            BLL_Library.blAccess dbAccess = new BLL_Library.blAccess();

            MenuItem addedItem = addChildMenu("Theme", menu, "", false);
            foreach (DAL_Library.Type theme in dbAccess.getThemes())
            {
                if(theme.Status == dbAccess.getStatus("Active").Id)
                    addChildMenu(theme.Type1, addedItem, "ClientArticles.aspx");
            }
        }

        private static void loadMenuCommon(MenuItem menu, String baseUrl)
        {

            addChildMenu("Disconnect", menu, baseUrl + "Disconnect.aspx");
            addChildMenu("Home",menu,baseUrl+"default.aspx");
        }
    }
}