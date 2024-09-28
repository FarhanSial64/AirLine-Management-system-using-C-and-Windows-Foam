namespace _22F_3681_DB_LAB_proj
{
    partial class addFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFlight));
            this.back = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flightName = new System.Windows.Forms.TextBox();
            this.totalSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(10, 45);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 35);
            this.back.TabIndex = 52;
            this.back.Text = "<--";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Gold;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(73, 332);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(422, 48);
            this.saveBtn.TabIndex = 51;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 43;
            this.label1.Text = "Add Flight";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(580, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(651, 702);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Flight Name";
            // 
            // flightName
            // 
            this.flightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightName.Location = new System.Drawing.Point(73, 170);
            this.flightName.Name = "flightName";
            this.flightName.Size = new System.Drawing.Size(422, 34);
            this.flightName.TabIndex = 55;
            this.flightName.TextChanged += new System.EventHandler(this.flightName_TextChanged);
            // 
            // totalSeats
            // 
            this.totalSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSeats.Location = new System.Drawing.Point(73, 274);
            this.totalSeats.Name = "totalSeats";
            this.totalSeats.Size = new System.Drawing.Size(422, 34);
            this.totalSeats.TabIndex = 57;
            this.totalSeats.TextChanged += new System.EventHandler(this.totalSeats_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "Total Seats";
            // 
            // addFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 697);
            this.Controls.Add(this.totalSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flightName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Name = "addFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFlight";
            this.Load += new System.EventHandler(this.addFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flightName;
        private System.Windows.Forms.TextBox totalSeats;
        private System.Windows.Forms.Label label3;
    }
}