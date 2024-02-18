using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    internal class cUrunler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _urunId;
        private int _urunturno;
        private string _urunAd;
        private decimal _fiyat;
        private string _aciklama;



# endregion

        #region Properties
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Urunturno { get => _urunturno; set => _urunturno = value; }
        public string UrunAd { get => _urunAd; set => _urunAd = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        #endregion


        public void urunleriListeleByUrunAdi(ListView lv,string urunAdi)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM URUNLER WHERE DURUM = 0 AND URUNAD LIKE CONCAT(@urunAdi, '%')", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunAdi",SqlDbType.VarChar).Value=urunAdi;
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}",dr["FIYAT"].ToString()));
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

        public int Urunekle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into URUNLER(URUNAD,KATEGORIID,ACIKLAMA,FIYAT) values(@urunAd,@katId,@aciklama,@fiyat)", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;



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

        public void UrunlerListele(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNLER.*,KATEGORIADI from URUNLER inner join KATEGORILER on KATEGORILER.ID=URUNLER.KATEGORIID Where URUNLER.DURUM=0", con);

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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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
        public int UrunBilgileriGuncelle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update URUNLER set URUNAD=@urunad,KATEGORIID=@katId,ACIKLAMA=@aciklama,FIYAT=@FIYAT Where ID=@urunId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value =u._urunAd ;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value =u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@FIYAT", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunId;
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

        public int UrunBilgileriSil(cUrunler u,int kat)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            string sql = "Update URUNLER set DURUM=1 Where";
            if (kat==0)
            {
                sql += " KATEGORIID=@urunId";
            }
            else
            {
                sql += " ID=@urunId";
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
               
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunId;
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
        public void urunleriListeleByUrunId(ListView lv, int urunId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNLER.*,KATEGORIADI from URUNLER inner join KATEGORILER on KATEGORILER.ID=URUNLER.KATEGORIID   Where URUNLER.DURUM=0 and URUNLER.KATEGORIID=@urunId", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = urunId;
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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

     //Bütün ürünleri getirir
        public void UrunleriListeleIstatiklereGore(ListView lv,DateTimePicker baslangic, DateTimePicker bitis)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 10 dbo.URUNLER.URUNAD, sum(dbo.SATISLAR.ADET) as adeti from dbo.KATEGORILER inner join dbo.URUNLER on dbo.KATEGORILER.ID=dbo.URUNLER.KATEGORIID inner join dbo.SATISLAR on dbo.URUNLER.ID= dbo.SATISLAR.URUNID inner join dbo.ADISYONLAR on dbo.SATISLAR.ADISYONID = dbo.ADISYONLAR.ID where (Convert(datetime,Tarih,104) between CONVERT(datetime,@baslangic,104) and Convert(datetime,@bitis,104)) group by dbo.URUNLER.URUNAD order by adeti desc", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortDateString();
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
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());
                
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

        //BELLİ Kategoriye ürünleri getirir
        public void UrunleriListeleIstatiklereGoreUrunId(ListView lv, DateTimePicker baslangic, DateTimePicker bitis,int urunKatId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 10 dbo.URUNLER.URUNAD, sum(dbo.SATISLAR.ADET) as adeti from dbo.KATEGORILER inner join dbo.URUNLER on dbo.KATEGORILER.ID=dbo.URUNLER.KATEGORIID inner join dbo.SATISLAR on dbo.URUNLER.ID= dbo.SATISLAR.URUNID inner join dbo.ADISYONLAR on dbo.SATISLAR.ADISYONID = dbo.ADISYONLAR.ID where (Convert(datetime,Tarih,104) between CONVERT(datetime,@baslangic,104) and Convert(datetime,@bitis,104)) and (dbo.URUNLER.KATEGORIID=@katId) group by dbo.URUNLER.URUNAD order by adeti desc", con);

            SqlDataReader dr = null;
          cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortDateString();
            cmd.Parameters.Add("@katId", SqlDbType.Int).Value = urunKatId;
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
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());

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
    }
}
