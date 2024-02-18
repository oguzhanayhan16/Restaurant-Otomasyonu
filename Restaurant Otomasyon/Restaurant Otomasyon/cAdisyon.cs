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
    internal class cAdisyon
    {
        #region Fields 
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;

        #endregion
        #region Properties

        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion
        cGenel gnl = new cGenel();
        public int getbyAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From ADISYONLAR Where MASAID=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
               
                con.Close();
            }


            return MasaId;

            
        }
        public bool setByAdditionNew(cAdisyon Bilgiler)
        {

            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into ADISYONLAR(SERVISTURNO,Tarih,PERSONELID,MASAID,DURUM) values(@ServisTurNo,@Tarih,@PersonelID,@MasaID,@Durum)", con);

    
          

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;

                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = Bilgiler.Durum;
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
        public void adisyonKapat(int adisyonId,int durum)
        {
          
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update ADISYONLAR set DURUM= @durum where ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();


               
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


           
        }

        public int paketAdisyonIdBul()
        {
            int miktar = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) as Sayi from  ADISYONLAR Where (DURUM=0) and(SERVISTURNO=2)", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar= Convert.ToInt32(cmd.ExecuteScalar());
              



            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
               
                con.Close();
            }


            return miktar;
        }

        public void acıkPaketAdisyonlar(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PAKETSIPARIS.MUSTERIID,MUSTERILER.AD +' ' + MUSTERILER.SOYAD As Musteri,ADISYONLAR.ID From" +
                " PAKETSIPARIS Inner Join MUSTERILER on MUSTERILER.ID=PAKETSIPARIS.MUSTERIID Inner Join ADISYONLAR on ADISYONLAR.ID=PAKETSIPARIS.ADISYONID Where ADISYONLAR.DURUM=0 ", con);
            SqlDataReader dr = null;
       
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int  sayac = 0;
                while(dr.Read())
                {
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Musteri"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }




            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                dr.Close();
                con.Close();
            }

        }
        public int musterininSonAdisyonID(int musteriId)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select ADISYONLAR.ID from ADISYONLAR Inner Join PAKETSIPARIS on PAKETSIPARIS.ADISYONID=ADISYONLAR.ID Where PAKETSIPARIS.DURUM=0 and ADISYONLAR.DURUM=0 and PAKETSIPARIS.MUSTERIID=@musteriId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
              
                sonuc= Convert.ToInt32(cmd.ExecuteScalar());



            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        public void musteriDetaylar(ListView lv, int musteriId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PAKETSIPARIS.MUSTERIID,PAKETSIPARIS.ADISYONID,MUSTERILER.AD,MUSTERILER.SOYAD,CONVERT(varchar(10), ADISYONLAR.Tarih, 104) as Tarih from ADISYONLAR Inner Join PAKETSIPARIS on PAKETSIPARIS.ADISYONID = ADISYONLAR.ID Inner Join MUSTERILER on MUSTERILER.ID = PAKETSIPARIS.MUSTERIID Where ADISYONLAR.SERVISTURNO = 2  and   PAKETSIPARIS.MUSTERIID = @musteriId", con);

            cmd.Parameters.Add("@musteriId",SqlDbType.Int).Value = musteriId;
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {

                int sayac = 0;
                dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["MUSTERIID"].ToString());

                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Tarih"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADISYONID"].ToString());

                    sayac++;
                }




            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
                dr.Close();
            }
        }
        public int AdisyonRezervasyonAc(cAdisyon Bilgiler)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into ADISYONLAR(SERVISTURNO,Tarih,PERSONELID,MASAID) values(@ServisTurNo,@Tarih,@PersonelID,@MasaID); select Scope_IDENTITY()", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;

                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = Bilgiler.Durum;
                result = Convert.ToInt32(cmd.ExecuteScalar());
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
    }
}
