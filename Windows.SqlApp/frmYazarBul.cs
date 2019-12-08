using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;
using Vektorel.KitapBankosu.Models;

namespace Windows.SqlApp
{
    public partial class frmYazarBul : Form
    {
        public frmYazarBul()
        {
            InitializeComponent();
        }

        private void BtnYazarBul_Click(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();
            Yazar yz=yb.Yazarbul(txtYazarAd.Text.Trim());
            if (yz==null)
            {
                MessageBox.Show("Yazar Bulunamadı");
            }
            else
            {

            }
        }
    }
}
