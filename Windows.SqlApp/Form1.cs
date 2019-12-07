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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

            try
            {
                TurBL t = new TurBL();
                Tur tur = new Tur();
                tur.Turad = txtKitapTur.Text;
                MessageBox.Show(t.TurEkle(tur)?"Ekleme başarılı":"Başarısız");


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
    }
}
