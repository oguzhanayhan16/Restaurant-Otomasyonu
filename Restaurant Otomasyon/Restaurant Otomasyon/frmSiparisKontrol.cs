using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    public partial class frmSiparisKontrol : Form
    {
        public frmSiparisKontrol()
        {
            InitializeComponent();
        }

        private void frmSiparisKontrol_Load(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            int butonSayisi = c.paketAdisyonIdBul();
            c.acıkPaketAdisyonlar(lvMusteriler);
            int alt = 1;
            int sol = 50;
            int bol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonSayisi)));
            for (int i = 1; i <= butonSayisi; i++)
            {
                Button btn = new Button();
                btn.AutoSize = false;
                btn.Size = new Size(179, 80);
                btn.FlatStyle=FlatStyle.Flat;
                btn.Name = lvMusteriler.Items[i - 1].SubItems[0].Text;
                btn.Text = lvMusteriler.Items[i - 1].SubItems[1].Text;
                btn.Font = new Font(btn.Font.FontFamily.Name, 180);
                btn.Location = new Point(sol, alt);
                this.Controls.Add(btn);

                sol+=btn.Width + 5;
                if (i == 2)
                {
                    sol = 1;
                    alt += 50;
                }
                btn.Click += new EventHandler(dinamicMethod);
                btn.MouseEnter +=new EventHandler(dinamicMethod2);
            }
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void dinamicMethod(object sender,EventArgs e)
        {
            Button dinamikButton = (sender as Button);
            cAdisyon c = new cAdisyon();

            frmBill frm = new frmBill();
            cGenel._ServisTurNo = 2;
            cGenel._AdisyonId = Convert.ToString(c.musterininSonAdisyonID(Convert.ToInt32(dinamikButton.Name)));
            frm.Show();
        }
        protected void dinamicMethod2(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
           
            Button dinamikButton = (sender as Button);
            c.musteriDetaylar(lvMusteriDetaylari, Convert.ToInt32(dinamikButton.Name));
            sonSiparisTarihi();
            lvSatisDetaylari.Items.Clear();
            cSiparis s= new cSiparis();
            cGenel._ServisTurNo = 2;
            cGenel._AdisyonId = Convert.ToString(c.musterininSonAdisyonID(Convert.ToInt32(dinamikButton.Name)));
            lblGenelToplam.Text = s.GenelToplamBul(Convert.ToInt32(dinamikButton.Name)).ToString()+" TL";
        }

        void sonSiparisTarihi()//sıkıntı var
        {
            if (lvMusteriDetaylari.Items.Count>0)
            {
                int s = lvMusteriDetaylari.Items.Count;
                lblSonSiparis.Text = lvMusteriDetaylari.Items[s - 1].SubItems[3].Text;
                txtToplamTutar.Text = s.ToString();

            }
        }

        void Toplam()
        {
            int katSayisi = lvSatisDetaylari.Items.Count;
            decimal toplam = 0;
            for (int i = 0; i < katSayisi; i++)
            {
                toplam += Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[2].Text) * Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[3].Text);
            }

            lblToplamSiparis.Text = toplam.ToString()+" TL";
        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMusteriDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMusteriDetaylari.SelectedItems.Count>0)
            {
                cSiparis c = new cSiparis();
                c.AdisyonPaketSiparisDetay(lvSatisDetaylari, Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                Toplam();
                lblGenelToplam.Text = c.GenelToplamBul(Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[0].Text)).ToString() + " TL";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void lvSatisDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
