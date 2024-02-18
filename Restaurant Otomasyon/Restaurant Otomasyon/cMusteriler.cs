using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Restaurant_Otomasyon
{
    internal class cMusteriler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int musteriID;
        private string musteriAd;
        private string musteriSoyAd;
        private string telefon;
        private string adres;
        private string email;



        #endregion
        #region Properties
        public int MusteriID { get => musteriID; set => musteriID = value; }
        public string MusteriAd { get => musteriAd; set => musteriAd = value; }
        public string MusteriSoyAd { get => musteriSoyAd; set => musteriSoyAd = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        public bool musteriVarmi(string tlf)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            try
            {

                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);


            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
               
                con.Close();
            }


            return sonuc;

        }
        public int MusteriSil(int musteriID)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update MUSTERILER set Durum = 0 where ID = @ID", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = musteriID;




                sonuc = cmd.ExecuteNonQuery();


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
        public int MusteriEkle(cMusteriler m)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into MUSTERILER(AD,SOYAD,TELEFON,ADRES,EMAIL) values(@ad,@soyad,@telefon,@adres,@email); select SCOPE_IDENTITY()", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m.musteriAd;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m.MusteriSoyAd;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m.adres;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m.Telefon;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m.email;



                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
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
        public bool MusteriBilgileriGuncelle(cMusteriler m)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update MUSTERILER set AD=@ad,SOYAD=@soyad,TELEFON=@telefon,ADRES=@adres,EMAIL=@email where ID=@musteriId", con);




            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m.musteriAd;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m.MusteriSoyAd;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m.Telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m.adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m.email;
                cmd.Parameters.Add("@musteriId", SqlDbType.VarChar).Value = m.musteriID;



                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

        public void MusteriGetir(ListView lv)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERILER where durum = 1", con);

            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                 dr=cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        public void MusteriGetirRezervasyon(ListView lv)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM MUSTERILER LEFT JOIN REZERVESYONLAR ON MUSTERILER.ID = REZERVESYONLAR.MUSTERIID\r\nWHERE MUSTERILER.durum =1  AND REZERVESYONLAR.MUSTERIID IS NULL  ;", con);

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
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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

        public void MusterileriGetirId(int musteriId,TextBox ad,TextBox soyad,TextBox tlf,TextBox adres, TextBox email)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERILER Where ID=@musteriID", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("musteriID", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
               

                while (dr.Read())
                {
                    ad.Text = dr["AD"].ToString();
                    soyad.Text = dr["SOYAD"].ToString();
                    tlf.Text = dr["TELEFON"].ToString();
                    adres.Text = dr["ADRES"].ToString();
                    email.Text = dr["EMAIL"].ToString();
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            
                dr.Close();
                con.Dispose();
                con.Close();
            
        }

        public void MusteriGetirAd(ListView lv,string musteriAd)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERILER Where AD like @musteriAd + '%' and durum=1", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriAd", SqlDbType.VarChar).Value = musteriAd;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString()); 
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void MusteriGetirAdRezervasyon(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT REZERVESYONLAR.ID, REZERVESYONLAR.MUSTERIID, REZERVESYONLAR.MASAID, REZERVESYONLAR.ADISYONID, MUSTERILER.AD, MUSTERILER.SOYAD, REZERVESYONLAR.TARIH, " +
                                    "CASE WHEN MASALAR.DURUM = 3 THEN 'Açık rezerve' WHEN MASALAR.DURUM = 4 THEN 'Rezerve' ELSE 'Diğer Durum' END AS MASADURUM " +
                                    "FROM REZERVESYONLAR " +
                                    "INNER JOIN MUSTERILER ON REZERVESYONLAR.MUSTERIID = MUSTERILER.ID " +
                                    "INNER JOIN MASALAR ON REZERVESYONLAR.MASAID = MASALAR.ID " +
                                    "INNER JOIN ADISYONLAR ON REZERVESYONLAR.ADISYONID = ADISYONLAR.ID " +
                                    "WHERE MUSTERILER.AD LIKE @musteriAd + '%' AND REZERVESYONLAR.DURUM = 1", con);


            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriAd", SqlDbType.VarChar).Value = musteriAd;

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
                    lv.Items[sayac].SubItems.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["MASAID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADISYONID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TARIH"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["MASADURUM"].ToString()); // Artık doğrudan MASALAR.DURUM'u kullanabilirsiniz
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }

                con.Close();
            }
        }

        public void MusteriGetirSoyAd(ListView lv, string musteriSoyad)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERILER Where SOYAD like @musteriSoyad + '%' and durum=1 ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriSoyad", SqlDbType.VarChar).Value = musteriSoyad;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
          public void MusteriGetirTlf(ListView lv, string musteriTlf)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERILER Where TELEFON like @musteriTlf + '%' and durum=1", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriTlf", SqlDbType.VarChar).Value = musteriTlf;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
    }
}
