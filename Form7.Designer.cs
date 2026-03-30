namespace KutuphaneOtomasyonu
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKitaplar = new System.Windows.Forms.TabPage();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.tabOdunc = new System.Windows.Forms.TabPage();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.lblKitapSec = new System.Windows.Forms.Label();
            this.tabMesajlar = new System.Windows.Forms.TabPage();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lstMesajlar = new System.Windows.Forms.ListBox();
            this.tabDuyurular = new System.Windows.Forms.TabPage();
            this.dataGridViewDuyurular = new System.Windows.Forms.DataGridView();
            this.tabKullaniciIslemleri = new System.Windows.Forms.TabPage();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.tabOdunc.SuspendLayout();
            this.tabMesajlar.SuspendLayout();
            this.tabDuyurular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyurular)).BeginInit();
            this.tabKullaniciIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "KÜTÜPHANE ÜYE PANELİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKitaplar);
            this.tabControl1.Controls.Add(this.tabOdunc);
            this.tabControl1.Controls.Add(this.tabMesajlar);
            this.tabControl1.Controls.Add(this.tabDuyurular);
            this.tabControl1.Controls.Add(this.tabKullaniciIslemleri);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(70, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 332);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabKitaplar
            // 
            this.tabKitaplar.Controls.Add(this.dataGridViewKitaplar);
            this.tabKitaplar.Location = new System.Drawing.Point(4, 27);
            this.tabKitaplar.Name = "tabKitaplar";
            this.tabKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKitaplar.Size = new System.Drawing.Size(553, 301);
            this.tabKitaplar.TabIndex = 0;
            this.tabKitaplar.Text = "Kitap Listesi";
            this.tabKitaplar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(-4, 10);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.RowTemplate.Height = 24;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(554, 295);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellContentClick);
            // 
            // tabOdunc
            // 
            this.tabOdunc.BackColor = System.Drawing.Color.Ivory;
            this.tabOdunc.Controls.Add(this.btnIadeEt);
            this.tabOdunc.Controls.Add(this.btnOduncAl);
            this.tabOdunc.Controls.Add(this.cmbKitaplar);
            this.tabOdunc.Controls.Add(this.lblKitapSec);
            this.tabOdunc.Location = new System.Drawing.Point(4, 27);
            this.tabOdunc.Name = "tabOdunc";
            this.tabOdunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdunc.Size = new System.Drawing.Size(553, 301);
            this.tabOdunc.TabIndex = 1;
            this.tabOdunc.Text = "Ödünç / İade";
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(354, 139);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(75, 33);
            this.btnIadeEt.TabIndex = 3;
            this.btnIadeEt.Text = "İade Et";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(196, 139);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(75, 33);
            this.btnOduncAl.TabIndex = 2;
            this.btnOduncAl.Text = "Ödünç Al";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(196, 65);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(158, 26);
            this.cmbKitaplar.TabIndex = 1;
            this.cmbKitaplar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblKitapSec
            // 
            this.lblKitapSec.AutoSize = true;
            this.lblKitapSec.Location = new System.Drawing.Point(42, 65);
            this.lblKitapSec.Name = "lblKitapSec";
            this.lblKitapSec.Size = new System.Drawing.Size(66, 18);
            this.lblKitapSec.TabIndex = 0;
            this.lblKitapSec.Text = "Kitap Seç;";
            // 
            // tabMesajlar
            // 
            this.tabMesajlar.BackColor = System.Drawing.Color.Ivory;
            this.tabMesajlar.Controls.Add(this.btnMesajGonder);
            this.tabMesajlar.Controls.Add(this.txtMesaj);
            this.tabMesajlar.Controls.Add(this.lstMesajlar);
            this.tabMesajlar.Location = new System.Drawing.Point(4, 27);
            this.tabMesajlar.Name = "tabMesajlar";
            this.tabMesajlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMesajlar.Size = new System.Drawing.Size(553, 301);
            this.tabMesajlar.TabIndex = 2;
            this.tabMesajlar.Text = "Mesajlar";
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Location = new System.Drawing.Point(315, 122);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(75, 34);
            this.btnMesajGonder.TabIndex = 2;
            this.btnMesajGonder.Text = "Gönder";
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(315, 66);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 22);
            this.txtMesaj.TabIndex = 1;
            // 
            // lstMesajlar
            // 
            this.lstMesajlar.FormattingEnabled = true;
            this.lstMesajlar.ItemHeight = 18;
            this.lstMesajlar.Location = new System.Drawing.Point(57, 45);
            this.lstMesajlar.Name = "lstMesajlar";
            this.lstMesajlar.Size = new System.Drawing.Size(161, 130);
            this.lstMesajlar.TabIndex = 0;
            this.lstMesajlar.SelectedIndexChanged += new System.EventHandler(this.lstMesajlar_SelectedIndexChanged);
            // 
            // tabDuyurular
            // 
            this.tabDuyurular.Controls.Add(this.dataGridViewDuyurular);
            this.tabDuyurular.Location = new System.Drawing.Point(4, 27);
            this.tabDuyurular.Name = "tabDuyurular";
            this.tabDuyurular.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuyurular.Size = new System.Drawing.Size(553, 301);
            this.tabDuyurular.TabIndex = 3;
            this.tabDuyurular.Text = "Duyurular";
            this.tabDuyurular.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDuyurular
            // 
            this.dataGridViewDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDuyurular.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDuyurular.Name = "dataGridViewDuyurular";
            this.dataGridViewDuyurular.ReadOnly = true;
            this.dataGridViewDuyurular.RowHeadersVisible = false;
            this.dataGridViewDuyurular.RowHeadersWidth = 51;
            this.dataGridViewDuyurular.RowTemplate.Height = 24;
            this.dataGridViewDuyurular.Size = new System.Drawing.Size(547, 295);
            this.dataGridViewDuyurular.TabIndex = 0;
            this.dataGridViewDuyurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDuyurular_CellContentClick);
            // 
            // tabKullaniciIslemleri
            // 
            this.tabKullaniciIslemleri.BackColor = System.Drawing.Color.OldLace;
            this.tabKullaniciIslemleri.Controls.Add(this.btnKayitSil);
            this.tabKullaniciIslemleri.Controls.Add(this.btnKayitGuncelle);
            this.tabKullaniciIslemleri.Location = new System.Drawing.Point(4, 27);
            this.tabKullaniciIslemleri.Name = "tabKullaniciIslemleri";
            this.tabKullaniciIslemleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabKullaniciIslemleri.Size = new System.Drawing.Size(553, 301);
            this.tabKullaniciIslemleri.TabIndex = 4;
            this.tabKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(20, 73);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(296, 36);
            this.btnKayitSil.TabIndex = 1;
            this.btnKayitSil.Text = "KAYIT SİL";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Location = new System.Drawing.Point(20, 33);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(296, 34);
            this.btnKayitGuncelle.TabIndex = 0;
            this.btnKayitGuncelle.Text = "KAYIT GÜNCELLE";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.tabOdunc.ResumeLayout(false);
            this.tabOdunc.PerformLayout();
            this.tabMesajlar.ResumeLayout(false);
            this.tabMesajlar.PerformLayout();
            this.tabDuyurular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyurular)).EndInit();
            this.tabKullaniciIslemleri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKitaplar;
        private System.Windows.Forms.TabPage tabOdunc;
        private System.Windows.Forms.TabPage tabMesajlar;
        private System.Windows.Forms.TabPage tabDuyurular;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.Label lblKitapSec;
        private System.Windows.Forms.Button btnIadeEt;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.ListBox lstMesajlar;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.DataGridView dataGridViewDuyurular;
        private System.Windows.Forms.TabPage tabKullaniciIslemleri;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitGuncelle;
    }
}