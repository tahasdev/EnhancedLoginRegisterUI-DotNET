using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projem
{
    public partial class girisYap : Form
    {
        connect connect = new connect(); // connect sınıfından bir örnek oluşturuyoruz, bu sınıf veritabanı bağlantısını yönetecek
        // Action<string, Color> bildirim = connection.Instance.bildirimB;
        public girisYap()
        {
            InitializeComponent();
            kullanicilariyukle(); // Kullanıcı adlarını yükle
        }

        private void bildirimG(string s, Color c)
        {
            bildirimL.Text = s;
            bildirimL.ForeColor = c;
        }
        private void bildirimG(string s)
        {
            bildirimL.Text = s;
            bildirimL.ForeColor = Color.Gray;
        }
        private void bildirimG(string x, string y) // overloaded for different usages
        {
            bildirimL.Text = x;
            bildirimL.ForeColor = Color.Gray;
        }

        void kullanicilariyukle()
        {
            try
            {
                using (var result = connect.q("SELECT kullaniciAdi FROM kullanici"))
                using (var okuyucu = result.cd.ExecuteReader())
                {
                    while (okuyucu.Read())
                    {
                        kAdiTxt.Items.Add(okuyucu["kullaniciAdi"].ToString());
                    }
                }
            }
            catch //(Exception ex)
            {
                enter.Instance.ShowForm(new connection()); // Hata durumunda bağlantı formunu göster
                // MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private async void girisYapBtn_Click(object sender, EventArgs e)
        {
            // enter.Instance.CheckDB(); // Veritabanı bağlantısını kontrol et

            //  girisYapBtn.Enabled = false;
            // bildirimB("Kontrol ediliyor...", Color.Orange);
            
              bool baglantiVar = await connect.DB();

              if (!baglantiVar)
              {
                enter.Instance.ShowForm(new connection()); //
                  return;
              }

              bool girisDogruMu = await KullaniciBilgileriniDogrulaAsync(kAdiTxt.Text, parolaTxt.Text);

              if (girisDogruMu)
              {
                  new anaMenu().Show();
              }
              else
              {
                  bildirimG("Kullanıcı adı veya şifre hatalı!", Color.Red);
                  girisYapBtn.Enabled = true;
              } 
        }

        private async Task<bool> KullaniciBilgileriniDogrulaAsync(string kullaniciAdi, string sifre)
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (var baglanti = new MySqlConnection(config.baglanti))
                    {
                        baglanti.Open();
                        using (var komut = new MySqlCommand("SELECT * FROM kullanici WHERE kullaniciAdi = @kAdi AND parola = @parola", baglanti))
                        {
                            komut.Parameters.AddWithValue("@kAdi", kullaniciAdi);
                            komut.Parameters.AddWithValue("@parola", sifre);
                            using (var okuyucu = komut.ExecuteReader())
                            {
                                return okuyucu.Read();
                            }
                        }
                    }
                }
                catch
                {
                    return false;
                }
            });
        }
    }
}
