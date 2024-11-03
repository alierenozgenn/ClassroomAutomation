namespace DershaneOtomasyon
{
    partial class frmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            this.dgdOdemeListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOnce = new System.Windows.Forms.DateTimePicker();
            this.dtpSonra = new System.Windows.Forms.DateTimePicker();
            this.btnTarihSorgula = new System.Windows.Forms.Button();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnYillik = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOdemeListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdOdemeListele
            // 
            this.dgdOdemeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdOdemeListele.Location = new System.Drawing.Point(9, 74);
            this.dgdOdemeListele.Name = "dgdOdemeListele";
            this.dgdOdemeListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdOdemeListele.Size = new System.Drawing.Size(934, 363);
            this.dgdOdemeListele.TabIndex = 0;
            this.dgdOdemeListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdOdemeListele_CellClick);
            this.dgdOdemeListele.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgdOdemeListele_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme Türü";
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Items.AddRange(new object[] {
            "Gelir",
            "Gider",
            "Hepsi"});
            this.cmbTuru.Location = new System.Drawing.Point(8, 31);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(140, 23);
            this.cmbTuru.TabIndex = 2;
            this.cmbTuru.SelectedIndexChanged += new System.EventHandler(this.cmbTuru_SelectedIndexChanged);
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Çek",
            "Banka",
            "Diğer",
            "Hepsi"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(156, 31);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(140, 23);
            this.cmbOdemeSekli.TabIndex = 4;
            this.cmbOdemeSekli.SelectedIndexChanged += new System.EventHandler(this.cmbIslemSekli_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ödeme Şekli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(370, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "İşlem Tarihi Aralığı";
            // 
            // dtpOnce
            // 
            this.dtpOnce.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOnce.Location = new System.Drawing.Point(319, 32);
            this.dtpOnce.Name = "dtpOnce";
            this.dtpOnce.Size = new System.Drawing.Size(119, 21);
            this.dtpOnce.TabIndex = 7;
            // 
            // dtpSonra
            // 
            this.dtpSonra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonra.Location = new System.Drawing.Point(446, 32);
            this.dtpSonra.Name = "dtpSonra";
            this.dtpSonra.Size = new System.Drawing.Size(119, 21);
            this.dtpSonra.TabIndex = 8;
            // 
            // btnTarihSorgula
            // 
            this.btnTarihSorgula.BackColor = System.Drawing.Color.White;
            this.btnTarihSorgula.Location = new System.Drawing.Point(573, 30);
            this.btnTarihSorgula.Name = "btnTarihSorgula";
            this.btnTarihSorgula.Size = new System.Drawing.Size(87, 27);
            this.btnTarihSorgula.TabIndex = 9;
            this.btnTarihSorgula.Text = "Sorgula";
            this.btnTarihSorgula.UseVisualStyleBackColor = false;
            this.btnTarihSorgula.Click += new System.EventHandler(this.btnTarihSorgula_Click);
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.BackColor = System.Drawing.Color.White;
            this.btnHaftalik.Location = new System.Drawing.Point(667, 30);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(87, 27);
            this.btnHaftalik.TabIndex = 10;
            this.btnHaftalik.Text = "Haftalık";
            this.btnHaftalik.UseVisualStyleBackColor = false;
            this.btnHaftalik.Click += new System.EventHandler(this.btnHaftalik_Click);
            // 
            // btnAylik
            // 
            this.btnAylik.BackColor = System.Drawing.Color.White;
            this.btnAylik.Location = new System.Drawing.Point(762, 31);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(87, 27);
            this.btnAylik.TabIndex = 11;
            this.btnAylik.Text = "Aylık";
            this.btnAylik.UseVisualStyleBackColor = false;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // btnYillik
            // 
            this.btnYillik.BackColor = System.Drawing.Color.White;
            this.btnYillik.Location = new System.Drawing.Point(856, 32);
            this.btnYillik.Name = "btnYillik";
            this.btnYillik.Size = new System.Drawing.Size(87, 27);
            this.btnYillik.TabIndex = 12;
            this.btnYillik.Text = "Yıllık";
            this.btnYillik.UseVisualStyleBackColor = false;
            this.btnYillik.Click += new System.EventHandler(this.btnYillik_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.White;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(563, 445);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(96, 45);
            this.btnDuzenle.TabIndex = 15;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(765, 445);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(85, 45);
            this.btnYazdir.TabIndex = 27;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(668, 445);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 45);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(859, 445);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 45);
            this.btnKapat.TabIndex = 29;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.Location = new System.Drawing.Point(468, 445);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 45);
            this.btnYeni.TabIndex = 60;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 499);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYillik);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.btnHaftalik);
            this.Controls.Add(this.btnTarihSorgula);
            this.Controls.Add(this.dtpSonra);
            this.Controls.Add(this.dtpOnce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdOdemeListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdOdemeListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdOdemeListele;
#pragma warning disable CS0169 // The field 'frmKasa.odemeYapanDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeYapanDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'frmKasa.odemeYapanDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOnce;
        private System.Windows.Forms.DateTimePicker dtpSonra;
        private System.Windows.Forms.Button btnTarihSorgula;
        private System.Windows.Forms.Button btnHaftalik;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnYillik;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeni;
    }
}