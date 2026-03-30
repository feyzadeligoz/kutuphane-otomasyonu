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
    public partial class Form9 : Form
    {
        SqlConnection baglanti = new SqlConnection(
            "Server=DESKTOP-BQI1LOE\\SQLEXPRESS;Database=KitApp;Trusted_Connection=True;");

        int secilenUyeID = 0; // Mesaj cevaplamak için
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            MesajlariGetir();
            DuyurulariGetir();
        }
        private void MesajlariGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        m.MesajID,
                        m.GonderenID,
                        u.Ad + ' ' + u.Soyad AS 'Gönderen',
                        m.Mesaj,
                        m.Tarih
                    FROM Mesajlar m
                    LEFT JOIN Uyeler u ON m.GonderenID = u.UyeID
                    WHERE m.AliciID = 1
                    ORDER BY m.Tarih DESC
                ", baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMesajlar.DataSource = dt;

                // Gereksiz kolonları gizle
                if (dgvMesajlar.Columns.Contains("MesajID"))
                    dgvMesajlar.Columns["MesajID"].Visible = false;

                if (dgvMesajlar.Columns.Contains("GonderenID"))
                    dgvMesajlar.Columns["GonderenID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesajlar yüklenirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDuyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0 && dgvDuyurular.CurrentRow != null)
                {
                    try
                    {
                        string duyuru = dgvDuyurular.CurrentRow.Cells["Duyuru"].Value.ToString();
                        DateTime tarih = Convert.ToDateTime(dgvDuyurular.CurrentRow.Cells["Tarih"].Value);

                        MessageBox.Show(
                            $"📢 Duyuru:\n\n{duyuru}\n\n" +
                            $"📅 Yayın Tarihi: {tarih:dd.MM.yyyy HH:mm}",
                            "Duyuru Detayı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Duyuru gösterilirken hata:\n" + ex.Message);
                    }
                }
            }

        }

        private void dgvMesajlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMesajlar.CurrentRow != null)
            {
                try
                {
                    txtCevap.Clear();

                    string mesaj = dgvMesajlar.CurrentRow.Cells["Mesaj"].Value.ToString();
                    secilenUyeID = Convert.ToInt32(dgvMesajlar.CurrentRow.Cells["GonderenID"].Value);
                    string gonderenAdi = dgvMesajlar.CurrentRow.Cells["Gönderen"].Value.ToString();
                    DateTime tarih = Convert.ToDateTime(dgvMesajlar.CurrentRow.Cells["Tarih"].Value);

                    MessageBox.Show(
                        $"📩 Mesaj:\n{mesaj}\n\n" +
                        $"👤 Gönderen: {gonderenAdi}\n" +
                        $"📅 Tarih: {tarih:dd.MM.yyyy HH:mm}\n\n" +
                        $"✍️ Cevabınızı aşağıdaki kutucuğa yazıp 'Cevap Gönder' butonuna tıklayın.",
                        "Mesaj Detayı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mesaj seçilirken hata:\n" + ex.Message);
                }
            }
        }

        // Cevap gönder butonu
        private void btnCevapGonder_Click(object sender, EventArgs e)
        {
            // Boş kontrol
            if (string.IsNullOrWhiteSpace(txtCevap.Text))
            {
                MessageBox.Show("Lütfen cevap mesajınızı yazın!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Üye seçilmiş mi kontrol
            if (secilenUyeID == 0)
            {
                MessageBox.Show("Lütfen önce bir mesaja tıklayın!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Mesajlar (GonderenID, AliciID, Mesaj, Tarih) VALUES (@g, @a, @m, @t)",
                    baglanti);

                cmd.Parameters.AddWithValue("@g", 1);              // Yönetici (GonderenID = 1)
                cmd.Parameters.AddWithValue("@a", secilenUyeID);   // Üyeye gönder
                cmd.Parameters.AddWithValue("@m", txtCevap.Text);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("✅ Cevap başarıyla gönderildi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCevap.Clear();
                secilenUyeID = 0;
                MesajlariGetir(); // Listeyi yenile
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Cevap gönderilirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DuyurulariGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DuyuruID, Icerik AS 'Duyuru', Tarih FROM Duyurular ORDER BY Tarih DESC",
                    baglanti);

                // ✅ BUNLAR EKSİKTİ - EKLEYIN
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDuyurular.DataSource = dt;

                // DuyuruID kolonunu gizle
                if (dgvDuyurular.Columns.Contains("DuyuruID"))
                    dgvDuyurular.Columns["DuyuruID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyurular yüklenirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Duyuru yayınla butonu
        private void btnDuyuruYayinla_Click(object sender, EventArgs e)
        {// ✅ TEST: Butona tıklanınca mesaj göster
           

            // Boş kontrol
            if (string.IsNullOrWhiteSpace(rtbDuyuru.Text))
            {
                MessageBox.Show("Duyuru metni boş olamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Duyurular (Icerik, Tarih) VALUES (@m, @t)",
                    baglanti);

                cmd.Parameters.AddWithValue("@m", rtbDuyuru.Text);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("📢 Duyuru başarıyla yayınlandı!\n\nTüm üyeler bu duyuruyu görebilecek.",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtbDuyuru.Clear();
                DuyurulariGetir(); // Listeyi yenile
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Duyuru yayınlanırken hata:\n" + ex.Message, "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuyuruYayinla_Click_1(object sender, EventArgs e)
        {
            this.btnDuyuruYayinla.Click += new System.EventHandler(this.btnDuyuruYayinla_Click);
        }

        private void btnCevapGonder_Click_1(object sender, EventArgs e)
        {
            this.btnCevapGonder.Click += new System.EventHandler(this.btnCevapGonder_Click);
        }
    }
}