using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Otomasyon
{
    internal class cPaketler
    {
        cGenel gnl= new cGenel();
        #region MyRegion
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _Paytypeid;


        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int Paytypeid { get => _Paytypeid; set => _Paytypeid = value; }
        #endregion
        public bool OrderSeriveceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into PAKETSIPARIS(ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA)values(@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA) ", con);
            try
            {
                if (con.State==System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID",SqlDbType.Int).Value=order._AdditionID;
                cmd.Parameters.Add("@MUSTERIID",SqlDbType.Int).Value=order._ClientId;
                cmd.Parameters.Add("@ODEMETURID",SqlDbType.Int).Value=order._Paytypeid;
                cmd.Parameters.Add("@ACIKLAMA",SqlDbType.Int).Value=order._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            } 
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally { con.Close();
                con.Dispose();
            }
            return result;
        }//paket servis açma
        public void OrderSeriveceClose(int AdditionID) {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update PAKETSIPARIS set PAKETSIPARIS.DURUM=1  where PAKETSIPARIS.ADISYONID=@AdditionID ", con);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value =AdditionID;
              
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

        }//paket servis kapatma

        public int OdemeTurIdGetir( int adisyonId)
        {
          int odemeTurId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PAKETSIPARIS.ODEMETURID from PAKETSIPARIS Inner Join ADISYONLAR on PAKETSIPARIS.ADISYONID=ADISYONLAR.ID where ADISYONLAR.ID=@adisyonId", con);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;

                odemeTurId = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return odemeTurId;
        }

        public int musteriSonAdisyonIDGetir(int musteriId)
        {
            int odemeTurId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select ADISYONLAR.ID from ADISYONLAR Inner Join PAKETSIPARIS on PAKETSIPARIS.ADISYONID=ADISYONLAR.ID where (ADISYONLAR.DURUM=0)" +
                " and  (PAKETSIPARIS.DURUM=0) and  (PAKETSIPARIS.MUSTERIID=@musteriId)", con);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;

                odemeTurId = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return odemeTurId;
        }
        public bool getCheckedOpenAdditionID(int additionId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from ADISYONLAR where (DURUM=0) and (ID=@additionId) ", con);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionId", SqlDbType.Int).Value = additionId;
             
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return result;
        }
    }
}
