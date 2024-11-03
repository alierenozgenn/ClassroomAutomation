using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyon
{
    public partial class frmOdemeVade : Form
    {
        public frmOdemeVade()
        {
            InitializeComponent();
        }
        OdemelerInfo odeme = new OdemelerInfo();
        OdemeVadeInfo odemeVade = new OdemeVadeInfo();
        OgrenciInfo ogrenci = new OgrenciInfo();
        private void frmOdemeVade_Load(object sender, EventArgs e)
        {
            OdemeVadeInfo odemeVade = new OdemeVadeInfo();
            /*
            List<OdemeVadeInfo> odv = new List<OdemeVadeInfo>();
            gridDoldur(odemeVade.OdemeVadeleriGetir(1));*/
            cmbIslem.SelectedIndex = 0;
            rdbGelir.Checked = true;

            OgrenciInfo ogrlist = new OgrenciInfo();
            gridDoldurOgr(ogrlist.OgrencileriGetir(1));

        }
        void gridDoldurOgr(List<OgrenciInfo> odv)
        {
            dgOgrenciList.DataSource = null;
            //dgPrsListe.Refresh();
            dgOgrenciList.DataSource = odv;
            dgOgrenciList.Columns[1].HeaderText = "NUMARA";
            dgOgrenciList.Columns[2].HeaderText = "ADI";
            dgOgrenciList.Columns[3].HeaderText = "SOYADI";
            dgOgrenciList.Columns[1].Width = 50;


            dgOgrenciList.Columns[4].Visible = false;
            dgOgrenciList.Columns[5].Visible = false;
            dgOgrenciList.Columns[6].Visible = false;
            dgOgrenciList.Columns[7].Visible = false;
            dgOgrenciList.Columns[8].Visible = false;
            dgOgrenciList.Columns[9].Visible = false;
            dgOgrenciList.Columns[10].Visible = false;
            dgOgrenciList.Columns[11].Visible = false;
            dgOgrenciList.Columns[12].Visible = false;
            dgOgrenciList.Columns[0].Visible = false;
        }
        void gridDoldur(List<OdemeVadeInfo> odv)
        {
            dgOdemeVade.DataSource = null;
            //dgPrsListe.Refresh();
            dgOdemeVade.DataSource = odv;
            dgOdemeVade.Columns[0].HeaderText = "ÖD. NO";
            dgOdemeVade.Columns[3].HeaderText = "TUTAR";
            dgOdemeVade.Columns[4].HeaderText = "V.TARİHİ";
            dgOdemeVade.Columns[5].HeaderText = "ÖD. TARİHİ";
            dgOdemeVade.Columns[6].HeaderText = "AÇIKLAMA";
            dgOdemeVade.Columns[7].HeaderText = "DURUM";
            
            //dgOdemeVade.Rows.
            dgOdemeVade.Columns[0].Width = 50;

            dgOdemeVade.Columns[1].Visible = false;
            dgOdemeVade.Columns[2].Visible = false;
            dgOdemeVade.Columns[8].Visible = false;
               
        }

        private void btnKisi_Click(object sender, EventArgs e)
        {

        }
        int makbuzID = 0;
        private void dgOdemeVade_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                odemeVade.OdvID = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[0].Value.ToString());
                odemeVade.OdvOdemeID = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[1].Value.ToString());
                odemeVade.OdvOgrID = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[2].Value.ToString());
                odemeVade.OdvVadeMiktar = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[3].Value.ToString());
                odemeVade.OdvVadeTarihi = Convert.ToDateTime(dgOdemeVade.Rows[e.RowIndex].Cells[4].Value.ToString());
                odemeVade.OdvOdemeTarihi = Convert.ToDateTime(dgOdemeVade.Rows[e.RowIndex].Cells[5].Value.ToString());
                odemeVade.OdvAciklama = dgOdemeVade.Rows[e.RowIndex].Cells[6].Value.ToString();
                odemeVade.OdvOdemeDurumu = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[7].Value.ToString());
                odemeVade.OdvDurum = Convert.ToInt32(dgOdemeVade.Rows[e.RowIndex].Cells[8].Value.ToString());


                List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
                ogrList = ogrenci.OgrenciNoGetir(odemeVade.OdvOgrID);
                ogrenci = ogrList[0];
                txtOgrenci.Text = ogrenci.OgrAd + " " + ogrenci.OgrSoyad;
                txtTutar.Text = odemeVade.OdvVadeMiktar.ToString();
                rdbYapildi.Checked = (odemeVade.OdvOdemeDurumu==1)?true:false;
                rdbYapilmadi.Checked = (odemeVade.OdvOdemeDurumu == 0) ? true : false;
                txtAciklama.Text = odemeVade.OdvAciklama;
                makbuzID = odemeVade.OdvID;
                /*
                odeme.OdemeSekli = cmbOdSekli.Text;
                odeme.OdemeIslem = cmbIslem.Text.Trim();
                odeme.OdemeTarih = dtpTarih.Value.Date;
                odeme.OdemeTutar = Convert.ToInt32(txtTutar.Text);
                odeme.OdemeBelNo = Convert.ToInt32(txtBelgeNo.Text);
                odeme.OdemeAciklama = txtAciklama.Text;
                odeme.OdemeKisiID = ogrenci.OgrID;
                odeme.OdemeDurum = 1;
                */
            }




        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rdbYapildi.Checked)
            {
                odemeVade.OdvOdemeDurumu = 1;
                odemeVade.OdvOdemeTarihi = dtpTarih.Value.Date;
                odemeVade.OdemeVadeGuncelle(odemeVade);

                OdemelerInfo kaydetOdeme = new OdemelerInfo();


                try
                {

        
                odeme.OdemeSekli = cmbOdSekli.Text;
                odeme.OdemeIslem = cmbIslem.Text.Trim();
                odeme.OdemeTarih = dtpTarih.Value.Date;
                odeme.OdemeTutar = Convert.ToInt32(txtTutar.Text);
                odeme.OdemeBelNo = Convert.ToInt32(txtBelgeNo.Text);
                odeme.OdemeAciklama = txtAciklama.Text;
                odeme.OdemeKisiID = ogrenci.OgrID;
                odeme.OdemeDurum = 1;
                odeme.OdemeTuru = 1;
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message);
                }
                odeme.OdemeEkle(odeme);
                OdemeVadeInfo odv = new OdemeVadeInfo();
                List<OdemeVadeInfo> odvlist = new List<OdemeVadeInfo>();
                List<OdemeVadeInfo> odvlisttemp = new List<OdemeVadeInfo>();
                odvlisttemp = odv.OdemeVadeleriGetir(1);
                foreach (OdemeVadeInfo item in odvlisttemp)
                {
                    if (item.OdvOgrID == ogrIDMakbuz)
                        odvlist.Add(item);
                }
                gridDoldur(odvlist);
               // gridDoldur(odemeVade.OdemeVadeleriGetir(1));
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int ogrIDMakbuz = 0;
        private void dgOgrenciList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ogrNO = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[1].Value.ToString());
            ogrIDMakbuz = ogrNO;
            OdemeVadeInfo odv = new OdemeVadeInfo();
           List<OdemeVadeInfo> odvlist = new List<OdemeVadeInfo>();
            List<OdemeVadeInfo> odvlisttemp = new List<OdemeVadeInfo>();
            odvlisttemp = odv.OdemeVadeleriGetir(1);
            foreach (OdemeVadeInfo item in odvlisttemp)
            {
                if (item.OdvOgrID == ogrNO)
                    odvlist.Add(item);
            }
            gridDoldur(odvlist);

        }

        private void btnHepsiAra_Click(object sender, EventArgs e)
        {
            List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            List<OgrenciInfo> ogrListTemp = new List<OgrenciInfo>();
            OgrenciInfo tPers = new OgrenciInfo();
            ogrListTemp = tPers.TumOgrencileriGetir();
            if (chkAyrilan.Checked)
            {
                ogrList = ogrListTemp;
            }
            else
            {
                foreach (OgrenciInfo info in ogrListTemp)
                {
                    if (info.OgrDurum == 1)
                        ogrList.Add(info);
                }

            }
            gridDoldurOgr(ogrList);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            odemeVade.OdvDurum = 0;
            odemeVade.OdemeVadeGuncelle(odemeVade);
            gridDoldur(odemeVade.OdemeVadeleriGetir(1));
        }

        private void dgOdemeVade_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // dgOdemeVade.Rows[e.RowIndex].Cells[7].Value = ((dgOdemeVade.Rows[e.RowIndex].Cells[7].Value.ToString() == "1") ? "Ödendi" : "Ödenmedi");
        }

        private void dgOdemeVade_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string odeme = "";
            if (dgOdemeVade.Rows[e.RowIndex].Cells[7].Value.ToString() == "1")
            {
                dgOdemeVade.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.RoyalBlue;
                odeme = "Ödendi";
            }
            else
            {
                dgOdemeVade.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                odeme = "Ödenmedi";
            }
        //    dgOdemeVade.Rows[e.RowIndex].Cells[6].Value = odeme;
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrNoAra_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);





        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrAdiAra_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrSoyadAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrNoAra_TextChanged(object sender, EventArgs e)
        {
            List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            List<OgrenciInfo> ogrListTemp = new List<OgrenciInfo>();
            OgrenciInfo tOgrs = new OgrenciInfo();
            ogrListTemp = tOgrs.TumOgrencileriGetir();
            int ogrvar = 0;
            int ogrAraNo = txtOgrNoAra.Text == "" ? 0 : Convert.ToInt32(txtOgrNoAra.Text);
         
                foreach (OgrenciInfo ogr in ogrListTemp)
                {
                    if (ogr.OgrNo == ogrAraNo)
                    {
                        ogrList.Add(ogr);
                        ogrvar = 1;
                        break;
                    }
                }

           
            if (ogrvar == 1)
                gridDoldurOgr(ogrList);
            else
            {
                ogrList = null;
               // MessageBox.Show("Kayıt yok.");
                dgOgrenciList.DataSource = null;
            }
        }

    }
}
