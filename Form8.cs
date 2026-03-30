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
    public partial class Form8 : Form
    {
        SqlConnection baglanti = new SqlConnection(
   "Server=DESKTOP-BQI1LOE\\SQLEXPRESS;Database=KitApp;Trusted_Connection=True;");
        int adminID = 1;
        int secilenUyeID = 0;


        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {

            TumunuGizle();          // 🔹 1. ÖNCE HEPSİNİ GİZLE

            KitaplariGetir();       // 🔹 2. VERİLERİ YÜKLE
            UyeleriGetir();
            OduncTakipGetir();
            MesajlariGetir();
          

            dgvKitaplar.Visible = true;

        }


        void TumunuGizle()
        {
            dgvKitaplar.Visible = false;
            dgvUyeler.Visible = false;
            dgvOdunc.Visible = false;
            dgvMesajlar.Visible = false;
            rtbDuyuru.Visible=false;
        }
        // 📚 KİTAPLAR
        void KitaplariGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        k.KitapID,
                        k.KitapAdi AS 'Kitap Adı',
                        k.Yazar,
                        CASE 
                            WHEN o.KitapID IS NULL THEN '✅ Müsait'
                            ELSE '❌ Ödünçte'
                        END AS Durum
                    FROM Kitaplar k
                    LEFT JOIN Odunc o 
                        ON k.KitapID = o.KitapID 
                        AND o.IadeTarihi IS NULL
                ", baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;

                // KitapID sütununu gizle
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        // 🔄 ÖDÜNÇ TAKİP
        void OduncTakipGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
         SELECT k.KitapAdi,
                u.Ad + ' ' + u.Soyad AS Uye,
                o.OduncTarihi AS AlisTarihi,
                DATEADD(day, 15, o.OduncTarihi) AS TeslimTarihi,
                DATEDIFF(day, GETDATE(), DATEADD(day, 15, o.OduncTarihi)) AS KalanGun
         FROM Odunc o
         JOIN Kitaplar k ON o.KitapID = k.KitapID
         JOIN Uyeler u ON o.UyeID = u.UyeID
         WHERE o.IadeTarihi IS NULL", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOdunc.DataSource = dt;
        }
        
        private void btnOduncTakip_Click(object sender, EventArgs e)
        {
           
        }
        // 💬 MESAJLAR
        private void FormYoneticiMesajlar_Load(object sender, EventArgs e)
        {
            MesajlariGetir();
        }
         // ✅ Sınıf seviyesinde değişken ekle

        // ✅ MesajlariGetir() - DÜZELTİLDİ
        private void MesajlariGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        m.MesajID,
                        m.GonderenID,
                        CASE 
                            WHEN u.Ad IS NOT NULL THEN u.Ad + ' ' + u.Soyad
                            ELSE 'Silinmiş Üye'
                        END AS GonderenAdi,
                        m.Mesaj,
                        m.Tarih
                    FROM Mesajlar m
                    LEFT JOIN Uyeler u ON m.GonderenID = u.UyeID
                    WHERE m.AliciID = 1  -- ✅ DÜZELTİLDİ: Yöneticiye gönderilen mesajlar
                    ORDER BY m.Tarih DESC
                ", baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMesajlar.DataSource = dt;

                // ✅ Kolonları düzenle
                if (dgvMesajlar.Columns.Contains("MesajID"))
                    dgvMesajlar.Columns["MesajID"].Visible = false;

                if (dgvMesajlar.Columns.Contains("GonderenID"))
                    dgvMesajlar.Columns["GonderenID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesajlar yüklenirken hata:\n" + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void panelDuyurular_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            
            
        }
        // 👤 ÜYELER
        void UyeleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Uyeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUyeler.DataSource = dt;
        }
        

            
        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            TumunuGizle();
            MesajlariGetir();
            dgvMesajlar.Visible = true;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); // hesaptan çıkış
        }

        private void btnCevapla_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDuyuruYayinla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Duyurular (Metin, Tarih) VALUES (@m, @t)",
                baglanti
            );

            cmd.Parameters.AddWithValue("@m", rtbDuyuru.Text);
            cmd.Parameters.AddWithValue("@t", DateTime.Now);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Duyuru yayınlandı");
            rtbDuyuru.Clear();
        }

        private void dgvDuyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMesajlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  if (dgvMesajlar.CurrentRow != null && e.RowIndex >= 0)
            {
                try
                {
                    // ✅ Mesajı ve gönderen ID'yi al
                    txtCevap.Clear();
                    string mesaj = dgvMesajlar.CurrentRow.Cells["Mesaj"].Value.ToString();
                    secilenUyeID = Convert.ToInt32(dgvMesajlar.CurrentRow.Cells["GonderenID"].Value);
                    string gonderenAdi = dgvMesajlar.CurrentRow.Cells["GonderenAdi"].Value.ToString();

                    // ✅ Bilgi ver
                    MessageBox.Show($"📩 Mesaj: {mesaj}\n\n✍️ Cevabınızı yazıp 'Cevap Gönder' butonuna tıklayın.",
                        $"{gonderenAdi} adlı üyeye cevap",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mesaj seçilirken hata:\n" + ex.Message);
                }
            }
        }

        private void btnCevapGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCevap.Text))
            {
                MessageBox.Show("Lütfen cevap mesajınızı yazın!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (secilenUyeID == 0)
            {
                MessageBox.Show("Lütfen önce bir mesaj seçin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // ✅ YENİ MESAJ OLARAK EKLE (güncelleme değil!)
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Mesajlar (GonderenID, AliciID, Mesaj, Tarih) VALUES (@g, @a, @m, @t)",
                    baglanti);

                cmd.Parameters.AddWithValue("@g", 1);              // Yönetici gönderici
                cmd.Parameters.AddWithValue("@a", secilenUyeID);   // Üye alıcı
                cmd.Parameters.AddWithValue("@m", txtCevap.Text);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Cevap başarıyla gönderildi! ✅", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCevap.Clear();
                secilenUyeID = 0;
                MesajlariGetir(); // ✅ Listeyi yenile
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show("Cevap gönderilirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuyuruYayinla_Click_1(object sender, EventArgs e)
        {

        }

        private void rtbDuyuru_TextChanged(object sender, EventArgs e)
        {

        }
         
        
    }
}
