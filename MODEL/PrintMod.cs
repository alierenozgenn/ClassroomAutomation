using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL
{
    public class PrintMod
    {
        PrintDocument pd = new PrintDocument();
        PrintPreviewDialog pDialog = new PrintPreviewDialog();
        Font Baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        Font govdeK = new Font("Verdana", 8);
        SolidBrush sb = new SolidBrush(Color.Black);
        OgrenciInfo ogr = new OgrenciInfo();
        List<OgrenciInfo> ogrList = new List<OgrenciInfo>();

        public List<OgrenciInfo> OgrList
        {
            get{   return ogrList;  }
            set{   ogrList = value; }
        }

        public List<PersonelInfo> PrsList
        {
            get
            {
                return prsList;
            }

            set
            {
                prsList = value;
            }
        }

        List<PersonelInfo> prsList = new List<PersonelInfo>();
        public PrintMod()
        {
           // pd.PrintPage += Pd_PrintOgrList;
        }
        public void TumOgrYazdir(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrList;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }

        private void Pd_PrintOgrList(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() +" ÖĞRENCİ LİSTESİ", Baslik, sb, 200, 30);         
            e.Graphics.DrawString("NO", Baslik, sb, 100, 80);
            e.Graphics.DrawString("KİMLİK NO", Baslik, sb, 160, 80);
            e.Graphics.DrawString("ADI", Baslik, sb, 300, 80);
            e.Graphics.DrawString("SOYADI", Baslik, sb, 450, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < ogrList.Count; i++)
            {
                e.Graphics.DrawString((i+1).ToString(), govde, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrNo.ToString(), govde, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrTcNo.ToString(), govde, sb, 160, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrAd.ToString(), govde, sb, 300, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrSoyad.ToString(), govde, sb, 450, 110 + (i * 30));
               // e.Graphics.DrawString(ogrList[i].OgrSozTarihi.Date.ToString(), govde, sb, 550, 190 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (OgrList.Count * 30));

        }
        

        public void OgrKartYazdir(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrKartYaz;
            pDialog.Document = pd;
        
            //pDialog.AllowSelection = true;
            //pDialog.AllowSomePages = true;
            //pDialog.AllowCurrentPage = true;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            //pd.DefaultPageSettings.PrinterSettings.PrintRange = pDialog.;
        
            pDialog.ShowDialog();
        }
     
        private void Pd_PrintOgrKartYaz(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi=drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;



            for (int i = 0; i < ogrList.Count; i++)
            {

                Pen blackPen = new Pen(Color.Black, 3);
                e.Graphics.DrawRectangle(blackPen, 20, 50 + 300 * i, 300, 200);

                e.Graphics.DrawString(drsBilgi.BlgDershaneAd, Baslik, sb, 100, 100 + (i * 30));
                e.Graphics.DrawString("NUMARA       :", Baslik, sb, 130, 100 + (i * 40));
                e.Graphics.DrawString("ADI          :", Baslik, sb, 130, 100 + (i * 50));
                e.Graphics.DrawString("SOYADI       :", Baslik, sb, 130, 100 + (i * 60));
                e.Graphics.DrawString("KİMLİK NO    :", Baslik, sb, 130, 100 + (i * 70));

                e.Graphics.DrawString(ogrList[i].OgrNo.ToString(), govde, sb, 200, 200 + (i * 40));
                e.Graphics.DrawString(ogrList[i].OgrAd.ToString(), govde, sb, 200, 200 + (i * 50));
                e.Graphics.DrawString(ogrList[i].OgrSoyad.ToString(), govde, sb, 200, 200 + (i * 60));
                e.Graphics.DrawString(ogrList[i].OgrTcNo.ToString(), govde, sb, 200, 200 + (i * 70));

            }
            }
         public void OgrBilgiYaz(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrBilgiYaz;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintOgrBilgiYaz(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];

            int ogrID = Convert.ToInt32(ogrList[0].OgrID);
            List<VeliInfo> veliList = new List<VeliInfo>();
            VeliInfo veliAnne = new VeliInfo();
            VeliInfo veliBaba = new VeliInfo();
            veliList = veliAnne.VelileriGetir(ogrID);
            foreach (VeliInfo velif in veliList)
            {
                if (velif.VeliAB == 0)
                {
                    veliAnne = velif;
                }
                else if (velif.VeliAB == 1)
                {
                    veliBaba = velif;
                }
            }

            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper()+" ÖĞRENCİ BİLGİLERİ ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NUMARASI :", Baslik, sb, 100, 70);
            e.Graphics.DrawString("ADI :", Baslik, sb, 100, 100);
            e.Graphics.DrawString("SOYADI :", Baslik, sb, 100, 130);
            e.Graphics.DrawString("TC NO :", Baslik, sb, 100, 160);
            e.Graphics.DrawString("SÖZLEŞME TARİHİ :", Baslik, sb, 100, 190);
            e.Graphics.DrawString("TELEFON :", Baslik, sb, 100, 220);
            e.Graphics.DrawString("ADRES :", Baslik, sb, 100, 250);
            e.Graphics.DrawString("AÇIKLAMA :", Baslik, sb, 100, 280);
            e.Graphics.DrawString("ANNE AD :", Baslik, sb, 100, 310);
            e.Graphics.DrawString("ANNE SOYADI :", Baslik, sb, 100, 340);
            e.Graphics.DrawString("ANNE TELEFON :", Baslik, sb, 100, 370);
            e.Graphics.DrawString("BABA ADI :", Baslik, sb, 100, 400);
            e.Graphics.DrawString("BABA SOYADI :", Baslik, sb, 100, 430);
            e.Graphics.DrawString("BABA TELEFON :", Baslik, sb, 100, 460);
            
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 50);

            try
            {


            e.Graphics.DrawString(ogrList[0].OgrNo.ToString(),          govde, sb, 300, 70);
            e.Graphics.DrawString(ogrList[0].OgrAd.ToString(),          govde, sb, 300, 100);
            e.Graphics.DrawString(ogrList[0].OgrSoyad.ToString(),       govde, sb, 300, 130);
            e.Graphics.DrawString(ogrList[0].OgrTcNo.ToString(),        govde, sb, 300, 160);
            e.Graphics.DrawString(ogrList[0].OgrSozTarihi.ToShortDateString(),   govde, sb, 300, 190);
            e.Graphics.DrawString(ogrList[0].OgrTel.ToString(),         govde, sb, 300, 220);
            e.Graphics.DrawString(ogrList[0].OgrAdres.ToString(),       govde, sb, 300, 250);
            e.Graphics.DrawString(ogrList[0].OgrAciklama.ToString(),    govde, sb, 300, 280);
            e.Graphics.DrawString(veliAnne.VeliAd.ToString(),           govde, sb, 300, 310);
            e.Graphics.DrawString(veliAnne.VeliSoyad.ToString(),        govde, sb, 300, 340);
            e.Graphics.DrawString(veliAnne.VeliTel.ToString(),          govde, sb, 300, 370);
            e.Graphics.DrawString(veliBaba.VeliAd.ToString(),           govde, sb, 300, 400);
            e.Graphics.DrawString(veliBaba.VeliSoyad.ToString(),        govde, sb, 300, 430);
            e.Graphics.DrawString(veliBaba.VeliTel.ToString(),          govde, sb, 300, 460);
            }
            catch (Exception)
            {

               
            }


            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 480);

        }

        public void TumOgrIletisimYazdir(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrIletisim;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }

        private void Pd_PrintOgrIletisim(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖĞRENCİ LİSTESİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NO", Baslik, sb, 100, 80);
            e.Graphics.DrawString("ADI SOYADI", Baslik, sb, 160, 80);
            e.Graphics.DrawString("TELEFON", Baslik, sb, 300, 80);
            e.Graphics.DrawString("ANNE TELEFON", Baslik, sb, 450, 80);
            e.Graphics.DrawString("BABA TELEFON", Baslik, sb, 600, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < ogrList.Count; i++)
            {
                List<VeliInfo> veliList = new List<VeliInfo>();
                VeliInfo veliAnne = new VeliInfo();
                VeliInfo veliBaba = new VeliInfo();
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrNo.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrAd.ToString()+" "+ ogrList[i].OgrSoyad.ToString(), govdeK, sb, 160, 110 + (i * 30));
                e.Graphics.DrawString(ogrList[i].OgrTel.ToString(), govdeK, sb, 300, 110 + (i * 30));
             
                int ogrID = Convert.ToInt32(ogrList[i].OgrID);
                veliList = veliAnne.VelileriGetir(ogrID);
                foreach (VeliInfo velif in veliList)
                {
                    if (velif.VeliAB == 0)
                    {
                        veliAnne = velif; 
                    }
                    else if (velif.VeliAB == 1)
                    {
                        veliBaba = velif; 
                    }
                }
                if (veliAnne.VeliTel == null)
                    veliAnne.VeliTel = "-";
                if (veliBaba.VeliTel == null)
                    veliBaba.VeliTel = "-";
                e.Graphics.DrawString(veliAnne.VeliTel.ToString(), govdeK, sb, 450, 110 + (i * 30));
                e.Graphics.DrawString(veliBaba.VeliTel.ToString(), govdeK, sb, 600, 110 + (i * 30));
           
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (OgrList.Count * 30));

        }
        public void TumOgrOdemeYaz(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintTumOgrOdeme;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintTumOgrOdeme(object sender, PrintPageEventArgs e)
        {
            int ogrID = Convert.ToInt32(ogrList[0].OgrID);
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
           
            OdemelerInfo ogrOdm = new OdemelerInfo();
            List<OdemelerInfo> ogrOdmList = new List<OdemelerInfo>();
          
            ogrOdmList = ogrOdm.OdemeleriGetir(1);

            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖDEME BİLGİLERİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("ÖĞR. NO ", govde, sb, 100, 80);
            e.Graphics.DrawString("ÖD. ŞEKLİ ", govde, sb, 200, 80);
            e.Graphics.DrawString("ÖD. TARİHİ", govde, sb, 330, 80);
            e.Graphics.DrawString("ÖD. TUTARI", govde, sb, 460, 80);
            e.Graphics.DrawString("AÇIKLAMA", govde, sb, 600, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 60);
            for (int i = 0; i < ogrOdmList.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeKisiID.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeSekli.ToString(), govdeK, sb, 200, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeTarih.ToShortDateString(), govdeK, sb, 330, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeTutar.ToString(), govdeK, sb, 460, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeAciklama.ToString(), govdeK, sb, 600, 110 + (i * 30));           
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (ogrOdmList.Count * 30));

        }
        public void OgrVadeOdemeYaz(List<OgrenciInfo> OgrLst)
        {
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrVadeOdeme;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintOgrVadeOdeme(object sender, PrintPageEventArgs e)
        {
            int ogrNO = Convert.ToInt32(ogrList[0].OgrNo);
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;

            OdemeVadeInfo odv = new OdemeVadeInfo();
            List<OdemeVadeInfo> odvlist = new List<OdemeVadeInfo>();
            List<OdemeVadeInfo> odvlisttemp = new List<OdemeVadeInfo>();
            odvlisttemp = odv.OdemeVadeleriGetir(1);
            foreach (OdemeVadeInfo item in odvlisttemp)
            {
                if (item.OdvOgrID == ogrNO)
                    odvlist.Add(item);
            }

       

            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖDEME BİLGİLERİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString(ogrList[0].OgrAd + " " + ogrList[0].OgrSoyad + " ÖDEME LİSTESİ", govde, sb, 250, 55);
            e.Graphics.DrawString("TUTAR", govde, sb, 100, 80);
            e.Graphics.DrawString("SENET TAR", govde, sb, 180, 80);
            e.Graphics.DrawString("ÖDEME TAR", govde, sb, 300, 80);
            e.Graphics.DrawString("ÖDEME", govde, sb, 430, 80);
            e.Graphics.DrawString("AÇIKLAMA", govde, sb, 500, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < odvlist.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(odvlist[i].OdvVadeMiktar.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(odvlist[i].OdvVadeTarihi.ToShortDateString(), govdeK, sb, 180, 110 + (i * 30));
                e.Graphics.DrawString(odvlist[i].OdvOdemeTarihi.ToShortDateString(), govdeK, sb, 300, 110 + (i * 30));
                e.Graphics.DrawString((odvlist[i].OdvOdemeDurumu==1)?"YAPILDI":"YAPILMADI", govdeK, sb, 430, 110 + (i * 30));
                e.Graphics.DrawString(odvlist[i].OdvAciklama.ToString(), govdeK, sb, 500, 110 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (odvlist.Count * 30));
         
        }
        public void TumPrsYazdir(List<PersonelInfo> PrsLst)
        {
            this.prsList = PrsLst;
            pd.PrintPage += Pd_PrintPrsList;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }

        private void Pd_PrintPrsList(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " PERSONEL LİSTESİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("KİMLİK NO", Baslik, sb, 100, 80);
            e.Graphics.DrawString("ADI", Baslik, sb, 250, 80);
            e.Graphics.DrawString("SOYADI", Baslik, sb, 350, 80);
            e.Graphics.DrawString("ÜNVAN", Baslik, sb, 500, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < prsList.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govde, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelKimlikNo.ToString(), govde, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelAd.ToString(), govde, sb, 250,110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelSoyad.ToString(), govde, sb, 350, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelUnvan.ToString(), govde, sb, 500, 110 + (i * 30));
                // e.Graphics.DrawString(ogrList[i].OgrSozTarihi.Date.ToString(), govde, sb, 550, 190 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (PrsList.Count * 30));

        }

        public void TumPrsIletisimYazdir(List<PersonelInfo> PrsLst)
        {

            this.prsList = PrsLst;
            pd.PrintPage += Pd_PrintPrsIletisim;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }

        private void Pd_PrintPrsIletisim(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " PERSONEL İLETİŞİM LİSTESİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NO", Baslik, sb, 100, 80);
            e.Graphics.DrawString("ADI SOYADI", Baslik, sb, 250, 80);
            e.Graphics.DrawString("TELEFON", Baslik, sb, 400, 80);
            e.Graphics.DrawString("ADRES", Baslik, sb, 500, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 90);
            for (int i = 0; i < prsList.Count; i++)
            {            
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelKimlikNo.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelAd.ToString() + " " + prsList[i].PersonelSoyad.ToString(), govdeK, sb, 250, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelGsm.ToString(), govdeK, sb, 400, 110 + (i * 30));
                e.Graphics.DrawString(prsList[i].PersonelAdres.ToString(), govdeK, sb, 500, 110 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (prsList.Count * 30));

        }

        public void PrsBilgiYaz(List<PersonelInfo> PrsLst,int PrsID)
        {
            List<PersonelInfo> prsListTemp = new List<PersonelInfo>();
            foreach (PersonelInfo item in PrsLst)
            {
                if (item.PersonelID == PrsID)
                    prsListTemp.Add(item);
            }
            this.prsList = prsListTemp;

            pd.PrintPage += Pd_PrintPrsBilgiYaz;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintPrsBilgiYaz(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];

            int prsID = Convert.ToInt32(prsList[0].PersonelID);

            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " PERSONEL BİLGİLERİ ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NO :", Baslik, sb, 100, 70);
            e.Graphics.DrawString("ADI :", Baslik, sb, 100, 100);
            e.Graphics.DrawString("SOYADI :", Baslik, sb, 100, 130);
            e.Graphics.DrawString("TC NO :", Baslik, sb, 100, 160);
            e.Graphics.DrawString("ÜNVAN :", Baslik, sb, 100, 190);
            e.Graphics.DrawString("TELEFON :", Baslik, sb, 100, 220);
            e.Graphics.DrawString("MAİL :", Baslik, sb, 100, 250);
            e.Graphics.DrawString("ADRES :", Baslik, sb, 100, 280);

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 50);
            try
            {

     

            e.Graphics.DrawString(prsList[0].PersonelID.ToString(), govde, sb, 300, 70);
            e.Graphics.DrawString(prsList[0].PersonelAd.ToString(), govde, sb, 300, 100);
            e.Graphics.DrawString(prsList[0].PersonelSoyad.ToString(), govde, sb, 300, 130);
            e.Graphics.DrawString(prsList[0].PersonelKimlikNo.ToString(), govde, sb, 300, 160);
            e.Graphics.DrawString(prsList[0].PersonelUnvan.ToString(), govde, sb, 300, 190);
            e.Graphics.DrawString(prsList[0].PersonelGsm.ToString(), govde, sb, 300, 220);
            e.Graphics.DrawString(prsList[0].PersonelMail.ToString(), govde, sb, 300, 250);
            e.Graphics.DrawString(prsList[0].PersonelAdres.ToString(), govde, sb, 300, 280);
            }
            catch (Exception)
            {

            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 300);

        }
        public void PrsOdemeYaz(List<PersonelInfo> PrsLst,int prsID)
        {
            List<PersonelInfo> prsListTemp = new List<PersonelInfo>();
            foreach (PersonelInfo item in PrsLst)
            {
                if (item.PersonelID == prsID)
                    prsListTemp.Add(item);
            }
            this.prsList = prsListTemp;
            
            pd.PrintPage += Pd_PrintPrsOdeme;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintPrsOdeme(object sender, PrintPageEventArgs e)
        {

            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;


            List<OdemelerInfo> prsOdmList = new List<OdemelerInfo>();
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
            int prsID = prsList[0].PersonelID;
            foreach (OdemelerInfo odm in odemeList)
            {
                if (odm.OdemeTuru == 0 && odm.OdemeKisiID==prsID)
                {
                    odemeListTemp.Add(odm);
                }
            }


            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖDEME BİLGİLERİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NO ", govde, sb, 100, 80);
            e.Graphics.DrawString("ÖD. ŞEKLİ ", govde, sb, 200, 80);
            e.Graphics.DrawString("ÖD. TARİHİ", govde, sb, 330, 80);
            e.Graphics.DrawString("ÖD. TUTARI", govde, sb, 460, 80);
            e.Graphics.DrawString("AÇIKLAMA", govde, sb, 600, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 60);
            for (int i = 0; i < odemeListTemp.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeKisiID.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeSekli.ToString(), govdeK, sb, 200, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeTarih.ToShortDateString(), govdeK, sb, 330, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeTutar.ToString(), govdeK, sb, 460, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeAciklama.ToString(), govdeK, sb, 600, 110 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (odemeListTemp.Count * 30));

        }
        public void TumPrsOdemeYaz(List<PersonelInfo> PrsLst)
        {
            this.prsList = PrsLst;
            pd.PrintPage += Pd_PrintTumPrsOdeme;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintTumPrsOdeme(object sender, PrintPageEventArgs e)
        {
            
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;

            
            List<OdemelerInfo> prsOdmList = new List<OdemelerInfo>();
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
           
            foreach (OdemelerInfo odm in odemeList)
            {
                if (odm.OdemeTuru == 0)
                {
                    odemeListTemp.Add(odm);
                }
            }
            

            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖDEME BİLGİLERİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("NO ", govde, sb, 100, 80);
            e.Graphics.DrawString("ÖD. ŞEKLİ ", govde, sb, 200, 80);
            e.Graphics.DrawString("ÖD. TARİHİ", govde, sb, 330, 80);
            e.Graphics.DrawString("ÖD. TUTARI", govde, sb, 460, 80);
            e.Graphics.DrawString("AÇIKLAMA", govde, sb, 600, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 60);
            for (int i = 0; i < odemeListTemp.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeKisiID.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeSekli.ToString(), govdeK, sb, 200, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeTarih.ToShortDateString(), govdeK, sb, 330, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeTutar.ToString(), govdeK, sb, 460, 110 + (i * 30));
                e.Graphics.DrawString(odemeListTemp[i].OdemeAciklama.ToString(), govdeK, sb, 600, 110 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (odemeListTemp.Count * 30));

        }
        List<OdemelerInfo> odmList = new List<OdemelerInfo>();
        public void TumOdemeYaz(List<OdemelerInfo> OdmLst)
        {
            this.odmList = OdmLst;
            pd.PrintPage += Pd_PrintTumOdeme;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }
        private void Pd_PrintTumOdeme(object sender, PrintPageEventArgs e)
        {
            
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;

            List<OdemelerInfo> ogrOdmList = new List<OdemelerInfo>();

            ogrOdmList = this.odmList;

            e.Graphics.DrawString(drsBilgi.BlgDershaneAd.ToUpper() + " ÖDEME BİLGİLERİ", Baslik, sb, 200, 30);
            e.Graphics.DrawString("ÖĞR. NO ", govde, sb, 100, 80);
            e.Graphics.DrawString("ÖD. ŞEKLİ ", govde, sb, 200, 80);
            e.Graphics.DrawString("ÖD. TARİHİ", govde, sb, 330, 80);
            e.Graphics.DrawString("ÖD. TUTARI", govde, sb, 460, 80);
            e.Graphics.DrawString("AÇIKLAMA", govde, sb, 600, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 60);
            for (int i = 0; i < ogrOdmList.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), govdeK, sb, 50, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeKisiID.ToString(), govdeK, sb, 100, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeSekli.ToString(), govdeK, sb, 200, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeTarih.ToShortDateString(), govdeK, sb, 330, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeTutar.ToString(), govdeK, sb, 460, 110 + (i * 30));
                e.Graphics.DrawString(ogrOdmList[i].OdemeAciklama.ToString(), govdeK, sb, 600, 110 + (i * 30));
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------", Baslik, sb, 50, 110 + (ogrOdmList.Count * 30));

        }
        int makbuzID = 0;
        public void OgrMakbuzYazdir(List<OgrenciInfo> OgrLst,int makbuzID)
        {
            this.makbuzID = makbuzID;
            this.ogrList = OgrLst;
            pd.PrintPage += Pd_PrintOgrMakbuzYaz;
            pDialog.Document = pd;
            ((Form)pDialog).WindowState = FormWindowState.Maximized;
            pDialog.PrintPreviewControl.Zoom = 1;
            pDialog.ShowDialog();
        }

        private void Pd_PrintOgrMakbuzYaz(object sender, PrintPageEventArgs e)
        {
            DershaneInfo drsBilgi = new DershaneInfo();
            drsBilgi = drsBilgi.BilgiGetir()[0];
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            List<OdemelerInfo> prsOdmList = new List<OdemelerInfo>();
            OdemelerInfo odeme = new OdemelerInfo();
            List<OdemelerInfo> odemeList = new List<OdemelerInfo>();
            List<OdemelerInfo> odemeListTemp = new List<OdemelerInfo>();
            odemeList = odeme.OdemeleriGetir(1);
            string mAdSoyad = ogrList[0].OgrAd+" "+ ogrList[0].OgrSoyad;
            foreach (OdemelerInfo odm in odemeList)
            {
                if (odm.OdemeID==makbuzID)
                {
                    odemeListTemp.Add(odm);
                }
            }


            Pen blackPen = new Pen(Color.Black, 3);
                e.Graphics.DrawRectangle(blackPen, 50, 30, 750, 500);
                e.Graphics.DrawString("Tarih: "+DateTime.Now.ToShortDateString(), govde, sb, 600, 50);
                e.Graphics.DrawString("TAHSİLAT MAKBUZU", new Font("Times New Roman", 16, FontStyle.Bold), sb, 300, 150);           
                e.Graphics.DrawString("Sayın :", govdeK, sb, 70, 180);
                e.Graphics.DrawString(ogrList[0].OgrAd+" "+ ogrList[0].OgrSoyad, govdeK, sb, 70, 195);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 70, 220, 700, 150);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 70, 220, 700, 30);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 670, 220, 100, 180);
            e.Graphics.DrawString("AÇIKLAMA", new Font("Times New Roman", 10, FontStyle.Bold), sb, 300, 225);
            e.Graphics.DrawString("TUTAR", new Font("Times New Roman", 10, FontStyle.Bold), sb, 700, 225);
            e.Graphics.DrawString("Öğrenci Ödeme", govdeK, sb, 100, 260);
            e.Graphics.DrawString(odemeListTemp[0].OdemeTutar.ToString()+" TL", govde, sb, 675, 260);
            e.Graphics.DrawString(odemeListTemp[0].OdemeTutar.ToString()+" TL", govde, sb, 675, 375);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString()+ " Saat: " + DateTime.Now.ToShortTimeString(), govdeK, sb, 450, 440);
            e.Graphics.DrawString(drsBilgi.BlgYetkili.ToString(), govdeK, sb, 450, 460);
            /*
            e.Graphics.DrawString("ADI          :", Baslik, sb, 130, 100 + 50);
                e.Graphics.DrawString("SOYADI       :", Baslik, sb, 130, 100 + 60);
                e.Graphics.DrawString("KİMLİK NO    :", Baslik, sb, 130, 100 + 70);

                e.Graphics.DrawString(odemeListTemp[0].OdemeKisiID.ToString(), govde, sb, 200, 240);
                e.Graphics.DrawString(odemeListTemp[0].OdemeSekli.ToString(), govde, sb, 200, 250);
                e.Graphics.DrawString(odemeListTemp[0].OdemeTutar.ToString(), govde, sb, 200, 260);
                e.Graphics.DrawString(odemeListTemp[0].OdemeTarih.ToString(), govde, sb, 200, 270);
                */
        }
    }
    }

