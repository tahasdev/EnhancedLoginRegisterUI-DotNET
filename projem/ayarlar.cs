using MySql.Data.MySqlClient;
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
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void degistirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                config config = new config();
                MySqlConnection baglanti = new MySqlConnection(config.baglanti);
                baglanti.Open();
                if (yeniParolaTxt.Text == tYeniParolaTxt.Text)
                {
                    string guncelleSorgu = "UPDATE kullanici SET parola = @yParola WHERE parola = @eParola AND kullaniciID = @kullanici";
                    MySqlCommand guncelle = new MySqlCommand(guncelleSorgu, baglanti);
                    guncelle.Parameters.AddWithValue("@eParola", eskiParolaTxt.Text);
                    guncelle.Parameters.AddWithValue("@yParola", yeniParolaTxt.Text);
                    guncelle.Parameters.AddWithValue("@kullanici", config.kullaniciID);
                    int basariliMi = guncelle.ExecuteNonQuery();
                    if (basariliMi > 0)
                    {
                        MessageBox.Show("Parola güncelleme başarılı", "Parola Değiştir");
                        eskiParolaTxt.Clear();
                        yeniParolaTxt.Clear();
                        tYeniParolaTxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Eski parolanız hatalı", "Parola Değiştir");
                    }
                }
                else
                {
                    MessageBox.Show("Parolalar uyuşmuyor");
                }
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void hesabimiSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show(config.kullaniciAdi + " kullanıcı adlı hesabı silmek istiyor musun?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        // Bağlantı için yeni config nesnesi oluşturuluyor
                        config config = new config();

                        using (MySqlConnection baglanti = new MySqlConnection(config.baglanti))
                        {
                            baglanti.Open();

                            string sorgu = "DELETE FROM kullanici WHERE kullaniciID = @kullaniciID";
                            using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                            {
                                // Parametre olarak aktif kullanıcının ID'si kullanılıyor
                                komut.Parameters.AddWithValue("@kullaniciID", config.kullaniciID);

                                int etkilenenSatir = komut.ExecuteNonQuery();

                                if (etkilenenSatir > 0)
                                {
                                    MessageBox.Show("Kullanıcı başarıyla silindi.");

                                    // Oturum bilgileri temizleniyor
                                    config.kullaniciID = 0;
                                    config.kullaniciAdi = "";

                                    this.Hide();

                                    girisYap girisYapForm = new girisYap();
                                    girisYapForm.ShowDialog();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı bulunamadı veya silinemedi.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }





    }
}
