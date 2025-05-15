namespace BedAndBreakfast
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            this.lblLincolnDescription = new System.Windows.Forms.Label();
            this.lblLincolnPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLincolnDescription
            // 
            this.lblLincolnDescription.Location = new System.Drawing.Point(39, 35);
            this.lblLincolnDescription.Name = "lblLincolnDescription";
            this.lblLincolnDescription.Size = new System.Drawing.Size(155, 27);
            this.lblLincolnDescription.TabIndex = 0;
            this.lblLincolnDescription.Text = "Return to the 1850s in this lovely room with private bath.";
            // 
            // lblLincolnPrice
            // 
            this.lblLincolnPrice.AutoSize = true;
            this.lblLincolnPrice.Location = new System.Drawing.Point(119, 74);
            this.lblLincolnPrice.Name = "lblLincolnPrice";
            this.lblLincolnPrice.Size = new System.Drawing.Size(75, 13);
            this.lblLincolnPrice.TabIndex = 1;
            this.lblLincolnPrice.Text = "$110 per night";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(233, 225);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLincolnPrice);
            this.Controls.Add(this.lblLincolnDescription);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLincolnDescription;
        private System.Windows.Forms.Label lblLincolnPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}