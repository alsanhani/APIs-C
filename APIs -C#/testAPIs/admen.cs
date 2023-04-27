using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAPIs
{
    public partial class admen : Form1
    {
        public admen()
        {
            InitializeComponent();
           
            
           


        }

        private void admen_Load(object sender, EventArgs e)
        {

        }
        public string ad = "";
        private void button3_Click(object sender, EventArgs e)
        {
            ad = "yes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = "no";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = j;
            ad = "yes";
            WebRequest request = WebRequest.Create("http://localhost/APIs/updatea.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string name = textBox6.Text;
            string isAdmin = ad;



            string postData = "&name=" + name + "&isAdmin=" + isAdmin;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            if (menuBreak != "Coludn't be inserted..")
            {
                 button7_Click(sender, e);

            }
            else
            {
                MessageBox.Show(menuBreak);
            }

        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Text = j;
            
            ad = "no";

            WebRequest request = WebRequest.Create("http://localhost/APIs/updatea.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string name = textBox6.Text;
            string isAdmin = ad;



            string postData = "&name=" + name + "&isAdmin=" + isAdmin;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            if (menuBreak != "Coludn't be inserted..")
            {
                  button7_Click(sender, e);

            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }
    }
}
