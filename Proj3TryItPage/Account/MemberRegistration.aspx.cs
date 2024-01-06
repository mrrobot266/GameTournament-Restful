using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;



namespace Proj3TryItPage.Account
{
    //public static string verifyText = "";
    public partial class MemberRegistration : System.Web.UI.Page
    {

        public static bool validCaptcha = false;
        string verifyText;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["myCookie"]; //implement cookies
            if(cookie != null)
            {
                memuserTextBox.Text = cookie["input"];
            }

               
            
        }

        protected void memberRegBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("myCookie");
            cookie["input"] = memuserTextBox.Text;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);

            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\Member.xml";
            string username = memuserTextBox.Text;
            string password = mempass.Value;

           // HashRef.ServiceClient h = new HashRef.ServiceClient(); // hashing
            //string pwdEncrypt = h.Hash(password, "CSE445");
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath); // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"].InnerText == username)
                {
                    errorUser.Text = String.Format("*Account with user name {0} already exists.", username);
                    errorUser.Visible = true;
                    return;
                }
            }
            errorUser.Visible = false;


            string captcha = imgText.Text;
                string captcha2 = ImageVerifierUserControl1.verifyText;



            if (captcha == captcha2 && errorUser.Visible == false)
                {

                    errorLbl.Visible = false;
                    validCaptcha = true;

                XmlElement myMember = myDoc.CreateElement("Member",
                rootElement.NamespaceURI);
                rootElement.AppendChild(myMember);
                XmlElement myUser = myDoc.CreateElement("Username",
                rootElement.NamespaceURI);
                myMember.AppendChild(myUser);
                myUser.InnerText = username;
                XmlElement myPwd = myDoc.CreateElement("Password",
                rootElement.NamespaceURI);
                myMember.AppendChild(myPwd);
                myPwd.InnerText = password;
                myDoc.Save(filepath);

                Response.Redirect("MemberLogin.aspx");
                }
                else
                {
                    errorLbl.Visible = true;
                    validCaptcha = false;
                }
            
  

           

              //  string username = memuserTextBox.Text;
              //  string password = mempassTextBox.Text;


        }

        protected void imgBtn_Click(object sender, EventArgs e)
        {
 

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberLogin.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}