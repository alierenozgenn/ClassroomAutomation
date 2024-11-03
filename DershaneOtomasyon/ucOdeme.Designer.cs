namespace DershaneOtomasyon
{
    partial class ucOdeme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbGelir = new System.Windows.Forms.RadioButton();
            this.rdbGider = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.cmbOdSekli = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Şekli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlem Türü";
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Location = new System.Drawing.Point(102, 47);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(46, 17);
            this.rdbGelir.TabIndex = 3;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Location = new System.Drawing.Point(153, 47);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(50, 17);
            this.rdbGider.TabIndex = 4;
            this.rdbGider.TabStop = true;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşlem";
            // 
            // cmbIslem
            // 
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "Öğrenci Geliri",
            "Diğer"});
            this.cmbIslem.Location = new System.Drawing.Point(101, 109);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(101, 21);
            this.cmbIslem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İşlem Tarihi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(101, 137);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(101, 20);
            this.dtpTarih.TabIndex = 8;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(102, 163);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "İşlem Tutarı";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(102, 189);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Belge No";
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(102, 241);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenci.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Öğrenci";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(102, 215);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 20);
            this.txtAciklama.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Açıklama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 281);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(128, 281);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 30);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.cmbOdSekli.Location = new System.Drawing.Point(102, 79);
            this.cmbOdSekli.Name = "cmbOdSekli";
            this.cmbOdSekli.Size = new System.Drawing.Size(101, 21);
            this.cmbOdSekli.TabIndex = 19;
            // 
            // ucOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbOdSekli);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOgrenci);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbGider);
            this.Controls.Add(this.rdbGelir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucOdeme";
            this.Size = new System.Drawing.Size(259, 349);
            this.Load += new System.EventHandler(this.ucOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbGelir;
        private System.Windows.Forms.RadioButton rdbGider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbOdSekli;
    }
}
