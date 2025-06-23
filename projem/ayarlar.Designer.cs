namespace projem
{
    partial class ayarlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.degistirBtn = new System.Windows.Forms.Button();
            this.tYeniParolaTxt = new System.Windows.Forms.TextBox();
            this.yeniParolaTxt = new System.Windows.Forms.TextBox();
            this.eskiParolaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hesabimiSilBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 247);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.degistirBtn);
            this.tabPage1.Controls.Add(this.tYeniParolaTxt);
            this.tabPage1.Controls.Add(this.yeniParolaTxt);
            this.tabPage1.Controls.Add(this.eskiParolaTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şifre Değiştir";
            // 
            // degistirBtn
            // 
            this.degistirBtn.Location = new System.Drawing.Point(141, 156);
            this.degistirBtn.Name = "degistirBtn";
            this.degistirBtn.Size = new System.Drawing.Size(200, 32);
            this.degistirBtn.TabIndex = 2;
            this.degistirBtn.Text = "Değiştir";
            this.degistirBtn.UseVisualStyleBackColor = true;
            this.degistirBtn.Click += new System.EventHandler(this.degistirBtn_Click);
            // 
            // tYeniParolaTxt
            // 
            this.tYeniParolaTxt.Location = new System.Drawing.Point(141, 112);
            this.tYeniParolaTxt.Name = "tYeniParolaTxt";
            this.tYeniParolaTxt.PasswordChar = '*';
            this.tYeniParolaTxt.Size = new System.Drawing.Size(200, 26);
            this.tYeniParolaTxt.TabIndex = 1;
            // 
            // yeniParolaTxt
            // 
            this.yeniParolaTxt.Location = new System.Drawing.Point(141, 64);
            this.yeniParolaTxt.Name = "yeniParolaTxt";
            this.yeniParolaTxt.PasswordChar = '*';
            this.yeniParolaTxt.Size = new System.Drawing.Size(200, 26);
            this.yeniParolaTxt.TabIndex = 1;
            // 
            // eskiParolaTxt
            // 
            this.eskiParolaTxt.Location = new System.Drawing.Point(141, 16);
            this.eskiParolaTxt.Name = "eskiParolaTxt";
            this.eskiParolaTxt.PasswordChar = '*';
            this.eskiParolaTxt.Size = new System.Drawing.Size(200, 26);
            this.eskiParolaTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tekrar Yeni Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hesabimiSilBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hesabımı Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hesabimiSilBtn
            // 
            this.hesabimiSilBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hesabimiSilBtn.ForeColor = System.Drawing.Color.Red;
            this.hesabimiSilBtn.Location = new System.Drawing.Point(3, 3);
            this.hesabimiSilBtn.Name = "hesabimiSilBtn";
            this.hesabimiSilBtn.Size = new System.Drawing.Size(358, 208);
            this.hesabimiSilBtn.TabIndex = 0;
            this.hesabimiSilBtn.Text = "Hesabımı Sil";
            this.hesabimiSilBtn.UseVisualStyleBackColor = true;
            this.hesabimiSilBtn.Click += new System.EventHandler(this.hesabimiSilBtn_Click);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 247);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tYeniParolaTxt;
        private System.Windows.Forms.TextBox yeniParolaTxt;
        private System.Windows.Forms.TextBox eskiParolaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button degistirBtn;
        private System.Windows.Forms.Button hesabimiSilBtn;
    }
}