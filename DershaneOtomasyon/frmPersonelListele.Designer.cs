namespace DershaneOtomasyon
{
    partial class frmPersonelListele
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.txtPrsAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgPrsListe = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrsListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHepsiAra);
            this.groupBox3.Controls.Add(this.btnAra);
            this.groupBox3.Controls.Add(this.chkAyrilan);
            this.groupBox3.Controls.Add(this.txtPrsAra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 380);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Ara";
            // 
            // btnHepsiAra
            // 
            this.btnHepsiAra.BackColor = System.Drawing.Color.White;
            this.btnHepsiAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHepsiAra.Location = new System.Drawing.Point(99, 76);
            this.btnHepsiAra.Name = "btnHepsiAra";
            this.btnHepsiAra.Size = new System.Drawing.Size(220, 27);
            this.btnHepsiAra.TabIndex = 56;
            this.btnHepsiAra.Text = "Bütün Personelleri listele";
            this.btnHepsiAra.UseVisualStyleBackColor = false;
            this.btnHepsiAra.Click += new System.EventHandler(this.btnHepsiAra_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAra.Location = new System.Drawing.Point(18, 76);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 27);
            this.btnAra.TabIndex = 55;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // chkAyrilan
            // 
            this.chkAyrilan.AutoSize = true;
            this.chkAyrilan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAyrilan.Location = new System.Drawing.Point(116, 50);
            this.chkAyrilan.Name = "chkAyrilan";
            this.chkAyrilan.Size = new System.Drawing.Size(159, 17);
            this.chkAyrilan.TabIndex = 47;
            this.chkAyrilan.Text = "Ayrılan Personelleride Listele";
            this.chkAyrilan.UseVisualStyleBackColor = true;
            // 
            // txtPrsAra
            // 
            this.txtPrsAra.Location = new System.Drawing.Point(116, 20);
            this.txtPrsAra.Name = "txtPrsAra";
            this.txtPrsAra.Size = new System.Drawing.Size(146, 20);
            this.txtPrsAra.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Personel Kimlik No";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgPrsListe);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(6, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 266);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // dgPrsListe
            // 
            this.dgPrsListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrsListe.Location = new System.Drawing.Point(6, 5);
            this.dgPrsListe.Name = "dgPrsListe";
            this.dgPrsListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrsListe.Size = new System.Drawing.Size(315, 251);
            this.dgPrsListe.TabIndex = 35;
            this.dgPrsListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrsListe_CellClick);
            this.dgPrsListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrsListe_CellDoubleClick);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(260, 388);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 61;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(179, 388);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 60;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 421);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Listele";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrsListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.TextBox txtPrsAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgPrsListe;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSec;
    }
}