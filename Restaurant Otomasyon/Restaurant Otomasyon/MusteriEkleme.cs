using System;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txtMusteriSoyAd.Text == "")
                {
                    MessageBox.Show("Lütfen müşteri ad soyadını doldurunuz.");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.musteriVarmi(txtTelefon.Text);
                    if (!sonuc)
                    {
                        c.MusteriAd = txtMusteriAd.Text;
                        c.MusteriSoyAd = txtMusteriSoyAd.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Email = txtEmail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text = c.MusteriEkle(c).ToString();
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Eklenemedi!!!!!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde kayıt eklenemedi!!!!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 karakterli bir numara giriniz.");
            }
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txtMusteriSoyAd.Text == "")
                {
                    MessageBox.Show("Lütfen müşteri ad soyadını doldurunuz.");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.MusteriAd = txtMusteriAd.Text;
                    c.MusteriSoyAd = txtMusteriSoyAd.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Email = txtEmail.Text;
                    c.Adres = txtAdres.Text;
                    c.MusteriID = Convert.ToInt32(txtMusteriNo.Text);
                    bool sonuc = c.MusteriBilgileriGuncelle(c);

                    if (sonuc)
                    {

                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Güncellendi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Güncellenemedi!!!!!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde kayıt güncellenemedi!!!!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 karakterli bir numara giriniz.");
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (cGenel._MusteriEkleme == 0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._MusteriEkleme = 1;
                this.Close();
                frm.Show();
            }
            else if (cGenel._MusteriEkleme == 1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._MusteriEkleme = 0;
                this.Close();
                frm.Show();
            }
        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId > 0)
            {

                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.MusterileriGetirId(Convert.ToInt32(txtMusteriNo.Text), txtMusteriAd, txtMusteriSoyAd, txtTelefon, txtAdres, txtEmail);
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }
        public void GuncelleButonDurumunuAyarla(bool durum)
        {
            btnGuncelle.Enabled = durum;

        }
        public void EkleButonDurumAyarla(bool durum)
        {

            btnEkle.Enabled = durum;
        }
    }
}
