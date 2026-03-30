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

namespace KutuphaneOtomasyonu
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(
   "Server=DESKTOP-BQI1LOE\\SQLEXPRESS;Database=KitApp;Trusted_Connection=True;");

        private void Form5_Load(object sender, EventArgs e)
        {
            // Meslekler
            cmbMeslek.Items.Add("Öğrenci");
            cmbMeslek.Items.Add("Akademisyen");
            cmbMeslek.Items.Add("Yönetici");
            cmbMeslek.Items.Add("Diğer");

            // Şifre yıldızlı
            txtSifre.PasswordChar = '*';
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1️Boş alan kontrolü
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" ||
                txtSifre.Text == "" || cmbMeslek.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            // 2️ Yaş hesaplama
            int yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            if (dtpDogumTarihi.Value > DateTime.Now.AddYears(-yas))
                yas--;

            // 3️ Yaş sınırı
            if (yas < 10)
            {
                MessageBox.Show("10 yaş altındaki kullanıcılar üye olamaz.");
                return;
            }

            // 4️ SQL’e kayıt
            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Uyeler (Ad, Soyad, DogumTarihi, Mail, Meslek, Sifre) " +
                    "VALUES (@ad, @soyad, @dogum, @mail, @meslek, @sifre)", baglanti);

                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@dogum", dtpDogumTarihi.Value);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@meslek", cmbMeslek.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("🎉 Tebrikler, başarılı bir şekilde üye oldunuz!");

                // 5️ Form1'e yönlendirme
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }
    }
}


      
