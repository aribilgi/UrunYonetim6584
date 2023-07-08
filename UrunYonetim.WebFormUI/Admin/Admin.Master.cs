using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrunYonetim.WebFormUI.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut(); // oturumu kapat
            Response.Redirect("/Admin/Login.aspx"); // kullanıcıyı tekrar girişe yönlendir
        }
    }
}