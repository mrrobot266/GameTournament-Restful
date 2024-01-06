using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Proj3TryItPage
{
    public partial class ImageVerifierUserControl1 : System.Web.UI.UserControl
    {
        public static bool validCaptcha = false;
        public static string verifyText;
     

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void imgBtn_Click(object sender, EventArgs e)
        {
            string venusRestful = "https://venus.sod.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/";

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$";

            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {

                stringChars[i] = chars[random.Next(chars.Length)];

            }

            verifyText = new string(stringChars);

            string finalVerify = string.Concat(venusRestful, verifyText);

            Image1.ImageUrl = finalVerify;

       
        }
    }
}