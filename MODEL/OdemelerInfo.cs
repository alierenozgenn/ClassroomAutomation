using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class OdemelerInfo:Helper
    {
        public OdemelerInfo() { }

        int odemeID;

        public int OdemeID
        {
            get { return odemeID; }
            set { odemeID = value; }
        }
        string odemeSekli;

        public string OdemeSekli
        {
            get { return odemeSekli; }
            set { odemeSekli = value; }
        }
        string odemeIslem;

        public string OdemeIslem
        {
            get { return odemeIslem; }
            set { odemeIslem = value; }
        }
        DateTime odemeTarih;

        public DateTime OdemeTarih
        {
            get { return odemeTarih; }
            set { odemeTarih = value; }
        }
        int odemeTutar;

        public int OdemeTutar
        {
            get { return odemeTutar; }
            set { odemeTutar = value; }
        }
        int odemeBelNo;

        public int OdemeBelNo
        {
            get { return odemeBelNo; }
            set { odemeBelNo = value; }
        }
        string odemeAciklama;

        public string OdemeAciklama
        {
            get { return odemeAciklama; }
            set { odemeAciklama = value; }
        }
        int odemeKisiID;

        public int OdemeKisiID
        {
            get { return odemeKisiID; }
            set { odemeKisiID = value; }
        }
        int odemeTuru;

        public int OdemeTuru
        {
            get { return odemeTuru; }
            set { odemeTuru = value; }
        }
        int odemeDurum;

        public int OdemeDurum
        {
            get { return odemeDurum; }
            set { odemeDurum = value; }
        }
        public OdemelerInfo(int odemeID, string odemeSekli, string odemeIslem, DateTime odemeTarih, int odemeTutar, int odemeBelNo, string odemeAciklama, int odemeKisiID, int odemeTuru, int odemeDurum)
        {
            this.odemeID = odemeID;
            this.odemeSekli = odemeSekli;
            this.odemeIslem = odemeIslem;
            this.odemeTarih = odemeTarih;
            this.odemeTutar = odemeTutar;
            this.odemeBelNo = odemeBelNo;
            this.odemeAciklama = odemeAciklama;
            this.odemeKisiID = odemeKisiID;
            this.odemeTuru = odemeTuru;
            this.odemeDurum = odemeDurum;    
        }
        public int OdemeEkle(OdemelerInfo info)
        {

           // bool personelVar = false;
            SqlParameter[] paramsql = new SqlParameter[8] { 
        new SqlParameter("@OdemeSekli",SqlDbType.VarChar),
        new SqlParameter("@OdemeIslem",SqlDbType.VarChar),
        new SqlParameter("@OdemeTarih",SqlDbType.Date),
        new SqlParameter("@OdemeTutar",SqlDbType.Int),
        new SqlParameter("@OdemeBelNo",SqlDbType.Int),
        new SqlParameter("@OdemeAciklama",SqlDbType.VarChar),
        new SqlParameter("@OdemeKisiID",SqlDbType.Int),
        new SqlParameter("@OdemeTuru",SqlDbType.Int),
        };
            int a = 0;
             //   Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.odemeSekli;
                    paramsql[1].Value = info.odemeIslem;
                    paramsql[2].Value = info.odemeTarih;
                    paramsql[3].Value = info.odemeTutar;
                    paramsql[4].Value = info.odemeBelNo;
                    paramsql[5].Value = info.odemeAciklama;
                    paramsql[6].Value = info.odemeKisiID;
                    paramsql[7].Value = info.odemeTuru;
                 
                    a = ExecuteNonQuery("ODEMEEKLE", CommandType.StoredProcedure, paramsql);
                 //   a = 1;
                }
                catch (SqlException ex)
                {

                    //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                    a = 2;
                }
           
    
            return a;
        }
        public int OdemeGuncelle(OdemelerInfo info)
        {

           
            SqlParameter[] paramsql = new SqlParameter[10] { 
        new SqlParameter("@OdemeID",SqlDbType.Int),
        new SqlParameter("@OdemeSekli",SqlDbType.VarChar),
        new SqlParameter("@OdemeIslem",SqlDbType.VarChar),
        new SqlParameter("@OdemeTarih",SqlDbType.Date),
        new SqlParameter("@OdemeTutar",SqlDbType.Int),
        new SqlParameter("@OdemeBelNo",SqlDbType.Int),
        new SqlParameter("@OdemeAciklama",SqlDbType.VarChar),
        new SqlParameter("@OdemeKisiID",SqlDbType.Int),
        new SqlParameter("@OdemeTuru",SqlDbType.Int),
        new SqlParameter("@OdemeDurum",SqlDbType.Int),
        };
            int a = 0;
      
              //  Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.odemeID;
                    paramsql[1].Value = info.odemeSekli;
                    paramsql[2].Value = info.odemeIslem;
                    paramsql[3].Value = info.odemeTarih;
                    paramsql[4].Value = info.odemeTutar;
                    paramsql[5].Value = info.odemeBelNo;
                    paramsql[6].Value = info.odemeAciklama;
                    paramsql[7].Value = info.odemeKisiID;
                    paramsql[8].Value = info.odemeTuru;
                    paramsql[9].Value = info.odemeDurum;

                    a = ExecuteNonQuery("ODEMEGUNCELLE", CommandType.StoredProcedure, paramsql);
                    //a = 1;
                }
                catch (SqlException ex)
                {

                    //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                    a = 2;
                }
         

                a = 3;
     
            return a;
        }
        public List<OdemelerInfo> OdemeleriGetir(int odemeDurum)
        {
            SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@OdemeDurum",SqlDbType.Int)
            };

            paramdizi[0].Value = odemeDurum;
           // Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("ODEMELERIGETIR", CommandType.StoredProcedure, paramdizi);
            List<OdemelerInfo> odemeListe = new List<OdemelerInfo>();
            while (dr.Read())
            {
                OdemelerInfo info = new OdemelerInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetString(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetInt32(9));
                odemeListe.Add(info);
            }
            return odemeListe;

        }
        public List<OdemelerInfo> TumOdemeleriGetir()
        {
            SqlParameter[] paramdizi = null;// new SqlParameter[]{
            //  new SqlParameter("@PersonelDurum",SqlDbType.Int)
            //   };

            // paramdizi[0].Value = personelDurum;
           // Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("ODEMEGETIRTUM", CommandType.StoredProcedure, paramdizi);
            List<OdemelerInfo> odemeListe = new List<OdemelerInfo>();
            while (dr.Read())
            {
                OdemelerInfo info = new OdemelerInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetString(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetInt32(9));
                odemeListe.Add(info);
            }
            return odemeListe;

        }
        public int OdemeSil(int odemeID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@OdemeID",SqlDbType.Int)
                };
            paramdizi[0].Value = odemeID;
           // Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("ODEMESIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }
    }
}
