using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proj3TryItPage.Account
{
    public partial class MemberFifa : System.Web.UI.Page
    {
        protected string hostURL = "http://localhost:49950";

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void RegistrationBtn_Click(object sender, EventArgs e)
        {

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            partLbl.Visible = true;
            partTxt.Visible = true;

            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\FifaRegistered.xml";
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);  // open file
            XmlElement rootElement = myDoc.DocumentElement;
            string participants = "";
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                participants = participants + node["Username"].InnerText + "\r\n";
            }
            partTxt.Text = participants;
        }

        protected void startBtn_Click(object sender, EventArgs e)
        {
            string[] teams = new string[8];
            int i = 0;
            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data\FifaRegistered.xml";
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);  // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                teams[i] = node["Username"].InnerText;
                i++;
            }
                                                          
            string url = @hostURL + "/Service.svc/SEED?x=" + teams[0] + "&y=" + teams[1] + "&z=" + teams[2] + "&a=" + teams[3] + "&b=" + teams[4] + "&c=" + teams[5] + "&d=" + teams[6] + "&e=" + teams[7];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            matchesTxt.Text = responsereader;

        }
    }
}