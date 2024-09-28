namespace _22F_3681_DB_LAB_proj
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminButt = new System.Windows.Forms.Button();
            this.empButt = new System.Windows.Forms.Button();
            this.passButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1229, 695);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminButt
            // 
            this.adminButt.BackColor = System.Drawing.Color.Gold;
            this.adminButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButt.Location = new System.Drawing.Point(96, 482);
            this.adminButt.Name = "adminButt";
            this.adminButt.Size = new System.Drawing.Size(247, 92);
            this.adminButt.TabIndex = 1;
            this.adminButt.Text = "Admin";
            this.adminButt.UseVisualStyleBackColor = false;
            this.adminButt.Click += new System.EventHandler(this.adminButt_Click);
            // 
            // empButt
            // 
            this.empButt.BackColor = System.Drawing.Color.Gold;
            this.empButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empButt.Location = new System.Drawing.Point(479, 482);
            this.empButt.Name = "empButt";
            this.empButt.Size = new System.Drawing.Size(247, 92);
            this.empButt.TabIndex = 2;
            this.empButt.Text = "Employee";
            this.empButt.UseVisualStyleBackColor = false;
            this.empButt.Click += new System.EventHandler(this.empButt_Click);
            // 
            // passButt
            // 
            this.passButt.BackColor = System.Drawing.Color.Gold;
            this.passButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButt.Location = new System.Drawing.Point(882, 482);
            this.passButt.Name = "passButt";
            this.passButt.Size = new System.Drawing.Size(247, 92);
            this.passButt.TabIndex = 3;
            this.passButt.Text = "Passenger";
            this.passButt.UseVisualStyleBackColor = false;
            this.passButt.Click += new System.EventHandler(this.passButt_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 697);
            this.Controls.Add(this.passButt);
            this.Controls.Add(this.empButt);
            this.Controls.Add(this.adminButt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adminButt;
        private System.Windows.Forms.Button empButt;
        private System.Windows.Forms.Button passButt;
    }
}