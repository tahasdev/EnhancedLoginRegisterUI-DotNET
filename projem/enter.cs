using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projem
{
    public partial class enter : Form
    {
        public static enter Instance { get; private set; } // enter formunun Singleton instance'ı | erişim sağlaylayıcımız 
        public enter()
        {
            InitializeComponent();
            Instance = this;
            ShowForm(new connection());
        }


        internal void ShowForm(Form formToShow)
        {
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formToShow);
            formToShow.Show();
        }
        private void parolamiUnuttumToolStripMenuItem_Click(object sender, EventArgs e)
        {
        ShowForm(new parolamiUnuttum());    
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        ShowForm(new kayitOl());
        }

        private void GirisYapStrip_Click(object sender, EventArgs e)
        {
        ShowForm(new girisYap());
        }

        private void enter_Load(object sender, EventArgs e)
        {
        
        }
    }
}
