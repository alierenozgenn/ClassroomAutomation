namespace DershaneOtomasyon
{
    partial class frmOgrenciListele
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
            this.btnSec = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gbOgrSorgula = new System.Windows.Forms.GroupBox();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.dgOgrenciList = new System.Windows.Forms.DataGridView();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtOgrSoyadAra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOgrAdiAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOgrNoAra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbOgrSorgula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.White;
            this.btnSec.Location = new System.Drawing.Point(172, 339);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(253, 339);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gbOgrSorgula
            // 
            this.gbOgrSorgula.Controls.Add(this.chkAyrilan);
            this.gbOgrSorgula.Controls.Add(this.dgOgrenciList);
            this.gbOgrSorgula.Controls.Add(this.btnHepsiAra);
            this.gbOgrSorgula.Controls.Add(this.btnAra);
            this.gbOgrSorgula.Controls.Add(this.txtOgrSoyadAra);
            this.gbOgrSorgula.Controls.Add(this.label13);
            this.gbOgrSorgula.Controls.Add(this.txtOgrAdiAra);
            this.gbOgrSorgula.Controls.Add(this.label14);
            this.gbOgrSorgula.Controls.Add(this.txtOgrNoAra);
            this.gbOgrSorgula.Controls.Add(this.label15);
            this.gbOgrSorgula.Location = new System.Drawing.Point(2, 2);
            this.gbOgrSorgula.Name = "gbOgrSorgula";
            this.gbOgrSorgula.Size = new System.Drawing.Size(326, 331);
            this.gbOgrSorgula.TabIndex = 19;
            this.gbOgrSorgula.TabStop = false;
            this.gbOgrSorgula.Text = "Öğrenci Sorgula";
            // 
            // chkAyrilan
            // 
            this.chkAyrilan.AutoSize = true;
            this.chkAyrilan.Location = new System.Drawing.Point(81, 116);
            this.chkAyrilan.Name = "chkAyrilan";
            this.chkAyrilan.Size = new System.Drawing.Size(155, 17);
            this.chkAyrilan.TabIndex = 60;
            this.chkAyrilan.Text = "Ayrılan Öğrencileride Listele";
            this.chkAyrilan.UseVisualStyleBackColor = true;
            // 
            // dgOgrenciList
            // 
            this.dgOgrenciList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciList.Location = new System.Drawing.Point(16, 172);
            this.dgOgrenciList.Name = "dgOgrenciList";
            this.dgOgrenciList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOgrenciList.Size = new System.Drawing.Size(293, 150);
            this.dgOgrenciList.TabIndex = 59;
            this.dgOgrenciList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciList_CellClick);
            this.dgOgrenciList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciList_CellDoubleClick);
            // 
            // btnHepsiAra
            // 
            this.btnHepsiAra.BackColor = System.Drawing.Color.White;
            this.btnHepsiAra.Location = new System.Drawing.Point(97, 139);
            this.btnHepsiAra.Name = "btnHepsiAra";
            this.btnHepsiAra.Size = new System.Drawing.Size(212, 27);
            this.btnHepsiAra.TabIndex = 58;
            this.btnHepsiAra.Text = "Bütün Öğrencileri Listele";
            this.btnHepsiAra.UseVisualStyleBackColor = false;
            this.btnHepsiAra.Click += new System.EventHandler(this.btnHepsiAra_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(16, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 27);
            this.btnAra.TabIndex = 57;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtOgrSoyadAra
            // 
            this.txtOgrSoyadAra.Location = new System.Drawing.Point(81, 86);
            this.txtOgrSoyadAra.Name = "txtOgrSoyadAra";
            this.txtOgrSoyadAra.Size = new System.Drawing.Size(228, 20);
            this.txtOgrSoyadAra.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Soyadı";
            // 
            // txtOgrAdiAra
            // 
            this.txtOgrAdiAra.Location = new System.Drawing.Point(81, 60);
            this.txtOgrAdiAra.Name = "txtOgrAdiAra";
            this.txtOgrAdiAra.Size = new System.Drawing.Size(228, 20);
            this.txtOgrAdiAra.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Adı";
            // 
            // txtOgrNoAra
            // 
            this.txtOgrNoAra.Location = new System.Drawing.Point(81, 34);
            this.txtOgrNoAra.Name = "txtOgrNoAra";
            this.txtOgrNoAra.Size = new System.Drawing.Size(228, 20);
            this.txtOgrNoAra.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Öğrenci No";
            // 
            // frmOgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(340, 373);
            this.Controls.Add(this.gbOgrSorgula);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSec);
            this.Name = "frmOgrenciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOgrenciListele";
            this.Load += new System.EventHandler(this.frmOgrenciListele_Load);
            this.gbOgrSorgula.ResumeLayout(false);
            this.gbOgrSorgula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox gbOgrSorgula;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.DataGridView dgOgrenciList;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtOgrSoyadAra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOgrAdiAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOgrNoAra;
        private System.Windows.Forms.Label label15;
    }
}