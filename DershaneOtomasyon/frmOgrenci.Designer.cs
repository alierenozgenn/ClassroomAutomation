namespace DershaneOtomasyon
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.tcOgrenci = new System.Windows.Forms.TabControl();
            this.tcpOgrBilgi = new System.Windows.Forms.TabPage();
            this.gbIletisim = new System.Windows.Forms.GroupBox();
            this.txtOgrAdres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOgrTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgrAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbBilgiler = new System.Windows.Forms.GroupBox();
            this.cmbSozTaksit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSozTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSozTar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKimNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcpVeli = new System.Windows.Forms.TabPage();
            this.gbVeliKim = new System.Windows.Forms.GroupBox();
            this.rdbAnne = new System.Windows.Forms.RadioButton();
            this.rdbBaba = new System.Windows.Forms.RadioButton();
            this.gbBaba = new System.Windows.Forms.GroupBox();
            this.lblBabaID = new System.Windows.Forms.Label();
            this.txtBabaAdres = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBabaMeslek = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBabaTel = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBabaKimlik = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBabaSoyad = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBabaAd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gbAnne = new System.Windows.Forms.GroupBox();
            this.lblAnneID = new System.Windows.Forms.Label();
            this.txtAnneAdres = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAnneMeslek = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAnneTel = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAnneKimlik = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAnneSoyadi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOdemeler = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgOgrOdemeList = new System.Windows.Forms.DataGridView();
            this.lblOgrID = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.gbOgrSorgula = new System.Windows.Forms.GroupBox();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.dgOgrenciList = new System.Windows.Forms.DataGridView();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.txtOgrNoAra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tcOgrenci.SuspendLayout();
            this.tcpOgrBilgi.SuspendLayout();
            this.gbIletisim.SuspendLayout();
            this.gbBilgiler.SuspendLayout();
            this.tcpVeli.SuspendLayout();
            this.gbVeliKim.SuspendLayout();
            this.gbBaba.SuspendLayout();
            this.gbAnne.SuspendLayout();
            this.tbOdemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrOdemeList)).BeginInit();
            this.gbOgrSorgula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOgrenci
            // 
            this.tcOgrenci.Controls.Add(this.tcpOgrBilgi);
            this.tcOgrenci.Controls.Add(this.tcpVeli);
            this.tcOgrenci.Controls.Add(this.tbOdemeler);
            this.tcOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcOgrenci.Location = new System.Drawing.Point(12, 12);
            this.tcOgrenci.Name = "tcOgrenci";
            this.tcOgrenci.SelectedIndex = 0;
            this.tcOgrenci.Size = new System.Drawing.Size(560, 331);
            this.tcOgrenci.TabIndex = 0;
            // 
            // tcpOgrBilgi
            // 
            this.tcpOgrBilgi.Controls.Add(this.gbIletisim);
            this.tcpOgrBilgi.Controls.Add(this.gbBilgiler);
            this.tcpOgrBilgi.Location = new System.Drawing.Point(4, 24);
            this.tcpOgrBilgi.Name = "tcpOgrBilgi";
            this.tcpOgrBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tcpOgrBilgi.Size = new System.Drawing.Size(552, 303);
            this.tcpOgrBilgi.TabIndex = 0;
            this.tcpOgrBilgi.Text = "Öğrenci Bilgileri";
            this.tcpOgrBilgi.UseVisualStyleBackColor = true;
            // 
            // gbIletisim
            // 
            this.gbIletisim.Controls.Add(this.txtOgrAdres);
            this.gbIletisim.Controls.Add(this.label11);
            this.gbIletisim.Controls.Add(this.txtOgrTel);
            this.gbIletisim.Controls.Add(this.label10);
            this.gbIletisim.Controls.Add(this.txtOgrAciklama);
            this.gbIletisim.Controls.Add(this.label9);
            this.gbIletisim.Location = new System.Drawing.Point(274, 17);
            this.gbIletisim.Name = "gbIletisim";
            this.gbIletisim.Size = new System.Drawing.Size(272, 250);
            this.gbIletisim.TabIndex = 23;
            this.gbIletisim.TabStop = false;
            this.gbIletisim.Text = "İletişim";
            // 
            // txtOgrAdres
            // 
            this.txtOgrAdres.Location = new System.Drawing.Point(76, 51);
            this.txtOgrAdres.Multiline = true;
            this.txtOgrAdres.Name = "txtOgrAdres";
            this.txtOgrAdres.Size = new System.Drawing.Size(189, 78);
            this.txtOgrAdres.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Adres";
            // 
            // txtOgrTel
            // 
            this.txtOgrTel.Location = new System.Drawing.Point(76, 25);
            this.txtOgrTel.Name = "txtOgrTel";
            this.txtOgrTel.Size = new System.Drawing.Size(189, 21);
            this.txtOgrTel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Telefon";
            // 
            // txtOgrAciklama
            // 
            this.txtOgrAciklama.Location = new System.Drawing.Point(76, 135);
            this.txtOgrAciklama.Multiline = true;
            this.txtOgrAciklama.Name = "txtOgrAciklama";
            this.txtOgrAciklama.Size = new System.Drawing.Size(189, 100);
            this.txtOgrAciklama.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Açıklama";
            // 
            // gbBilgiler
            // 
            this.gbBilgiler.Controls.Add(this.cmbSozTaksit);
            this.gbBilgiler.Controls.Add(this.label8);
            this.gbBilgiler.Controls.Add(this.txtSozTutar);
            this.gbBilgiler.Controls.Add(this.label7);
            this.gbBilgiler.Controls.Add(this.dtpSozTar);
            this.gbBilgiler.Controls.Add(this.label6);
            this.gbBilgiler.Controls.Add(this.cmbCinsiyet);
            this.gbBilgiler.Controls.Add(this.label5);
            this.gbBilgiler.Controls.Add(this.txtKimNo);
            this.gbBilgiler.Controls.Add(this.label4);
            this.gbBilgiler.Controls.Add(this.txtOgrSoyadi);
            this.gbBilgiler.Controls.Add(this.label3);
            this.gbBilgiler.Controls.Add(this.txtOgrAdi);
            this.gbBilgiler.Controls.Add(this.label2);
            this.gbBilgiler.Controls.Add(this.txtOgrNo);
            this.gbBilgiler.Controls.Add(this.label1);
            this.gbBilgiler.Location = new System.Drawing.Point(13, 19);
            this.gbBilgiler.Name = "gbBilgiler";
            this.gbBilgiler.Size = new System.Drawing.Size(255, 248);
            this.gbBilgiler.TabIndex = 22;
            this.gbBilgiler.TabStop = false;
            this.gbBilgiler.Text = "Bilgiler";
            // 
            // cmbSozTaksit
            // 
            this.cmbSozTaksit.FormattingEnabled = true;
            this.cmbSozTaksit.Items.AddRange(new object[] {
            "Peşin",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbSozTaksit.Location = new System.Drawing.Point(90, 212);
            this.cmbSozTaksit.Name = "cmbSozTaksit";
            this.cmbSozTaksit.Size = new System.Drawing.Size(157, 23);
            this.cmbSozTaksit.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ödeme Şekli";
            // 
            // txtSozTutar
            // 
            this.txtSozTutar.Location = new System.Drawing.Point(90, 186);
            this.txtSozTutar.Name = "txtSozTutar";
            this.txtSozTutar.Size = new System.Drawing.Size(157, 21);
            this.txtSozTutar.TabIndex = 7;
            this.txtSozTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSozTutar_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Söz. Tutar";
            // 
            // dtpSozTar
            // 
            this.dtpSozTar.Location = new System.Drawing.Point(90, 160);
            this.dtpSozTar.Name = "dtpSozTar";
            this.dtpSozTar.Size = new System.Drawing.Size(157, 21);
            this.dtpSozTar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Söz Tarihi";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(90, 126);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(157, 23);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cinsiyet";
            // 
            // txtKimNo
            // 
            this.txtKimNo.Location = new System.Drawing.Point(90, 97);
            this.txtKimNo.MaxLength = 11;
            this.txtKimNo.Name = "txtKimNo";
            this.txtKimNo.Size = new System.Drawing.Size(157, 21);
            this.txtKimNo.TabIndex = 4;
            this.txtKimNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kimlik No";
            // 
            // txtOgrSoyadi
            // 
            this.txtOgrSoyadi.Location = new System.Drawing.Point(90, 71);
            this.txtOgrSoyadi.Name = "txtOgrSoyadi";
            this.txtOgrSoyadi.Size = new System.Drawing.Size(157, 21);
            this.txtOgrSoyadi.TabIndex = 3;
            this.txtOgrSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrSoyadi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyadi";
            // 
            // txtOgrAdi
            // 
            this.txtOgrAdi.Location = new System.Drawing.Point(90, 45);
            this.txtOgrAdi.Name = "txtOgrAdi";
            this.txtOgrAdi.Size = new System.Drawing.Size(157, 21);
            this.txtOgrAdi.TabIndex = 2;
            this.txtOgrAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(90, 19);
            this.txtOgrNo.MaxLength = 5;
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(157, 21);
            this.txtOgrNo.TabIndex = 1;
            this.txtOgrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Öğrenci No";
            // 
            // tcpVeli
            // 
            this.tcpVeli.Controls.Add(this.gbVeliKim);
            this.tcpVeli.Controls.Add(this.gbBaba);
            this.tcpVeli.Controls.Add(this.gbAnne);
            this.tcpVeli.Location = new System.Drawing.Point(4, 24);
            this.tcpVeli.Name = "tcpVeli";
            this.tcpVeli.Padding = new System.Windows.Forms.Padding(3);
            this.tcpVeli.Size = new System.Drawing.Size(552, 303);
            this.tcpVeli.TabIndex = 1;
            this.tcpVeli.Text = "Veli Bilgileri";
            this.tcpVeli.UseVisualStyleBackColor = true;
            // 
            // gbVeliKim
            // 
            this.gbVeliKim.Controls.Add(this.rdbAnne);
            this.gbVeliKim.Controls.Add(this.rdbBaba);
            this.gbVeliKim.Location = new System.Drawing.Point(195, 253);
            this.gbVeliKim.Name = "gbVeliKim";
            this.gbVeliKim.Size = new System.Drawing.Size(151, 46);
            this.gbVeliKim.TabIndex = 3;
            this.gbVeliKim.TabStop = false;
            this.gbVeliKim.Text = "Veli Bilgisi Seçiniz";
            // 
            // rdbAnne
            // 
            this.rdbAnne.AutoSize = true;
            this.rdbAnne.Location = new System.Drawing.Point(20, 19);
            this.rdbAnne.Name = "rdbAnne";
            this.rdbAnne.Size = new System.Drawing.Size(53, 19);
            this.rdbAnne.TabIndex = 3;
            this.rdbAnne.TabStop = true;
            this.rdbAnne.Text = "Anne";
            this.rdbAnne.UseVisualStyleBackColor = true;
            // 
            // rdbBaba
            // 
            this.rdbBaba.AutoSize = true;
            this.rdbBaba.Location = new System.Drawing.Point(78, 19);
            this.rdbBaba.Name = "rdbBaba";
            this.rdbBaba.Size = new System.Drawing.Size(54, 19);
            this.rdbBaba.TabIndex = 2;
            this.rdbBaba.TabStop = true;
            this.rdbBaba.Text = "Baba";
            this.rdbBaba.UseVisualStyleBackColor = true;
            // 
            // gbBaba
            // 
            this.gbBaba.Controls.Add(this.lblBabaID);
            this.gbBaba.Controls.Add(this.txtBabaAdres);
            this.gbBaba.Controls.Add(this.label21);
            this.gbBaba.Controls.Add(this.txtBabaMeslek);
            this.gbBaba.Controls.Add(this.label22);
            this.gbBaba.Controls.Add(this.txtBabaTel);
            this.gbBaba.Controls.Add(this.label23);
            this.gbBaba.Controls.Add(this.txtBabaKimlik);
            this.gbBaba.Controls.Add(this.label24);
            this.gbBaba.Controls.Add(this.txtBabaSoyad);
            this.gbBaba.Controls.Add(this.label25);
            this.gbBaba.Controls.Add(this.txtBabaAd);
            this.gbBaba.Controls.Add(this.label26);
            this.gbBaba.Location = new System.Drawing.Point(306, 20);
            this.gbBaba.Name = "gbBaba";
            this.gbBaba.Size = new System.Drawing.Size(228, 227);
            this.gbBaba.TabIndex = 2;
            this.gbBaba.TabStop = false;
            this.gbBaba.Text = "Baba Bilgileri";
            // 
            // lblBabaID
            // 
            this.lblBabaID.AutoSize = true;
            this.lblBabaID.Location = new System.Drawing.Point(4, 211);
            this.lblBabaID.Name = "lblBabaID";
            this.lblBabaID.Size = new System.Drawing.Size(14, 15);
            this.lblBabaID.TabIndex = 26;
            this.lblBabaID.Text = "0";
            this.lblBabaID.Visible = false;
            // 
            // txtBabaAdres
            // 
            this.txtBabaAdres.Location = new System.Drawing.Point(72, 156);
            this.txtBabaAdres.Multiline = true;
            this.txtBabaAdres.Name = "txtBabaAdres";
            this.txtBabaAdres.Size = new System.Drawing.Size(150, 56);
            this.txtBabaAdres.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "Adres";
            // 
            // txtBabaMeslek
            // 
            this.txtBabaMeslek.Location = new System.Drawing.Point(72, 130);
            this.txtBabaMeslek.Name = "txtBabaMeslek";
            this.txtBabaMeslek.Size = new System.Drawing.Size(150, 21);
            this.txtBabaMeslek.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 15);
            this.label22.TabIndex = 8;
            this.label22.Text = "Meslek";
            // 
            // txtBabaTel
            // 
            this.txtBabaTel.Location = new System.Drawing.Point(72, 104);
            this.txtBabaTel.Name = "txtBabaTel";
            this.txtBabaTel.Size = new System.Drawing.Size(150, 21);
            this.txtBabaTel.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 15);
            this.label23.TabIndex = 6;
            this.label23.Text = "Telefon";
            // 
            // txtBabaKimlik
            // 
            this.txtBabaKimlik.Location = new System.Drawing.Point(72, 79);
            this.txtBabaKimlik.MaxLength = 11;
            this.txtBabaKimlik.Name = "txtBabaKimlik";
            this.txtBabaKimlik.Size = new System.Drawing.Size(150, 21);
            this.txtBabaKimlik.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 4;
            this.label24.Text = "Kimlik  No";
            // 
            // txtBabaSoyad
            // 
            this.txtBabaSoyad.Location = new System.Drawing.Point(72, 54);
            this.txtBabaSoyad.Name = "txtBabaSoyad";
            this.txtBabaSoyad.Size = new System.Drawing.Size(150, 21);
            this.txtBabaSoyad.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "Soyadı";
            // 
            // txtBabaAd
            // 
            this.txtBabaAd.Location = new System.Drawing.Point(72, 30);
            this.txtBabaAd.Name = "txtBabaAd";
            this.txtBabaAd.Size = new System.Drawing.Size(150, 21);
            this.txtBabaAd.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "Adı";
            // 
            // gbAnne
            // 
            this.gbAnne.Controls.Add(this.lblAnneID);
            this.gbAnne.Controls.Add(this.txtAnneAdres);
            this.gbAnne.Controls.Add(this.label20);
            this.gbAnne.Controls.Add(this.txtAnneMeslek);
            this.gbAnne.Controls.Add(this.label19);
            this.gbAnne.Controls.Add(this.txtAnneTel);
            this.gbAnne.Controls.Add(this.label18);
            this.gbAnne.Controls.Add(this.txtAnneKimlik);
            this.gbAnne.Controls.Add(this.label17);
            this.gbAnne.Controls.Add(this.txtAnneSoyadi);
            this.gbAnne.Controls.Add(this.label16);
            this.gbAnne.Controls.Add(this.txtAnneAdi);
            this.gbAnne.Controls.Add(this.label12);
            this.gbAnne.Location = new System.Drawing.Point(16, 20);
            this.gbAnne.Name = "gbAnne";
            this.gbAnne.Size = new System.Drawing.Size(228, 227);
            this.gbAnne.TabIndex = 1;
            this.gbAnne.TabStop = false;
            this.gbAnne.Text = "Anne Bilgileri";
            // 
            // lblAnneID
            // 
            this.lblAnneID.AutoSize = true;
            this.lblAnneID.Location = new System.Drawing.Point(4, 211);
            this.lblAnneID.Name = "lblAnneID";
            this.lblAnneID.Size = new System.Drawing.Size(14, 15);
            this.lblAnneID.TabIndex = 25;
            this.lblAnneID.Text = "0";
            this.lblAnneID.Visible = false;
            // 
            // txtAnneAdres
            // 
            this.txtAnneAdres.Location = new System.Drawing.Point(72, 154);
            this.txtAnneAdres.Multiline = true;
            this.txtAnneAdres.Name = "txtAnneAdres";
            this.txtAnneAdres.Size = new System.Drawing.Size(150, 56);
            this.txtAnneAdres.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Adres";
            // 
            // txtAnneMeslek
            // 
            this.txtAnneMeslek.Location = new System.Drawing.Point(72, 129);
            this.txtAnneMeslek.Name = "txtAnneMeslek";
            this.txtAnneMeslek.Size = new System.Drawing.Size(150, 21);
            this.txtAnneMeslek.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Meslek";
            // 
            // txtAnneTel
            // 
            this.txtAnneTel.Location = new System.Drawing.Point(72, 103);
            this.txtAnneTel.Name = "txtAnneTel";
            this.txtAnneTel.Size = new System.Drawing.Size(150, 21);
            this.txtAnneTel.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Telefon";
            // 
            // txtAnneKimlik
            // 
            this.txtAnneKimlik.Location = new System.Drawing.Point(72, 78);
            this.txtAnneKimlik.MaxLength = 11;
            this.txtAnneKimlik.Name = "txtAnneKimlik";
            this.txtAnneKimlik.Size = new System.Drawing.Size(150, 21);
            this.txtAnneKimlik.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Kimlik  No";
            // 
            // txtAnneSoyadi
            // 
            this.txtAnneSoyadi.Location = new System.Drawing.Point(72, 54);
            this.txtAnneSoyadi.Name = "txtAnneSoyadi";
            this.txtAnneSoyadi.Size = new System.Drawing.Size(150, 21);
            this.txtAnneSoyadi.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Soyadı";
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(72, 30);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(150, 21);
            this.txtAnneAdi.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adı";
            // 
            // tbOdemeler
            // 
            this.tbOdemeler.Controls.Add(this.label13);
            this.tbOdemeler.Controls.Add(this.dgOgrOdemeList);
            this.tbOdemeler.Location = new System.Drawing.Point(4, 24);
            this.tbOdemeler.Name = "tbOdemeler";
            this.tbOdemeler.Padding = new System.Windows.Forms.Padding(3);
            this.tbOdemeler.Size = new System.Drawing.Size(552, 303);
            this.tbOdemeler.TabIndex = 2;
            this.tbOdemeler.Text = "Ödemeler";
            this.tbOdemeler.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(174, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Öğrenci Ödeme Bilgileri";
            // 
            // dgOgrOdemeList
            // 
            this.dgOgrOdemeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrOdemeList.Location = new System.Drawing.Point(6, 68);
            this.dgOgrOdemeList.Name = "dgOgrOdemeList";
            this.dgOgrOdemeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOgrOdemeList.Size = new System.Drawing.Size(540, 220);
            this.dgOgrOdemeList.TabIndex = 0;
            this.dgOgrOdemeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrOdemeList_CellClick);
            this.dgOgrOdemeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrOdemeList_CellContentClick);
            // 
            // lblOgrID
            // 
            this.lblOgrID.AutoSize = true;
            this.lblOgrID.Location = new System.Drawing.Point(13, 356);
            this.lblOgrID.Name = "lblOgrID";
            this.lblOgrID.Size = new System.Drawing.Size(13, 13);
            this.lblOgrID.TabIndex = 24;
            this.lblOgrID.Text = "0";
            this.lblOgrID.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(545, 349);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 45);
            this.btnKaydet.TabIndex = 13;
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
            this.btnSil.Location = new System.Drawing.Point(636, 349);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 45);
            this.btnSil.TabIndex = 14;
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
            this.btnKapat.Location = new System.Drawing.Point(818, 349);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 45);
            this.btnKapat.TabIndex = 15;
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
            this.btnYeni.Location = new System.Drawing.Point(454, 349);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 45);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gbOgrSorgula
            // 
            this.gbOgrSorgula.Controls.Add(this.chkAyrilan);
            this.gbOgrSorgula.Controls.Add(this.dgOgrenciList);
            this.gbOgrSorgula.Controls.Add(this.btnHepsiAra);
            this.gbOgrSorgula.Controls.Add(this.txtOgrNoAra);
            this.gbOgrSorgula.Controls.Add(this.label15);
            this.gbOgrSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOgrSorgula.Location = new System.Drawing.Point(578, 12);
            this.gbOgrSorgula.Name = "gbOgrSorgula";
            this.gbOgrSorgula.Size = new System.Drawing.Size(326, 331);
            this.gbOgrSorgula.TabIndex = 18;
            this.gbOgrSorgula.TabStop = false;
            this.gbOgrSorgula.Text = "Öğrenci Sorgula";
            // 
            // chkAyrilan
            // 
            this.chkAyrilan.AutoSize = true;
            this.chkAyrilan.Location = new System.Drawing.Point(131, 109);
            this.chkAyrilan.Name = "chkAyrilan";
            this.chkAyrilan.Size = new System.Drawing.Size(178, 19);
            this.chkAyrilan.TabIndex = 60;
            this.chkAyrilan.Text = "Ayrılan Öğrencileride Listele";
            this.chkAyrilan.UseVisualStyleBackColor = true;
            // 
            // dgOgrenciList
            // 
            this.dgOgrenciList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciList.Location = new System.Drawing.Point(16, 132);
            this.dgOgrenciList.Name = "dgOgrenciList";
            this.dgOgrenciList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOgrenciList.Size = new System.Drawing.Size(293, 193);
            this.dgOgrenciList.TabIndex = 59;
            this.dgOgrenciList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciList_CellClick);
            this.dgOgrenciList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciList_CellContentClick);
            // 
            // btnHepsiAra
            // 
            this.btnHepsiAra.BackColor = System.Drawing.Color.White;
            this.btnHepsiAra.Location = new System.Drawing.Point(16, 60);
            this.btnHepsiAra.Name = "btnHepsiAra";
            this.btnHepsiAra.Size = new System.Drawing.Size(293, 43);
            this.btnHepsiAra.TabIndex = 58;
            this.btnHepsiAra.Text = "Bütün Öğrencileri Listele";
            this.btnHepsiAra.UseVisualStyleBackColor = false;
            this.btnHepsiAra.Click += new System.EventHandler(this.btnHepsiAra_Click);
            // 
            // txtOgrNoAra
            // 
            this.txtOgrNoAra.Location = new System.Drawing.Point(81, 34);
            this.txtOgrNoAra.Name = "txtOgrNoAra";
            this.txtOgrNoAra.Size = new System.Drawing.Size(228, 21);
            this.txtOgrNoAra.TabIndex = 1;
            this.txtOgrNoAra.TextChanged += new System.EventHandler(this.txtOgrNoAra_TextChanged);
            this.txtOgrNoAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrNoAra_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Öğrenci No";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(727, 349);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(85, 45);
            this.btnYazdir.TabIndex = 26;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 399);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblOgrID);
            this.Controls.Add(this.gbOgrSorgula);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.tcOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenci";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            this.tcOgrenci.ResumeLayout(false);
            this.tcpOgrBilgi.ResumeLayout(false);
            this.gbIletisim.ResumeLayout(false);
            this.gbIletisim.PerformLayout();
            this.gbBilgiler.ResumeLayout(false);
            this.gbBilgiler.PerformLayout();
            this.tcpVeli.ResumeLayout(false);
            this.gbVeliKim.ResumeLayout(false);
            this.gbVeliKim.PerformLayout();
            this.gbBaba.ResumeLayout(false);
            this.gbBaba.PerformLayout();
            this.gbAnne.ResumeLayout(false);
            this.gbAnne.PerformLayout();
            this.tbOdemeler.ResumeLayout(false);
            this.tbOdemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrOdemeList)).EndInit();
            this.gbOgrSorgula.ResumeLayout(false);
            this.gbOgrSorgula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcOgrenci;
        private System.Windows.Forms.TabPage tcpOgrBilgi;
        private System.Windows.Forms.TabPage tcpVeli;
        private System.Windows.Forms.GroupBox gbIletisim;
        private System.Windows.Forms.TextBox txtOgrAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOgrTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgrAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbBilgiler;
        private System.Windows.Forms.ComboBox cmbSozTaksit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSozTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSozTar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKimNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblOgrID;
        private System.Windows.Forms.GroupBox gbOgrSorgula;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.DataGridView dgOgrenciList;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.TextBox txtOgrNoAra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbAnne;
        private System.Windows.Forms.TextBox txtAnneAdres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAnneMeslek;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAnneTel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAnneKimlik;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAnneSoyadi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbBaba;
        private System.Windows.Forms.TextBox txtBabaAdres;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBabaMeslek;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBabaTel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBabaKimlik;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBabaSoyad;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtBabaAd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbVeliKim;
        private System.Windows.Forms.Label lblBabaID;
        private System.Windows.Forms.Label lblAnneID;
        private System.Windows.Forms.RadioButton rdbAnne;
        private System.Windows.Forms.RadioButton rdbBaba;
        private System.Windows.Forms.TabPage tbOdemeler;
        private System.Windows.Forms.DataGridView dgOgrOdemeList;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label13;
    }
}