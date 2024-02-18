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
    internal class cPersonelGorev
    {

        cGenel gnl = new cGenel();
        private int  _personelGorevId;
        private string _tanim;

        public int PersonelGorevId { get => _personelGorevId; set => _personelGorevId = value; }
        public string tanim { get => _tanim; set => _tanim = value; }

        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from PERSONELGOREVLERI", con);

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
                    cPersonelGorev cp = new cPersonelGorev();
                    cp.PersonelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    cp.tanim = Convert.ToString(dr["GOREV"]);
                    cb.Items.Add(cp);
                  

                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            
             

        }
        public string PersonelGorevTanim(int per)
        {
            string sonuc = "";

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select GOREV from PERSONELGOREVLERI where ID=@perId", con);


            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = per;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
              sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

            con.Dispose();
            con.Close();

            return sonuc;
        }

        public override string ToString()
        {
            return _tanim;
        }
    }
}
