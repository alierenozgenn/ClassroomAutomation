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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }
        PersonelInfo perSec = new PersonelInfo();

        public PersonelInfo PerSec
        {
            get { return perSec; }
            set { perSec = value; }
        }
        private void btnAra_Click(object sender, EventArgs e)
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
                    break;
                }
                else
                {
                    persList = null;
                    MessageBox.Show("Kayıt yok.");
                    dgPrsListe.DataSource = null;

                    break;
                }
            }
           
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
        void gridDoldur(List<PersonelInfo> pers)
        {
            dgPrsListe.DataSource = null;
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

        private void dgPrsListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                perSec.PersonelID =Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[0].Value.ToString());
                perSec.PersonelAd = dgPrsListe.Rows[e.RowIndex].Cells[1].Value.ToString();
                perSec.PersonelSoyad = dgPrsListe.Rows[e.RowIndex].Cells[2].Value.ToString();
                perSec.PersonelKimlikNo = dgPrsListe.Rows[e.RowIndex].Cells[3].Value.ToString();
                perSec.PersonelUnvan = dgPrsListe.Rows[e.RowIndex].Cells[4].Value.ToString();
                perSec.PersonelDurum =(dgPrsListe.Rows[e.RowIndex].Cells[5].Value.ToString() == "1") ? 1 : 0;
                perSec.PersonelMaas = Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[6].Value.ToString());
                perSec.PersonelUcret = Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[7].Value.ToString());
                perSec.PersonelOgrtmn= (dgPrsListe.Rows[e.RowIndex].Cells[8].Value.ToString() == "0") ?1:0;
                perSec.PersonelGsm= dgPrsListe.Rows[e.RowIndex].Cells[9].Value.ToString();
                perSec.PersonelMail = dgPrsListe.Rows[e.RowIndex].Cells[10].Value.ToString();
                perSec.PersonelAdres = dgPrsListe.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPrsListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                perSec.PersonelID = Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[0].Value.ToString());
                perSec.PersonelAd = dgPrsListe.Rows[e.RowIndex].Cells[1].Value.ToString();
                perSec.PersonelSoyad = dgPrsListe.Rows[e.RowIndex].Cells[2].Value.ToString();
                perSec.PersonelKimlikNo = dgPrsListe.Rows[e.RowIndex].Cells[3].Value.ToString();
                perSec.PersonelUnvan = dgPrsListe.Rows[e.RowIndex].Cells[4].Value.ToString();
                perSec.PersonelDurum = (dgPrsListe.Rows[e.RowIndex].Cells[5].Value.ToString() == "1") ? 1 : 0;
                perSec.PersonelMaas = Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[6].Value.ToString());
                perSec.PersonelUcret = Convert.ToInt32(dgPrsListe.Rows[e.RowIndex].Cells[7].Value.ToString());
                perSec.PersonelOgrtmn = (dgPrsListe.Rows[e.RowIndex].Cells[8].Value.ToString() == "0") ? 1 : 0;
                perSec.PersonelGsm = dgPrsListe.Rows[e.RowIndex].Cells[9].Value.ToString();
                perSec.PersonelMail = dgPrsListe.Rows[e.RowIndex].Cells[10].Value.ToString();
                perSec.PersonelAdres = dgPrsListe.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            this.Close();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            PersonelInfo prslist = new PersonelInfo();
            gridDoldur(prslist.PersonelleriGetir(1));
        }
    }
}
