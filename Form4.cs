using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(
    "Server=DESKTOP-BQI1LOE\\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;");
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Uyeler WHERE KullaniciAdi=@k AND Sifre=@s",
                    baglanti
                );

                cmd.Parameters.AddWithValue("@k", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@s", txtSifre.Text.Trim());

                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    MessageBox.Show("Hoş geldiniz 🎉");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış ❌");
                    txtEmail.Clear();
                    txtSifre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
    

