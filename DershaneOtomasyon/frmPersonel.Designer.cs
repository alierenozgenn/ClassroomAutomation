namespace DershaneOtomasyon
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbIletisim = new System.Windows.Forms.GroupBox();
            this.txtPrsMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrsAdres = new System.Windows.Forms.TextBox();
            this.txtPrsTel = new System.Windows.Forms.TextBox();
            this.gbIBilgiler = new System.Windows.Forms.GroupBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkOgretmen = new System.Windows.Forms.CheckBox();
            this.rdbPasif = new System.Windows.Forms.RadioButton();
            this.rdbAktif = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrsEkUcret = new System.Windows.Forms.TextBox();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.txtPrsSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrsBrans = new System.Windows.Forms.TextBox();
            this.txtPrsMaas = new System.Windows.Forms.TextBox();
            this.txtPrsAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dgPersonelOdeme = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgPrsListe = new System.Windows.Forms.DataGridView();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.txtPrsAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbIletisim.SuspendLayout();
            this.gbIBilgiler.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelOdeme)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrsListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 347);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.gbIletisim);
            this.tabPage1.Controls.Add(this.gbIBilgiler);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gbIletisim
            // 
            this.gbIletisim.Controls.Add(this.txtPrsMail);
            this.gbIletisim.Controls.Add(this.label7);
            this.gbIletisim.Controls.Add(this.label8);
            this.gbIletisim.Controls.Add(this.label9);
            this.gbIletisim.Controls.Add(this.txtPrsAdres);
            this.gbIletisim.Controls.Add(this.txtPrsTel);
            this.gbIletisim.Location = new System.Drawing.Point(303, 23);
            this.gbIletisim.Name = "gbIletisim";
            this.gbIletisim.Size = new System.Drawing.Size(264, 275);
            this.gbIletisim.TabIndex = 47;
            this.gbIletisim.TabStop = false;
            this.gbIletisim.Text = "İletişim";
            // 
            // txtPrsMail
            // 
            this.txtPrsMail.Location = new System.Drawing.Point(84, 53);
            this.txtPrsMail.Name = "txtPrsMail";
            this.txtPrsMail.Size = new System.Drawing.Size(166, 21);
            this.txtPrsMail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tel.";
            // 
            // txtPrsAdres
            // 
            this.txtPrsAdres.Location = new System.Drawing.Point(84, 83);
            this.txtPrsAdres.Multiline = true;
            this.txtPrsAdres.Name = "txtPrsAdres";
            this.txtPrsAdres.Size = new System.Drawing.Size(166, 78);
            this.txtPrsAdres.TabIndex = 12;
            // 
            // txtPrsTel
            // 
            this.txtPrsTel.Location = new System.Drawing.Point(84, 22);
            this.txtPrsTel.Name = "txtPrsTel";
            this.txtPrsTel.Size = new System.Drawing.Size(166, 21);
            this.txtPrsTel.TabIndex = 10;
            this.txtPrsTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsTel_KeyPress);
            // 
            // gbIBilgiler
            // 
            this.gbIBilgiler.Controls.Add(this.txtKimlikNo);
            this.gbIBilgiler.Controls.Add(this.label11);
            this.gbIBilgiler.Controls.Add(this.txtPrsEkUcret);
            this.gbIBilgiler.Controls.Add(this.chkOgretmen);
            this.gbIBilgiler.Controls.Add(this.rdbPasif);
            this.gbIBilgiler.Controls.Add(this.rdbAktif);
            this.gbIBilgiler.Controls.Add(this.label6);
            this.gbIBilgiler.Controls.Add(this.lblPersonelID);
            this.gbIBilgiler.Controls.Add(this.txtPrsSoyad);
            this.gbIBilgiler.Controls.Add(this.label5);
            this.gbIBilgiler.Controls.Add(this.label4);
            this.gbIBilgiler.Controls.Add(this.label3);
            this.gbIBilgiler.Controls.Add(this.label2);
            this.gbIBilgiler.Controls.Add(this.label1);
            this.gbIBilgiler.Controls.Add(this.txtPrsBrans);
            this.gbIBilgiler.Controls.Add(this.txtPrsMaas);
            this.gbIBilgiler.Controls.Add(this.txtPrsAdi);
            this.gbIBilgiler.Location = new System.Drawing.Point(21, 23);
            this.gbIBilgiler.Name = "gbIBilgiler";
            this.gbIBilgiler.Size = new System.Drawing.Size(264, 275);
            this.gbIBilgiler.TabIndex = 46;
            this.gbIBilgiler.TabStop = false;
            this.gbIBilgiler.Text = "Bilgiler";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(80, 78);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(170, 21);
            this.txtKimlikNo.TabIndex = 3;
            this.txtKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimlikNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Kimlik No";
            // 
            // chkOgretmen
            // 
            this.chkOgretmen.AutoSize = true;
            this.chkOgretmen.Location = new System.Drawing.Point(79, 242);
            this.chkOgretmen.Name = "chkOgretmen";
            this.chkOgretmen.Size = new System.Drawing.Size(105, 19);
            this.chkOgretmen.TabIndex = 9;
            this.chkOgretmen.Text = "Öğretmen mi?";
            this.chkOgretmen.UseVisualStyleBackColor = true;
            // 
            // rdbPasif
            // 
            this.rdbPasif.AutoSize = true;
            this.rdbPasif.Location = new System.Drawing.Point(166, 203);
            this.rdbPasif.Name = "rdbPasif";
            this.rdbPasif.Size = new System.Drawing.Size(52, 19);
            this.rdbPasif.TabIndex = 8;
            this.rdbPasif.TabStop = true;
            this.rdbPasif.Text = "Pasif";
            this.rdbPasif.UseVisualStyleBackColor = true;
            // 
            // rdbAktif
            // 
            this.rdbAktif.AutoSize = true;
            this.rdbAktif.Location = new System.Drawing.Point(80, 203);
            this.rdbAktif.Name = "rdbAktif";
            this.rdbAktif.Size = new System.Drawing.Size(47, 19);
            this.rdbAktif.TabIndex = 7;
            this.rdbAktif.TabStop = true;
            this.rdbAktif.Text = "Aktif";
            this.rdbAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ek Ücret";
            // 
            // txtPrsEkUcret
            // 
            this.txtPrsEkUcret.Location = new System.Drawing.Point(79, 170);
            this.txtPrsEkUcret.Name = "txtPrsEkUcret";
            this.txtPrsEkUcret.Size = new System.Drawing.Size(171, 21);
            this.txtPrsEkUcret.TabIndex = 5;
            this.txtPrsEkUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsEkUcret_KeyPress);
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(192, 230);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(14, 15);
            this.lblPersonelID.TabIndex = 59;
            this.lblPersonelID.Text = "0";
            this.lblPersonelID.Visible = false;
            // 
            // txtPrsSoyad
            // 
            this.txtPrsSoyad.Location = new System.Drawing.Point(80, 51);
            this.txtPrsSoyad.Name = "txtPrsSoyad";
            this.txtPrsSoyad.Size = new System.Drawing.Size(170, 21);
            this.txtPrsSoyad.TabIndex = 2;
            this.txtPrsSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsSoyad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ünvanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Adı";
            // 
            // txtPrsBrans
            // 
            this.txtPrsBrans.Location = new System.Drawing.Point(80, 108);
            this.txtPrsBrans.Name = "txtPrsBrans";
            this.txtPrsBrans.Size = new System.Drawing.Size(170, 21);
            this.txtPrsBrans.TabIndex = 4;
            this.txtPrsBrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsBrans_KeyPress);
            // 
            // txtPrsMaas
            // 
            this.txtPrsMaas.Location = new System.Drawing.Point(80, 140);
            this.txtPrsMaas.Name = "txtPrsMaas";
            this.txtPrsMaas.Size = new System.Drawing.Size(170, 21);
            this.txtPrsMaas.TabIndex = 6;
            this.txtPrsMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsMaas_KeyPress);
            // 
            // txtPrsAdi
            // 
            this.txtPrsAdi.Location = new System.Drawing.Point(80, 19);
            this.txtPrsAdi.Name = "txtPrsAdi";
            this.txtPrsAdi.Size = new System.Drawing.Size(170, 21);
            this.txtPrsAdi.TabIndex = 1;
            this.txtPrsAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsAdi_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dgPersonelOdeme);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödemeler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(195, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Personele Ait Ödeme Listesi";
            // 
            // dgPersonelOdeme
            // 
            this.dgPersonelOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonelOdeme.Location = new System.Drawing.Point(14, 37);
            this.dgPersonelOdeme.Name = "dgPersonelOdeme";
            this.dgPersonelOdeme.Size = new System.Drawing.Size(553, 290);
            this.dgPersonelOdeme.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgPrsListe);
            this.groupBox3.Controls.Add(this.btnHepsiAra);
            this.groupBox3.Controls.Add(this.chkAyrilan);
            this.groupBox3.Controls.Add(this.txtPrsAra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(600, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 345);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Ara";
            // 
            // dgPrsListe
            // 
            this.dgPrsListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrsListe.Location = new System.Drawing.Point(15, 132);
            this.dgPrsListe.Name = "dgPrsListe";
            this.dgPrsListe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgPrsListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrsListe.Size = new System.Drawing.Size(325, 201);
            this.dgPrsListe.TabIndex = 64;
            this.dgPrsListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrsListe_CellClick);
            // 
            // btnHepsiAra
            // 
            this.btnHepsiAra.BackColor = System.Drawing.Color.White;
            this.btnHepsiAra.Location = new System.Drawing.Point(15, 52);
            this.btnHepsiAra.Name = "btnHepsiAra";
            this.btnHepsiAra.Size = new System.Drawing.Size(325, 46);
            this.btnHepsiAra.TabIndex = 56;
            this.btnHepsiAra.Text = "Bütün Personelleri Listele";
            this.btnHepsiAra.UseVisualStyleBackColor = false;
            this.btnHepsiAra.Click += new System.EventHandler(this.btnHepsiAra_Click);
            // 
            // chkAyrilan
            // 
            this.chkAyrilan.AutoSize = true;
            this.chkAyrilan.Location = new System.Drawing.Point(153, 107);
            this.chkAyrilan.Name = "chkAyrilan";
            this.chkAyrilan.Size = new System.Drawing.Size(184, 19);
            this.chkAyrilan.TabIndex = 47;
            this.chkAyrilan.Text = "Ayrılan Personelleride Listele";
            this.chkAyrilan.UseVisualStyleBackColor = true;
            // 
            // txtPrsAra
            // 
            this.txtPrsAra.Location = new System.Drawing.Point(135, 23);
            this.txtPrsAra.Name = "txtPrsAra";
            this.txtPrsAra.Size = new System.Drawing.Size(203, 21);
            this.txtPrsAra.TabIndex = 46;
            this.txtPrsAra.TextChanged += new System.EventHandler(this.txtPrsAra_TextChanged);
            this.txtPrsAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrsAra_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Personel Kimlik No";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(778, 359);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(85, 45);
            this.btnYazdir.TabIndex = 63;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(596, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 45);
            this.btnKaydet.TabIndex = 60;
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
            this.btnSil.Location = new System.Drawing.Point(687, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 45);
            this.btnSil.TabIndex = 61;
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
            this.btnKapat.Location = new System.Drawing.Point(869, 359);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 45);
            this.btnKapat.TabIndex = 62;
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
            this.btnYeni.Location = new System.Drawing.Point(505, 359);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 45);
            this.btnYeni.TabIndex = 59;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 419);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.ogretmenler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbIletisim.ResumeLayout(false);
            this.gbIletisim.PerformLayout();
            this.gbIBilgiler.ResumeLayout(false);
            this.gbIBilgiler.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelOdeme)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrsListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbIBilgiler;
        private System.Windows.Forms.CheckBox chkOgretmen;
        private System.Windows.Forms.RadioButton rdbPasif;
        private System.Windows.Forms.RadioButton rdbAktif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrsEkUcret;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.TextBox txtPrsSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrsBrans;
        private System.Windows.Forms.TextBox txtPrsMaas;
        private System.Windows.Forms.TextBox txtPrsAdi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbIletisim;
        private System.Windows.Forms.TextBox txtPrsMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrsAdres;
        private System.Windows.Forms.TextBox txtPrsTel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.TextBox txtPrsAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgPersonelOdeme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridView dgPrsListe;
    }
}