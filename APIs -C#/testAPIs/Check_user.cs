using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace testAPIs
{

    interface ILogin
    {
        string Login(string username, string pass);
    }
    internal class Check_user : login , ILogin 
    {
        public string Login(string username1, string pass)
        {
            
            string type = "";

            if (username1 != "" || pass != "")
            {
                WebRequest request = WebRequest.Create("http://localhost/APIs/loginc.php");
                request.Method = "POST";// the method to send data
                request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                string username = username1;
                string password = pass;
                string postData = "username=" + username + "&password=" + password;

                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] data = enc.GetBytes(postData);
                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);


                WebResponse response = request.GetResponse();
                Stream stream2 = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream2);
                string result = sr.ReadLine();
                if (result == "1")
                {
                    type="1";

                }

            }
            return type;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Check_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Name = "Check_user";
            this.Load += new System.EventHandler(this.Check_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Check_user_Load(object sender, EventArgs e)
        {

        }
    }
}
