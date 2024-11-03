using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
namespace DershaneOtomasyon
{
    public partial class frmDBilgi : Form
    {
        public frmDBilgi()
        {
            InitializeComponent();
        }
        DershaneInfo drs = new DershaneInfo();
        List<DershaneInfo> drsList = new List<DershaneInfo>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {          
            drs.BlgDershaneAd = txtDersAd.Text;
            drs.BlgYetkili = cmbYetkili.Text;//txtYekili.Text;
            drs.BlgTel = txtTelefon.Text;
            drs.BlgVergiDairesi = txtVergiDairesi.Text;
            drs.BlgVergiNo = txtVergiNo.Text;
            drs.BlgIban = txtIBAN.Text;
            drs.BlgAdres = txtAdres.Text;
            drs.BlgKAdi = txtKadi.Text.Trim();
            drs.BlgParola = txtParola.Text.Trim();              
            }

            catch (Exception er)

            {
                MessageBox.Show("Bütün Alanları Doldurunuz");
            }

            if(yeniKayit==1)
            {
                
                string a = drs.BilgiEkle(drs);
                yeniKayit = 0;
                drsList = drs.BilgiGetir();
                cmbYetkili.Items.Clear();
                foreach (DershaneInfo item in drsList)
                {
                    cmbYetkili.Items.Add(item.BlgYetkili);
                }
                cmbYetkili.SelectedIndex = 0;

            }
            else
            { 
            DialogResult dialogResult = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                    drs.BlgID = drsinfo.BlgID;
                    string a=  drs.BilgiGuncelle(drs);              
            }
            }
        }

        private void frmDBilgi_Load(object sender, EventArgs e)
        {            
            drsList = drs.BilgiGetir();
            foreach (DershaneInfo item in drsList)
            {
                cmbYetkili.Items.Add(item.BlgYetkili);
            }
            cmbYetkili.SelectedIndex = 0;

            txtDersAd.Text = drsList[0].BlgDershaneAd as string ?? default(string);
            txtYekili.Text = drsList[0].BlgYetkili as string ?? default(string);
            txtTelefon.Text = drsList[0].BlgTel as string ?? default(string);
            txtVergiDairesi.Text = drsList[0].BlgVergiDairesi as string ?? default(string);
            txtVergiNo.Text = drsList[0].BlgVergiNo as string ?? default(string);
            txtIBAN.Text = drsList[0].BlgIban as string ?? default(string);
            txtAdres.Text = drsList[0].BlgAdres as string ?? default(string);
            txtKadi.Text = drsList[0].BlgKAdi as string ?? default(string);
            txtParola.Text= drsList[0].BlgParola as string ?? default(string);
            drs.BlgID = drsList[0].BlgID;
            drsinfo.BlgID = drs.BlgID;

            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            //this.Close();
            
            drs.BlgID = drsinfo.BlgID;
            int a = drs.BilgiSil(drs.BlgID);
            drsList = drs.BilgiGetir();
            cmbYetkili.Items.Clear();
            foreach (DershaneInfo item in drsList)
            {
                cmbYetkili.Items.Add(item.BlgYetkili);
            }
            cmbYetkili.SelectedIndex = 0;

        }
        int yeniKayit = 0;
        string gncAd = "";
        private void btnYeni_Click(object sender, EventArgs e)
        {
            gncAd = cmbYetkili.Text;
            yeniKayit = 1;           
            gbBilgiler.Controls.OfType<TextBox>().ToList().ForEach(x => x.Enabled=false);
            txtKadi.Enabled = true;
            txtParola.Enabled = true;
            txtYekili.Enabled = true;
            txtYekili.Clear();
            txtKadi.Clear();
            txtParola.Clear();
            cmbYetkili.Text = "";
        }
        DershaneInfo drsinfo = new DershaneInfo();
        private void cmbYetkili_SelectedIndexChanged(object sender, EventArgs e)
        {
            gncAd = cmbYetkili.Text;
            foreach (DershaneInfo item in drsList)
            {
                if (item.BlgYetkili == gncAd)
                    drsinfo = item;
            }
            txtKadi.Text = drsinfo.BlgKAdi;
            txtParola.Text = drsinfo.BlgParola;
        }
    }
}
