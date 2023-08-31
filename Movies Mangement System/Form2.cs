using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            if (f.checking_name(UserNameTxt.Text.ToString()))
            {
                if (f.checking_email(EmailTxt.Text.ToString()))
                {
                    if (f.ValidateEmail(EmailTxt.Text.ToString()))
                    {
                        if (f.validpassword(PasswordTxt.Text.ToString()))
                        {
                            if (PasswordTxt.Text.ToString() == ConPasswordTxt.Text.ToString())
                            {

                                bool x;
                                x = f.InsertUser(EmailTxt.Text.ToString(), UserNameTxt.Text.ToString(), PasswordTxt.Text.ToString());
                                if (x)
                                {
                                    UserNameTxt.Clear();
                                    EmailTxt.Clear();
                                    PasswordTxt.Clear();
                                    ConPasswordTxt.Clear();
                                    MessageBox.Show("Registration completed", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                else
                                {
                                    MessageBox.Show("Please try again", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password Mismatch", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password \n\nPassword must be 8 characters and does not contain spaces", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Email", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                    else
                    {
                        MessageBox.Show("Email already Exist Please Enter another Email", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Username Already Exist Please Enter another one", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        


        private void ShwPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShwPass.Checked)
            {
                PasswordTxt.PasswordChar ='\0';
                ConPasswordTxt.PasswordChar = '\0';
            }
            else
            {
                PasswordTxt.PasswordChar = '*';
                ConPasswordTxt.PasswordChar = '*';
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            var Myform = new Form1();
            Myform.Show();

             this.Close();
        }
    }
}
