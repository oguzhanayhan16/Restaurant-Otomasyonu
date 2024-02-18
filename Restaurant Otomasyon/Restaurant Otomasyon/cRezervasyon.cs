using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Restaurant_Otomasyon
{
    internal class cRezervasyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _TableID;
        private int _ClientID;
        private DateTime _Date;
        private int _CleintCount;
        private string _Description;
        private int _AdditionID;


        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableID { get => _TableID; set => _TableID = value; }
        public int ClientID { get => _ClientID; set => _ClientID = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int CleintCount { get => _CleintCount; set => _CleintCount = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public string Description { get => _Description; set => _Description = value; }
        #endregion
        //Müşteri masa numarasına göre
        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 MUSTERIID from REZERVESYONLAR where MASAID=@masaid order by MUSTERIID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = tableId;



                clientId = Convert.ToInt32(cmd.ExecuteScalar());
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


            return clientId;

        }


        public bool rezervationClose(int adisyonId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update REZERVESYONLAR set DURUM=1 where ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;



                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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


            return result;
        }

        public void musteriIdGetirRezervasyon(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select REZERVESYONLAR.MUSTERIID,(AD+ SOYAD) as musteri from REZERVASYONLAR Inner Join MUSTERİLER on REZERVASYONLAR.MUSTERIID=MUSTERILER.ID Where REZERVASYONLAR.DURUM=0 ", con);






            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["musteri"].ToString());
                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }//REZERVASYONLARI GETİR

        public void acikRezervasyonlariGetir(ListView lv,int musteriId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select REZERVESYONLAR.MUSTERIID,AD,SOYAD,ADISYONID,Tarih from REZERVESYONLAR Inner Join MUSTERİLER on REZERVESYONLAR.MUSTERIID=MUSTERILER.ID Where REZERVASYONLAR.MUSTERIID=@musteriId and REZERVASYONLAR.DURUM=0 order by REZERVASYONLAR.ID desc  ", con);




            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["Tarih"].ToString());
                lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());

                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }//Eski rezervasyonları getir

       public DateTime EnSonrezervasyonTarih(int musteriId)
        {
           DateTime tar = new DateTime();
            tar=DateTime.Now;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih from REZERVESYONLAR  Where REZERVASYONLAR.MUSTERIID=@musteriId and REZERVASYONLAR.DURUM=1 order by REZERVASYONLAR.ID desc  ", con);
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            tar = Convert.ToDateTime(cmd.ExecuteScalar());

            con.Dispose();
            con.Close();
            return tar;

        }//En son rezervasyon tarihini getir

        public int acikRezervasyonSayisi()
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) from REZERVASYONLAR Where  REZERVASYONLAR.DURUM=0   ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw new Exception(hata);
            }
            con.Dispose();
            con.Close();

            return sonuc;
        }//Açık rezervasyonların sayısı

        public bool rezervasyonAcikmiKontrol(int musteriId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 REZERVESYONLAR.ID FROM REZERVESYONLAR Where MUSTERIID=@musteriId AND DURUM=1 order by  ID desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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


            return result;
        }// Rezervasyon açık mı kontrol

        public bool rezervasyonAc(cRezervasyon r)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO REZERVESYONLAR (MUSTERIID, MASAID, ADISYONID, KISISAYISI, TARIH, DURUM) VALUES (@MUSTERIID, @MASAID, @ADISYONID, @KISISAYISI, @TARIH, 1)", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = r._ClientID;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = r._TableID;
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = r._AdditionID;
                cmd.Parameters.Add("@KISISAYISI", SqlDbType.Int).Value = r._CleintCount;
                cmd.Parameters.Add("@TARIH", SqlDbType.Date).Value = r._Date;
            


                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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


            return result;
        }// Rezervasyon aç

        public int rezerveMasaIdGetir(int musteriId)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select REZERVESYONLAR.MASAID from REZERVESYONLAR Inner Join ADISYONLAR on REZERVASYONLAR.ADISYONID=ADISYONLAR.ID Where  (REZERVASYONLAR.DURUM=1) and ADISYONLAR.DURUM=0 and REZERVASYONLAR.MUSTERIID=@musteriId   ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = musteriId;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw new Exception(hata);
            }
            con.Dispose();
            con.Close();

            return sonuc;
        }//Rezerve masanın idsini getir


        public void RezervasyonlariGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select REZERVESYONLAR.MUSTERIID,AD,SOYAD,ADISYONID,Tarih from REZERVESYONLAR Inner Join MUSTERİLER on REZERVESYONLAR.MUSTERIID=MUSTERILER.ID Where REZERVASYONLAR.MUSTERIID=@musteriId and REZERVASYONLAR.DURUM=0 order by REZERVASYONLAR.ID desc  ", con);




       

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["Tarih"].ToString());
                lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());

                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void RezervasyonKontrol(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT  REZERVESYONLAR.ID, MUSTERIID,  REZERVESYONLAR.MASAID,  ADISYONID,  AD,  SOYAD,  TARIH, \r\nCASE WHEN MASALAR.DURUM = 3 THEN 'Açık rezerve'WHEN MASALAR.DURUM = 4 THEN 'Rezerve'ELSE 'Diğer Durum'END AS MASADURUM\r\nFROM REZERVESYONLAR, MUSTERILER,  MASALAR,  ADISYONLAR\r\nWHERE REZERVESYONLAR.MUSTERIID = MUSTERILER.ID AND MASALAR.ID = REZERVESYONLAR.MASAID AND REZERVESYONLAR.ADISYONID = ADISYONLAR.ID and REZERVESYONLAR.DURUM=1;\r\n\r\n\r\n  ", con);






            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["MASAID"].ToString());
                lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["TARIH"].ToString());
                lv.Items[i].SubItems.Add(dr["MASADURUM"].ToString());

                i++;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }

        public bool rezervationKapat(int  musteriID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update REZERVESYONLAR set DURUM=0 where MUSTERIID=@musteriID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;



                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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


            return result;
        }

    }
}
