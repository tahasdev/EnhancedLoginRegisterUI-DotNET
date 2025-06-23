using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projem
{
    public partial class parolamiUnuttum : Form
    {
        public parolamiUnuttum()
        {
            InitializeComponent();
        }

        async void bildirimG(string s)
        {
            bildirimL.Text = s;
            bildirimL.ForeColor = Color.Black; // varsayılan renk
            await Task.Delay(2000); // 2 saniye bekle
            bildirimL.Text = string.Empty; // Bildirimi temizle
        }
        async void bildirimG(string s, string renkKod)
        {
            bildirimL.Text = s;

            var renkler = new Dictionary<string, Color>
            {
                { "r", Color.Red },
                { "g", Color.Green },
                { "b", Color.Blue },
                { "o", Color.Orange }
            };
                    bildirimL.ForeColor = renkler.ContainsKey(renkKod) ? renkler[renkKod] : Color.Gray;
            await Task.Delay(2000); // 2 saniye bekle
            bildirimL.Text = string.Empty; // Bildirimi temizle
        }
        private async void sifirlaBtn_Click(object sender, EventArgs e)
{
    try
    {
        string seciliSoru = soruTxt.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(seciliSoru))
        {
            bildirimG("Lütfen bir güvenlik sorusu seçiniz.","o");
            return;
        }

        int soruId = 0;

        // Güvenlik sorusu ID'sini bul
        using (var result = connect.q($"SELECT guvenlik_sorusu_id FROM guvenlik_sorusu WHERE guvenlik_sorusu_adi = '{seciliSoru}'"))
        using (var okuyucuSoru = result.cd.ExecuteReader())
        {
            if (okuyucuSoru.Read())
            {
                soruId = Convert.ToInt32(okuyucuSoru["guvenlik_sorusu_id"]);
            }
            else
            {
                bildirimG("Güvenlik sorusu bulunamadı.","r");
                return;
            }
        }

        // Kullanıcı doğrulamasını yap
        string checkQuery = $"SELECT COUNT(*) FROM kullanici WHERE kullaniciAdi = '{kAdiTxt.Text}' AND guvenlik_sorusu_id = {soruId} AND LOWER(cevap) = '{cevapTxt.Text.ToLower()}'";

        int existingUserCount;
        using (var checkResult = connect.q(checkQuery))
        {
            existingUserCount = Convert.ToInt32(checkResult.cd.ExecuteScalar());
        }

        if (existingUserCount > 0)
        {
            // Şifreyi güncelle
            string updateQuery = $"UPDATE kullanici SET parola = '{parolaTxt.Text}' WHERE kullaniciAdi = '{kAdiTxt.Text}'";

            using (var updateResult = connect.q(updateQuery))
            {
                int rowsAffected = updateResult.cd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    bildirimG("Parola sıfırlama başarılı. Giriş Yap ekranına yönlendiriliyorsunuz.", "g");
                    await Task.Delay(2000); // 2 saniye bekle
                    enter.Instance.ShowForm(new girisYap()); // Bağlantı formunu göster
                }
            }
        }
        else
        {
            bildirimG("Kullanıcı adı, güvenlik sorusu veya cevap hatalı.","r");
        }
    }
    catch // (Exception ex)
    {
         enter.Instance.ShowForm(new connection()); // Hata durumunda bağlantı formunu göster
       //bildirimG("Hata Oluştu: " + ex.Message,"r");
            }
}

        private void parolamiUnuttum_Load(object sender, EventArgs e)
        {
            kayitOl.guvenliksorulariniyukle(soruTxt);
        }

        private void parolamiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
