using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
namespace DershaneOtomasyon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            DershaneInfo drs = new DershaneInfo();
            string kadi = txtKadi.Text as string ?? default(string);
            string parola = txtSifre.Text as string ?? default(string);

            int login = drs.Login(kadi,parola);
            if (login == 1)
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
                lblUyari.Visible = true;
        }
    }
}
