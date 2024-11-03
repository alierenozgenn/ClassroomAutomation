namespace DershaneOtomasyon
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.gbOdeme = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKisi = new System.Windows.Forms.Button();
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
            this.lblOdemeID = new System.Windows.Forms.Label();
            this.dgOdemeTaksit = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOdeme
            // 
            this.gbOdeme.Controls.Add(this.btnKapat);
            this.gbOdeme.Controls.Add(this.btnKaydet);
            this.gbOdeme.Controls.Add(this.btnKisi);
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
            this.gbOdeme.Location = new System.Drawing.Point(8, 6);
            this.gbOdeme.Name = "gbOdeme";
            this.gbOdeme.Size = new System.Drawing.Size(262, 344);
            this.gbOdeme.TabIndex = 0;
            this.gbOdeme.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(149, 287);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 45);
            this.btnKapat.TabIndex = 17;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(17, 287);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 45);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKisi
            // 
            this.btnKisi.BackColor = System.Drawing.Color.White;
            this.btnKisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKisi.FlatAppearance.BorderSize = 0;
            this.btnKisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnKisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKisi.Location = new System.Drawing.Point(216, 245);
            this.btnKisi.Name = "btnKisi";
            this.btnKisi.Size = new System.Drawing.Size(31, 27);
            this.btnKisi.TabIndex = 39;
            this.btnKisi.Text = "...";
            this.btnKisi.UseVisualStyleBackColor = false;
            this.btnKisi.Click += new System.EventHandler(this.btnKisi_Click);
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
            this.cmbOdSekli.Location = new System.Drawing.Point(99, 60);
            this.cmbOdSekli.Name = "cmbOdSekli";
            this.cmbOdSekli.Size = new System.Drawing.Size(147, 23);
            this.cmbOdSekli.TabIndex = 38;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(99, 217);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(147, 21);
            this.txtAciklama.TabIndex = 35;
            this.txtAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAciklama_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Açıklama";
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(99, 247);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(116, 21);
            this.txtOgrenci.TabIndex = 33;
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Location = new System.Drawing.Point(14, 255);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(50, 15);
            this.lblKisi.TabIndex = 32;
            this.lblKisi.Text = "Öğrenci";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(99, 187);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(147, 21);
            this.txtBelgeNo.TabIndex = 31;
            this.txtBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBelgeNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Belge No";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(99, 157);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(147, 21);
            this.txtTutar.TabIndex = 29;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "İşlem Tutarı";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(98, 127);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(149, 21);
            this.dtpTarih.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "İşlem Tarihi";
            // 
            // cmbIslem
            // 
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "Öğrenci Geliri",
            "Diğer"});
            this.cmbIslem.Location = new System.Drawing.Point(98, 95);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(149, 23);
            this.cmbIslem.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "İşlem";
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Location = new System.Drawing.Point(159, 23);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(55, 19);
            this.rdbGider.TabIndex = 23;
            this.rdbGider.TabStop = true;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            this.rdbGider.CheckedChanged += new System.EventHandler(this.rdbGider_CheckedChanged);
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Location = new System.Drawing.Point(99, 23);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(51, 19);
            this.rdbGelir.TabIndex = 22;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            this.rdbGelir.CheckedChanged += new System.EventHandler(this.rdbGelir_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "İşlem Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "İşlem Şekli";
            // 
            // lblOdemeID
            // 
            this.lblOdemeID.AutoSize = true;
            this.lblOdemeID.Location = new System.Drawing.Point(206, 373);
            this.lblOdemeID.Name = "lblOdemeID";
            this.lblOdemeID.Size = new System.Drawing.Size(14, 15);
            this.lblOdemeID.TabIndex = 1;
            this.lblOdemeID.Text = "0";
            this.lblOdemeID.Visible = false;
            // 
            // dgOdemeTaksit
            // 
            this.dgOdemeTaksit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOdemeTaksit.Location = new System.Drawing.Point(281, 33);
            this.dgOdemeTaksit.Name = "dgOdemeTaksit";
            this.dgOdemeTaksit.Size = new System.Drawing.Size(552, 314);
            this.dgOdemeTaksit.TabIndex = 2;
            this.dgOdemeTaksit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOdemeTaksit_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(446, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ödeme Yapılacak Vadeyi Seçiniz";
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgOdemeTaksit);
            this.Controls.Add(this.lblOdemeID);
            this.Controls.Add(this.gbOdeme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdeme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme Ekle";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.gbOdeme.ResumeLayout(false);
            this.gbOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnKisi;
        private System.Windows.Forms.Label lblOdemeID;
        private System.Windows.Forms.DataGridView dgOdemeTaksit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}