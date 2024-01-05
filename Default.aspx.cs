using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj3TryItPage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 

        protected void memberBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("Account/MemberLogin.aspx");
        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/MemberRegistration.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/MemberLogin.aspx");
        }

        protected void staffloginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void staffBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceDirectory.aspx");
        }
    }
}