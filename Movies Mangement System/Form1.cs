using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SWE_Project
{

    public partial class Form1 : Form
    {
        string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0,0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();

            if (f.signIn(UserEmail_txt.Text.ToString(), userPassworf_txt.Text.ToString()))
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select user_name from imdb_user where mail= :email";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":email", UserEmail_txt.Text.ToString());

                string user_name =Convert.ToString(cmd.ExecuteScalar());

                UserEmail_txt.Clear();
                userPassworf_txt.Clear();
                var form = new dashboard(user_name);
                MessageBox.Show("Successful Logged in", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                form.Show();
                this.Hide();
                conn.Dispose();

            }
            else
            {
                MessageBox.Show("Invalid Email or Password", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var Myform = new Form2();
            Myform.Show();

            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                
           
        }

        private void Email_txt_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
           
        }

      

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = new Admin();
            a.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {












        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
