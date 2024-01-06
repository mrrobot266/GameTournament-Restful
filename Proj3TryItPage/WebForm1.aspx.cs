using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

//http://localhost:49950/Service.svc
//http://webstrar75.fulton.asu.edu/page0/Service.svc
namespace Proj3TryItPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string hostURL = "http://localhost:49950";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
            //on invoke button click 
        protected void btnURL_Click(object sender, EventArgs e)
        {


            //make httprequest to rest service
            string url = @hostURL + "/Service.svc/WD?x=" + txtURL.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            txtUrlOutput.Text = responsereader;

        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {

            //make httprequest to rest service
            string url = @hostURL + "/Service.svc/WF?x=" + txtFilterInput.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            txtFilterOutput.Text = responsereader;
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = @hostURL + "/Service.svc/NUM?x=" + txtNumbers.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            TextBox1.Text = responsereader;

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string url = @hostURL + "/Service.svc/REG?x=" + txtTeamName.Text + "&y=" + txtEmail1.Text + "&z=" + txtUser1.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            txtRegMsg.Text = responsereader;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string url = @hostURL + "/Service.svc/SEED?x=" + txtTeam1.Text + "&y=" + txtTeam2.Text + "&z=" + txtTeam3.Text + "&a=" + txtTeam4.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            txtGameResult.Text = responsereader;
        }
    }





}