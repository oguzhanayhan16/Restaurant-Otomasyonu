using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restaurant_Otomasyon
{
    internal class cUrunCesitleri
    {
        cGenel gnl = new cGenel();
        #region Fields 
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;

        #endregion
        #region Properties

        
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        #endregion

        public void getByProductTypes(ListView Cesitler,Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT,URUNLER.ID From KATEGORILER Inner Join URUNLER on KATEGORILER.ID=URUNLER.KATEGORIID WHERE URUNLER.KATEGORIID=@KATEGORIID", con);

            string aa = btn.Name;
            int uzunluk = aa.Length;


            cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk-1,1);


             if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
              SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();

        }
        public void getByProductSearch(ListView Cesitler, string txt)
        {
            Cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM URUNLER WHERE URUNAD LIKE '%' + @URUNAD + '%'", con);

            // Parametrenin türünü NVarChar olarak ayarla
            cmd.Parameters.Add("@URUNAD", SqlDbType.NVarChar).Value = txt;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }

        // Diğer metotlarınızın düzeltilmiş kısımları...

        //urun cesitlerini getir combobox
        public void UrunCesiletiniGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from KATEGORILER Where DURUM=0", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   cUrunCesitleri uc = new cUrunCesitleri();
                    uc._UrunTurNo= Convert.ToInt32(dr["ID"]);
                    uc._KategoriAd= Convert.ToString(dr["KATEGORIADI"]);
                    uc.Aciklama= Convert.ToString(dr["ACIKLAMA"]);
                       cb.Items.Add(uc);
                   
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }


        }
        //      //urun cesitlerini getir listview
        public void UrunCesiletiniGetir(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from KATEGORILER where DURUM=0", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    sayac++;    

                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }


        }
        //      //urun cesitlerini getir ARAMA
        public void UrunCesiletiniGetir(ListView lv,string source)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from KATEGORILER where DURUM=0 and KATEGORIADI  LIKE CONCAT('%', @source, '%')", con);
           

            SqlDataReader dr = null;
            cmd.Parameters.Add("@source", SqlDbType.VarChar).Value = source;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    sayac++;

                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }


        }
        public int Urunekle(cUrunCesitleri uc)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into KATEGORILER(KATEGORIADI,ACIKLAMA) values(@kategoriadi,@aciklama)", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@kategoriadi", SqlDbType.VarChar).Value =uc._KategoriAd;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = uc._Aciklama;



                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
            return sonuc;
        }
        public int UrunBilgileriGuncelle(cUrunCesitleri uc)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update KATEGORILER set KATEGORIADI=@kategoriadi,ACIKLAMA=@aciklama Where ID=@katID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@kategoriadi", SqlDbType.VarChar).Value = uc._KategoriAd;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = uc._Aciklama;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = uc._UrunTurNo;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
            return sonuc;
        }
        public int UrunKategoriSil(int id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update KATEGORILER set DURUM=1 Where ID=@katID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
               
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = id;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
            return sonuc;
        }

        public override string ToString()
        
        {
            return KategoriAd;
        }

    }
}
