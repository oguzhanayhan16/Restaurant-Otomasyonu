using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant_Otomasyon
{
    internal class cOdeme
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurID;
        private decimal _AraToplam;
        private decimal _Indırım;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriID;


        #endregion

        #region Properties
        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public int OdemeTurID { get => _OdemeTurID; set => _OdemeTurID = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indırım { get => _Indırım; set => _Indırım = value; }
        public decimal KdvTutari { get => _KdvTutari; set => _KdvTutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriID { get => _MusteriID; set => _MusteriID = value; }
        #endregion

        //Müşterinin masa hesabını kapatma
        public bool billClose(cOdeme bill)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into HESAPODEMELERI(ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,INDIRIM,TOPLAMTUTAR) values" +
                "(@ADISYONID,@ODEMETURID,@MUSTERIID,@ARATOPLAM,@KDVTUTARI,@INDIRIM,@TOPLAMTUTAR)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = bill._AdisyonID;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = bill._OdemeTurID;
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = bill._MusteriID;
                cmd.Parameters.Add("@ARATOPLAM", SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("@KDVTUTARI", SqlDbType.Money).Value = bill._KdvTutari;
                cmd.Parameters.Add("@INDIRIM", SqlDbType.Money).Value = bill._Indırım;
                cmd.Parameters.Add("@TOPLAMTUTAR", SqlDbType.Money).Value = bill._GenelToplam;
              
       

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
        //Müşterinin toplam harcamasını buluyoruz
        public decimal sumtTotalforClientId(int clientId)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select sum(TOPLAMTUTAR) as total from HESAPODEMELERI where MUSTERIID=@clientId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;



                total = Convert.ToDecimal(cmd.ExecuteNonQuery());
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
          
            return total;

        }
    }
}
