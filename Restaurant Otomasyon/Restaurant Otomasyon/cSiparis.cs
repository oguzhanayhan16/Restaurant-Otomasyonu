using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Reflection;


namespace Restaurant_Otomasyon
{
    internal class cSiparis
    {
        cGenel gnl = new cGenel();
        #region Fields 
        private int _Id;
        private int _adisyon;
        private int _urunId;
        private int _adet;
        private int _masaId;



        #endregion
        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int Adisyon { get => _adisyon; set => _adisyon = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }

        #endregion
       public void getByOrder(ListView lv,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT,SATISLAR.ID,SATISLAR.URUNID,SATISLAR.ADET From SATISLAR Inner Join URUNLER on SATISLAR.URUNID=URUNLER.ID WHERE " +
                "ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int sayac = 0;
                dr = cmd.ExecuteReader();
                
                while(dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {

                con.Close();
            }


        }
        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into SATISLAR(ADISYONID,URUNID,MASAID,ADET) values(@AdisyonNo,@UrunId,@masaId,@Adet)", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._adisyon;

                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Bilgiler._masaId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._adet;
               
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


            return result;
        }
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From SATISLAR Where ID=@SatisId", con);
            cmd.Parameters.Add("@SatisId", SqlDbType.Int).Value = satisId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public decimal GenelToplamBul(int musteriId)
        {
            decimal genelToplam = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
           
            SqlCommand cmd = new SqlCommand("Select sum(TOPLAMTUTAR) from HESAPODEMELERI where MUSTERIID=@musteriId", con);



            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

               
                genelToplam = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


            return genelToplam;
        }
        public void AdisyonPaketSiparisDetay(ListView lv , int adisyonId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select SATISLAR.ID as SatisId,URUNLER.URUNAD,URUNLER.FIYAT,SATISLAR.ADET " +
                "FROM SATISLAR INNER JOIN ADISYONLAR on ADISYONLAR.ID=SATISLAR.ADISYONID INNER JOIN URUNLER on URUNLER.ID=SATISLAR.URUNID" +
                " where SATISLAR.ADISYONID=@adisyonId", con);
            SqlDataReader dr = null;


            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int sayac = 0;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lv.Items.Add(dr["SatisId"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());
         
                    sayac++;
                }



            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


         
        }

    }
  }

