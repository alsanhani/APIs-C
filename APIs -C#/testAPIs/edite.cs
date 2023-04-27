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
    public partial class edite : Form
    {
       
        public edite( string t, string z, string x, string c, string a)
        {
            InitializeComponent();
            
            textBox1.Text = t;
            textBox2.Text = z;
            textBox3.Text = x;
            textBox4.Text = c;
            textBox5.Text = a;

        }

        private void edite_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            WebRequest request = WebRequest.Create("http://localhost/APIs/update.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string name = textBox3.Text;
            string password = textBox4.Text;
            string email = textBox5.Text;
            
            string postData = "&fname=" + fname + "&lname=" + lname + "&name=" + name + "&password=" + password + "&email=" + email;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            add d = new add();
            d.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
       
    }
}

