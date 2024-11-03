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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

  

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PersonelInfo kaydetPersonel = new PersonelInfo();
            try
            {

    
            kaydetPersonel.PersonelAd = txtPrsAdi.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelSoyad = txtPrsSoyad.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelKimlikNo = txtKimlikNo.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelUnvan = txtPrsBrans.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelDurum = (rdbAktif.Checked == true) ? 1 : 0;
            kaydetPersonel.PersonelMaas = Convert.ToInt32(txtPrsMaas.Text.Trim());
            kaydetPersonel.PersonelUcret = Convert.ToInt32(txtPrsEkUcret.Text);
            kaydetPersonel.PersonelOgrtmn = (chkOgretmen.Checked==true) ? 1 : 0;
            kaydetPersonel.PersonelGsm = txtPrsTel.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelMail = txtPrsMail.Text.Trim() as string ?? default(string);
            kaydetPersonel.PersonelAdres = txtPrsAdres.Text.Trim() as string ?? default(string);

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

            List<PersonelInfo> personelList = new List<PersonelInfo>();
            personelList = kaydetPersonel.PersonelleriGetir(1);
            int gncPrsID = 0;
            int persVar = 0;
            foreach (PersonelInfo prs in personelList)
            {
                if (prs.PersonelID == Convert.ToInt32(lblPersonelID.Text))
                {
                    gncPrsID = prs.PersonelID;
                    persVar = 1;
                    break;
                }
            }

            if (persVar == 0)
            {
                int a = kaydetPersonel.PersonelEkle(kaydetPersonel);

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelle", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kaydetPersonel.PersonelID = gncPrsID;
                    int a = kaydetPersonel.PersonelGuncelle(kaydetPersonel);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

            PersonelInfo personel = new PersonelInfo();
            gridDoldur(personel.PersonelleriGetir(1));
        }

        private void ogretmenler_Load(object sender, EventArgs e)
        {
           PersonelInfo personel = new PersonelInfo();
           gridDoldur(personel.PersonelleriGetir(1));
        }
     
        void gridDoldur(List<PersonelInfo> pers)
        {
            dgPrsListe.DataSource = null;
            //dgPrsListe.Refresh();
            dgPrsListe.DataSource = pers;
            dgPrsListe.Columns[1].HeaderText = "ADI";
            dgPrsListe.Columns[2].HeaderText = "SOYADI";
            dgPrsListe.Columns[3].HeaderText = "KİMLİKNO";
            dgPrsListe.Columns[3].Width = 80;
            dgPrsListe.Columns[4].Visible = false;
            dgPrsListe.Columns[5].Visible = false;
            dgPrsListe.Columns[6].Visible = false;
            dgPrsListe.Columns[7].Visible = false;
            dgPrsListe.Columns[8].Visible = false;
            dgPrsListe.Columns[9].Visible = false;
            dgPrsListe.Columns[10].Visible = false;
            dgPrsListe.Columns[0].Visible = false;
            dgPrsListe.Columns[11].Visible = false;

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            gbIBilgiler.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
            gbIletisim.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
            lblPersonelID.Text = "0";
            chkOgretmen.Checked = false;
            txtPrsAdi.Focus();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPrsListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblPersonelID.Text = dgPrsListe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrsAdi.Text = dgPrsListe.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrsSoyad.Text = dgPrsListe.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtKimlikNo.Text = dgPrsListe.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrsBrans.Text = dgPrsListe.Rows[e.RowIndex].Cells[4].Value.ToString();               
                rdbAktif.Checked = (dgPrsListe.Rows[e.RowIndex].Cells[5].Value.ToString() == "1") ? true : false;
                rdbPasif.Checked = (dgPrsListe.Rows[e.RowIndex].Cells[5].Value.ToString() == "0") ? true : false;
                txtPrsMaas.Text = dgPrsListe.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPrsEkUcret.Text = dgPrsListe.Rows[e.RowIndex].Cells[7].Value.ToString();
                chkOgretmen.Checked = (dgPrsListe.Rows[e.RowIndex].Cells[8].Value.ToString() == "0") ? true : false;
                txtPrsTel.Text = dgPrsListe.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtPrsMail.Text = dgPrsListe.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtPrsAdres.Text = dgPrsListe.Rows[e.RowIndex].Cells[11].Value.ToString();

                OdemelerInfo prsOdm = new OdemelerInfo();
                List<OdemelerInfo> prsOdmList=new List<OdemelerInfo>();
                List<OdemelerInfo> prsOdmListTemp = new List<OdemelerInfo>();
                prsOdmListTemp = prsOdm.OdemeleriGetir(1);

                foreach (OdemelerInfo info in prsOdmListTemp)
                {
                    if (info.OdemeTuru == 0 & info.OdemeKisiID==Convert.ToInt32(lblPersonelID.Text))
                        prsOdmList.Add(info);
                }
                dgPersonelOdeme.DataSource = prsOdmList;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelInfo silPrs = new PersonelInfo();
            int prsSilID = Convert.ToInt32(lblPersonelID.Text);
            silPrs.PersonelSil(prsSilID);
            PersonelInfo personel = new PersonelInfo();
            gridDoldur(personel.PersonelleriGetir(1));
        }

        private void btnHepsiAra_Click(object sender, EventArgs e)
        {
            List<PersonelInfo> persList = new List<PersonelInfo>();
            List<PersonelInfo> persListTemp = new List<PersonelInfo>();
            PersonelInfo tPers = new PersonelInfo();
            persListTemp = tPers.TumPersonelleriGetir();
            if (chkAyrilan.Checked)
            {
                persList = persListTemp;
            }
            else
            {
                foreach (PersonelInfo info in persListTemp)
                {
                    if (info.PersonelDurum == 1)
                        persList.Add(info);
                }
                
               }
            gridDoldur(persList);



        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtPrsAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.Items.Add("Tüm Personel Listesi");
            cm.Items.Add("Tüm Personel İletişim Bilgileri");
            cm.Items.Add("Seçili Personel Bilgileri");
            cm.Items.Add("Tüm Personel Ödemeler");
            cm.Items.Add("Seçili Personel Ödemeler");
            cm.Show(btnYazdir, new Point(0, btnYazdir.Height - cm.Height - btnYazdir.Height - 24));
            cm.ItemClicked += Cm_ItemClicked; ;
        }

        private void Cm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PersonelInfo prs = new PersonelInfo();
            PrintMod pM = new PrintMod();
            if (e.ClickedItem.ToString() == "Tüm Personel Listesi")
            {

                pM.TumPrsYazdir(prs.PersonelleriGetir(1));
            }
            else if (e.ClickedItem.ToString() == "Tüm Personel İletişim Bilgileri")
            {
                pM.TumPrsIletisimYazdir(prs.PersonelleriGetir(1));

            }
            else if (e.ClickedItem.ToString() == "Seçili Personel Bilgileri")
            {
                int prsID = 0;
                if (lblPersonelID.Text != "0")
                    prsID = Convert.ToInt32(lblPersonelID.Text);

                pM.PrsBilgiYaz(prs.PersonelleriGetir(1),prsID);

            }
            else if (e.ClickedItem.ToString() == "Tüm Personel Ödemeler")
            {
               
                pM.TumPrsOdemeYaz(prs.PersonelleriGetir(1));
            }
            else if (e.ClickedItem.ToString() == "Seçili Personel Ödemeler")
            {
                int prsID = 0;
                if (lblPersonelID.Text != "0")
                    prsID = Convert.ToInt32(lblPersonelID.Text);

                pM.PrsOdemeYaz(prs.PersonelleriGetir(1), prsID);
                
            }
        }

        private void txtPrsAra_TextChanged(object sender, EventArgs e)
        {

            List<PersonelInfo> persList = new List<PersonelInfo>();
            List<PersonelInfo> persListTemp = new List<PersonelInfo>();
            PersonelInfo tPers = new PersonelInfo();
            persListTemp = tPers.TumPersonelleriGetir();
            foreach (PersonelInfo prs in persListTemp)
            {
                if (prs.PersonelKimlikNo == txtPrsAra.Text)
                {
                    persList.Add(prs);
                    gridDoldur(persList);
                    //break;
                }
                else
                {
                    persList = null;
                    //MessageBox.Show("Kayıt yok.");
                    dgPrsListe.DataSource = null;

                    break;
                }
            }
        }

        private void txtPrsAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPrsSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrsBrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtPrsEkUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrsMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }



}
