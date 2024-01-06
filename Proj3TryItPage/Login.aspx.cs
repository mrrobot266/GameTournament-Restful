using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proj3TryItPage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string pw = stafflogPassword.Value;

            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\Staff.xml";
            string user = staffUser.Text; string password = stafflogPassword.Value;
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
                        Response.Redirect("Protected/Staff.aspx");
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
        }

       
        
        
        
        
        private bool myAutheticate(string user, string pass)
        {
            string fLocation = Path.Combine(Request.PhysicalApplicationPath,
            @"App_Data\Staff.xml");
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
    }
}