
namespace SWE_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signin_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShwPass = new System.Windows.Forms.CheckBox();
            this.Sign_up_lb = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.ConPasswordTxt = new System.Windows.Forms.TextBox();
            this.ConPassword = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Register_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signin_lb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ShwPass);
            this.panel1.Controls.Add(this.Sign_up_lb);
            this.panel1.Controls.Add(this.EmailTxt);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.ConPasswordTxt);
            this.panel1.Controls.Add(this.ConPassword);
            this.panel1.Controls.Add(this.PasswordTxt);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.UserNameTxt);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Register_btn);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel1.Location = new System.Drawing.Point(625, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 783);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(463, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "IMDb";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signin_lb
            // 
            this.signin_lb.AutoSize = true;
            this.signin_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_lb.ForeColor = System.Drawing.Color.Red;
            this.signin_lb.Location = new System.Drawing.Point(333, 695);
            this.signin_lb.Name = "signin_lb";
            this.signin_lb.Size = new System.Drawing.Size(81, 16);
            this.signin_lb.TabIndex = 29;
            this.signin_lb.Text = "Sign In Now";
            this.signin_lb.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(161, 695);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Already Have an Account";
            // 
            // ShwPass
            // 
            this.ShwPass.AutoSize = true;
            this.ShwPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShwPass.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShwPass.Location = new System.Drawing.Point(410, 537);
            this.ShwPass.Name = "ShwPass";
            this.ShwPass.Size = new System.Drawing.Size(144, 27);
            this.ShwPass.TabIndex = 27;
            this.ShwPass.Text = "Show Password";
            this.ShwPass.UseVisualStyleBackColor = true;
            this.ShwPass.CheckedChanged += new System.EventHandler(this.ShwPass_CheckedChanged);
            // 
            // Sign_up_lb
            // 
            this.Sign_up_lb.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Bold);
            this.Sign_up_lb.ForeColor = System.Drawing.Color.White;
            this.Sign_up_lb.Location = new System.Drawing.Point(104, 67);
            this.Sign_up_lb.Name = "Sign_up_lb";
            this.Sign_up_lb.Size = new System.Drawing.Size(265, 63);
            this.Sign_up_lb.TabIndex = 5;
            this.Sign_up_lb.Text = "Get Started";
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTxt.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.EmailTxt.Location = new System.Drawing.Point(113, 294);
            this.EmailTxt.Multiline = true;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(488, 36);
            this.EmailTxt.TabIndex = 26;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(109, 252);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(58, 19);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email:";
            // 
            // ConPasswordTxt
            // 
            this.ConPasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ConPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConPasswordTxt.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.ConPasswordTxt.Location = new System.Drawing.Point(113, 495);
            this.ConPasswordTxt.Multiline = true;
            this.ConPasswordTxt.Name = "ConPasswordTxt";
            this.ConPasswordTxt.PasswordChar = '*';
            this.ConPasswordTxt.Size = new System.Drawing.Size(488, 36);
            this.ConPasswordTxt.TabIndex = 24;
            // 
            // ConPassword
            // 
            this.ConPassword.AutoSize = true;
            this.ConPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConPassword.Location = new System.Drawing.Point(109, 460);
            this.ConPassword.Name = "ConPassword";
            this.ConPassword.Size = new System.Drawing.Size(156, 19);
            this.ConPassword.TabIndex = 23;
            this.ConPassword.Text = "Confirm Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.PasswordTxt.Location = new System.Drawing.Point(113, 395);
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(488, 36);
            this.PasswordTxt.TabIndex = 22;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(109, 361);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 19);
            this.Password.TabIndex = 21;
            this.Password.Text = "Password:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.UserNameTxt.Location = new System.Drawing.Point(113, 191);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(488, 36);
            this.UserNameTxt.TabIndex = 20;
            this.UserNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(109, 149);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 19);
            this.Username.TabIndex = 19;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.label2_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.Red;
            this.Register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Register_btn.FlatAppearance.BorderSize = 0;
            this.Register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.Color.White;
            this.Register_btn.Location = new System.Drawing.Point(155, 604);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(377, 50);
            this.Register_btn.TabIndex = 15;
            this.Register_btn.Text = "REGISTER";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 835);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sign_up_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox ConPasswordTxt;
        private System.Windows.Forms.Label ConPassword;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ShwPass;
        private System.Windows.Forms.Label signin_lb;
    }
}