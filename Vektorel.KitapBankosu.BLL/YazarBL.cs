using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.DAL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosu.BLL
{
    public class YazarBL
    {
        Helper hlp = new Helper();
        public bool YazarEkle(Yazar yazar)
        {

            SqlParameter[] p = { new SqlParameter("@Ad", yazar.Ad), new SqlParameter("@Soyad", yazar.Soyad), new SqlParameter("@Dtar", yazar.Dtar), new SqlParameter("@OlumTarih", yazar.OlumTarih) };
            if (yazar.OlumTarih == DateTime.MinValue)
            {
                p[3].Value = DBNull.Value;
            }
            return hlp.ExecuteNonQuery("Insert into tblYazarlar values (@Ad,@Soyad,@Dtar,@Olumtarih)", p) > 0;

        }

        public Yazar Yazarbul(string yazarad)
        {
            SqlParameter[] p = { new SqlParameter("Ad", yazarad) };
            SqlDataReader dr = hlp.ExecuteReader("Select from tblYazarlar where Ad=@Ad", p);
            Yazar yz = null;
            if (dr.Read())
            {
                yz = new Yazar();
                yz.Ad = dr["Ad"].ToString();
                yz.Soyad = dr["Soyad"].ToString();
                yz.Dtar = Convert.ToDateTime(dr["Dtar"]);
                if (yz.OlumTarih != null)
                {
                    yz.OlumTarih = Convert.ToDateTime(dr["Dtar"]);
                }
            }
            dr.Close();
            return yz;




        }
    }

}

