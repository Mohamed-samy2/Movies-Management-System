
namespace SWE_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sign_in_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_signin_btn = new System.Windows.Forms.Button();
            this.Sign_in_lb = new System.Windows.Forms.Label();
            this.userSignUp_lb = new System.Windows.Forms.LinkLabel();
            this.UserEmail_txt = new System.Windows.Forms.TextBox();
            this.userPassworf_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_in_btn
            // 
            this.Sign_in_btn.BackColor = System.Drawing.Color.Red;
            this.Sign_in_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_in_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Sign_in_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_in_btn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.Sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.Sign_in_btn.Location = new System.Drawing.Point(72, 436);
            this.Sign_in_btn.Name = "Sign_in_btn";
            this.Sign_in_btn.Size = new System.Drawing.Size(406, 54);
            this.Sign_in_btn.TabIndex = 0;
            this.Sign_in_btn.Text = "Sign in";
            this.Sign_in_btn.UseVisualStyleBackColor = false;
            this.Sign_in_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(66, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "New to IMDb ?";
            // 
            // Admin_signin_btn
            // 
            this.Admin_signin_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Admin_signin_btn.FlatAppearance.BorderSize = 0;
            this.Admin_signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Admin_signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_signin_btn.Font = new System.Drawing.Font("Corbel", 10F);
            this.Admin_signin_btn.ForeColor = System.Drawing.Color.White;
            this.Admin_signin_btn.Location = new System.Drawing.Point(317, 506);
            this.Admin_signin_btn.Name = "Admin_signin_btn";
            this.Admin_signin_btn.Size = new System.Drawing.Size(161, 38);
            this.Admin_signin_btn.TabIndex = 8;
            this.Admin_signin_btn.Text = "Admin";
            this.Admin_signin_btn.UseVisualStyleBackColor = true;
            this.Admin_signin_btn.Click += new System.EventHandler(this.button3_Click);
            this.Admin_signin_btn.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.Admin_signin_btn.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // Sign_in_lb
            // 
            this.Sign_in_lb.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Bold);
            this.Sign_in_lb.ForeColor = System.Drawing.Color.White;
            this.Sign_in_lb.Location = new System.Drawing.Point(12, 25);
            this.Sign_in_lb.Name = "Sign_in_lb";
            this.Sign_in_lb.Size = new System.Drawing.Size(175, 61);
            this.Sign_in_lb.TabIndex = 5;
            this.Sign_in_lb.Text = "Sign In";
            // 
            // userSignUp_lb
            // 
            this.userSignUp_lb.ActiveLinkColor = System.Drawing.Color.White;
            this.userSignUp_lb.AutoSize = true;
            this.userSignUp_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSignUp_lb.Font = new System.Drawing.Font("Corbel", 10F);
            this.userSignUp_lb.LinkColor = System.Drawing.Color.White;
            this.userSignUp_lb.Location = new System.Drawing.Point(180, 523);
            this.userSignUp_lb.Name = "userSignUp_lb";
            this.userSignUp_lb.Size = new System.Drawing.Size(95, 21);
            this.userSignUp_lb.TabIndex = 20;
            this.userSignUp_lb.TabStop = true;
            this.userSignUp_lb.Text = "Sign up now";
            this.userSignUp_lb.VisitedLinkColor = System.Drawing.Color.Red;
            this.userSignUp_lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserEmail_txt
            // 
            this.UserEmail_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UserEmail_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmail_txt.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail_txt.ForeColor = System.Drawing.Color.White;
            this.UserEmail_txt.Location = new System.Drawing.Point(65, 237);
            this.UserEmail_txt.MaxLength = 300;
            this.UserEmail_txt.Multiline = true;
            this.UserEmail_txt.Name = "UserEmail_txt";
            this.UserEmail_txt.Size = new System.Drawing.Size(406, 40);
            this.UserEmail_txt.TabIndex = 1;
            this.UserEmail_txt.Tag = "";
            this.UserEmail_txt.Click += new System.EventHandler(this.Email_txt_Click);
            this.UserEmail_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // userPassworf_txt
            // 
            this.userPassworf_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userPassworf_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassworf_txt.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassworf_txt.ForeColor = System.Drawing.Color.White;
            this.userPassworf_txt.Location = new System.Drawing.Point(72, 358);
            this.userPassworf_txt.MaxLength = 300;
            this.userPassworf_txt.Multiline = true;
            this.userPassworf_txt.Name = "userPassworf_txt";
            this.userPassworf_txt.PasswordChar = '*';
            this.userPassworf_txt.Size = new System.Drawing.Size(406, 40);
            this.userPassworf_txt.TabIndex = 1;
            this.userPassworf_txt.Tag = "";
            this.userPassworf_txt.Click += new System.EventHandler(this.textBox1_Click);
            this.userPassworf_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Sign_in_lb);
            this.panel1.Controls.Add(this.UserEmail_txt);
            this.panel1.Controls.Add(this.userPassworf_txt);
            this.panel1.Controls.Add(this.userSignUp_lb);
            this.panel1.Controls.Add(this.Admin_signin_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Sign_in_btn);
            this.panel1.Location = new System.Drawing.Point(383, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 620);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(60, 177);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(187, 39);
            this.Username.TabIndex = 21;
            this.Username.Text = "Email:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SWE_Project.Properties.Resources.imdb__3_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::SWE_Project.Properties.Resources.Netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sign_in_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Admin_signin_btn;
        private System.Windows.Forms.Label Sign_in_lb;
        private System.Windows.Forms.LinkLabel userSignUp_lb;
        private System.Windows.Forms.TextBox UserEmail_txt;
        private System.Windows.Forms.TextBox userPassworf_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

