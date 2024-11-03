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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        int odemeKisiID;

        public int OdemeKisiID
        {
            get { return odemeKisiID; }
            set { odemeKisiID = value; }
        }
        OdemelerInfo ogrDgSec = new OdemelerInfo();

        public OdemelerInfo OgrSec
        {
            get { return ogrDgSec; }
            set { ogrDgSec = value; }
        }
        OdemeVadeInfo odmVadeIslem = new OdemeVadeInfo();
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OdemelerInfo kaydetOdeme = new OdemelerInfo();
            try
            {

   
            kaydetOdeme.OdemeSekli = cmbOdSekli.Text;
            kaydetOdeme.OdemeIslem = cmbIslem.Text.Trim();
            kaydetOdeme.OdemeTarih = dtpTarih.Value.Date;
            kaydetOdeme.OdemeTutar = Convert.ToInt32(txtTutar.Text);
            kaydetOdeme.OdemeBelNo = Convert.ToInt32(txtBelgeNo.Text);
            kaydetOdeme.OdemeAciklama = txtAciklama.Text;
            kaydetOdeme.OdemeKisiID = odemeKisiID;
            kaydetOdeme.OdemeDurum = 1;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            int odemeTuru = 2;
            if (rdbGelir.Checked)
                odemeTuru = 1;
            else if (rdbGider.Checked)
                odemeTuru = 0;

            if (odemeTuru == 2)
            {
                MessageBox.Show("Ödeme Türü Seçiniz!", "Ödeme Türü");
            }
            else
            {

                kaydetOdeme.OdemeTuru = odemeTuru;
 
                List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
                odemeList = kaydetOdeme.OdemeleriGetir(1);
                int gncOdmID = 0;
                int odmVar = 0;
                foreach (OdemelerInfo odm in odemeList)
                {
                    if (odm.OdemeID == Convert.ToInt32(lblOdemeID.Text))
                    {
                        gncOdmID = odm.OdemeID;
                        odmVar = 1;
                        break;
                    }
                }

                if (odmVar == 0)
                {
                    int a = kaydetOdeme.OdemeEkle(kaydetOdeme);
                    odmVadeIslem.OdvOdemeDurumu = 1;
                    odmVadeIslem.OdvOdemeTarihi = dtpTarih.Value.Date;
                    odmVadeIslem.OdemeVadeGuncelle(odmVadeIslem);
                }
                else
                {




                    DialogResult dialogResult = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelle", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        kaydetOdeme.OdemeID = gncOdmID;
                        kaydetOdeme.OdemeKisiID =odemeKisiID;

                        int a = kaydetOdeme.OdemeGuncelle(kaydetOdeme);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                 gbOdeme.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
                 gbOdeme.Controls.OfType<ComboBox>().ToList().ForEach(x => x.SelectedIndex = -1);
                this.Width = 300;
                dgOdemeTaksit.Visible = false;
                dgOdemeTaksit.DataSource = null;
            }



        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbGelir_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbGelir.Checked)
            {
                cmbIslem.Items.Clear();
                cmbIslem.Items.Add("Öğrenci Geliri");
                cmbIslem.Items.Add("Diğer");
                lblKisi.Text = "Öğrenci";
            }
        }

        private void rdbGider_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGider.Checked)
            {
                cmbIslem.Items.Clear();
                cmbIslem.Items.Add("Maaş");
                cmbIslem.Items.Add("Avans");
                cmbIslem.Items.Add("Ek Ödeme");
                cmbIslem.Items.Add("Fatura");
                cmbIslem.Items.Add("Kitap");
                cmbIslem.Items.Add("Kira");
                cmbIslem.Items.Add("Vergi");
                cmbIslem.Items.Add("Temizlik");
                cmbIslem.Items.Add("Tanıtım");
                cmbIslem.Items.Add("Yiyecek İçecek");
                cmbIslem.Items.Add("Öğrenci İadesi");
                cmbIslem.Items.Add("Diğer");
                lblKisi.Text = "Personel";
            }
        }

        private void btnKisi_Click(object sender, EventArgs e)
        {
            string odemeAdSoyad = "";
            if (rdbGelir.Checked)
            {
                OgrenciInfo ogrOdeme = new OgrenciInfo();
                frmOgrenciListele ogrList = new frmOgrenciListele(){
                 OgrSec = ogrOdeme
             };
                ogrList.ShowDialog();
                odemeAdSoyad = ogrOdeme.OgrAd + " " + ogrOdeme.OgrSoyad;
                odemeKisiID = ogrOdeme.OgrID;
                this.Width = 860;
                dgOdemeTaksit.Visible = true;
                dgOdemeTaksit.DataSource = null;
                OdemeVadeInfo odmGetir =new OdemeVadeInfo();
                List<OdemeVadeInfo> odmList = new List<OdemeVadeInfo>();
                List<OdemeVadeInfo> odmListtemp = new List<OdemeVadeInfo>();
                odmListtemp = odmGetir.OdemeVadeleriGetir(1);
                

                foreach (OdemeVadeInfo info in odmListtemp)
                {
                    if (info.OdvOgrID == ogrOdeme.OgrNo)
                        odmList.Add(info);
                }
                dgOdemeTaksit.DataSource = odmList;
                this.Left = this.Left - 200;
            }
            else if (rdbGider.Checked)
            {
                this.Width = 300;
                dgOdemeTaksit.Visible = false;
                dgOdemeTaksit.DataSource = null;
                PersonelInfo prsOdeme = new PersonelInfo();
                frmPersonelListele prslist = new frmPersonelListele()
                {
                    PerSec = prsOdeme
                };
                prslist.ShowDialog();
                odemeAdSoyad = prsOdeme.PersonelAd + " " + prsOdeme.PersonelSoyad;
                odemeKisiID = prsOdeme.PersonelID;
            }
            txtOgrenci.Text = odemeAdSoyad;
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            // OgrenciInfo ogrOdeme = new OgrenciInfo();
            this.Width = 300;
                frmKasa ogrL = new frmKasa()
                {
                    OdmInfo = ogrDgSec
                };
                if (ogrDgSec.OdemeID!=0)
                {
                lblOdemeID.Text = ogrDgSec.OdemeID.ToString();
                rdbGelir.Checked = (ogrDgSec.OdemeTuru == 1) ? true : false;
                rdbGider.Checked = (ogrDgSec.OdemeTuru == 0) ? true : false;
                cmbIslem.SelectedText = ogrDgSec.OdemeSekli;
                cmbOdSekli.SelectedText = ogrDgSec.OdemeIslem;
                dtpTarih.Text = ogrDgSec.OdemeTarih.ToString();
                txtTutar.Text = ogrDgSec.OdemeTutar.ToString();
                txtBelgeNo.Text = ogrDgSec.OdemeBelNo.ToString();
                txtAciklama.Text = ogrDgSec.OdemeAciklama;
                txtOgrenci.Text = ogrDgSec.OdemeKisiID.ToString();
                txtOgrenci.Enabled = false;
                btnKisi.Enabled = false;
                odemeKisiID=ogrDgSec.OdemeKisiID;


            }
        }
        
        private void dgOdemeTaksit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTutar.Text = dgOdemeTaksit.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAciklama.Text = dgOdemeTaksit.Rows[e.RowIndex].Cells[6].Value.ToString();

                odmVadeIslem.OdvID = Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[0].Value.ToString());
                odmVadeIslem.OdvOdemeID = Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[1].Value.ToString());
                odmVadeIslem.OdvOgrID = Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[2].Value.ToString());
                odmVadeIslem.OdvVadeMiktar = Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[3].Value.ToString());
                odmVadeIslem.OdvVadeTarihi =Convert.ToDateTime(dgOdemeTaksit.Rows[e.RowIndex].Cells[4].Value.ToString());
                odmVadeIslem.OdvOdemeTarihi =Convert.ToDateTime( dgOdemeTaksit.Rows[e.RowIndex].Cells[5].Value.ToString());
                odmVadeIslem.OdvAciklama = dgOdemeTaksit.Rows[e.RowIndex].Cells[6].Value.ToString();
                odmVadeIslem.OdvOdemeDurumu =Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[7].Value.ToString());
                odmVadeIslem.OdvDurum = Convert.ToInt32(dgOdemeTaksit.Rows[e.RowIndex].Cells[8].Value.ToString());


 

            }

        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        }
    }
