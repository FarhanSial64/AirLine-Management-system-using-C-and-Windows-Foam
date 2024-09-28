namespace _22F_3681_DB_LAB_proj
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.Flights = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empButt = new System.Windows.Forms.Button();
            this.feedButt = new System.Windows.Forms.Button();
            this.schButt = new System.Windows.Forms.Button();
            this.LogOutButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Flights)).BeginInit();
            this.SuspendLayout();
            // 
            // Flights
            // 
            this.Flights.Image = ((System.Drawing.Image)(resources.GetObject("Flights.Image")));
            this.Flights.Location = new System.Drawing.Point(0, 1);
            this.Flights.Name = "Flights";
            this.Flights.Size = new System.Drawing.Size(1234, 702);
            this.Flights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flights.TabIndex = 0;
            this.Flights.TabStop = false;
            this.Flights.Click += new System.EventHandler(this.Flights_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Dash Board";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empButt
            // 
            this.empButt.BackColor = System.Drawing.Color.Gold;
            this.empButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empButt.Location = new System.Drawing.Point(34, 126);
            this.empButt.Name = "empButt";
            this.empButt.Size = new System.Drawing.Size(168, 68);
            this.empButt.TabIndex = 2;
            this.empButt.Text = "Manage Employee";
            this.empButt.UseVisualStyleBackColor = false;
            this.empButt.Click += new System.EventHandler(this.empButt_Click);
            // 
            // feedButt
            // 
            this.feedButt.BackColor = System.Drawing.Color.Gold;
            this.feedButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedButt.Location = new System.Drawing.Point(34, 352);
            this.feedButt.Name = "feedButt";
            this.feedButt.Size = new System.Drawing.Size(168, 68);
            this.feedButt.TabIndex = 4;
            this.feedButt.Text = "View Feed Back";
            this.feedButt.UseVisualStyleBackColor = false;
            this.feedButt.Click += new System.EventHandler(this.feedButt_Click);
            // 
            // schButt
            // 
            this.schButt.BackColor = System.Drawing.Color.Gold;
            this.schButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schButt.Location = new System.Drawing.Point(34, 236);
            this.schButt.Name = "schButt";
            this.schButt.Size = new System.Drawing.Size(168, 68);
            this.schButt.TabIndex = 5;
            this.schButt.Text = "Schedule";
            this.schButt.UseVisualStyleBackColor = false;
            this.schButt.Click += new System.EventHandler(this.schButt_Click);
            // 
            // LogOutButt
            // 
            this.LogOutButt.BackColor = System.Drawing.Color.Gold;
            this.LogOutButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButt.Location = new System.Drawing.Point(34, 572);
            this.LogOutButt.Name = "LogOutButt";
            this.LogOutButt.Size = new System.Drawing.Size(168, 68);
            this.LogOutButt.TabIndex = 6;
            this.LogOutButt.Text = "LOG OUT";
            this.LogOutButt.UseVisualStyleBackColor = false;
            this.LogOutButt.Click += new System.EventHandler(this.LogOutButt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Flights";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOutButt);
            this.Controls.Add(this.schButt);
            this.Controls.Add(this.feedButt);
            this.Controls.Add(this.empButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Flights);
            this.Name = "AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin DashBoard";
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Flights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empButt;
        private System.Windows.Forms.Button feedButt;
        private System.Windows.Forms.Button schButt;
        private System.Windows.Forms.Button LogOutButt;
        private System.Windows.Forms.Button button1;
    }
}