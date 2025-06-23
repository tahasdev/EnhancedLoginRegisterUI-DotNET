namespace projem
{
    partial class parolamiUnuttum
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kAdiTxt = new System.Windows.Forms.TextBox();
            this.cevapTxt = new System.Windows.Forms.TextBox();
            this.sifirlaBtn = new System.Windows.Forms.Button();
            this.soruTxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parolaTxt = new System.Windows.Forms.TextBox();
            this.bildirimL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(260, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(260, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güvenlik Sorusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(260, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cevap";
            // 
            // kAdiTxt
            // 
            this.kAdiTxt.Location = new System.Drawing.Point(263, 153);
            this.kAdiTxt.Name = "kAdiTxt";
            this.kAdiTxt.Size = new System.Drawing.Size(248, 26);
            this.kAdiTxt.TabIndex = 1;
            // 
            // cevapTxt
            // 
            this.cevapTxt.Location = new System.Drawing.Point(263, 259);
            this.cevapTxt.Name = "cevapTxt";
            this.cevapTxt.Size = new System.Drawing.Size(248, 26);
            this.cevapTxt.TabIndex = 3;
            // 
            // sifirlaBtn
            // 
            this.sifirlaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifirlaBtn.Location = new System.Drawing.Point(263, 380);
            this.sifirlaBtn.Name = "sifirlaBtn";
            this.sifirlaBtn.Size = new System.Drawing.Size(248, 45);
            this.sifirlaBtn.TabIndex = 4;
            this.sifirlaBtn.Text = "Sıfırla";
            this.sifirlaBtn.UseVisualStyleBackColor = true;
            this.sifirlaBtn.Click += new System.EventHandler(this.sifirlaBtn_Click);
            // 
            // soruTxt
            // 
            this.soruTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soruTxt.FormattingEnabled = true;
            this.soruTxt.Location = new System.Drawing.Point(263, 205);
            this.soruTxt.Name = "soruTxt";
            this.soruTxt.Size = new System.Drawing.Size(248, 28);
            this.soruTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(259, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Parola";
            // 
            // parolaTxt
            // 
            this.parolaTxt.Location = new System.Drawing.Point(263, 311);
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.PasswordChar = '*';
            this.parolaTxt.Size = new System.Drawing.Size(248, 26);
            this.parolaTxt.TabIndex = 3;
            // 
            // bildirimL
            // 
            this.bildirimL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bildirimL.ForeColor = System.Drawing.Color.Gray;
            this.bildirimL.Location = new System.Drawing.Point(92, 357);
            this.bildirimL.Name = "bildirimL";
            this.bildirimL.Size = new System.Drawing.Size(544, 20);
            this.bildirimL.TabIndex = 17;
            this.bildirimL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parolamiUnuttum
            // 
            this.AcceptButton = this.sifirlaBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bildirimL);
            this.Controls.Add(this.soruTxt);
            this.Controls.Add(this.sifirlaBtn);
            this.Controls.Add(this.parolaTxt);
            this.Controls.Add(this.cevapTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kAdiTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "parolamiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parolamı Unuttum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parolamiUnuttum_FormClosed);
            this.Load += new System.EventHandler(this.parolamiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kAdiTxt;
        private System.Windows.Forms.TextBox cevapTxt;
        private System.Windows.Forms.Button sifirlaBtn;
        private System.Windows.Forms.ComboBox soruTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parolaTxt;
        private System.Windows.Forms.Label bildirimL;
    }
}