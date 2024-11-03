using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace MODEL
{
    public class OgrenciInfo:Helper
    {
        public OgrenciInfo() { }

        int ogrID;

        public int OgrID
        {
            get { return ogrID; }
            set { ogrID = value; }
        }
        int ogrNo;

        public int OgrNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }
        string ogrAd;

        public string OgrAd
        {
            get { return ogrAd; }
            set { ogrAd = value; }
        }
        string ogrSoyad;

        public string OgrSoyad
        {
            get { return ogrSoyad; }
            set { ogrSoyad = value; }
        }
        string ogrTcNo;

        public string OgrTcNo
        {
            get { return ogrTcNo; }
            set { ogrTcNo = value; }
        }
        int ogrCinsiyet;

        public int OgrCinsiyet
        {
            get { return ogrCinsiyet; }
            set { ogrCinsiyet = value; }
        }
        DateTime ogrSozTarihi;

        public DateTime OgrSozTarihi
        {
            get { return ogrSozTarihi; }
            set { ogrSozTarihi = value; }
        }
        int ogrSozTutar;

        public int OgrSozTutar
        {
            get { return ogrSozTutar; }
            set { ogrSozTutar = value; }
        }
        int ogrSozTaksit;

        public int OgrSozTaksit
        {
            get { return ogrSozTaksit; }
            set { ogrSozTaksit = value; }
        }
        string ogrTel;

        public string OgrTel
        {
            get { return ogrTel; }
            set { ogrTel = value; }
        }
        string ogrAdres;

        public string OgrAdres
        {
            get { return ogrAdres; }
            set { ogrAdres = value; }
        }
        string ogrAciklama;

        public string OgrAciklama
        {
            get { return ogrAciklama; }
            set { ogrAciklama = value; }
        }
        int ogrDurum;

        public int OgrDurum
        {
            get { return ogrDurum; }
            set { ogrDurum = value; }
        }
        public OgrenciInfo(int ogrID, int ogrNo, string ogrAd, string ogrSoyad, string ogrTcNo, int ogrCinsiyet, DateTime ogrSozTarihi, int ogrSozTutar, int ogrSozTaksit,
        string ogrTel, string ogrAdres, string ogrAciklama, int ogrDurum)
        {
            this.ogrID = ogrID;
            this.ogrNo = ogrNo;
            this.ogrAd = ogrAd;
            this.ogrSoyad = ogrSoyad;
            this.ogrTcNo = ogrTcNo;
            this.ogrCinsiyet = ogrCinsiyet;
            this.ogrSozTarihi = ogrSozTarihi;
            this.ogrSozTutar = ogrSozTutar;
            this.ogrSozTaksit = ogrSozTaksit;
            this.ogrTel = ogrTel;
            this.ogrAdres = ogrAdres;
            this.ogrAciklama = ogrAciklama;
            this.ogrDurum = ogrDurum;
        }



        public int OgrenciEkle(OgrenciInfo info)
        {

            bool ogrenciVar = false;
            SqlParameter[] paramsql = new SqlParameter[12] { 
        new SqlParameter("@OgrNo",SqlDbType.Int),
        new SqlParameter("@OgrAd",SqlDbType.VarChar),
        new SqlParameter("@OgrSoyad",SqlDbType.VarChar),
        new SqlParameter("@OgrTcNo",SqlDbType.VarChar),
        new SqlParameter("@OgrCinsiyet",SqlDbType.Int),
        new SqlParameter("@OgrSozTarihi",SqlDbType.Date),
        new SqlParameter("@OgrSozTutar",SqlDbType.Int),
        new SqlParameter("@OgrSozTaksit",SqlDbType.Int),
        new SqlParameter("@OgrTel",SqlDbType.VarChar),
        new SqlParameter("@OgrAdres",SqlDbType.VarChar),
        new SqlParameter("@OgrAciklama",SqlDbType.VarChar),
        new SqlParameter("@OgrDurum",SqlDbType.Int)
        };
            int a = 0;
            if (!ogrenciVar)
            {
               // Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.ogrNo;
                    paramsql[1].Value = info.ogrAd;
                    paramsql[2].Value = info.ogrSoyad;
                    paramsql[3].Value = info.ogrTcNo;
                    paramsql[4].Value = info.ogrCinsiyet;
                    paramsql[5].Value = info.ogrSozTarihi;
                    paramsql[6].Value = info.ogrSozTutar;
                    paramsql[7].Value = info.ogrSozTaksit;
                    paramsql[8].Value = info.ogrTel;
                    paramsql[9].Value = info.ogrAdres;
                    paramsql[10].Value = info.ogrAciklama;
                    paramsql[11].Value = info.ogrDurum;
                    a = ExecuteNonQuery("OGRENCIEKLE", CommandType.StoredProcedure, paramsql);
                    //a = 1;
                }
                catch (SqlException ex)
                {

                    //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                    a = 2;
                }
            }
            else
            {

                a = 3;
            }
            return a;
        }
        public int OgrenciGuncelle(OgrenciInfo info)
        {

            bool personelVar = false;
            SqlParameter[] paramsql = new SqlParameter[13] { 
        new SqlParameter("@OgrenciID",SqlDbType.Int),
        new SqlParameter("@OgrNo",SqlDbType.Int),
        new SqlParameter("@OgrAd",SqlDbType.VarChar),
        new SqlParameter("@OgrSoyad",SqlDbType.VarChar),
        new SqlParameter("@OgrTcNo",SqlDbType.VarChar),
        new SqlParameter("@OgrCinsiyet",SqlDbType.Int),
        new SqlParameter("@OgrSozTarihi",SqlDbType.Date),
        new SqlParameter("@OgrSozTutar",SqlDbType.Int),
        new SqlParameter("@OgrSozTaksit",SqlDbType.Int),
        new SqlParameter("@OgrTel",SqlDbType.VarChar),
        new SqlParameter("@OgrAdres",SqlDbType.VarChar),
        new SqlParameter("@OgrAciklama",SqlDbType.VarChar),
        new SqlParameter("@OgrDurum",SqlDbType.Int)
        };
            int a = 0;
            if (!personelVar)
            {
               // Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.ogrID;
                    paramsql[1].Value = info.ogrNo;
                    paramsql[2].Value = info.ogrAd;
                    paramsql[3].Value = info.ogrSoyad;
                    paramsql[4].Value = info.ogrTcNo;
                    paramsql[5].Value = info.ogrCinsiyet;
                    paramsql[6].Value = info.ogrSozTarihi;
                    paramsql[7].Value = info.ogrSozTutar;
                    paramsql[8].Value = info.ogrSozTaksit;
                    paramsql[9].Value = info.ogrTel;
                    paramsql[10].Value = info.ogrAdres;
                    paramsql[11].Value = info.ogrAciklama;
                    paramsql[12].Value = info.ogrDurum;
                    a = ExecuteNonQuery("OGRENCIGUNCELLE", CommandType.StoredProcedure, paramsql);
                    //a = 1;
                }
                catch (SqlException ex)
                {
                    //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                    a = 2;
                }
            }
            else
            {
                a = 3;
            }
            return a;
        }
        public List<OgrenciInfo> OgrencileriGetir(int ogrenciDurum)
        {
            SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@OgrDurum",SqlDbType.Int)
            };
            paramdizi[0].Value = ogrenciDurum;
           // Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("OGRENCILERIGETIR", CommandType.StoredProcedure, paramdizi);
            List<OgrenciInfo> ogrenciListe = new List<OgrenciInfo>();
            while (dr.Read())
            {
                OgrenciInfo info = new OgrenciInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetDateTime(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10), dr.GetString(11), dr.GetInt32(12));
                ogrenciListe.Add(info);
            }
            return ogrenciListe;

        }
        public List<OgrenciInfo> OgrenciNoGetir(int ogrenciNo)
        {
            SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@OgrNO",SqlDbType.Int)
            };
            paramdizi[0].Value = ogrenciNo;
          //  Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("OGRENCINOGETIR", CommandType.StoredProcedure, paramdizi);
            List<OgrenciInfo> ogrenciListe = new List<OgrenciInfo>();
            while (dr.Read())
            {
                OgrenciInfo info = new OgrenciInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetDateTime(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10), dr.GetString(11), dr.GetInt32(12));
                ogrenciListe.Add(info);
            }
            return ogrenciListe;

        }
        public List<OgrenciInfo> TumOgrencileriGetir()
        {
            SqlParameter[] paramdizi = null;
            //Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("OGRENCIGETIRTUM", CommandType.StoredProcedure, paramdizi);
            List<OgrenciInfo> ogrenciListe = new List<OgrenciInfo>();
            while (dr.Read())
            {
                OgrenciInfo info = new OgrenciInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetDateTime(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10), dr.GetString(11), dr.GetInt32(12));
                ogrenciListe.Add(info);
            }
            return ogrenciListe;

        }
        public int OgrenciSil(int ogrenciID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@OgrenciID",SqlDbType.Int)
                };
            paramdizi[0].Value = ogrenciID;
            //Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("OGRENCISIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }
        /*

        PrintDocument pd = new PrintDocument();
        PrintPreviewDialog pDialog = new PrintPreviewDialog();
        Font Baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);
       // OgrenciInfo ogr = new OgrenciInfo();
        List<OgrenciInfo> ogrListYaz = new List<OgrenciInfo>();

        public void TumOgrYazdir(List<OgrenciInfo> OgrLst)
        {
            this.ogrListYaz = OgrLst;
            pd.PrintPage += Pd_PrintOgrList;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
/*
        private void Pd_PrintOgrList(object sender, PrintPageEventArgs e)
        {
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("ÖĞRENCİ LİSTESİ", Baslik, sb, 300, 30);
            e.Graphics.DrawString("NO", Baslik, sb, 100, 80);
            e.Graphics.DrawString("KİMLİK NO", Baslik, sb, 160, 80);
            e.Graphics.DrawString("ADI", Baslik, sb, 300, 80);
            e.Graphics.DrawString("SOYADI", Baslik, sb, 450, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < ogrListYaz.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govde, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(ogrListYaz[i].OgrNo.ToString(), govde, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(ogrListYaz[i].OgrTcNo.ToString(), govde, sb, 160, 110 + (i * 30));
                e.Graphics.DrawString(ogrListYaz[i].OgrAd.ToString(), govde, sb, 300, 110 + (i * 30));
                e.Graphics.DrawString(ogrListYaz[i].OgrSoyad.ToString(), govde, sb, 450, 110 + (i * 30));
                // e.Graphics.DrawString(ogrListYaz[i].OgrSozTarihi.Date.ToString(), govde, sb, 550, 190 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (ogrListYaz.Count * 30));

        }

        public List<OgrenciInfo> TumOgrencileriGetir(int v)
        {
            throw new NotImplementedException();
        }*/
    }
}
/*
        int ogrID;
        int ogrNo;
        string ogrAd;
        string ogrSoyad;
        string ogrTcNo;
        int ogrCinsiyet;
        DateTime ogrSozTarihi;
        int ogrSozTutar;
        int ogrSozTaksit;
        string ogrTel;
        string ogrAdres;
        string ogrAciklama;
        int ogDurum;
 */