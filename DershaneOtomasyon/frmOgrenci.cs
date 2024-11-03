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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        
        
        private void btnYeni_Click(object sender, EventArgs e)
        {
            //if (tcOgrenci.SelectedTab== )
            //lblOgrID.Text = tcOgrenci.SelectedIndex.ToString();
                gbBilgiler.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
                gbIletisim.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
                gbAnne.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
                gbBaba.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
            
                txtOgrNo.Focus();
                lblOgrID.Text = "0";
            }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciInfo kaydetOgrenci = new OgrenciInfo();
            List<OgrenciInfo> ogrenciList = new List<OgrenciInfo>();
            OdemeVadeInfo kaydetOdemeVade = new OdemeVadeInfo();
            List<OdemeVadeInfo> odemeVadeList = new List<OdemeVadeInfo>();
            odemeVadeList = kaydetOdemeVade.OdemeVadeleriGetir(1);
            ogrenciList = kaydetOgrenci.OgrencileriGetir(1);
            int gncOgrID = 0;
            int ogrVar = 0;
            foreach (OgrenciInfo ogr in ogrenciList)
            {
                if (ogr.OgrID == Convert.ToInt32(lblOgrID.Text))
                {
                    gncOgrID = ogr.OgrID;
                    ogrVar = 1;
                    break;
                }
            }
            
            if(tcOgrenci.SelectedIndex==0)
            {
                try
                {

         
        
            kaydetOgrenci.OgrNo = Convert.ToInt32(txtOgrNo.Text);
            kaydetOgrenci.OgrAd = txtOgrAdi.Text as string ?? default(string);
            kaydetOgrenci.OgrSoyad = txtOgrSoyadi.Text as string ?? default(string);
            kaydetOgrenci.OgrTcNo = txtKimNo.Text as string ?? default(string);
            kaydetOgrenci.OgrCinsiyet = cmbCinsiyet.SelectedIndex as int? ?? default(int);
            kaydetOgrenci.OgrSozTarihi = dtpSozTar.Value.Date;
            kaydetOgrenci.OgrSozTutar = txtSozTutar.Text==""?0: Convert.ToInt32(txtSozTutar.Text);
            kaydetOgrenci.OgrSozTaksit = (cmbSozTaksit.Text=="Peşin")?1:Convert.ToInt32(cmbSozTaksit.Text);
            kaydetOgrenci.OgrTel = txtOgrTel.Text as string ?? default(string);
            kaydetOgrenci.OgrAdres = txtOgrAdres.Text as string ?? default(string);
            kaydetOgrenci.OgrAciklama = txtOgrAciklama.Text as string ?? default(string);
            kaydetOgrenci.OgrDurum = 1;

            kaydetOdemeVade.OdvOdemeID = 0;
            kaydetOdemeVade.OdvOgrID = kaydetOgrenci.OgrNo;
            kaydetOdemeVade.OdvVadeMiktar =kaydetOgrenci.OgrSozTutar/ kaydetOgrenci.OgrSozTaksit;
            kaydetOdemeVade.OdvVadeTarihi = kaydetOgrenci.OgrSozTarihi;
            kaydetOdemeVade.OdvOdemeTarihi = new DateTime();
            kaydetOdemeVade.OdvAciklama = kaydetOgrenci.OgrSozTarihi.ToString() + " Tarihli sözleşme senedi.";
            kaydetOdemeVade.OdvOdemeDurumu = 0;
            kaydetOdemeVade.OdvDurum = 1;
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message);
                }
                if (ogrVar == 0)
            {
                int a = kaydetOgrenci.OgrenciEkle(kaydetOgrenci);

                for (int i = 0; i < kaydetOgrenci.OgrSozTaksit; i++)
                {
                    kaydetOdemeVade.OdvVadeTarihi = DateTime.Now.AddMonths(i);
                    int c = kaydetOdemeVade.OdemeVadeEkle(kaydetOdemeVade);
                }
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelle", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kaydetOgrenci.OgrID = gncOgrID;
                    int a = kaydetOgrenci.OgrenciGuncelle(kaydetOgrenci);

                    kaydetOdemeVade.OdemeVadeTumSil(kaydetOgrenci.OgrNo);
                    for (int i = 0; i < kaydetOgrenci.OgrSozTaksit; i++)
                    {
                        kaydetOdemeVade.OdvVadeTarihi = DateTime.Now.AddMonths(i);
                        int c = kaydetOdemeVade.OdemeVadeEkle(kaydetOdemeVade);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
            else if (tcOgrenci.SelectedIndex == 1)
            {
                VeliInfo kaydetAnne = new VeliInfo();
                VeliInfo kaydetBaba = new VeliInfo();
                try
                {


                kaydetAnne.VeliOgrID = Convert.ToInt32(lblOgrID.Text);
                kaydetAnne.VeliAd = txtAnneAdi.Text as string ?? default(string);
                kaydetAnne.VeliSoyad = txtAnneSoyadi.Text as string ?? default(string);
                kaydetAnne.VeliKimlikNo = txtAnneKimlik.Text as string ?? default(string);
                kaydetAnne.VeliTel = txtAnneTel.Text as string ?? default(string);
                kaydetAnne.VeliMeslek = txtAnneMeslek.Text as string ?? default(string);
                kaydetAnne.Veli = (rdbAnne.Checked) ? 1 : 0;
                kaydetAnne.VeliAdres = txtAnneAdres.Text;
                kaydetAnne.VeliAB = 0; // 0 anne 1 baba
                kaydetAnne.VeliDurum= 1;
               
                
                kaydetBaba.VeliOgrID = Convert.ToInt32(lblOgrID.Text);
                kaydetBaba.VeliAd = txtBabaAd.Text as string ?? default(string);
                kaydetBaba.VeliSoyad = txtBabaSoyad.Text as string ?? default(string);
                kaydetBaba.VeliKimlikNo = txtBabaKimlik.Text as string ?? default(string);
                kaydetBaba.VeliTel = txtBabaTel.Text as string ?? default(string);
                kaydetBaba.VeliMeslek = txtBabaMeslek.Text as string ?? default(string);
                kaydetBaba.Veli = (rdbBaba.Checked) ? 1 : 0;
                kaydetBaba.VeliAdres = txtBabaAdres.Text as string ?? default(string);
                kaydetBaba.VeliAB = 1;
                kaydetBaba.VeliDurum = 1;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    throw;
                }
                List<VeliInfo> veliList = new List<VeliInfo>();
                veliList = kaydetAnne.VelileriGetir(gncOgrID);
                //int gncOgrID = 0;
                int veliVar = 0;
               foreach (VeliInfo veli in veliList)
                {
                    if (veli.VeliOgrID ==Convert.ToInt32(lblOgrID.Text)) //Convert.ToInt32(lblAnneID.Text) || veli.VeliOgrID == Convert.ToInt32(lblBabaID.Text))
                    {
                        gncOgrID = veli.VeliOgrID;
                        veliVar = 1;
                        break;
                    }
                }

               if (veliVar == 0)
                {
                    int a = kaydetAnne.VeliEkle(kaydetAnne);
                    int b = kaydetBaba.VeliEkle(kaydetBaba);
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelle", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        kaydetAnne.VeliID = Convert.ToInt32(lblAnneID.Text);
                        kaydetBaba.VeliID = Convert.ToInt32(lblBabaID.Text);
                        int a = kaydetAnne.VeliGuncelle(kaydetAnne);
                        int b = kaydetBaba.VeliGuncelle(kaydetBaba);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            
            }
            OgrenciInfo ogrlist = new OgrenciInfo();
            gridDoldur(ogrlist.OgrencileriGetir(1));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int ogrSilID = Convert.ToInt32(lblOgrID.Text);
            if (tcOgrenci.SelectedIndex == 0)
            {

                DialogResult dialogResult = MessageBox.Show("Kayıt Silinsin mi?", "Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OgrenciInfo silOgr = new OgrenciInfo();
                    silOgr.OgrenciSil(ogrSilID);
                    gridDoldur(silOgr.OgrencileriGetir(1));
                }
            }
            else if(tcOgrenci.SelectedIndex == 1)
            { DialogResult dialogResult = MessageBox.Show("Veli Bilgileri Silinsin mi?", "Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    VeliInfo silVeli = new VeliInfo();
                    silVeli.VeliSil(ogrSilID);
                }
            }
        }

        void gridDoldur(List<OgrenciInfo> ogrs)
        {
            dgOgrenciList.DataSource = null;
            dgOgrenciList.DataSource = ogrs;
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


        private void btnAra_Click(object sender, EventArgs e)
        {
          
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
            gridDoldur(ogrList);
        }

        private void dgOgrenciList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblOgrID.Text =dgOgrenciList.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOgrNo.Text = dgOgrenciList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOgrAdi.Text = dgOgrenciList.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOgrSoyadi.Text = dgOgrenciList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtKimNo.Text = dgOgrenciList.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbCinsiyet.SelectedIndex =Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[5].Value.ToString());
                dtpSozTar.Text =dgOgrenciList.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSozTutar.Text = dgOgrenciList.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmbSozTaksit.Text =dgOgrenciList.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtOgrTel.Text = dgOgrenciList.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtOgrAdres.Text = dgOgrenciList.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtOgrAciklama.Text = dgOgrenciList.Rows[e.RowIndex].Cells[11].Value.ToString();

                int ogrID=Convert.ToInt32(lblOgrID.Text);
                List<VeliInfo> veliList = new List<VeliInfo>();
                VeliInfo veliAnne = new VeliInfo();
                VeliInfo veliBaba = new VeliInfo();
                veliList = veliAnne.VelileriGetir(ogrID);
                foreach (VeliInfo velif in veliList)
                {
                    if (velif.VeliAB== 0)
                    {
                        veliAnne = velif;
                    }
                    else if(velif.VeliAB==1)
                    {
                        veliBaba = velif;
                    }
                }

                lblAnneID.Text = veliAnne.VeliID.ToString();
                txtAnneAdi.Text=veliAnne.VeliAd;
                txtAnneSoyadi.Text=veliAnne.VeliSoyad;
                txtAnneKimlik.Text=veliAnne.VeliKimlikNo;
                txtAnneTel.Text=veliAnne.VeliTel;
                txtAnneMeslek.Text=veliAnne.VeliMeslek;
                rdbAnne.Checked=Convert.ToBoolean(veliAnne.Veli);
                txtAnneAdres.Text=veliAnne.VeliAdres;
                veliAnne.VeliAB = 0;
                veliAnne.VeliDurum = 1;


                lblBabaID.Text=veliBaba.VeliID.ToString();
                txtBabaAd.Text=veliBaba.VeliAd;
                txtBabaSoyad.Text=veliBaba.VeliSoyad;
                txtBabaKimlik.Text=veliBaba.VeliKimlikNo;
                txtBabaTel.Text=veliBaba.VeliTel;
                txtBabaMeslek.Text=veliBaba.VeliMeslek;
                rdbBaba.Checked=Convert.ToBoolean(veliBaba.Veli);
                txtBabaAdres.Text=veliBaba.VeliAdres;
                veliBaba.VeliAB = 1;
                veliBaba.VeliDurum = 1;


                OdemelerInfo ogrOdm = new OdemelerInfo();
                List<OdemelerInfo> prsOgrList = new List<OdemelerInfo>();
                List<OdemelerInfo> prsOgrListTemp = new List<OdemelerInfo>();
                prsOgrListTemp = ogrOdm.OdemeleriGetir(1);

                foreach (OdemelerInfo info in prsOgrListTemp)
                {
                    if (info.OdemeTuru == 1 & info.OdemeKisiID == Convert.ToInt32(lblOgrID.Text))
                        prsOgrList.Add(info);
                }
                dgOgrOdemeList.DataSource = prsOgrList;

            }
     
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            this.btnHepsiAra_Click(sender, e);
        }

        private void dgOgrenciList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSozTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrNoAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrSoyadi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKimNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.Items.Add("Tüm Öğrenci Listesi");            
            cm.Items.Add("Tüm Öğrenci İletişim Bilgileri");
            cm.Items.Add("Seçili Öğrenci Bilgileri");
            cm.Items.Add("Tüm Öğrenci Ödemeler");
            cm.Items.Add("Seçili Öğrenci Ödemeler");
            if(makBuzYaz>=0) cm.Items.Add("Tahsilat Makbuzu");
            cm.Show(btnYazdir, new Point(0, btnYazdir.Height-cm.Height-btnYazdir.Height-24));
            cm.ItemClicked += Cm_ItemClicked;            
        }

        private void Cm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            OgrenciInfo Ogr = new OgrenciInfo();
            PrintMod pM = new PrintMod();
            if (e.ClickedItem.ToString()=="Tüm Öğrenci Listesi")
            {
               
                pM.TumOgrYazdir(Ogr.OgrencileriGetir(1));
            }
            else if (e.ClickedItem.ToString() == "Tüm Öğrenci İletişim Bilgileri")
            {
                pM.TumOgrIletisimYazdir(Ogr.OgrencileriGetir(1));

            }
            else if(e.ClickedItem.ToString()== "Seçili Öğrenci Bilgileri")
            {
                int ogrNo = 0;
               if (txtOgrNo.Text!="")
                     ogrNo = Convert.ToInt32(txtOgrNo.Text);

                pM.OgrBilgiYaz(Ogr.OgrenciNoGetir(ogrNo));

            }
            else if (e.ClickedItem.ToString() == "Tüm Öğrenci Ödemeler")
            {
               int ogrNo = 0;
                if (txtOgrNo.Text != "")
                    ogrNo = Convert.ToInt32(txtOgrNo.Text);

                pM.TumOgrOdemeYaz(Ogr.OgrenciNoGetir(ogrNo));
            }
            else if (e.ClickedItem.ToString() == "Seçili Öğrenci Ödemeler")
            {
                int ogrNo = 0;
                if (txtOgrNo.Text != "")
                    ogrNo = Convert.ToInt32(txtOgrNo.Text);
                pM.OgrVadeOdemeYaz(Ogr.OgrenciNoGetir(ogrNo));
            }
            else if (e.ClickedItem.ToString() == "Tahsilat Makbuzu")
            {
                int ogrNo = 0;
                if (txtOgrNo.Text != "")
                    ogrNo = Convert.ToInt32(txtOgrNo.Text);
                pM.OgrMakbuzYazdir(Ogr.OgrenciNoGetir(ogrNo),makbuzID);
            }
        }

        private void txtOgrNoAra_TextChanged(object sender, EventArgs e)
        {
            List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            List<OgrenciInfo> ogrListTemp = new List<OgrenciInfo>();
            OgrenciInfo tOgrs = new OgrenciInfo();
            ogrListTemp = tOgrs.TumOgrencileriGetir();
            int ogrvar = 0;

            int ogrArano = txtOgrNoAra.Text==""?0: Convert.ToInt32(txtOgrNoAra.Text);
            foreach (OgrenciInfo ogr in ogrListTemp)
            {
                if (ogr.OgrNo == ogrArano)
                {
                    ogrList.Add(ogr);
                    ogrvar = 1;
                    //break;
                }
            }
            if (ogrvar == 1)
                gridDoldur(ogrList);
            else
            {
                ogrList = null;
                //MessageBox.Show("Kayıt yok.");
                dgOgrenciList.DataSource = null;
            }
        }

        private void dgOgrOdemeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int makBuzYaz = -1;
        int makbuzID = 0;
        private void dgOgrOdemeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                makBuzYaz = e.RowIndex;
                makbuzID = Convert.ToInt32(dgOgrOdemeList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
    }

