using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciIsleri_Click(object sender, EventArgs e)
        {
            frmOgrenci ogrenci = new frmOgrenci();
            ogrenci.ShowDialog();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel personel = new frmPersonel();
            personel.ShowDialog();

        }

        private void btnKasaIslemler_Click(object sender, EventArgs e)
        {
            frmKasa kasa = new frmKasa();
            kasa.ShowDialog();
        }


        private void btnDersBilgi_Click(object sender, EventArgs e)
        {       
            frmDBilgi frm = new frmDBilgi();
            frm.ShowDialog();
    }

        private void btnOgrOdeme_Click(object sender, EventArgs e)
        {
            frmOdemeVade odemeVade = new frmOdemeVade();
            odemeVade.ShowDialog();
    }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            frmOdeme odeme = new frmOdeme();
            odeme.ShowDialog();
    }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
