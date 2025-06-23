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
    public partial class guvenliksorusuekleMenu : Form
    {
        public guvenliksorusuekleMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { /*
                config config = new config();
                using (MySqlConnection connection = new MySqlConnection(config.baglanti))
                {
                    connection.Open();

                    string query = "INSERT INTO guvenlik_sorusu (guvenlik_sorusu_adi) VALUES (@soru)";
                    MySqlCommand command = new MySqlCommand(query, connection); */

                var x = connect.q("INSERT INTO guvenlik_sorusu (guvenlik_sorusu_adi) VALUES (@soru)");
                
                using (var cn = x.cn) 
                using (var cd = x.cd)
                {

                    cd.Parameters.AddWithValue("@soru", textBox1.Text.Trim());
                    int r = cd.ExecuteNonQuery();

                    if (r > 0)
                    {
                        MessageBox.Show("Güvenlik sorusu başarıyla eklendi.");
                        textBox1.Clear();
                        kayitOl k = new kayitOl();
                        k.guvenliksorulariniyukle();
                        k.soruTxt.Refresh();
                    }


                    else
                    {
                        MessageBox.Show("Güvenlik sorusu eklenemedi.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        
        }





    }
}
