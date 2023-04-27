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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

           

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
         public string name="ncksdn";
        public string j;
        public void yousef(object sender, DataGridViewCellEventArgs e)
        {
            

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            j = textBox3.Text;

        }
       
        
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        public void button8_Click(object sender, EventArgs e)
        {
            add d = new add();
            d.Show();
            this.Hide();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            edite q = new edite(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            q.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost/APIs/DELETE.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string name = textBox1.Text;


            string postData = "name=" + name;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);

            if (menuBreak != "Coludn't be deleted..")
            {
                button7_Click(sender, e);

            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost/APIs/Menu.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string postData = "RequestType=select";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();

            if (menuBreak != "Sorry, No food in this menu")
            {
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "a";
                dataGridView1.DataSource = ds.Tables["a"];




            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           // this.DestroyHandle();
        }
       


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
