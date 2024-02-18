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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem; 
            txtPersonelId.Text = Convert.ToString(c.PersonelId);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.Items.Count > 0)
            {
                btnSil.Enabled = true;
                txtPersonelId.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnSil.Enabled = false;
            }
          
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._personelGorevId);
            if (gorev=="Müdür")
            {
                cp.personelGetbyInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetirLV(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnDegistir.Enabled = false;
                btnKaydet.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki : Personel / Yetki Sınırlı / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() !="" || txtYeniSifreTekrar.Text.Trim() !="")
            {
                if (txtYeniSifre.Text== txtYeniSifreTekrar.Text)
                {
                    if (txtPersonelId.Text !="")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc =c.personelSifreDegistir(Convert.ToInt32(txtPersonelId.Text),txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla tamamlandı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel seçiniz.");
                    }
                         
                }
                else
                {
                    MessageBox.Show("Şifre aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız.");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev cPersonelGorev = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(cPersonelGorev.PersonelGorevId);
        
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
            btnKaydet.Enabled = true;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.Items.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                   bool sonuc= c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silinmiştir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluşmuştur.");
                    }

                }
                else
                {
                    MessageBox.Show("Kayıt seçiniz.");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim()!="" & txtSoyad.Text.Trim() != ""& txtSifreTekrar.Text.Trim() != ""& txtSifre.Text.Trim() !="" & txtGorevId2.Text.Trim() !="")
            {
                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim())&&(txtSifreTekrar.Text.Length>5 || txtSifre.Text.Length>5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd=txtAd.Text.Trim();
                    c.PersonelSoyad=txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifreTekrar.Text;
                    c.GorevId = Convert.ToInt32(txtGorevId2.Text);
                    bool sonuc=c.personelEkle(c);
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarılı.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluşmuştur.");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreler aynı değildir.");
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
          if (lvPersoneller.SelectedItems.Count>0)
           {

            if (txtAd.Text != "" || txtSoyad.Text != "" || txtSifreTekrar.Text != "" || txtSifre.Text != "" || txtGorevId2.Text != "")
            {
                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifreTekrar.Text.Length > 5 || txtSifre.Text.Length > 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifreTekrar.Text;
                    c.GorevId = Convert.ToInt32(txtGorevId2.Text);
                    bool sonuc = c.personelGuncelle(c,Convert.ToInt32(txtPersonelId.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarılı.");
                            c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluşmuştur.");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreler aynı değildir.");
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
          }
            else
            {
                MessageBox.Show("Kayıt seçiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" || textBox3.Text.Trim() != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox2.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla tamamlandı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel seçiniz.");
                    }

                }
                else
                {
                    MessageBox.Show("Şifre aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız.");
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

        private void txtPersonelId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
