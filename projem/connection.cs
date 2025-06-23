using projem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class connection : Form
    {

        connect connect = new connect();
        public static connection Instance { get; private set; }
        public static Type LastFormType { get; set; } = null;
        public static object[] LastFormArgs { get; set; } = null;
        
        public static void SetLastForm(Form form, params object[] args)
        {
            if (!(form is connection)) // connection formunu kaydetme
            {
                LastFormType = form.GetType();
                LastFormArgs = args;
            }
        }
        public connection()
        {
            InitializeComponent();
            Instance = this;
            Load += async (s, e) => await CheckDB();

        }

        internal async Task CheckDB()
        {
            bool ok = await connect.DB();

            if (ok)
            {
             // bildirimB("Online", Color.Green); // bağlantı başarılı olduğunda yeşil renkli bildirim 
                // panel1.Visible = false; // bağlantı başarılı olduğunda paneli gizle
                tekrardeneBtn.Visible = false; // bağlantı başarılı olduğunda tekrar dene butonunu gizle
                await Task.Delay(2000); // 2 saniye bekle
                enter.Instance.menuStrip1.Visible = true; // baglanti saglandiginda menu cubugunu etkinlestir
                if (LastFormType != null && LastFormType != typeof(connection))
                {
                    var form = (Form)Activator.CreateInstance(LastFormType, LastFormArgs ?? new object[] { });
                    enter.Instance.ShowForm(form);
                }
                else
                {
                    enter.Instance.ShowForm(new girisYap());
                }
            }
            else
            {
                bildirimB("Veritabanı bağlantısı kurulamadı", Color.Gray);
                loading.Visible = false;
                tekrardeneBtn.Visible = true;
                enter.Instance.menuStrip1.Visible = false; // baglanti saglanamadiginda menu cubugunu gizle
            }
        }
        private void tekrardeneBtn_Click(object sender, EventArgs e)
        {
            tekrardene();
        }

        internal void bildirimB(string mesaj, Color renk)
        {
            lblBaglantiDurumu.Text = mesaj;
            lblBaglantiDurumu.ForeColor = renk;
        }
        internal async void tekrardene()
        {
            tekrardeneBtn.Visible = false;
            loading.Visible = true;
            bildirimB("Yeniden bağlanılıyor...", Color.Orange);
            await Task.Delay(2000);
            await CheckDB();
            loading.Visible = false;
        }
    }
}