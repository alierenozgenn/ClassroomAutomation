namespace DershaneOtomasyon
{
    partial class ucOgrenciListele
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
            this.gbOgrSorgula = new System.Windows.Forms.GroupBox();
            this.lblOgrID = new System.Windows.Forms.Label();
            this.chkAyrilan = new System.Windows.Forms.CheckBox();
            this.dgOgrenciList = new System.Windows.Forms.DataGridView();
            this.btnHepsiAra = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtOgrSoyadAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrAdiAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOgrSorgula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOgrSorgula
            // 
            this.gbOgrSorgula.Controls.Add(this.lblOgrID);
            this.gbOgrSorgula.Controls.Add(this.chkAyrilan);
            this.gbOgrSorgula.Controls.Add(this.dgOgrenciList);
            this.gbOgrSorgula.Controls.Add(this.btnHepsiAra);
            this.gbOgrSorgula.Controls.Add(this.btnAra);
            this.gbOgrSorgula.Controls.Add(this.txtOgrSoyadAra);
            this.gbOgrSorgula.Controls.Add(this.label3);
            this.gbOgrSorgula.Controls.Add(this.txtOgrAdiAra);
            this.gbOgrSorgula.Controls.Add(this.label2);
            this.gbOgrSorgula.Controls.Add(this.txtOgrNoAra);
            this.gbOgrSorgula.Controls.Add(this.label1);
            this.gbOgrSorgula.Location = new System.Drawing.Point(6, 6);
            this.gbOgrSorgula.Name = "gbOgrSorgula";
            this.gbOgrSorgula.Size = new System.Drawing.Size(326, 339);
            this.gbOgrSorgula.TabIndex = 0;
            this.gbOgrSorgula.TabStop = false;
            this.gbOgrSorgula.Text = "Öğrenci Sorgula";
            // 
            // lblOgrID
            // 
            this.lblOgrID.AutoSize = true;
            this.lblOgrID.Location = new System.Drawing.Point(251, 117);
            this.lblOgrID.Name = "lblOgrID";
            this.lblOgrID.Size = new System.Drawing.Size(35, 13);
            this.lblOgrID.TabIndex = 61;
            this.lblOgrID.Text = "label4";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı";
            // 
            // txtOgrAdiAra
            // 
            this.txtOgrAdiAra.Location = new System.Drawing.Point(81, 60);
            this.txtOgrAdiAra.Name = "txtOgrAdiAra";
            this.txtOgrAdiAra.Size = new System.Drawing.Size(228, 20);
            this.txtOgrAdiAra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı";
            // 
            // txtOgrNoAra
            // 
            this.txtOgrNoAra.Location = new System.Drawing.Point(81, 34);
            this.txtOgrNoAra.Name = "txtOgrNoAra";
            this.txtOgrNoAra.Size = new System.Drawing.Size(228, 20);
            this.txtOgrNoAra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // ucOgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOgrSorgula);
            this.Name = "ucOgrenciListele";
            this.Size = new System.Drawing.Size(339, 352);
            this.Load += new System.EventHandler(this.ucOgrenciListele_Load);
            this.gbOgrSorgula.ResumeLayout(false);
            this.gbOgrSorgula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrSorgula;
        private System.Windows.Forms.TextBox txtOgrSoyadAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrAdiAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOgrenciList;
        private System.Windows.Forms.Button btnHepsiAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox chkAyrilan;
        private System.Windows.Forms.Label lblOgrID;
    }
}
