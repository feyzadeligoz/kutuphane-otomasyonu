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

 namespace KitAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // SQL BAĞLANTISI
        SqlConnection baglanti = new SqlConnection(
            "Data Source=DESKTOP-XXXX\\SQLEXPRESS;Initial Catalog=KitAPPDB;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           {
                baglanti.Open();

                var cmd = new SqlCommand(
                    "SELECT * FROM Uyeler WHERE KullaniciAdi=@k AND Sifre=@s",
                    baglanti);

                cmd.Parameters.AddWithValue("@k", textBox1.Text);
                cmd.Parameters.AddWithValue("@s", textBox2.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Hoş geldiniz 🎉", "Başarılı Giriş");

                    Form2 ana = new Form2();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış ❌", "Hata");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }

                baglanti.Close();
            
        }
      
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }}
   