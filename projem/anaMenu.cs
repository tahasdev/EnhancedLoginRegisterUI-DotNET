using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void anaMenu_Load(object sender, EventArgs e)
        {
            config config = new config();
            toolStripStatusLabel2.Text = config.kullaniciAdi; 

            Menu1 x = new Menu1();
            x.MdiParent = this;
            x.Dock = DockStyle.Fill;
            x.Show();
        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu2 y = new Menu2();
            y.MdiParent = this;
            y.Dock = DockStyle.Fill;
            y.Show();
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            not not = new not();
            not.ShowDialog();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.ShowDialog();
        }

        private void oturumKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            girisYap girisYap = new girisYap();
            girisYap.ShowDialog();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu1 digerMenu = new Menu1();
            digerMenu.MdiParent = this;
            digerMenu.Dock = DockStyle.Fill;
            digerMenu.Show();
        }

        private void anaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
