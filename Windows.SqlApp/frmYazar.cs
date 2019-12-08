using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;
using Vektorel.KitapBankosu.Models;


namespace Windows.SqlApp
{
    public partial class frmYazar : Form
    {
        public frmYazar()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

            try
            {
                YazarBL yzr = new YazarBL();
                Yazar yazar = new Yazar();
                yazar.Ad = txtYazarAd.Text;
                yazar.Soyad = txtYazarSoyad.Text;

                yazar.Dtar = dtYazarDtar.Value;
                if (!chckyasiyor.Checked)
                {
                    yazar.OlumTarih = dtYazarOlumTarih.Value;

                }
                yzr.YazarEkle(yazar);


            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show(ex.Number + "Bu ad daha önce girilmiş.");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası hata numarası" + ex.Number);
                        break;

                }

            }

            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen hata");
            }

        }

        private void Chckyasiyor_CheckedChanged(object sender, EventArgs e)
        {
            if (chckyasiyor.Checked)
            {
                dtYazarOlumTarih.Enabled = false;
            }
            else
            {
                dtYazarOlumTarih.Enabled = true;
            }
        }

        private void frmYazar_Load(object sender, EventArgs e)
        {

        }
    }
}
