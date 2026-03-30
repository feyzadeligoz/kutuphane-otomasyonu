namespace KutuphaneOtomasyonu
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMesajlar = new System.Windows.Forms.DataGridView();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnCevapGonder = new System.Windows.Forms.Button();
            this.dgvDuyurular = new System.Windows.Forms.DataGridView();
            this.rtbDuyuru = new System.Windows.Forms.RichTextBox();
            this.btnDuyuruYayinla = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCevapGonder);
            this.tabPage1.Controls.Add(this.txtCevap);
            this.tabPage1.Controls.Add(this.dgvMesajlar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mesajlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDuyuruYayinla);
            this.tabPage2.Controls.Add(this.rtbDuyuru);
            this.tabPage2.Controls.Add(this.dgvDuyurular);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Duyurular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "YÖNETİCİ PANELİ";
            // 
            // dgvMesajlar
            // 
            this.dgvMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesajlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMesajlar.Location = new System.Drawing.Point(3, 3);
            this.dgvMesajlar.Name = "dgvMesajlar";
            this.dgvMesajlar.ReadOnly = true;
            this.dgvMesajlar.RowHeadersWidth = 51;
            this.dgvMesajlar.RowTemplate.Height = 24;
            this.dgvMesajlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesajlar.Size = new System.Drawing.Size(476, 190);
            this.dgvMesajlar.TabIndex = 0;
            this.dgvMesajlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesajlar_CellContentClick);
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(0, 183);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCevap.Size = new System.Drawing.Size(486, 58);
            this.txtCevap.TabIndex = 1;
            // 
            // btnCevapGonder
            // 
            this.btnCevapGonder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCevapGonder.Location = new System.Drawing.Point(3, 241);
            this.btnCevapGonder.Name = "btnCevapGonder";
            this.btnCevapGonder.Size = new System.Drawing.Size(476, 46);
            this.btnCevapGonder.TabIndex = 2;
            this.btnCevapGonder.Text = "Cevap  Gönder";
            this.btnCevapGonder.UseVisualStyleBackColor = true;
            this.btnCevapGonder.Click += new System.EventHandler(this.btnCevapGonder_Click_1);
            // 
            // dgvDuyurular
            // 
            this.dgvDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyurular.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDuyurular.Location = new System.Drawing.Point(3, 3);
            this.dgvDuyurular.Name = "dgvDuyurular";
            this.dgvDuyurular.ReadOnly = true;
            this.dgvDuyurular.RowHeadersVisible = false;
            this.dgvDuyurular.RowHeadersWidth = 51;
            this.dgvDuyurular.RowTemplate.Height = 24;
            this.dgvDuyurular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuyurular.Size = new System.Drawing.Size(476, 167);
            this.dgvDuyurular.TabIndex = 0;
            this.dgvDuyurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuyurular_CellContentClick);
            // 
            // rtbDuyuru
            // 
            this.rtbDuyuru.Location = new System.Drawing.Point(3, 170);
            this.rtbDuyuru.Name = "rtbDuyuru";
            this.rtbDuyuru.Size = new System.Drawing.Size(479, 76);
            this.rtbDuyuru.TabIndex = 1;
            this.rtbDuyuru.Text = "";
            // 
            // btnDuyuruYayinla
            // 
            this.btnDuyuruYayinla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDuyuruYayinla.Location = new System.Drawing.Point(3, 244);
            this.btnDuyuruYayinla.Name = "btnDuyuruYayinla";
            this.btnDuyuruYayinla.Size = new System.Drawing.Size(476, 43);
            this.btnDuyuruYayinla.TabIndex = 2;
            this.btnDuyuruYayinla.Text = "Duyuru Yayınla";
            this.btnDuyuruYayinla.UseVisualStyleBackColor = true;
            this.btnDuyuruYayinla.Click += new System.EventHandler(this.btnDuyuruYayinla_Click_1);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCevapGonder;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.DataGridView dgvMesajlar;
        private System.Windows.Forms.Button btnDuyuruYayinla;
        private System.Windows.Forms.RichTextBox rtbDuyuru;
        private System.Windows.Forms.DataGridView dgvDuyurular;
    }
}