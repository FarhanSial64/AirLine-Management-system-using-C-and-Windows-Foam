namespace _22F_3681_DB_LAB_proj
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LoginBut = new System.Windows.Forms.Button();
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1232, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(762, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log In to Your Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(769, 323);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(412, 30);
            this.userName.TabIndex = 3;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userPass
            // 
            this.userPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPass.Location = new System.Drawing.Point(769, 437);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(412, 30);
            this.userPass.TabIndex = 5;
            this.userPass.TextChanged += new System.EventHandler(this.userPass_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1006, 488);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginBut
            // 
            this.LoginBut.BackColor = System.Drawing.Color.Gold;
            this.LoginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBut.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBut.ForeColor = System.Drawing.Color.Black;
            this.LoginBut.Location = new System.Drawing.Point(839, 533);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(255, 44);
            this.LoginBut.TabIndex = 7;
            this.LoginBut.TabStop = false;
            this.LoginBut.Text = "LOGIN";
            this.LoginBut.UseVisualStyleBackColor = false;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // forgotPass
            // 
            this.forgotPass.AutoSize = true;
            this.forgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.Location = new System.Drawing.Point(769, 488);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(159, 25);
            this.forgotPass.TabIndex = 8;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Forgot Password";
            this.forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPass_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Don\'t Have a Account? ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1012, 593);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 664);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.forgotPass);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

