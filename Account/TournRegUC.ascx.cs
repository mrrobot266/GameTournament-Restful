using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proj3TryItPage.Account
{
    public partial class TournRegUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {


            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\FifaRegistered.xml";
            string username = TextBox2.Text;
            string email = TextBox3.Text;

            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath); // open file
            XmlElement rootElement = myDoc.DocumentElement;

            int maxlimit = 0;

            foreach (XmlNode node in rootElement.ChildNodes)
            {
                maxlimit++;
                if (maxlimit >= 8)
                {
                    Label5.Text = "*Maximum number of players have registered*";
                    Label5.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (maxlimit < 8)
            {
                XmlElement myMember = myDoc.CreateElement("Member",
                    rootElement.NamespaceURI);
                rootElement.AppendChild(myMember);
                XmlElement myUser = myDoc.CreateElement("Username",
                rootElement.NamespaceURI);
                myMember.AppendChild(myUser);
                myUser.InnerText = username;
                XmlElement myEmail = myDoc.CreateElement("Email",
                rootElement.NamespaceURI);
                myMember.AppendChild(myEmail);
                myEmail.InnerText = email;
                myDoc.Save(filepath);
            }



            
                Label5.Visible = true;
            
        }
    }
}