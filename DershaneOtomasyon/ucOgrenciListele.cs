using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyon
{
    public partial class ucOgrenciListele : UserControl
    {
        public ucOgrenciListele()
        {
            InitializeComponent();
        }

        OgrenciInfo ogrenciBilgi = new OgrenciInfo();

        public OgrenciInfo OgrenciBilgi
        {
            get { return ogrenciBilgi; }
            set { ogrenciBilgi = value; }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<OgrenciInfo> ogrList = new List<OgrenciInfo>();
            List<OgrenciInfo> ogrListTemp = new List<OgrenciInfo>();
            OgrenciInfo tOgrs = new OgrenciInfo();
            ogrListTemp = tOgrs.TumOgrencileriGetir();
            foreach (OgrenciInfo ogr in ogrListTemp)
            {
                if (ogr.OgrAd == txtOgrAdiAra.Text)
                 {
                ogrList.Add(ogr);
                gridDoldur(ogrList);
                break;
                 }
                 else
                 {
                ogrList = null;
                MessageBox.Show("Kayıt yok.");
                dgOgrenciList.DataSource=null;       
                  break;
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
            dgOgrenciList.Columns[0].Visible = false;
            dgOgrenciList.Columns[11].Visible = false;
            dgOgrenciList.Columns[12].Visible = false;

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

        private void ucOgrenciListele_Load(object sender, EventArgs e)
        {
            OgrenciInfo ogr = new OgrenciInfo();
           gridDoldur(ogr.OgrencileriGetir(1));
            
        }

        private void dgOgrenciList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ogrenciBilgi.OgrID = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[0].Value.ToString());
                ogrenciBilgi.OgrNo = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[1].Value.ToString());
                ogrenciBilgi.OgrAd = dgOgrenciList.Rows[e.RowIndex].Cells[2].Value.ToString();
                ogrenciBilgi.OgrSoyad = dgOgrenciList.Rows[e.RowIndex].Cells[3].Value.ToString();
                ogrenciBilgi.OgrTcNo = dgOgrenciList.Rows[e.RowIndex].Cells[4].Value.ToString();
                ogrenciBilgi.OgrCinsiyet =Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[5].Value.ToString());
                ogrenciBilgi.OgrSozTarihi = DateTime.Now.Date;// Convert.ToDateTime(dgOgrenciList.Rows[e.RowIndex].Cells[5].Value.ToString());
                ogrenciBilgi.OgrSozTutar = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[7].Value.ToString());
                ogrenciBilgi.OgrSozTaksit = Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[8].Value.ToString());
                ogrenciBilgi.OgrTel = dgOgrenciList.Rows[e.RowIndex].Cells[9].Value.ToString();
                ogrenciBilgi.OgrAdres = dgOgrenciList.Rows[e.RowIndex].Cells[10].Value.ToString();
                ogrenciBilgi.OgrAciklama = dgOgrenciList.Rows[e.RowIndex].Cells[11].Value.ToString();
                ogrenciBilgi.OgrDurum =Convert.ToInt32(dgOgrenciList.Rows[e.RowIndex].Cells[12].Value.ToString());


            }
     
        }
    }
}
