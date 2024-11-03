using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class VeliInfo:Helper
    {
        public VeliInfo() { }

        int veliID;

        public int VeliID
        {
            get { return veliID; }
            set { veliID = value; }
        }
        int veliOgrID;

        public int VeliOgrID
        {
            get { return veliOgrID; }
            set { veliOgrID = value; }
        }
        string veliAd;

        public string VeliAd
        {
            get { return veliAd; }
            set { veliAd = value; }
        }
        string veliSoyad;

        public string VeliSoyad
        {
            get { return veliSoyad; }
            set { veliSoyad = value; }
        }
        string veliKimlikNo;

        public string VeliKimlikNo
        {
            get { return veliKimlikNo; }
            set { veliKimlikNo = value; }
        }
        string veliTel;

        public string VeliTel
        {
            get { return veliTel; }
            set { veliTel = value; }
        }
        string veliMeslek;

        public string VeliMeslek
        {
            get { return veliMeslek; }
            set { veliMeslek = value; }
        }
        int veli;

        public int Veli
        {
            get { return veli; }
            set { veli = value; }
        }
        string veliAdres;

        public string VeliAdres
        {
            get { return veliAdres; }
            set { veliAdres = value; }
        }
        int veliAB;

        public int VeliAB
        {
            get { return veliAB; }
            set { veliAB = value; }
        }
        int veliDurum;

        public int VeliDurum
        {
            get { return veliDurum; }
            set { veliDurum = value; }
        }
        public VeliInfo(int veliID, int veliOgrID, string veliAd,  string veliSoyad, string veliKimlikNo,string veliTel, string veliMeslek, int veli, string veliAdres,int veliAB, int veliDurum)
        {
            this.veliID = veliID;
            this.veliOgrID = veliOgrID;
            this.veliAd = veliAd;
            this.veliSoyad = veliSoyad;
            this.veliKimlikNo = veliKimlikNo;
            this.veliTel = veliTel;
            this.veliMeslek = veliMeslek;
            this.veli = veli;
            this.veliAB = veliAB;
            this.veliAdres = veliAdres;     
        }

        public int VeliEkle(VeliInfo info)
        {

            bool ogrenciVar = false;
            SqlParameter[] paramsql = new SqlParameter[10] { 
        new SqlParameter("@VeliOgrID",SqlDbType.Int),
        new SqlParameter("@VeliAd",SqlDbType.VarChar),
        new SqlParameter("@VeliSoyad",SqlDbType.VarChar),
        new SqlParameter("@VeliKimlikNo",SqlDbType.VarChar),
        new SqlParameter("@VeliTel",SqlDbType.VarChar),
        new SqlParameter("@VeliMeslek",SqlDbType.VarChar),
        new SqlParameter("@Velisi",SqlDbType.Int),
        new SqlParameter("@VeliAdres",SqlDbType.VarChar),
        new SqlParameter("@VeliAB",SqlDbType.Int),
        new SqlParameter("@VeliDurum",SqlDbType.Int)
        };
            int a = 0;
            if (!ogrenciVar)
            {
                //Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.veliOgrID;
                    paramsql[1].Value = info.veliAd;
                    paramsql[2].Value = info.veliSoyad;
                    paramsql[3].Value = info.veliKimlikNo;
                    paramsql[4].Value = info.veliTel;
                    paramsql[5].Value = info.veliMeslek;
                    paramsql[6].Value = info.veli;
                    paramsql[7].Value = info.veliAdres;
                    paramsql[8].Value = info.veliAB;
                    paramsql[9].Value = info.veliDurum;
                    a = ExecuteNonQuery("VELIEKLE", CommandType.StoredProcedure, paramsql);
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
        public int VeliGuncelle(VeliInfo info)
        {

            bool ogrVar = false;
            SqlParameter[] paramsql = new SqlParameter[11] { 
        new SqlParameter("@VeliID",SqlDbType.Int),
        new SqlParameter("@VeliOgrID",SqlDbType.Int),
        new SqlParameter("@VeliAd",SqlDbType.VarChar),
        new SqlParameter("@VeliSoyad",SqlDbType.VarChar),
        new SqlParameter("@VeliKimlikNo",SqlDbType.VarChar),
        new SqlParameter("@VeliTel",SqlDbType.VarChar),
        new SqlParameter("@VeliMeslek",SqlDbType.VarChar),
        new SqlParameter("@Velisi",SqlDbType.Int),
        new SqlParameter("@VeliAdres",SqlDbType.VarChar),
        new SqlParameter("@VeliAB",SqlDbType.Int),
        new SqlParameter("@VeliDurum",SqlDbType.Int)
        };
            int a = 0;
            if (!ogrVar)
            {
                //Helper hlp = new Helper();
                try
                {
                    paramsql[0].Value = info.veliID;
                    paramsql[1].Value = info.veliOgrID;
                    paramsql[2].Value = info.veliAd;
                    paramsql[3].Value = info.veliSoyad;
                    paramsql[4].Value = info.veliKimlikNo;
                    paramsql[5].Value = info.veliTel;
                    paramsql[6].Value = info.veliMeslek;
                    paramsql[7].Value = info.veli;
                    paramsql[8].Value = info.veliAdres;
                    paramsql[9].Value = info.veliAB;
                    paramsql[10].Value = info.veliDurum;
                    a = ExecuteNonQuery("VELIGUNCELLE", CommandType.StoredProcedure, paramsql);
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
        public List<VeliInfo> VelileriGetir(int veliOgrID)
        {
            SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@VeliOgrID",SqlDbType.Int)
            };
            paramdizi[0].Value = veliOgrID;
            //Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("VELILERIGETIR", CommandType.StoredProcedure, paramdizi);
            List<VeliInfo> veliListe = new List<VeliInfo>();
            while (dr.Read())
            {
                VeliInfo info = new VeliInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7), dr.GetString(8),dr.GetInt32(9), dr.GetInt32(10));
                veliListe.Add(info);
            }
            return veliListe;

        }
        public List<VeliInfo> TumVelileriGetir()
        {
            SqlParameter[] paramdizi = null;
            //Helper hlp = new Helper();
            SqlDataReader dr = ExecuteReader("VELIGETIRTUM", CommandType.StoredProcedure, paramdizi);
            List<VeliInfo> veliListe = new List<VeliInfo>();
            while (dr.Read())
            {
                VeliInfo info = new VeliInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7), dr.GetString(8), dr.GetInt32(9), dr.GetInt32(10));
                veliListe.Add(info);
            }
            return veliListe;

        }
        public int VeliSil(int veliOgrID)
        {
            SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@VeliOgrID",SqlDbType.Int)
                };
            paramdizi[0].Value = veliOgrID;
            //Helper hlp = new Helper();
            try
            {
                ExecuteNonQuery("VELISIL", CommandType.StoredProcedure, paramdizi);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return 0;
        }


        }
}
/*
        int veliID;
        int veliOgrID;
        string veliAdi;
        string veliSoyadi;
        string veliKimlikNo;
        string veliTel;
        string veliMeslek;
        int veli;
        string veliAdres;
        int veliDurum;
 
 */