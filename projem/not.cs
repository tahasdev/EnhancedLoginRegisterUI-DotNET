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
    public partial class not : Form
    {
        public not()
        {
            InitializeComponent();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            baslikTxt.Clear();
            oncelikTxt.Text = "";
            icerikTxt.Clear();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                config config = new config();
                MySqlConnection connection = new MySqlConnection(config.baglanti);
                connection.Open();
                string insertQuery = "INSERT INTO notlar (baslik, icerik, oncelik, kullaniciID) VALUES (@baslik, @icerik, @oncelik, @kullanici)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@baslik", baslikTxt.Text);
                insertCmd.Parameters.AddWithValue("@icerik", icerikTxt.Text);
                insertCmd.Parameters.AddWithValue("@oncelik", oncelikTxt.Text);
                insertCmd.Parameters.AddWithValue("@kullanici", config.kullaniciID);

                int rowsAffected = insertCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Not kaydı başarılı", "Not Ekle");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void not_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
            try
            {
                config config = new config();
                MySqlConnection con = new MySqlConnection(config.baglanti);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT baslik, icerik, oncelik FROM notlar WHERE kullaniciID = @kullanici", con);
                da.SelectCommand.Parameters.AddWithValue("@kullanici", config.kullaniciID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
