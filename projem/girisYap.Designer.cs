namespace projem
{
    partial class girisYap
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
            this.kAdiTxt = new System.Windows.Forms.ComboBox();
            this.parolaTxt = new System.Windows.Forms.TextBox();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bildirimL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kAdiTxt
            // 
            this.kAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiTxt.FormattingEnabled = true;
            this.kAdiTxt.Location = new System.Drawing.Point(32, 40);
            this.kAdiTxt.Name = "kAdiTxt";
            this.kAdiTxt.Size = new System.Drawing.Size(248, 28);
            this.kAdiTxt.TabIndex = 1;
            // 
            // parolaTxt
            // 
            this.parolaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaTxt.Location = new System.Drawing.Point(32, 111);
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.PasswordChar = '*';
            this.parolaTxt.Size = new System.Drawing.Size(248, 26);
            this.parolaTxt.TabIndex = 2;
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.girisYapBtn.Location = new System.Drawing.Point(32, 172);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(248, 45);
            this.girisYapBtn.TabIndex = 3;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = true;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(29, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(29, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bildirimL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.girisYapBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kAdiTxt);
            this.panel1.Controls.Add(this.parolaTxt);
            this.panel1.Location = new System.Drawing.Point(237, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 330);
            this.panel1.TabIndex = 9;
            // 
            // bildirimL
            // 
            this.bildirimL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bildirimL.ForeColor = System.Drawing.Color.Gray;
            this.bildirimL.Location = new System.Drawing.Point(0, 140);
            this.bildirimL.Name = "bildirimL";
            this.bildirimL.Size = new System.Drawing.Size(317, 29);
            this.bildirimL.TabIndex = 7;
            this.bildirimL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // girisYap
            // 
            this.AcceptButton = this.girisYapBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "girisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox kAdiTxt;
        private System.Windows.Forms.TextBox parolaTxt;
        private System.Windows.Forms.Button girisYapBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bildirimL;
    }
}