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
    public partial class frmOgrenciListele : Form
    {
        public frmOgrenciListele()
        {
            InitializeComponent();
        }
        OgrenciInfo ogrSec = new OgrenciInfo();
        public OgrenciInfo OgrSec
        {
            get { return ogrSec; }
            set { ogrSec = value; }
        }
        private void ucOgrenciListele1_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            List<OgrenciInfo> ogrListTemp = new List<OgrenciInfo>();
            OgrenciInfo tOgrs = new OgrenciInfo();
            ogrListTemp = tOgrs.TumOgrencileriGetir();
            int ogrvar = 0;
            foreach (OgrenciInfo ogr in ogrListTemp)
            {
                if (ogr.OgrAd == txtOgrAdiAra.Text)
                {
                    ogrList.Add(ogr);
                    ogrvar = 1;
                    break;
                }
            }
            if (ogrvar == 1)
                gridDoldur(ogrList);
            else
            {
                ogrList = null;
                MessageBox.Show("Kayıt yok.");
                dgOgrenciList.DataSource = null;
            }
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
            dgOgrenciList.Columns[0].Visible = false;
            dgOgrenciList.Columns[11].Visible = false;
            dgOgrenciList.Columns[12].Visible = false;

        }

        private void dgOgrenciList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ogrSec.OgrID = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[0].Value.ToString());
                ogrSec.OgrNo = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[1].Value.ToString());
                ogrSec.OgrAd = dgOgrenciList.Rows[e.RowIndex].Cells[2].Value.ToString();
                ogrSec.OgrSoyad = dgOgrenciList.Rows[e.RowIndex].Cells[3].Value.ToString();
                ogrSec.OgrTcNo = dgOgrenciList.Rows[e.RowIndex].Cells[4].Value.ToString();
                ogrSec.OgrCinsiyet = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[5].Value.ToString());
                ogrSec.OgrSozTarihi = DateTime.Now.Date;//dgOgrenciList.Rows[e.RowIndex].Cells[6].Value.ToString();
                ogrSec.OgrSozTutar = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[7].Value.ToString());
                ogrSec.OgrSozTaksit = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[8].Value.ToString());
                ogrSec.OgrTel = dgOgrenciList.Rows[e.RowIndex].Cells[9].Value.ToString();
                ogrSec.OgrAdres = dgOgrenciList.Rows[e.RowIndex].Cells[10].Value.ToString();
                ogrSec.OgrAciklama = dgOgrenciList.Rows[e.RowIndex].Cells[11].Value.ToString();
            }

            this.Close();
        }


        private void frmOgrenciListele_Load(object sender, EventArgs e)
        {
             OgrenciInfo ogrlist = new OgrenciInfo();
             gridDoldur(ogrlist.OgrencileriGetir(1));
        }

        private void dgOgrenciList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ogrSec.OgrID = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[0].Value.ToString());
                ogrSec.OgrNo = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[1].Value.ToString());
                ogrSec.OgrAd = dgOgrenciList.Rows[e.RowIndex].Cells[2].Value.ToString();
                ogrSec.OgrSoyad = dgOgrenciList.Rows[e.RowIndex].Cells[3].Value.ToString();
                ogrSec.OgrTcNo = dgOgrenciList.Rows[e.RowIndex].Cells[4].Value.ToString();
                ogrSec.OgrCinsiyet = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[5].Value.ToString());
                ogrSec.OgrSozTarihi = DateTime.Now.Date;//dgOgrenciList.Rows[e.RowIndex].Cells[6].Value.ToString();
                ogrSec.OgrSozTutar = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[7].Value.ToString());
                ogrSec.OgrSozTaksit = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[8].Value.ToString());
                ogrSec.OgrTel = dgOgrenciList.Rows[e.RowIndex].Cells[9].Value.ToString();
                ogrSec.OgrAdres = dgOgrenciList.Rows[e.RowIndex].Cells[10].Value.ToString();
                ogrSec.OgrAciklama = dgOgrenciList.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }
    }
}
