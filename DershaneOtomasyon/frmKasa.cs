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
using System.Data.Sql;

namespace DershaneOtomasyon
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        OdemelerInfo odmInfo = new OdemelerInfo();

        public OdemelerInfo OdmInfo
        {
            get { return odmInfo; }
            set { odmInfo = value; }
        }
        private void frmKasa_Load(object sender, EventArgs e)
        {
            OdemelerInfo odeme = new OdemelerInfo();
            gridDoldur(odeme.OdemeleriGetir(1));
        }
        List<OdemelerInfo> odemYaz = new List<OdemelerInfo>();
        void gridDoldur(List<OdemelerInfo> odem)
        {
            odemYaz = odem;
            dgdOdemeListele.DataSource = null;
            //dgPrsListe.Refresh();
            dgdOdemeListele.DataSource = odem;
            dgdOdemeListele.Columns[0].Width = 40;
        /*    dgdOdemeListele.Columns[1].HeaderText = "ADI";
            dgdOdemeListele.Columns[2].HeaderText = "SOYADI";
            dgdOdemeListele.Columns[3].HeaderText = "KİMLİKNO";
            
            /*
            dgdOdemeListele.Columns[0].Visible = false;
            dgdOdemeListele.Columns[4].Visible = false;
            dgdOdemeListele.Columns[5].Visible = false;
            dgdOdemeListele.Columns[6].Visible = false;
            dgdOdemeListele.Columns[7].Visible = false;
            dgdOdemeListele.Columns[8].Visible = false;
            dgdOdemeListele.Columns[9].Visible = false;
            */

        }

        private void cmbTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo>odemeList=new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
            foreach (OdemelerInfo odm in odemeList)
            {
                    if (cmbTuru.SelectedIndex==0 & odm.OdemeTuru == 1)
                    {
                        odemeListTemp.Add(odm);
                    }
                    else if(cmbTuru.SelectedIndex==1 & odm.OdemeTuru == 0)
                    { 
                        odemeListTemp.Add(odm); 
                    }
                    else if (cmbTuru.SelectedIndex == 2)
                    {
                        odemeListTemp.Add(odm);
                    }
            }
            gridDoldur(odemeListTemp);
        }

        private void cmbIslemSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
            foreach (OdemelerInfo odm in odemeList)
            {
                if (cmbOdemeSekli.SelectedIndex == 0 & odm.OdemeSekli == "Nakit")
                {
                    odemeListTemp.Add(odm);
                }
                else if (cmbOdemeSekli.SelectedIndex == 1 & odm.OdemeSekli == "Kredi Kartı")
                {
                    odemeListTemp.Add(odm);
                }
                else if (cmbOdemeSekli.SelectedIndex == 2 & odm.OdemeSekli == "Çek")
                {
                    odemeListTemp.Add(odm);
                }
                else if (cmbOdemeSekli.SelectedIndex == 3 & odm.OdemeSekli == "Banka")
                {
                    odemeListTemp.Add(odm);
                }
                else if (cmbOdemeSekli.SelectedIndex == 4 & odm.OdemeSekli == "Diğer")
                {
                    odemeListTemp.Add(odm);
                }
                else if (cmbOdemeSekli.SelectedIndex == 5)
                { 
                    odemeListTemp.Add(odm); 
                }
            }
            gridDoldur(odemeListTemp);
        }
        public void TarihSorgula(DateTime once,DateTime sonra)
        {
          //  DateTime dtOnce = dtpOnce.Value;
           // DateTime dtSonra = dtpSonra.Value;
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
            foreach (OdemelerInfo odm in odemeList)
            {
                DateTime odmTarih = odm.OdemeTarih;
                if (odmTarih >= once & odmTarih <= sonra)
                {
                    odemeListTemp.Add(odm);
                }

            }
            gridDoldur(odemeListTemp);



        }

        private void btnTarihSorgula_Click(object sender, EventArgs e)
        {
            DateTime dtOnce = dtpOnce.Value;
            DateTime dtSonra = dtpSonra.Value;
            TarihSorgula(dtOnce, dtSonra);
         


        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            DateTime dtOnce = DateTime.Now.AddDays(-7);//1 hafta öncesi olacak
            DateTime dtSonra = DateTime.Now.Date;
            TarihSorgula(dtOnce, dtSonra);
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            DateTime dtOnce = DateTime.Now.AddMonths(-1);//1 ay öncesi olacak
            DateTime dtSonra = DateTime.Now.Date;
            TarihSorgula(dtOnce, dtSonra);
        }

        private void btnYillik_Click(object sender, EventArgs e)
        {
            DateTime dtOnce = DateTime.Now.AddYears(-1);//1 yıl öncesi olacak
            DateTime dtSonra = DateTime.Now.Date;
            TarihSorgula(dtOnce, dtSonra);
        }

        private void btnTahsilat_Click(object sender, EventArgs e)
        {
            frmOdeme frmOdemeEkle = new frmOdeme();
            frmOdemeEkle.ShowDialog();
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            frmOdeme frmOdemeEkle = new frmOdeme();
            
            frmOdemeEkle.ShowDialog();
        }

        private void dgdOdemeListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {                   
                odmInfo.OdemeID=Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[0].Value.ToString());
                odmInfo.OdemeSekli=dgdOdemeListele.Rows[e.RowIndex].Cells[1].Value.ToString();
                odmInfo.OdemeIslem = dgdOdemeListele.Rows[e.RowIndex].Cells[2].Value.ToString();
                odmInfo.OdemeTarih =Convert.ToDateTime(dgdOdemeListele.Rows[e.RowIndex].Cells[3].Value.ToString());
                odmInfo.OdemeTutar =Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[4].Value.ToString());
                odmInfo.OdemeBelNo =Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[5].Value.ToString());
                odmInfo.OdemeAciklama =dgdOdemeListele.Rows[e.RowIndex].Cells[6].Value.ToString();
                odmInfo.OdemeKisiID =Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[7].Value.ToString());
                odmInfo.OdemeTuru=Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[8].Value.ToString());
                odmInfo.OdemeDurum=Convert.ToInt32(dgdOdemeListele.Rows[e.RowIndex].Cells[9].Value.ToString());
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // OdemelerInfo ogrOdeme = new OdemelerInfo();
            frmOdeme ogrList = new frmOdeme()
            {
                OgrSec = odmInfo
            };
            ogrList.ShowDialog();
            gridDoldur(odmInfo.OdemeleriGetir(1));   
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OdemelerInfo ogrOdeme = new OdemelerInfo();
            ogrOdeme.OdemeSil(odmInfo.OdemeID);
            gridDoldur(odmInfo.OdemeleriGetir(1));
        }

        private void dgdOdemeListele_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgdOdemeListele.Rows[e.RowIndex].Cells[8].Value.ToString() == "1" )
            {
                dgdOdemeListele.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.RoyalBlue;
            }
            else
            {
                dgdOdemeListele.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintMod pM = new PrintMod();
            pM.TumOdemeYaz(odemYaz);
        }
    }
}
