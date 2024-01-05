using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proj3TryItPage.Account
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string pw = memlogPassword.Value;

            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\Member.xml";
            string user = memlogText.Text; string password = memlogPassword.Value; 
            //HashRef.ServiceClient h = new HashRef.ServiceClient(); // hashing
            //string pwdEncrypt = h.Hash(password, "CSE445");
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);  // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"].InnerText == user)
                {
                    if (node["Password"].InnerText == password)
                    {
                        invalidLbl.Visible = false;
                        //createLoginCookie();
                        Response.Redirect("Member.aspx");
                        return;
                    }
                    else
                    {//if username exists but password does match. 
                        invalidLbl.Visible = true;
                        return;
                    }
                }
            }
            invalidLbl.Visible = true; 
            return;


            //if (myAutheticate(memlogText.Text, memlogPassword.Value))
            //{
            ////    FormsAuthentication.RedirectFromLoginPage
            //  //      (memlogText.Text, Persistent.Checked);
            //}
            //else
            //{
            //    invalidLbl.Visible = true;
            //}


            
        }

        private bool myAutheticate(string user, string pass)
        {
            string fLocation = Path.Combine(Request.PhysicalApplicationPath,
            @"App_Data\Member.xml");
            if (File.Exists(fLocation))
            {
                FileStream FS = new FileStream(fLocation, FileMode.Open);
                XmlDocument xd = new XmlDocument();
                xd.Load(FS);
                XmlNode node = xd;
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    // use hash function if the credential is hashed
                    // check if the username and password exist in the XML file;
                    if (node["Username"].InnerText == user && node["Password"].InnerText == pass)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberRegistration.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}