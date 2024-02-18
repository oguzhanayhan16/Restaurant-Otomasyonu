using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkleme frm = new MusteriEkleme();
            cGenel._MusteriEkleme = 1;
            frm.Show();
           
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusteriGetir(lvMusteriler);
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
               cMusteriler cMusteriler = new cMusteriler();
              
                    int sonuc = cMusteriler.MusteriSil(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                    if (sonuc > 0)
                    {

                        MessageBox.Show("Müşteri silindi.");
                        cMusteriler.MusteriGetir(lvMusteriler);
                    }
                    else
                    {

                        MessageBox.Show("Müşteri silinemedi.");
                    }
                

            }
            else
            {
                MessageBox.Show("Müşteri seçiniz.");
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {
                MusteriEkleme frm = new MusteriEkleme();
             
                cGenel._MusteriEkleme = 1;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                
                this.Close();
                frm.Show();  
                
            }
            else
            {
                MessageBox.Show("Müşteri seçiniz.");
            }
        }

        private void frmGeriDon_Click(object sender, EventArgs e)
        {
            
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
            
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusteriGetirAd(lvMusteriler, txtAd.Text);
        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusteriGetirSoyAd(lvMusteriler, txtSoyAd.Text);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusteriGetirTlf(lvMusteriler, txtTelefon.Text);
        }

        private void frmAdisyonBul_Click(object sender, EventArgs e)
        {
            if (txtAdisyonId.Text!="")
            {
                cGenel._AdisyonId = txtAdisyonId.Text;
                cPaketler c = new cPaketler();

                bool sonuc = c.getCheckedOpenAdditionID(Convert.ToInt32(txtAdisyonId.Text));
                if (sonuc)
                {
                    frmBill frm = new frmBill();
                    cGenel._ServisTurNo = 2;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show(txtAdisyonId.Text + " Nolu  adisyon ID bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Aramak istediğiniz adisyonu yazınız");
            }
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            txtSoyAd.Enabled = false;
            txtTelefon.Enabled = false;
            txtMusteriAd.Enabled = true;
        }

        private void txtSoyAd_Click(object sender, EventArgs e)
        {
            txtSoyAd.Enabled = true;
            txtTelefon.Enabled = false;
            txtMusteriAd.Enabled = false;
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            txtSoyAd.Enabled = false;
            txtTelefon.Enabled = true;
            txtMusteriAd.Enabled = false;
        }

        private void frmSiparisler_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Close();
            frm.Show();
        }
    }
}
 