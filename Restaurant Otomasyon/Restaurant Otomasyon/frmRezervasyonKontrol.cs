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
    public partial class frmRezervasyonKontrol : Form
    {
        public frmRezervasyonKontrol()
        {
            InitializeComponent();
        }

        private void frmRezervasyonKontrol_Load(object sender, EventArgs e)
        {
            cRezervasyon cRezervasyon = new cRezervasyon();
            cRezervasyon.RezervasyonKontrol(lvRezervasyon);
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

        private void lvRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRezervasyon.SelectedItems.Count > 0)
            {
                txtMusteriID.Text = lvRezervasyon.SelectedItems[0].SubItems[1].Text;
                txtMusteriAdSil.Text = lvRezervasyon.SelectedItems[0].SubItems[4].Text;
                txtMusteriSoyadiSil.Text = lvRezervasyon.SelectedItems[0].SubItems[5].Text;
                txtTarihSil.Text = lvRezervasyon.SelectedItems[0].SubItems[6].Text;
                txtRezerveSil.Text = lvRezervasyon.SelectedItems[0].SubItems[7].Text;
                

            }
        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusteriGetirAdRezervasyon(lvRezervasyon,txtMusteriAd.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cRezervasyon c = new cRezervasyon();
            if (lvRezervasyon.SelectedItems.Count > 0)
            {
           
                if (MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                if (txtRezerveSil.Text == "Açık rezerve")
                {
                    c.rezervationKapat(Convert.ToInt32(txtMusteriID.Text));
                    cMusteriler cm = new cMusteriler();
                    cm.MusteriSil(Convert.ToInt32(txtMusteriID.Text));
                    cMasalar cMasalar = new cMasalar();
                    cMasalar.setChangeTableState(lvRezervasyon.SelectedItems[0].SubItems[2].Text, 1);
                    MessageBox.Show("Rezervasyon silindi");
                }
                else
                {
                    MessageBox.Show("Bu rezervasyon zaten açıktır.");
                }
            }
            }
            else
            {
                MessageBox.Show("Lütfen bir kişi seçiniz.");
            }


        }
    }
}
