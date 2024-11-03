using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PersonelInfo:Helper
    {
        public PersonelInfo()
        { }


        int personelID;

        public int PersonelID
        {
            get { return personelID; }
            set { personelID = value; }
        }
        string personelAd;

        public string PersonelAd
        {
            get { return personelAd; }
            set { personelAd = value; }
        }
        string personelSoyad;
        
        public string PersonelSoyad
        {
            get { return personelSoyad; }
            set { personelSoyad = value; }
        }
        string personelKimlikNo;

        public string PersonelKimlikNo
        {
            get { return personelKimlikNo; }
            set { personelKimlikNo = value; }
        }
        string personelUnvan;

        public string PersonelUnvan
        {
            get { return personelUnvan; }
            set { personelUnvan = value; }
        }
        int personelDurum;

        public int PersonelDurum
        {
            get { return personelDurum; }
            set { personelDurum = value; }
        }
        int personelMaas;

        public int PersonelMaas
        {
            get { return personelMaas; }
            set { personelMaas = value; }
        }
        int personelUcret;

        public int PersonelUcret
        {
            get { return personelUcret; }
            set { personelUcret = value; }
        }
        int personelOgrtmn;

        public int PersonelOgrtmn
        {
            get { return personelOgrtmn; }
            set { personelOgrtmn = value; }
        }
        string personelGsm;

        public string PersonelGsm
        {
            get { return personelGsm; }
            set { personelGsm = value; }
        }
        string personelMail;

        public string PersonelMail
        {
            get { return personelMail; }
            set { personelMail = value; }
        }
        string personelAdres;

        public string PersonelAdres
        {
            get { return personelAdres; }
            set { personelAdres = value; }
        }

        public PersonelInfo(int personelID, string personelAd, string personelSoyad,string personelKimlikNo, string personelUnvan, int personelDurum, int personelMaas, int personelUcret, int personelOgrtmn, string personelGsm, string personelMail, string personelAdres)
        {
            this.personelID = personelID;
            this.personelAd = personelAd;
            this.personelSoyad = personelSoyad;
            this.personelKimlikNo = personelKimlikNo;
            this.personelUnvan = personelUnvan;
            this.personelDurum = personelDurum;
            this.personelMaas = personelMaas;
            this.personelUcret = personelUcret;
            this.personelOgrtmn = personelOgrtmn;
            this.personelGsm = personelGsm;
            this.personelMail = personelMail;
            this.personelAdres = personelAdres;
        }

          public int PersonelEkle(PersonelInfo info)
       {
       
        bool personelVar = false;
        SqlParameter[] paramsql = new SqlParameter[11] { 
        new SqlParameter("@PersonelAd",SqlDbType.VarChar),
        new SqlParameter("@PersonelSoyad",SqlDbType.VarChar),
        new SqlParameter("@PersonelKimlikNo",SqlDbType.VarChar),
        new SqlParameter("@PersonelUnvan",SqlDbType.VarChar),
        new SqlParameter("@PersonelDurum",SqlDbType.Int),
        new SqlParameter("@PersonelMaas",SqlDbType.Int),
        new SqlParameter("@PersonelEkUcret",SqlDbType.Int),
        new SqlParameter("@PersonelOgretmen",SqlDbType.Int),
        new SqlParameter("@PersonelGsm",SqlDbType.VarChar),
        new SqlParameter("@PersonelMail",SqlDbType.VarChar),
        new SqlParameter("@PersonelAdres",SqlDbType.VarChar),
        };
        int a = 0;
        if (!personelVar)
        {
           // Helper hlp = new Helper();
            try
            {
                paramsql[0].Value = info.personelAd;
                paramsql[1].Value = info.personelSoyad;
                paramsql[2].Value = info.personelKimlikNo;
                paramsql[3].Value=info.personelUnvan;
                paramsql[4].Value=info.personelDurum;
                paramsql[5].Value=info.personelMaas;
                paramsql[6].Value=info.personelUcret;
                paramsql[7].Value = info.personelOgrtmn;
                paramsql[8].Value=info.personelGsm;
                paramsql[9].Value = info.personelMail;
                paramsql[10].Value = info.personelAdres;
              a=  ExecuteNonQuery("PERSONELEKLE", CommandType.StoredProcedure, paramsql);
                //a = 1;
            }
            catch (SqlException ex)
            {
               
             //   lblDurum.Text = "Veri kaynağına bağlanılırken bir hata oluştu kayıt işlemi iptal edildi.";//.Hata kodu:" + ex.Message;
                a = 2;
            }
        }
        else {

            a = 3;
        }
        return a;
       }
       public int PersonelGuncelle(PersonelInfo info)
       {

           bool personelVar = false;
           SqlParameter[] paramsql = new SqlParameter[12] { 
        new SqlParameter("@PersonelID",SqlDbType.Int),
        new SqlParameter("@PersonelAd",SqlDbType.VarChar),
        new SqlParameter("@PersonelSoyad",SqlDbType.VarChar),
        new SqlParameter("@PersonelKimlikNo",SqlDbType.VarChar),
        new SqlParameter("@PersonelUnvan",SqlDbType.VarChar),
        new SqlParameter("@PersonelDurum",SqlDbType.Int),
        new SqlParameter("@PersonelMaas",SqlDbType.Int),
        new SqlParameter("@PersonelEkUcret",SqlDbType.Int),
        new SqlParameter("@PersonelOgretmen",SqlDbType.Int),
        new SqlParameter("@PersonelGsm",SqlDbType.VarChar),
        new SqlParameter("@PersonelMail",SqlDbType.VarChar),
        new SqlParameter("@PersonelAdres",SqlDbType.VarChar),
        };
           int a = 0;
           if (!personelVar)
           {
              // Helper hlp = new Helper();
               try
               {
                   paramsql[0].Value = info.personelID;
                   paramsql[1].Value = info.personelAd;
                   paramsql[2].Value = info.personelSoyad;
                   paramsql[3].Value = info.personelKimlikNo;
                   paramsql[4].Value = info.personelUnvan;
                   paramsql[5].Value = info.personelDurum;
                   paramsql[6].Value = info.personelMaas;
                   paramsql[7].Value = info.personelUcret;
                   paramsql[8].Value = info.personelOgrtmn;
                   paramsql[9].Value = info.personelGsm;
                   paramsql[10].Value = info.personelMail;
                   paramsql[11].Value = info.personelAdres;
                   
                   a = ExecuteNonQuery("PERSONELGUNCELLE", CommandType.StoredProcedure, paramsql);
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
       public List<PersonelInfo> PersonelleriGetir(int personelDurum)
       {
           SqlParameter[] paramdizi = new SqlParameter[]{
            new SqlParameter("@PersonelDurum",SqlDbType.Int)
            };

           paramdizi[0].Value = personelDurum;
           //Helper hlp=new Helper();
           SqlDataReader dr = ExecuteReader("PERSONELLERIGETIR", CommandType.StoredProcedure, paramdizi);
           List<PersonelInfo> personelListe = new List<PersonelInfo>();
           while (dr.Read())
           {
               PersonelInfo info = new PersonelInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),dr.GetString(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10), dr.GetString(11));
               personelListe.Add(info);
           }
           return personelListe;

       }
       public List<PersonelInfo> TumPersonelleriGetir()
       {
           SqlParameter[] paramdizi = null;// new SqlParameter[]{
          //  new SqlParameter("@PersonelDurum",SqlDbType.Int)
         //   };

          // paramdizi[0].Value = personelDurum;
           //Helper hlp = new Helper();
           SqlDataReader dr = ExecuteReader("PERSONELGETIRTUM", CommandType.StoredProcedure, paramdizi);
           List<PersonelInfo> personelListe = new List<PersonelInfo>();
           while (dr.Read())
           {
               PersonelInfo info = new PersonelInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10), dr.GetString(11));
               personelListe.Add(info);
           }
           return personelListe;

       }
       public int PersonelSil(int personelID)
       {
           SqlParameter[] paramdizi = new SqlParameter[1] {
                new SqlParameter("@PersonelID",SqlDbType.Int)
                };
           paramdizi[0].Value = personelID;
           //Helper hlp = new Helper();
           try
           {
               ExecuteNonQuery("PERSONELSIL", CommandType.StoredProcedure, paramdizi);
           }
           catch (SqlException ex)
           {
               
               throw;
           }
          
           return 0;
       }


    }

    
}
