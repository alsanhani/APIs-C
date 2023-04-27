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
    public partial class login : Form, ILogin
    {
        public login()
        {
            InitializeComponent();
        }
        public string Login(string username, string pass)
        {
            Check_user n = new Check_user();
            if (n.Login(username, pass) == "1")
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            return n.Login(username, pass);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string q, w;
        private void button3_Click(object sender, EventArgs e)
        {
            Check_user n = new Check_user();
            if (n.Login(textBox1.Text, textBox5.Text) == "1")
            {
                admen f = new admen();
                f.Show();
                this.Hide();
            }

            else if (textBox1.Text != "" || textBox5.Text != "")
            {
                WebRequest request = WebRequest.Create("http://localhost/APIs/login.php");
                request.Method = "POST";// the method to send data
                request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                string username = textBox1.Text;
                string password = textBox5.Text;
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
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

      
        }
    }

