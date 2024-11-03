namespace DershaneOtomasyon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDersBilgi = new System.Windows.Forms.Button();
            this.btnOgrOdeme = new System.Windows.Forms.Button();
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            this.btnKasaIslemler = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnOgrenciIsleri = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 121);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnDersBilgi);
            this.tabPage1.Controls.Add(this.btnOgrOdeme);
            this.tabPage1.Controls.Add(this.btnOdemeEkle);
            this.tabPage1.Controls.Add(this.btnKasaIslemler);
            this.tabPage1.Controls.Add(this.btnPersonel);
            this.tabPage1.Controls.Add(this.btnOgrenciIsleri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 95);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dershane Otomasyon";
            // 
            // btnDersBilgi
            // 
            this.btnDersBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersBilgi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDersBilgi.FlatAppearance.BorderSize = 0;
            this.btnDersBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDersBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDersBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersBilgi.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDersBilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnDersBilgi.Image")));
            this.btnDersBilgi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDersBilgi.Location = new System.Drawing.Point(414, -1);
            this.btnDersBilgi.Name = "btnDersBilgi";
            this.btnDersBilgi.Size = new System.Drawing.Size(83, 99);
            this.btnDersBilgi.TabIndex = 5;
            this.btnDersBilgi.Text = "Dershane Bilgi";
            this.btnDersBilgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDersBilgi.UseVisualStyleBackColor = true;
            this.btnDersBilgi.Click += new System.EventHandler(this.btnDersBilgi_Click);
            // 
            // btnOgrOdeme
            // 
            this.btnOgrOdeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrOdeme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOgrOdeme.FlatAppearance.BorderSize = 0;
            this.btnOgrOdeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOgrOdeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOgrOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrOdeme.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnOgrOdeme.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrOdeme.Image")));
            this.btnOgrOdeme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrOdeme.Location = new System.Drawing.Point(331, -3);
            this.btnOgrOdeme.Name = "btnOgrOdeme";
            this.btnOgrOdeme.Size = new System.Drawing.Size(83, 99);
            this.btnOgrOdeme.TabIndex = 4;
            this.btnOgrOdeme.Text = "Öğrenci Ödeme";
            this.btnOgrOdeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrOdeme.UseVisualStyleBackColor = true;
            this.btnOgrOdeme.Click += new System.EventHandler(this.btnOgrOdeme_Click);
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdemeEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdemeEkle.FlatAppearance.BorderSize = 0;
            this.btnOdemeEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOdemeEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOdemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeEkle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnOdemeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeEkle.Image")));
            this.btnOdemeEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdemeEkle.Location = new System.Drawing.Point(249, -1);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(83, 99);
            this.btnOdemeEkle.TabIndex = 3;
            this.btnOdemeEkle.Text = "Ödeme İşlemleri";
            this.btnOdemeEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdemeEkle.UseVisualStyleBackColor = true;
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // btnKasaIslemler
            // 
            this.btnKasaIslemler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasaIslemler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKasaIslemler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKasaIslemler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnKasaIslemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasaIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaIslemler.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnKasaIslemler.Image = ((System.Drawing.Image)(resources.GetObject("btnKasaIslemler.Image")));
            this.btnKasaIslemler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasaIslemler.Location = new System.Drawing.Point(166, 0);
            this.btnKasaIslemler.Name = "btnKasaIslemler";
            this.btnKasaIslemler.Size = new System.Drawing.Size(83, 99);
            this.btnKasaIslemler.TabIndex = 2;
            this.btnKasaIslemler.Text = "Kasa İşlemleri";
            this.btnKasaIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasaIslemler.UseVisualStyleBackColor = true;
            this.btnKasaIslemler.Click += new System.EventHandler(this.btnKasaIslemler_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonel.Location = new System.Drawing.Point(83, 0);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(83, 99);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "Personel İşlemler";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnOgrenciIsleri
            // 
            this.btnOgrenciIsleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenciIsleri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOgrenciIsleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOgrenciIsleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOgrenciIsleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciIsleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciIsleri.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnOgrenciIsleri.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenciIsleri.Image")));
            this.btnOgrenciIsleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrenciIsleri.Location = new System.Drawing.Point(0, 0);
            this.btnOgrenciIsleri.Name = "btnOgrenciIsleri";
            this.btnOgrenciIsleri.Size = new System.Drawing.Size(83, 99);
            this.btnOgrenciIsleri.TabIndex = 0;
            this.btnOgrenciIsleri.Text = "Öğrenci İşlemler";
            this.btnOgrenciIsleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciIsleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIsleri.Click += new System.EventHandler(this.btnOgrenciIsleri_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yardım";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 414);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERSHANE OTOMASYON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOgrenciIsleri;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnKasaIslemler;
        private System.Windows.Forms.Button btnDersBilgi;
        private System.Windows.Forms.Button btnOgrOdeme;
        private System.Windows.Forms.Button btnOdemeEkle;
    }
}

