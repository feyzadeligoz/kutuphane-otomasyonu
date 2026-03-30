namespace KutuphaneOtomasyonu
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabDuyurular = new System.Windows.Forms.TabPage();
            this.btnDuyuruYayinla = new System.Windows.Forms.Button();
            this.rtbDuyuru = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabMesajlar = new System.Windows.Forms.TabPage();
            this.btnCevapGonder = new System.Windows.Forms.Button();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMesajlar = new System.Windows.Forms.DataGridView();
            this.tabOdunc = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOdunc = new System.Windows.Forms.DataGridView();
            this.tabUyeler = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.tabKitaplar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabDuyurular.SuspendLayout();
            this.tabMesajlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).BeginInit();
            this.tabOdunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunc)).BeginInit();
            this.tabUyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.tabKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETİCİ PANELİ";
            // 
            // tabDuyurular
            // 
            this.tabDuyurular.Controls.Add(this.btnDuyuruYayinla);
            this.tabDuyurular.Controls.Add(this.rtbDuyuru);
            this.tabDuyurular.Controls.Add(this.label6);
            this.tabDuyurular.Location = new System.Drawing.Point(4, 25);
            this.tabDuyurular.Name = "tabDuyurular";
            this.tabDuyurular.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuyurular.Size = new System.Drawing.Size(460, 293);
            this.tabDuyurular.TabIndex = 4;
            this.tabDuyurular.Text = "Duyurular";
            this.tabDuyurular.UseVisualStyleBackColor = true;
            // 
            // btnDuyuruYayinla
            // 
            this.btnDuyuruYayinla.Location = new System.Drawing.Point(141, 197);
            this.btnDuyuruYayinla.Name = "btnDuyuruYayinla";
            this.btnDuyuruYayinla.Size = new System.Drawing.Size(135, 23);
            this.btnDuyuruYayinla.TabIndex = 2;
            this.btnDuyuruYayinla.Text = "Duyuru Yayınla";
            this.btnDuyuruYayinla.UseVisualStyleBackColor = true;
            this.btnDuyuruYayinla.Click += new System.EventHandler(this.btnDuyuruYayinla_Click_1);
            // 
            // rtbDuyuru
            // 
            this.rtbDuyuru.Location = new System.Drawing.Point(141, 49);
            this.rtbDuyuru.Name = "rtbDuyuru";
            this.rtbDuyuru.Size = new System.Drawing.Size(145, 113);
            this.rtbDuyuru.TabIndex = 1;
            this.rtbDuyuru.Text = "";
            this.rtbDuyuru.TextChanged += new System.EventHandler(this.rtbDuyuru_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yeni Duyuru";
            // 
            // tabMesajlar
            // 
            this.tabMesajlar.Controls.Add(this.btnCevapGonder);
            this.tabMesajlar.Controls.Add(this.txtCevap);
            this.tabMesajlar.Controls.Add(this.label5);
            this.tabMesajlar.Controls.Add(this.dgvMesajlar);
            this.tabMesajlar.Location = new System.Drawing.Point(4, 25);
            this.tabMesajlar.Name = "tabMesajlar";
            this.tabMesajlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMesajlar.Size = new System.Drawing.Size(460, 293);
            this.tabMesajlar.TabIndex = 3;
            this.tabMesajlar.Text = "Mesajlar";
            this.tabMesajlar.UseVisualStyleBackColor = true;
            // 
            // btnCevapGonder
            // 
            this.btnCevapGonder.Location = new System.Drawing.Point(170, 210);
            this.btnCevapGonder.Name = "btnCevapGonder";
            this.btnCevapGonder.Size = new System.Drawing.Size(138, 23);
            this.btnCevapGonder.TabIndex = 3;
            this.btnCevapGonder.Text = "Cevap Gönder";
            this.btnCevapGonder.UseVisualStyleBackColor = true;
            this.btnCevapGonder.Click += new System.EventHandler(this.btnCevapGonder_Click);
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(170, 158);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(138, 22);
            this.txtCevap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yönetici Cevabı:";
            // 
            // dgvMesajlar
            // 
            this.dgvMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesajlar.Location = new System.Drawing.Point(19, 18);
            this.dgvMesajlar.Name = "dgvMesajlar";
            this.dgvMesajlar.RowHeadersWidth = 51;
            this.dgvMesajlar.RowTemplate.Height = 24;
            this.dgvMesajlar.Size = new System.Drawing.Size(289, 99);
            this.dgvMesajlar.TabIndex = 0;
            this.dgvMesajlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesajlar_CellContentClick);
            // 
            // tabOdunc
            // 
            this.tabOdunc.Controls.Add(this.label4);
            this.tabOdunc.Controls.Add(this.dgvOdunc);
            this.tabOdunc.Location = new System.Drawing.Point(4, 25);
            this.tabOdunc.Name = "tabOdunc";
            this.tabOdunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdunc.Size = new System.Drawing.Size(460, 293);
            this.tabOdunc.TabIndex = 2;
            this.tabOdunc.Text = "Ödünç Kitaplar";
            this.tabOdunc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ödünç Verilen Kitaplar";
            // 
            // dgvOdunc
            // 
            this.dgvOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdunc.Location = new System.Drawing.Point(61, 54);
            this.dgvOdunc.Name = "dgvOdunc";
            this.dgvOdunc.RowHeadersWidth = 51;
            this.dgvOdunc.RowTemplate.Height = 24;
            this.dgvOdunc.Size = new System.Drawing.Size(368, 215);
            this.dgvOdunc.TabIndex = 0;
            // 
            // tabUyeler
            // 
            this.tabUyeler.Controls.Add(this.label3);
            this.tabUyeler.Controls.Add(this.dgvUyeler);
            this.tabUyeler.Location = new System.Drawing.Point(4, 25);
            this.tabUyeler.Name = "tabUyeler";
            this.tabUyeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUyeler.Size = new System.Drawing.Size(460, 293);
            this.tabUyeler.TabIndex = 1;
            this.tabUyeler.Text = "Üyeler";
            this.tabUyeler.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kayıtlı Üyeler";
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(66, 53);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 51;
            this.dgvUyeler.RowTemplate.Height = 24;
            this.dgvUyeler.Size = new System.Drawing.Size(360, 218);
            this.dgvUyeler.TabIndex = 0;
            // 
            // tabKitaplar
            // 
            this.tabKitaplar.Controls.Add(this.label2);
            this.tabKitaplar.Controls.Add(this.dgvKitaplar);
            this.tabKitaplar.Location = new System.Drawing.Point(4, 25);
            this.tabKitaplar.Name = "tabKitaplar";
            this.tabKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKitaplar.Size = new System.Drawing.Size(460, 293);
            this.tabKitaplar.TabIndex = 0;
            this.tabKitaplar.Text = "Kitaplar";
            this.tabKitaplar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tüm Kitaplar";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(67, 41);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(335, 221);
            this.dgvKitaplar.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabKitaplar);
            this.tabAdmin.Controls.Add(this.tabUyeler);
            this.tabAdmin.Controls.Add(this.tabOdunc);
            this.tabAdmin.Controls.Add(this.tabMesajlar);
            this.tabAdmin.Controls.Add(this.tabDuyurular);
            this.tabAdmin.Location = new System.Drawing.Point(85, 89);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(468, 322);
            this.tabAdmin.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAdmin);
            this.Name = "Form8";
            this.Text = "Form8";
            this.tabDuyurular.ResumeLayout(false);
            this.tabDuyurular.PerformLayout();
            this.tabMesajlar.ResumeLayout(false);
            this.tabMesajlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).EndInit();
            this.tabOdunc.ResumeLayout(false);
            this.tabOdunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunc)).EndInit();
            this.tabUyeler.ResumeLayout(false);
            this.tabUyeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.tabKitaplar.ResumeLayout(false);
            this.tabKitaplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDuyurular;
        private System.Windows.Forms.Button btnDuyuruYayinla;
        private System.Windows.Forms.RichTextBox rtbDuyuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabMesajlar;
        private System.Windows.Forms.Button btnCevapGonder;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMesajlar;
        private System.Windows.Forms.TabPage tabOdunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOdunc;
        private System.Windows.Forms.TabPage tabUyeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.TabPage tabKitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.TabControl tabAdmin;
    }
}