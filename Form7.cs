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
    public partial class Form7 : Form
    {
        SqlConnection baglanti = new SqlConnection(
    "Server=DESKTOP-BQI1LOE\\SQLEXPRESS;Database=KitApp;Trusted_Connection=True;");
        int aktifID ;
       
        public Form7(int girisID)
        {
            InitializeComponent();
            aktifID = girisID;
           
        }
      

        private void KitaplariGetir(string aranan = "")
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                k.KitapID,
                k.KitapAdi,
                k.Yazar,
                CASE 
                    WHEN o.KitapID IS NULL THEN ' Müsait'
                    ELSE '❌ Ödünçte'
                END AS Durum
            FROM Kitaplar k
            LEFT JOIN Odunc o 
                ON k.KitapID = o.KitapID 
                AND o.IadeTarihi IS NULL
            WHERE k.KitapAdi LIKE @aranan
            ORDER BY k.KitapAdi
        ", baglanti);

                da.SelectCommand.Parameters.AddWithValue(
                    "@aranan", aranan + "%"); // a yazınca a ile başlayanlar

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKitaplar.DataSource = dt;

                dataGridViewKitaplar.Columns["KitapID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata:\n" + ex.Message);
            }
        
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
           private void btnOduncAl_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ ComboBox'tan değer al
                if (cmbKitaplar.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen ödünç almak istediğiniz kitabı seçin!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int kitapID = Convert.ToInt32(cmbKitaplar.SelectedValue);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // Kitabın dolu olup olmadığını kontrol et
                SqlCommand kontrol = new SqlCommand(
                    "SELECT COUNT(*) FROM Odunc WHERE KitapID=@id AND IadeTarihi IS NULL",
                    baglanti);
                kontrol.Parameters.AddWithValue("@id", kitapID);
                int doluMu = (int)kontrol.ExecuteScalar();

                if (doluMu > 0)
                {
                    MessageBox.Show("Bu kitap şu an başka bir üye tarafından kullanılıyor!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                    return;
                }

                // Üyenin zaten ödünç aldığı kitap var mı kontrol et
                SqlCommand uyeKontrol = new SqlCommand(
                    "SELECT COUNT(*) FROM Odunc WHERE UyeID=@u AND IadeTarihi IS NULL",
                    baglanti);
                uyeKontrol.Parameters.AddWithValue("@u", aktifID); // veya aktifUyeID
                int uyeKitapSayisi = (int)uyeKontrol.ExecuteScalar();

                if (uyeKitapSayisi >= 3)  // Maksimum 3 kitap limiti
                {
                    MessageBox.Show("Maksimum 3 kitap ödünç alabilirsiniz. Önce bir kitap iade edin!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                    return;
                }

                // Ödünç kaydını ekle
                SqlCommand ekle = new SqlCommand(
                    "INSERT INTO Odunc (KitapID, UyeID, OduncTarihi, IadeTarihi) VALUES (@k, @u, @o, NULL)",
                    baglanti);
                ekle.Parameters.AddWithValue("@k", kitapID);
                ekle.Parameters.AddWithValue("@u", aktifID); // veya aktifUyeID
                ekle.Parameters.AddWithValue("@o", DateTime.Now);

                ekle.ExecuteNonQuery();

                // Yöneticiye mesaj gönder (opsiyonel)
                try
                {
                    string kitapAdi = cmbKitaplar.Text;  // ComboBox'tan kitap adını al

                    SqlCommand mesaj = new SqlCommand(
                        "INSERT INTO Mesajlar (GonderenID, AliciID, Mesaj, Tarih) VALUES (@g, @a, @m, @t)",
                        baglanti);
                    mesaj.Parameters.AddWithValue("@g", aktifID); // veya aktifUyeID
                    mesaj.Parameters.AddWithValue("@a", 1);  // Yönetici ID
                    mesaj.Parameters.AddWithValue("@m", "'" + kitapAdi + "' kitabı ödünç alındı.");
                    mesaj.Parameters.AddWithValue("@t", DateTime.Now);
                    mesaj.ExecuteNonQuery();
                }
                catch (Exception mesajHata)
                {
                    // Mesaj gönderilemese bile devam et
                    Console.WriteLine("Mesaj gönderilemedi: " + mesajHata.Message);
                }

                baglanti.Close();

                MessageBox.Show("Tebrikler! Kitap başarıyla ödünç alındı.\n15 gün içinde iade ediniz.",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                KitaplariGetir(); // Listeyi yenile
                cmbKitaplar.SelectedIndex = -1; // ComboBox'ı temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödünç alma işlemi sırasında hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        
        }

    


        private void dataGridViewKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
          
        
            try
            {
                // 1️⃣ Önce üyenin ödünç aldığı kitapları kontrol et
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand kontrol = new SqlCommand(
                    "SELECT COUNT(*) FROM Odunc WHERE UyeID = @id AND IadeTarihi IS NULL",
                    baglanti);
                kontrol.Parameters.AddWithValue("@id", aktifID);
                int kitapSayisi = (int)kontrol.ExecuteScalar();
                baglanti.Close();

                if (kitapSayisi == 0)
                {
                    MessageBox.Show("İade edilecek kitap bulunamadı!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Yeni form oluştur
                Form iadeForm = new Form();
                iadeForm.Text = "İade Edilecek Kitabı Seç";
                iadeForm.Size = new Size(700, 400);
                iadeForm.StartPosition = FormStartPosition.CenterScreen;

                // 3️⃣ DataGridView oluştur
                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.MultiSelect = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 4️⃣ VERİYİ ÇEK - DÜZELTME YAPILDI
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                o.OduncID,
                k.KitapAdi AS 'Kitap Adı',
                k.Yazar,
                o.OduncTarihi AS 'Ödünç Tarihi',
                DATEDIFF(DAY, o.OduncTarihi, GETDATE()) AS 'Geçen Gün'
            FROM Odunc o
            INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
            WHERE o.UyeID = @uyeID AND o.IadeTarihi IS NULL
        ", baglanti);

                da.SelectCommand.Parameters.AddWithValue("@uyeID", aktifID);
                da.Fill(dt);
                dgv.DataSource = dt;

                // 5️⃣ OduncID kolonunu gizle
                if (dgv.Columns.Contains("OduncID"))
                {
                    dgv.Columns["OduncID"].Visible = false;
                }

                // 6️⃣ İade butonu
                Button btnOnayla = new Button();
                btnOnayla.Text = "İade Et";
                btnOnayla.Dock = DockStyle.Bottom;
                btnOnayla.Height = 40;
                btnOnayla.Font = new Font("Arial", 10, FontStyle.Bold);

                btnOnayla.Click += (s, ev) =>
                {
                    // 7️⃣ Satır seçili mi?
                    if (dgv.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Lütfen iade edilecek kitabı seçin!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        // 8️⃣ OduncID al
                        int oduncID = Convert.ToInt32(dgv.SelectedRows[0].Cells["OduncID"].Value);

                        // 9️⃣ İade işlemi
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Odunc SET IadeTarihi = @tarih WHERE OduncID = @id",
                            baglanti);

                        cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", oduncID);

                        cmd.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("✅ Kitap başarıyla iade edildi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        iadeForm.Close();
                        KitaplariGetir(); // Ana formdaki listeyi yenile
                    }
                    catch (Exception ex)
                    {
                        if (baglanti.State == ConnectionState.Open)
                            baglanti.Close();

                        MessageBox.Show("İade işlemi sırasında hata:\n" + ex.Message, "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // 🔟 Forma ekle
                iadeForm.Controls.Add(dgv);
                iadeForm.Controls.Add(btnOnayla);

                // 1️⃣1️⃣ Formu göster
                iadeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("İade formu açılırken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void lstMesajlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
"SELECT Mesaj FROM Mesajlar WHERE Alici='Uye'", baglanti);

            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            lstMesajlar.Items.Clear();

            while (dr.Read())
                lstMesajlar.Items.Add(dr[0].ToString());

            baglanti.Close();
        }
       
// ✅ MesajlariGetir() - DÜZELTİLDİ
private void MesajlariGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // ✅ Hem gönderilen hem alınan mesajları getir
                SqlCommand cmd = new SqlCommand(@"
            SELECT GonderenID, Mesaj, Tarih
            FROM Mesajlar
            WHERE (GonderenID = @id OR AliciID = @id)
            ORDER BY Tarih ASC
        ", baglanti);

                cmd.Parameters.AddWithValue("@id", aktifID);

                SqlDataReader dr = cmd.ExecuteReader();
                lstMesajlar.Items.Clear();

                while (dr.Read())
                {
                    int gonderen = Convert.ToInt32(dr["GonderenID"]);
                    string mesaj = dr["Mesaj"].ToString();
                    DateTime tarih = Convert.ToDateTime(dr["Tarih"]);

                    // ✅ Doğru etiketleme
                    if (gonderen == aktifID)
                        lstMesajlar.Items.Add($"[{tarih:HH:mm}] Siz: {mesaj}");
                    else if (gonderen == 1) // Yönetici ID = 1
                        lstMesajlar.Items.Add($"[{tarih:HH:mm}] Yönetici: {mesaj}");
                }

                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show("Mesajlar yüklenirken hata:\n" + ex.Message);
            }

        }
        private void YeniMesajKontrol()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Mesajlar WHERE AliciID = @id",
                    baglanti);

                cmd.Parameters.AddWithValue("@id", aktifID);

                int mesajSayisi = (int)cmd.ExecuteScalar();
                baglanti.Close();

                if (mesajSayisi > 0)
                {
                    MessageBox.Show("📩 Yeni mesajınız var!", "Bildirim");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Mesaj kontrol hatası:\n" + ex.Message);
            }
        }
        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMesaj.Text))
            {
                MessageBox.Show("Mesaj boş olamaz!", "Uyarı",
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

                cmd.Parameters.AddWithValue("@g", aktifID);  // Üye gönderici
                cmd.Parameters.AddWithValue("@a", 1);        // Yönetici alıcı
                cmd.Parameters.AddWithValue("@m", txtMesaj.Text);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                txtMesaj.Clear();
                MesajlariGetir(); // ✅ Listeyi yenile

                MessageBox.Show("Mesaj gönderildi! ✅", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show("Mesaj gönderilirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewDuyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DuyurulariGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DuyuruID, Icerik AS 'Duyuru', Tarih FROM Duyurular ORDER BY Tarih DESC",
                    baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDuyurular.DataSource = dt;

                if (dataGridViewDuyurular.Columns.Contains("DuyuruID"))
                    dataGridViewDuyurular.Columns["DuyuruID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyurular yüklenirken hata:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            KitaplariGetir();
            KitaplariComboBoxaGetir();
            MesajlariGetir();
            DuyurulariGetir(); // ✅ BUNU EKLEYİN
            MessageBox.Show("Form7 AKTİF ID = " + aktifID);

        }
        private void KitaplariComboBoxaGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT KitapID, KitapAdi FROM Kitaplar",
                baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbKitaplar.DisplayMember = "KitapAdi"; // Görünen
            cmbKitaplar.ValueMember = "KitapID";    // Arka plandaki ID
            cmbKitaplar.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
        "Hesabınız ve size ait tüm bilgiler silinecek. Emin misiniz?",
        "Uyarı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            try
            {
                baglanti.Open();

                // 1️⃣ Önce bu üyeye ait ödünç kayıtlarını sil
                SqlCommand cmdOdunc = new SqlCommand(
                    "DELETE FROM Odunc WHERE UyeID = @id", baglanti);
                cmdOdunc.Parameters.AddWithValue("@id", aktifID);
                cmdOdunc.ExecuteNonQuery();

                // 2️⃣ Sonra üyeyi sil
                SqlCommand cmdUye = new SqlCommand(
                    "DELETE FROM Uyeler WHERE UyeID = @id", baglanti);
                cmdUye.Parameters.AddWithValue("@id", aktifID);
                cmdUye.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Hesabınız başarıyla silindi.");
                Application.Exit(); // Programdan çıkart (hesap silindiği için)
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message);
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
















        }
    }
}
