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
    public partial class ucOdeme : UserControl
    {
        public ucOdeme()
        {
            InitializeComponent();
        }

        private void ucOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OdemelerInfo kaydetOdeme = new OdemelerInfo();

            kaydetOdeme.OdemeSekli = cmbOdSekli.Text;
            kaydetOdeme.OdemeIslem = cmbIslem.Text.Trim();
            kaydetOdeme.OdemeTarih = dtpTarih.Value.Date;
            kaydetOdeme.OdemeTutar = Convert.ToInt32(txtTutar.Text);
            kaydetOdeme.OdemeBelNo = Convert.ToInt32(txtBelgeNo.Text);
            kaydetOdeme.OdemeAciklama = txtAciklama.Text;
            kaydetOdeme.OdemeKisiID = Convert.ToInt32(txtOgrenci.Text);
            int odemeTuru=2;
            if (rdbGelir.Checked)
                odemeTuru = 1;
            else if (rdbGider.Checked)
                odemeTuru = 0;

            if (odemeTuru == 2)
            {
                MessageBox.Show("Ödeme Türü", "Ödeme Türü Seçiniz");
            }
            else
            {
                kaydetOdeme.OdemeTuru = odemeTuru;
                int a = kaydetOdeme.OdemeEkle(kaydetOdeme);
            }
        }

    }
}
