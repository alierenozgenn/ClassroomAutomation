using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MODEL
{
    public class DershaneInfo:Helper
    {
        public DershaneInfo() { }
        int blgID;
        string blgDershaneAd;
        string blgTel;
        string blgVergiDairesi;
        string blgVergiNo;
        string blgIban;
        string blgYetkili;
        string blgAdres;
        string blgKAdi;
        string blgParola;
        public int BlgID{get{ return blgID;}set{blgID = value;}}

        public string BlgDershaneAd
        {
            get
            {
                return blgDershaneAd;
            }

            set
            {
                blgDershaneAd = value;
            }
        }

        public string BlgTel
        {
            get
            {
                return blgTel;
            }

            set
            {
                blgTel = value;
            }
        }

        public string BlgVergiDairesi
        {
            get
            {
                return blgVergiDairesi;
            }

            set
            {
                blgVergiDairesi = value;
            }
        }

        public string BlgVergiNo
        {
            get
            {
                return blgVergiNo;
            }

            set
            {
                blgVergiNo = value;
            }
        }

        public string BlgIban
        {
            get
            {
                return blgIban;
            }

            set
            {
                blgIban = value;
            }
        }

        public string BlgYetkili
        {
            get
            {
                return blgYetkili;
            }

            set
            {
                blgYetkili = value;
            }
        }

        public string BlgAdres
        {
            get
            {
                return blgAdres;
            }

            set
            {
                blgAdres = value;
            }
        }

        public string BlgKAdi
        {
            get
            {
                return blgKAdi;
            }

            set
            {
                blgKAdi = value;
            }
        }

        public string BlgParola
        {
            get
            {
                return blgParola;
            }

            set
            {
                blgParola = value;
            }
        }

        public DershaneInfo(int blgID,string blgDershaneAd,string blgTel,string blgVergiDairesi,string blgVergiNo,string blgIban, string blgYetkili, string blgAdres,string blgKAdi,string blgParola)
        {
            this.blgID = blgID;
            this.blgDershaneAd = blgDershaneAd;
            this.blgTel = blgTel;
            this.blgVergiDairesi = blgVergiDairesi;
            this.blgVergiNo = blgVergiNo;
            this.blgIban = blgIban;
            this.blgYetkili = blgYetkili;
            this.blgAdres = blgAdres;
            this.blgKAdi = blgKAdi;
            this.blgParola = blgParola;
        }

        public string BilgiEkle(DershaneInfo info)
        {


            SqlParameter[] paramsql = new SqlParameter[9] {
        new SqlParameter("@BlgDershaneAd",SqlDbType.VarChar),
        new SqlParameter("@BlgTel",SqlDbType.VarChar),
        new SqlParameter("@BlgVergiDairesi",SqlDbType.VarChar),
        new SqlParameter("@BlgVergiNo",SqlDbType.VarChar),
        new SqlParameter("@BlgIBAN",SqlDbType.VarChar),
        new SqlParameter("@BlgYetkili",SqlDbType.VarChar),
        new SqlParameter("@BlgAdres",SqlDbType.VarChar),
        new SqlParameter("@BlgKAdi",SqlDbType.VarChar),
        new SqlParameter("@BlgParola",SqlDbType.VarChar),
        };
            int a = 0;
            string err = "";

            try
            {
                paramsql[0].Value = info.blgDershaneAd;
                paramsql[1].Value = info.blgTel;
                paramsql[2].Value = info.blgVergiDairesi;
                paramsql[3].Value = info.blgVergiNo;
                paramsql[4].Value = info.blgIban;
                paramsql[5].Value = info.blgYetkili;
                paramsql[6].Value = info.blgAdres;
                paramsql[7].Value = info.blgKAdi;
                paramsql[8].Value = info.blgParola;
                a = ExecuteNonQuery("DERSHANEBILGIEKLE", CommandType.StoredProcedure, paramsql);
                //a = 1;
            }
            catch (SqlException ex)
            {

                err = ex.Message;
                a = 2;
            }


            return err;
        }
        public string BilgiGuncelle(DershaneInfo info)
        {

            
            SqlParameter[] paramsql = new SqlParameter[10] {
        new SqlParameter("@BlgID",SqlDbType.Int),
        new SqlParameter("@BlgDershaneAd",SqlDbType.VarChar),
        new SqlParameter("@BlgTel",SqlDbType.VarChar),
        new SqlParameter("@BlgVergiDairesi",SqlDbType.VarChar),
        new SqlParameter("@BlgVergiNo",SqlDbType.VarChar),
        new SqlParameter("@BlgIBAN",SqlDbType.VarChar),
        new SqlParameter("@BlgYetkili",SqlDbType.VarChar),
        new SqlParameter("@BlgAdres",SqlDbType.VarChar),
        new SqlParameter("@BlgKAdi",SqlDbType.VarChar),
        new SqlParameter("@BlgParola",SqlDbType.VarChar),
        };
            int a = 0;
            string err = "" ;
               
                try
                {
                    paramsql[0].Value = info.blgID;
                    paramsql[1].Value = info.blgDershaneAd;
                    paramsql[2].Value = info.blgTel;
                    paramsql[3].Value = info.blgVergiDairesi;
                    paramsql[4].Value = info.blgVergiNo;
                    paramsql[5].Value = info.blgIban;
                    paramsql[6].Value = info.blgYetkili;
                    paramsql[7].Value = info.blgAdres;
                    paramsql[8].Value = info.blgKAdi;
                    paramsql[9].Value = info.blgParola;
                a = ExecuteNonQuery("DERSHANEBILGIGUNCELLE", CommandType.StoredProcedure, paramsql);
                    //a = 1;
                }
                catch (SqlException ex)
                {

                 err = ex.Message;
                    a = 2;
                }
           

            return err;
        }
        public List<DershaneInfo> BilgiGetir()
        {
            SqlParameter[] paramdizi = null;
            SqlDataReader dr = ExecuteReader("DERSHANEBILGIGETIR", CommandType.StoredProcedure, paramdizi);
            List<DershaneInfo> drsBilgi = new List<DershaneInfo>();
            while (dr.Read())
            {
                DershaneInfo info = new DershaneInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7),dr.GetString(8),dr.GetString(9));
                drsBilgi.Add(info);
            }
            return drsBilgi;
        }
        public int Login(string kadi,string parola)
        {
            DershaneInfo info = new DershaneInfo();

            SqlParameter[] paramsql = new SqlParameter[2] {
            new SqlParameter("@BlgKAdi",SqlDbType.VarChar),
            new SqlParameter("@BlgParola",SqlDbType.VarChar) };
            paramsql[0].Value = kadi;
            paramsql[1].Value = parola;

            SqlDataReader dr = ExecuteReader("DERSHANELOGINGETIR", CommandType.StoredProcedure, paramsql);
            List<DershaneInfo> drsBilgi = new List<DershaneInfo>();
            while (dr.Read())
            {
                DershaneInfo infod = new DershaneInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9));
                drsBilgi.Add(infod);
            }

            return drsBilgi.Count>0?1:0;
        }
        public int BilgiSil(int personelID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@BlgID",SqlDbType.Int)
                };
            paramdizi[0].Value = personelID;
            //Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("DERSHANEBILGISIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }

    }
}
