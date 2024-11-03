using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class OdemeVadeInfo:Helper
    {
        public OdemeVadeInfo() { }
        int odvID;

        public int OdvID
        {
            get { return odvID; }
            set { odvID = value; }
        }
        int odvOdemeID;

        public int OdvOdemeID
        {
            get { return odvOdemeID; }
            set { odvOdemeID = value; }
        }
        int odvOgrID;

        public int OdvOgrID
        {
            get { return odvOgrID; }
            set { odvOgrID = value; }
        }
        int odvVadeMiktar;

        public int OdvVadeMiktar
        {
            get { return odvVadeMiktar; }
            set { odvVadeMiktar = value; }
        }
        DateTime odvVadeTarihi;

        public DateTime OdvVadeTarihi
        {
            get { return odvVadeTarihi; }
            set { odvVadeTarihi = value; }
        }
        DateTime odvOdemeTarihi;

        public DateTime OdvOdemeTarihi
        {
            get { return odvOdemeTarihi; }
            set { odvOdemeTarihi = value; }
        }
        string odvAciklama;

        public string OdvAciklama
        {
            get { return odvAciklama; }
            set { odvAciklama = value; }
        }
        int odvOdemeDurumu;

        public int OdvOdemeDurumu
        {
            get { return odvOdemeDurumu; }
            set { odvOdemeDurumu = value; }
        }
        int odvDurum;

        public int OdvDurum
        {
            get { return odvDurum; }
            set { odvDurum = value; }
        }

        public OdemeVadeInfo(int odvID, int odvOdemeID, int odvOgrID, int odvVadeMiktar, DateTime odvVadeTarihi, DateTime odvOdemeTarihi, string odvAciklama, int odvOdemeDurumu, int odvDurum)
        {
            this.odvID = odvID;
            this.odvOdemeID = odvOdemeID;
            this.odvOgrID = odvOgrID;
            this.odvVadeMiktar = odvVadeMiktar;
            this.odvVadeTarihi = odvVadeTarihi;
            this.odvOdemeTarihi = odvOdemeTarihi;
            this.odvAciklama = odvAciklama;
            this.odvOdemeDurumu = odvOdemeDurumu;
            this.odvDurum = odvDurum;
        }

        public int OdemeVadeEkle(OdemeVadeInfo info)
        {

           
            SqlParameter[] paramsql = new SqlParameter[8] { 
        new SqlParameter("@OdvOdemeID",SqlDbType.Int),
        new SqlParameter("@OdvOgrID",SqlDbType.Int),
        new SqlParameter("@OdvVadeMiktar",SqlDbType.Int),
        new SqlParameter("@OdvVadeTarihi",SqlDbType.Date),
        new SqlParameter("@OdvOdemeTarihi",SqlDbType.Date),
        new SqlParameter("@OdvAciklama",SqlDbType.VarChar),
        new SqlParameter("@OdvOdemeDurumu",SqlDbType.Int),
        new SqlParameter("@OdvDurum",SqlDbType.Int),      
        };
            int a = 0;
           // Helper hlp = new Helper();
            try
            {
                paramsql[0].Value = info.odvOdemeID;
                paramsql[1].Value = info.odvOgrID;
                paramsql[2].Value = info.odvVadeMiktar;
                paramsql[3].Value = info.odvVadeTarihi;
                paramsql[4].Value = info.odvOdemeTarihi;
                paramsql[5].Value = info.odvAciklama;
                paramsql[6].Value = info.odvOdemeDurumu;
                paramsql[7].Value = info.odvDurum;

                a = ExecuteNonQuery("ODEMEVADEEKLE", CommandType.StoredProcedure, paramsql);
                //   a = 1;
            }
            catch (SqlException ex)
            {

                //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                a = 2;
            }


            return a;
        }
        public int OdemeVadeGuncelle(OdemeVadeInfo info)
        {


            SqlParameter[] paramsql = new SqlParameter[9] { 
        new SqlParameter("@OdvID",SqlDbType.Int),
        new SqlParameter("@OdvOdemeID",SqlDbType.Int),
        new SqlParameter("@OdvOgrID",SqlDbType.Int),
        new SqlParameter("@OdvVadeMiktar",SqlDbType.Int),
        new SqlParameter("@OdvVadeTarihi",SqlDbType.Date),
        new SqlParameter("@OdvOdemeTarihi",SqlDbType.Date),
        new SqlParameter("@OdvAciklama",SqlDbType.VarChar),
        new SqlParameter("@OdvOdemeDurumu",SqlDbType.Int),
        new SqlParameter("@OdvDurum",SqlDbType.Int), 
        };
            int a = 0;

            //Helper hlp = new Helper();
            try
            {
                paramsql[0].Value = info.odvID;
                paramsql[1].Value = info.odvOdemeID;
                paramsql[2].Value = info.odvOgrID;
                paramsql[3].Value = info.odvVadeMiktar;
                paramsql[4].Value = info.odvVadeTarihi;
                paramsql[5].Value = info.odvOdemeTarihi;
                paramsql[6].Value = info.odvAciklama;
                paramsql[7].Value = info.odvOdemeDurumu;
                paramsql[8].Value = info.odvDurum;

                a = ExecuteNonQuery("ODEMEVADEGUNCELLE", CommandType.StoredProcedure, paramsql);
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
        public List<OdemeVadeInfo> OdemeVadeleriGetir(int odvDurum)
        {
            SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@OdvDurum",SqlDbType.Int)
            };

            paramdizi[0].Value = odvDurum;
           // Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("ODEMEVADELERIGETIR", CommandType.StoredProcedure, paramdizi);
            List<OdemeVadeInfo> odemeVadeListe = new List<OdemeVadeInfo>();
            while (dr.Read())
            {
                OdemeVadeInfo info = new OdemeVadeInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetDateTime(4), dr.GetDateTime(5), dr.GetString(6), dr.GetInt32(7), dr.GetInt32(8));
                odemeVadeListe.Add(info);
            }
            return odemeVadeListe;

        }
        public List<OdemeVadeInfo> TumOdemeVadeleriGetir()
        {
            SqlParameter[] paramdizi = null;// new SqlParameter[]{
            //  new SqlParameter("@PersonelDurum",SqlDbType.Int)
            //   };

            // paramdizi[0].Value = personelDurum;
           // Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("ODEMEVADEGETIRTUM", CommandType.StoredProcedure, paramdizi);
            List<OdemeVadeInfo> odemeVadeListe = new List<OdemeVadeInfo>();
            while (dr.Read())
            {
                OdemeVadeInfo info = new OdemeVadeInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetDateTime(4), dr.GetDateTime(5), dr.GetString(6), dr.GetInt32(7), dr.GetInt32(8));
                odemeVadeListe.Add(info);
            }
            return odemeVadeListe;

        }
        public int OdemeVadeSil(int odvID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@OdvID",SqlDbType.Int)
                };
            paramdizi[0].Value = odvID;
           // Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("ODEMEVADESIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }
        public int OdemeVadeTumSil(int odvOgrID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@OdvOgrID",SqlDbType.Int)
                };
            paramdizi[0].Value = odvOgrID;
           // Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("ODEMEVADETUMSIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }
    }
}
