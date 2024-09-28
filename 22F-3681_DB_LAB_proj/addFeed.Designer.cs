namespace _22F_3681_DB_LAB_proj
{
    partial class addFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFeed));
            this.LogOutButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.RichTextBox();
            this.rating = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passName = new System.Windows.Forms.TextBox();
            this.checkProfile = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutButt
            // 
            this.LogOutButt.BackColor = System.Drawing.Color.Gold;
            this.LogOutButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButt.Location = new System.Drawing.Point(1093, 650);
            this.LogOutButt.Name = "LogOutButt";
            this.LogOutButt.Size = new System.Drawing.Size(135, 37);
            this.LogOutButt.TabIndex = 30;
            this.LogOutButt.Text = "LOG OUT";
            this.LogOutButt.UseVisualStyleBackColor = false;
            this.LogOutButt.Click += new System.EventHandler(this.LogOutButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Passenger FeedBack";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 702);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Gold;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(486, 461);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(135, 46);
            this.submitBtn.TabIndex = 35;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 51);
            this.label2.TabIndex = 36;
            this.label2.Text = "Give Your Feed Back";
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(28, 217);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(593, 218);
            this.feedback.TabIndex = 37;
            this.feedback.Text = "";
            this.feedback.TextChanged += new System.EventHandler(this.feedback_TextChanged);
            // 
            // rating
            // 
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.FormattingEnabled = true;
            this.rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rating.Location = new System.Drawing.Point(28, 461);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(135, 33);
            this.rating.TabIndex = 38;
            this.rating.SelectedIndexChanged += new System.EventHandler(this.rating_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Rate Us";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(786, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Hi !";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // passName
            // 
            this.passName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passName.Location = new System.Drawing.Point(849, 15);
            this.passName.Name = "passName";
            this.passName.Size = new System.Drawing.Size(213, 34);
            this.passName.TabIndex = 41;
            // 
            // checkProfile
            // 
            this.checkProfile.BackColor = System.Drawing.Color.Gold;
            this.checkProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProfile.Location = new System.Drawing.Point(1068, 12);
            this.checkProfile.Name = "checkProfile";
            this.checkProfile.Size = new System.Drawing.Size(160, 43);
            this.checkProfile.TabIndex = 40;
            this.checkProfile.Text = "View Profile";
            this.checkProfile.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 28);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(63, 35);
            this.back.TabIndex = 43;
            this.back.Text = "<-";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 699);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passName);
            this.Controls.Add(this.checkProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.LogOutButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFeed";
            this.Load += new System.EventHandler(this.addFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogOutButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox feedback;
        private System.Windows.Forms.ComboBox rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passName;
        private System.Windows.Forms.Button checkProfile;
        private System.Windows.Forms.Button back;
    }
}