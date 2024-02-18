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
    internal class cMasalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;
        private string _MasaBilgi;


        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTuru { get => _ServisTuru; set => _ServisTuru = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        public string MasaBilgi { get => _MasaBilgi; set => _MasaBilgi = value; }

        #endregion

        cGenel gnl = new cGenel();
        public string SessionSum(int state,string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MASAID from ADISYONLAR Right Join MASALAR on ADISYONLAR.MASAID = MASALAR.ID Where MASALAR.DURUM=@durum and ADISYONLAR.DURUM=0 and " +
                "MASALAR.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum",SqlDbType.Int).Value=state;
            cmd.Parameters.Add("@masaId",SqlDbType.Int).Value=Convert.ToInt32(masaId);
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch(Exception ex)
            {
                string hata=ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

            return "dt";
        } // Hatalı

        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length =aa.Length;
            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }
   

        }
        public bool TableGetByState(int ButtonName,int state)
        {

            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM From MASALAR Where ID=@TableId and DURUM=@State", con);

            cmd.Parameters.Add("@TableId",SqlDbType.Int).Value=ButtonName;
            cmd.Parameters.Add("@state",SqlDbType.Int).Value=state;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                string hata=ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close ();
            }


            return result;
        }

        public void setChangeTableState(string ButonName, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update MASALAR Set DURUM=@DURUM Where ID=@MasaNo", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // "masa" kelimesini kaldır ve geriye kalan kısmı al
                string masaNumberString = ButonName.Trim().Replace("btnMasa", "");

                // Sayısal değeri elde et
                int buttonNumber = Convert.ToInt32(masaNumberString);

                cmd.Parameters.Add("@DURUM", SqlDbType.Int).Value = state;
                cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = buttonNumber;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunu ele alabilirsiniz
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        public void masaKapasitesiDurumGetir(ComboBox cb)
        {
            cb.Items.Clear();
            string durum = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MASALAR Where DURUM=1", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar m = new cMasalar();
                if (m.Durum==2)
                {
                    durum = "DOLU";
                }
                else if (m.Durum == 3)
                {
                    durum = "REZERVE";
                }
                m._Kapasite = Convert.ToInt32(dr["KAPASITE"]);
                m._MasaBilgi = "Masa No: " + dr["ID"].ToString() + " Kapasitesi : " + dr["KAPASITE"].ToString();
                m._ID = Convert.ToInt32(dr["ID"]);
                cb.Items.Add(m);

            }

            dr.Close();
            con.Dispose();
            con.Close();
        }

        public override string ToString()
        {
            return MasaBilgi;
        }

    }
}
