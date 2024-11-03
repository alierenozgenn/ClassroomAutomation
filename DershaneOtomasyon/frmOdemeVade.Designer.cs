namespace DershaneOtomasyon
{
    partial class frmOdemeVade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeVade));
            this.dgOdemeVade = new System.Windows.Forms.DataGridView();
            this.lblOdvID = new System.Windows.Forms.Label();
            this.lblOdemeID = new System.Windows.Forms.Label();
            this.lblOgrID = new System.Windows.Forms.Label();
            this.gbOdeme = new System.Windows.Forms.GroupBox();
            this.rdbYapilmadi = new System.Windows.Forms.RadioButton();
            this.rdbYapildi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOdSekli = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.lblKisi = new System.Windows.Forms.Label();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbGider = new System.Windows.Forms.RadioButton();
            this.rdbGelir = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOgrSorgula = new System.Windows.Forms.GroupBox();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.dgOgrenciList = new System.Windows.Forms.DataGridView();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.txtOgrNoAra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeVade)).BeginInit();
            this.gbOdeme.SuspendLayout();
            this.gbOgrSorgula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOdemeVade
            // 
            this.dgOdemeVade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOdemeVade.Location = new System.Drawing.Point(15, 317);
            this.dgOdemeVade.Name = "dgOdemeVade";
            this.dgOdemeVade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOdemeVade.Size = new System.Drawing.Size(591, 192);
            this.dgOdemeVade.TabIndex = 0;
            this.dgOdemeVade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOdemeVade_CellClick);
            this.dgOdemeVade.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgOdemeVade_RowPrePaint);
            this.dgOdemeVade.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgOdemeVade_RowsAdded);
            // 
            // lblOdvID
            // 
            this.lblOdvID.AutoSize = true;
            this.lblOdvID.Location = new System.Drawing.Point(404, 434);
            this.lblOdvID.Name = "lblOdvID";
            this.lblOdvID.Size = new System.Drawing.Size(41, 15);
            this.lblOdvID.TabIndex = 1;
            this.lblOdvID.Text = "label1";
            // 
            // lblOdemeID
            // 
            this.lblOdemeID.AutoSize = true;
            this.lblOdemeID.Location = new System.Drawing.Point(481, 434);
            this.lblOdemeID.Name = "lblOdemeID";
            this.lblOdemeID.Size = new System.Drawing.Size(41, 15);
            this.lblOdemeID.TabIndex = 2;
            this.lblOdemeID.Text = "label1";
            // 
            // lblOgrID
            // 
            this.lblOgrID.AutoSize = true;
            this.lblOgrID.Location = new System.Drawing.Point(575, 434);
            this.lblOgrID.Name = "lblOgrID";
            this.lblOgrID.Size = new System.Drawing.Size(41, 15);
            this.lblOgrID.TabIndex = 3;
            this.lblOgrID.Text = "label1";
            // 
            // gbOdeme
            // 
            this.gbOdeme.Controls.Add(this.rdbYapilmadi);
            this.gbOdeme.Controls.Add(this.rdbYapildi);
            this.gbOdeme.Controls.Add(this.label7);
            this.gbOdeme.Controls.Add(this.cmbOdSekli);
            this.gbOdeme.Controls.Add(this.txtAciklama);
            this.gbOdeme.Controls.Add(this.label8);
            this.gbOdeme.Controls.Add(this.txtOgrenci);
            this.gbOdeme.Controls.Add(this.lblKisi);
            this.gbOdeme.Controls.Add(this.txtBelgeNo);
            this.gbOdeme.Controls.Add(this.label6);
            this.gbOdeme.Controls.Add(this.txtTutar);
            this.gbOdeme.Controls.Add(this.label5);
            this.gbOdeme.Controls.Add(this.dtpTarih);
            this.gbOdeme.Controls.Add(this.label4);
            this.gbOdeme.Controls.Add(this.cmbIslem);
            this.gbOdeme.Controls.Add(this.label3);
            this.gbOdeme.Controls.Add(this.rdbGider);
            this.gbOdeme.Controls.Add(this.rdbGelir);
            this.gbOdeme.Controls.Add(this.label2);
            this.gbOdeme.Controls.Add(this.label1);
            this.gbOdeme.Location = new System.Drawing.Point(14, 2);
            this.gbOdeme.Name = "gbOdeme";
            this.gbOdeme.Size = new System.Drawing.Size(271, 308);
            this.gbOdeme.TabIndex = 38;
            this.gbOdeme.TabStop = false;
            // 
            // rdbYapilmadi
            // 
            this.rdbYapilmadi.AutoSize = true;
            this.rdbYapilmadi.Location = new System.Drawing.Point(171, 279);
            this.rdbYapilmadi.Name = "rdbYapilmadi";
            this.rdbYapilmadi.Size = new System.Drawing.Size(80, 19);
            this.rdbYapilmadi.TabIndex = 41;
            this.rdbYapilmadi.Text = "Yapılmadı";
            this.rdbYapilmadi.UseVisualStyleBackColor = true;
            // 
            // rdbYapildi
            // 
            this.rdbYapildi.AutoSize = true;
            this.rdbYapildi.Location = new System.Drawing.Point(99, 279);
            this.rdbYapildi.Name = "rdbYapildi";
            this.rdbYapildi.Size = new System.Drawing.Size(62, 19);
            this.rdbYapildi.TabIndex = 40;
            this.rdbYapildi.Text = "Yapıldı";
            this.rdbYapildi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ödeme";
            // 
            // cmbOdSekli
            // 
            this.cmbOdSekli.FormattingEnabled = true;
            this.cmbOdSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Çek",
            "Banka",
            "Diğer"});
            this.cmbOdSekli.Location = new System.Drawing.Point(100, 52);
            this.cmbOdSekli.Name = "cmbOdSekli";
            this.cmbOdSekli.Size = new System.Drawing.Size(147, 23);
            this.cmbOdSekli.TabIndex = 38;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(100, 209);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(147, 21);
            this.txtAciklama.TabIndex = 35;
            this.txtAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAciklama_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Açıklama";
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(100, 239);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(147, 21);
            this.txtOgrenci.TabIndex = 33;
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Location = new System.Drawing.Point(15, 247);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(50, 15);
            this.lblKisi.TabIndex = 32;
            this.lblKisi.Text = "Öğrenci";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(100, 179);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(147, 21);
            this.txtBelgeNo.TabIndex = 31;
            this.txtBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBelgeNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Belge No";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(100, 149);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(147, 21);
            this.txtTutar.TabIndex = 29;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "İşlem Tutarı";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(99, 119);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(149, 21);
            this.dtpTarih.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "İşlem Tarihi";
            // 
            // cmbIslem
            // 
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "Öğrenci Geliri"});
            this.cmbIslem.Location = new System.Drawing.Point(99, 87);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(149, 23);
            this.cmbIslem.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "İşlem";
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Enabled = false;
            this.rdbGider.Location = new System.Drawing.Point(160, 15);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(55, 19);
            this.rdbGider.TabIndex = 23;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Checked = true;
            this.rdbGelir.Enabled = false;
            this.rdbGelir.Location = new System.Drawing.Point(100, 15);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(51, 19);
            this.rdbGelir.TabIndex = 22;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "İşlem Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "İşlem Şekli";
            // 
            // gbOgrSorgula
            // 
            this.gbOgrSorgula.Controls.Add(this.chkAyrilan);
            this.gbOgrSorgula.Controls.Add(this.dgOgrenciList);
            this.gbOgrSorgula.Controls.Add(this.btnHepsiAra);
            this.gbOgrSorgula.Controls.Add(this.txtOgrNoAra);
            this.gbOgrSorgula.Controls.Add(this.label15);
            this.gbOgrSorgula.Location = new System.Drawing.Point(293, 3);
            this.gbOgrSorgula.Name = "gbOgrSorgula";
            this.gbOgrSorgula.Size = new System.Drawing.Size(313, 307);
            this.gbOgrSorgula.TabIndex = 39;
            this.gbOgrSorgula.TabStop = false;
            this.gbOgrSorgula.Text = "Öğrenci Sorgula";
            // 
            // chkAyrilan
            // 
            this.chkAyrilan.AutoSize = true;
            this.chkAyrilan.Location = new System.Drawing.Point(124, 98);
            this.chkAyrilan.Name = "chkAyrilan";
            this.chkAyrilan.Size = new System.Drawing.Size(178, 19);
            this.chkAyrilan.TabIndex = 60;
            this.chkAyrilan.Text = "Ayrılan Öğrencileride Listele";
            this.chkAyrilan.UseVisualStyleBackColor = true;
            // 
            // dgOgrenciList
            // 
            this.dgOgrenciList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciList.Location = new System.Drawing.Point(13, 122);
            this.dgOgrenciList.Name = "dgOgrenciList";
            this.dgOgrenciList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOgrenciList.Size = new System.Drawing.Size(286, 173);
            this.dgOgrenciList.TabIndex = 59;
            this.dgOgrenciList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciList_CellClick);
            // 
            // btnHepsiAra
            // 
            this.btnHepsiAra.BackColor = System.Drawing.Color.White;
            this.btnHepsiAra.Location = new System.Drawing.Point(13, 53);
            this.btnHepsiAra.Name = "btnHepsiAra";
            this.btnHepsiAra.Size = new System.Drawing.Size(286, 39);
            this.btnHepsiAra.TabIndex = 58;
            this.btnHepsiAra.Text = "Bütün Öğrencileri Listele";
            this.btnHepsiAra.UseVisualStyleBackColor = false;
            this.btnHepsiAra.Click += new System.EventHandler(this.btnHepsiAra_Click);
            // 
            // txtOgrNoAra
            // 
            this.txtOgrNoAra.Location = new System.Drawing.Point(86, 25);
            this.txtOgrNoAra.Name = "txtOgrNoAra";
            this.txtOgrNoAra.Size = new System.Drawing.Size(213, 21);
            this.txtOgrNoAra.TabIndex = 1;
            this.txtOgrNoAra.TextChanged += new System.EventHandler(this.txtOgrNoAra_TextChanged);
            this.txtOgrNoAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrNoAra_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Öğrenci No";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(314, 515);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 45);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(417, 515);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 45);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(509, 515);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 45);
            this.btnKapat.TabIndex = 42;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmOdemeVade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 568);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.gbOgrSorgula);
            this.Controls.Add(this.dgOdemeVade);
            this.Controls.Add(this.gbOdeme);
            this.Controls.Add(this.lblOgrID);
            this.Controls.Add(this.lblOdemeID);
            this.Controls.Add(this.lblOdvID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdemeVade";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenci Ödeme";
            this.Load += new System.EventHandler(this.frmOdemeVade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeVade)).EndInit();
            this.gbOdeme.ResumeLayout(false);
            this.gbOdeme.PerformLayout();
            this.gbOgrSorgula.ResumeLayout(false);
            this.gbOgrSorgula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOdemeVade;
        private System.Windows.Forms.Label lblOdvID;
        private System.Windows.Forms.Label lblOdemeID;
        private System.Windows.Forms.Label lblOgrID;
        private System.Windows.Forms.GroupBox gbOdeme;
        private System.Windows.Forms.ComboBox cmbOdSekli;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label lblKisi;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbGider;
        private System.Windows.Forms.RadioButton rdbGelir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbYapilmadi;
        private System.Windows.Forms.RadioButton rdbYapildi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbOgrSorgula;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.DataGridView dgOgrenciList;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.TextBox txtOgrNoAra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}