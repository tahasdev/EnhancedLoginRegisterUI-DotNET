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
    public partial class kayitOl : Form
    {
        public kayitOl()
        {

            InitializeComponent();
        }

        private void kayitOl_Shown(object sender, EventArgs e)
        {
            guvenliksorulariniyukle(soruTxt);
        }
        private async void kayitOlBtn_Click(object sender, EventArgs e)
        {



         // parametre ekleyici   -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
            void ParametreEkle(MySqlCommand cmd, params (string key, object value)[] parametreler)
            {
                foreach (var (key, value) in parametreler)
                    cmd.Parameters.AddWithValue(key, value);
            }
            // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

            // boş alan kontrolü
            bool BosAlanVarMi(params Control[] kontroller)
            {
                if (kontroller.Any(ctrl =>
                    ctrl is TextBox tb && string.IsNullOrWhiteSpace(tb.Text) ||
                    ctrl is ComboBox cb && cb.SelectedIndex == -1))
                {
                    bildirimG("Lütfen tüm alanları doldurun.");
                    return true;
                }

                return false;
            }
            // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


            if (BosAlanVarMi(adiTxt, soyadiTxt, kAdiTxt, parolaTxt, cevapTxt, soruTxt))
                return;

            try
            {
                int soruId = 0;
                string seciliSoru = soruTxt.SelectedItem.ToString();

                // 1. Güvenlik sorusu ID'sini al
                using (var r = connect.q("SELECT guvenlik_sorusu_id FROM guvenlik_sorusu WHERE guvenlik_sorusu_adi = @soru"))
                {
                    r.cd.Parameters.AddWithValue("@soru", seciliSoru);
                    using (var reader = r.cd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soruId = Convert.ToInt32(reader["guvenlik_sorusu_id"]);
                        }
                    }
                }

                // 2. Kullanıcı adı daha önce alınmış mı kontrol et
                using (var r = connect.q("SELECT COUNT(*) FROM kullanici WHERE kullaniciAdi = @kAdi"))
                {
                    r.cd.Parameters.AddWithValue("@kAdi", kAdiTxt.Text.Trim());
                    int existingUserCount = Convert.ToInt32(r.cd.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        bildirimG("Kullanıcı adı zaten mevcut");
                        return;
                    }
                }

                // 3. Yeni kullanıcıyı ekle
                using (var r = connect.q("INSERT INTO kullanici (adi, soyadi, kullaniciAdi, parola, guvenlik_sorusu_id, cevap) VALUES (@adi, @soyadi, @kAdi, @parola, @soru, @cevap)"))
                {
                    ParametreEkle(r.cd,
                        ("@adi", adiTxt.Text.Trim()),
                        ("@soyadi", soyadiTxt.Text.Trim()),
                        ("@kAdi", kAdiTxt.Text.Trim()),
                        ("@parola", parolaTxt.Text.Trim()),
                        ("@cevap", cevapTxt.Text.Trim()),
                        ("@soru", soruId)
                    );


                    int rowsAffected = r.cd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        bildirimG("Kullanıcı kaydı başarılı", Color.Green);
                        await Task.Delay(1000);
                        connection.SetLastForm(this);
                        enter.Instance.ShowForm(new connection());

                    }
                    
                }
            }
            catch // (Exception ex)
            {
                connection.SetLastForm(this);
                enter.Instance.ShowForm(new connection());
               // MessageBox.Show("Hata Oluştu: " + ex.Message);
                
            }
        }


        private void kayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        internal void guvenliksorulariniyukle()
        {
            guvenliksorulariniyukle(soruTxt);
        }

        public static void guvenliksorulariniyukle(ComboBox cb)
        {
            try
            {
                using (var result = connect.q("SELECT guvenlik_sorusu_adi FROM guvenlik_sorusu"))
                using (var reader = result.cd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cb.Items.Add(reader["guvenlik_sorusu_adi"].ToString());
                    }
                }
            }
            catch //(Exception ex)
            {
                connection.SetLastForm(new kayitOl());
                enter.Instance.ShowForm(new connection());
                //MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        //      _____________________________________________________________________________________________________________________

        // GÜVENLİK SORUSU EKLE MENÜSÜ 

        // Bildirim mesajlarını gösteren metot
        private void bildirimG(string s, Color c) {
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


        private void button1_Click(object sender, EventArgs e)
        {
            guvenliksorusuekleMenu x = new guvenliksorusuekleMenu();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // r: result c: connection cd: command q: query

                var r = connect.q("INSERT INTO guvenlik_sorusu (guvenlik_sorusu_adi) VALUES (@soru)");

                using (var c = r.cn)
                using (var cd = r.cd)
                {

                    if (textBox1.Text.Trim() == string.Empty)
                    {
                        bildirimG("Lütfen soru giriniz.", Color.Red);
                        return;
                    }
                    cd.Parameters.AddWithValue("@soru", textBox1.Text.Trim());

                    int rowsAffected = cd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        bildirimG("Güvenlik sorusu başarıyla eklendi.", Color.Green);
                        soruTxt.Items.Clear();
                        textBox1.Clear();
                        panel2.Visible = false;
                        guvenliksorulariniyukle(soruTxt);
                    }
                    else
                    {
                        bildirimG("Güvenlik sorusu eklenemedi.", Color.Red);
                    }
                }
            }
            catch (Exception ex)
            {
                bildirimG("Hata oluştu: " + ex.Message, Color.Red);
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                panel2.Visible = true; // Seçili soru varsa butonu etkinleştir
                panel1.Visible = false; // Soru ekleme panelini göster
        }

        private void GuvenlikSorusuMenuCikBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false; // Soru ekleme panelini gizle
        }

        private void soruTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }


        //      ________________________________________________________________________________________________________________
    }
}
