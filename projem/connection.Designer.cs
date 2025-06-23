namespace projem
{
    partial class connection
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
            this.loading = new System.Windows.Forms.PictureBox();
            this.tekrardeneBtn = new System.Windows.Forms.Button();
            this.lblBaglantiDurumu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loading.Image = global::projem.Properties.Resources.spinner;
            this.loading.Location = new System.Drawing.Point(332, 213);
            this.loading.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(120, 99);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 0;
            this.loading.TabStop = false;
            // 
            // tekrardeneBtn
            // 
            this.tekrardeneBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tekrardeneBtn.Location = new System.Drawing.Point(332, 256);
            this.tekrardeneBtn.Name = "tekrardeneBtn";
            this.tekrardeneBtn.Size = new System.Drawing.Size(120, 28);
            this.tekrardeneBtn.TabIndex = 1;
            this.tekrardeneBtn.Text = "Tekrar dene";
            this.tekrardeneBtn.UseVisualStyleBackColor = true;
            this.tekrardeneBtn.Visible = false;
            this.tekrardeneBtn.Click += new System.EventHandler(this.tekrardeneBtn_Click);
            // 
            // lblBaglantiDurumu
            // 
            this.lblBaglantiDurumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaglantiDurumu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaglantiDurumu.Location = new System.Drawing.Point(252, 323);
            this.lblBaglantiDurumu.Name = "lblBaglantiDurumu";
            this.lblBaglantiDurumu.Size = new System.Drawing.Size(280, 36);
            this.lblBaglantiDurumu.TabIndex = 2;
            this.lblBaglantiDurumu.Text = "Kişisel Muhasebe";
            this.lblBaglantiDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(207, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 158);
            this.panel1.TabIndex = 3;
            // 
            // connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblBaglantiDurumu);
            this.Controls.Add(this.tekrardeneBtn);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.panel1);
            this.Name = "connection";
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Button tekrardeneBtn;
        private System.Windows.Forms.Label lblBaglantiDurumu;
        private System.Windows.Forms.Panel panel1;
    }
}