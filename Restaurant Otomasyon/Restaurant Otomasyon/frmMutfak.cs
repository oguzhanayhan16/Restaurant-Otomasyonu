using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri anaKategori = new cUrunCesitleri();
            anaKategori.UrunCesiletiniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;


            label4.Visible = false;
            txtArama.Visible = false;
            cUrunCesitleri c = new cUrunCesitleri();
            c.UrunCesiletiniGetir(lvKategoriler);
            rbAnaKategori.Checked=true;
        }
        private void Temizle()
        {
            txtGidaAd.Clear();
            txtGidaFiyat.Clear();
            txtGidaFiyat.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAnaKategori.Checked)
            {
                if (txtGidaAd.Text.Trim() == "" || txtGidaFiyat.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida adi,fiyatı ve kategorisi seçilmemiştir", "Dikkat bilgiler eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cUrunler cUrunler = new cUrunler();
                    cUrunler.Fiyat = Convert.ToDecimal(txtGidaFiyat.Text);
                    cUrunler.UrunAd = txtGidaAd.Text;
                    cUrunler.Aciklama = "Ürün Eklendi";
                    cUrunler.Urunturno = urunTurNo;
                    int sonuc = cUrunler.Urunekle(cUrunler);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklenmiştir.");

                        yenile();
                        Temizle();
                    }
                }

            }
            else
            {
                if (txtKategoriAdi.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz.", "Dikkat bilgiler eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri cu = new cUrunCesitleri();
                    cu.Aciklama = txtAciklama.Text;
                    cu.KategoriAd = txtKategoriAdi.Text;
                    int sonuc = cu.Urunekle(cu);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Eklenmiştir.");
                        yenile();
                        Temizle();
                    }
                }
            }
        }
        int urunTurNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler cUrunler = new cUrunler();
            if (cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                cUrunler.UrunlerListele(lvGidaListesi);
            }
            else
            {
                cUrunCesitleri cu = (cUrunCesitleri)cbKategoriler.SelectedItem;
                urunTurNo = cu.UrunTurNo;
                cUrunler.urunleriListeleByUrunId(lvGidaListesi, urunTurNo);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbAnaKategori.Checked)
            {
                if (txtGidaAd.Text.Trim() == "" || txtGidaFiyat.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida adi,fiyatı ve kategorisi seçilmemiştir", "Dikkat bilgiler eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cUrunler cUrunler = new cUrunler();
                    cUrunler.Fiyat = Convert.ToDecimal(txtGidaFiyat.Text);
                    cUrunler.UrunAd = txtGidaAd.Text;
                    cUrunler.UrunId = Convert.ToInt32(txtUrunId.Text);
                    cUrunler.Urunturno = urunTurNo;
                    cUrunler.Aciklama = "Ürün Güncellendi";
                    int sonuc = cUrunler.UrunBilgileriGuncelle(cUrunler);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Güncellendi.");
                        yenile();
                        Temizle();
                    }
                }

            }
            else
            {
                if (txtKategoriId.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Dikkat bilgiler eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri cu = new cUrunCesitleri();
                    cu.Aciklama = txtAciklama.Text;
                    cu.KategoriAd = txtKategoriAdi.Text;
                    cu.UrunTurNo = Convert.ToInt32(txtKategoriId.Text);
                    int sonuc = cu.UrunBilgileriGuncelle(cu);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Güncellenmiştir.");
                        yenile();
                        Temizle();
                    }
                }
            }
        }

        private void lvGidaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                txtGidaAd.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyat.Text = lvGidaListesi.SelectedItems[0].SubItems[4].Text;
                txtUrunId.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;

            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                txtKategoriAdi.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriId.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtAciklama.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (rbAnaKategori.Checked)
            {
                if (lvGidaListesi.SelectedItems.Count > 0)
                {

                    if (MessageBox.Show("Ürün silmekte emin misiniz?", "Dikkat bilgiler eksik", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler cUrunler = new cUrunler();

                        cUrunler.UrunId = Convert.ToInt32(txtUrunId.Text);

                        int sonuc = cUrunler.UrunBilgileriSil(cUrunler,1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir.");
                         
                            cbKategoriler_SelectedIndexChanged(sender, e);
                            yenile();
                            Temizle();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Lütfen ürün seçiniz");
                }

            }
            else
            {
                if (lvKategoriler.SelectedItems.Count>0)
                {

                if (MessageBox.Show("Ürün silmekte emin misiniz?", "Dikkat bilgiler eksik", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   cUrunCesitleri cu = new cUrunCesitleri();


                        int sonuc = cu.UrunKategoriSil(Convert.ToInt32(txtKategoriId));
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Silinmiştir.");
                            cUrunler cUrunler = new cUrunler();
                            cUrunler.UrunId = Convert.ToInt32(txtKategoriId.Text);
                            cUrunler.UrunBilgileriSil(cUrunler, 0);
                            yenile();
                        Temizle();
                    }

                }
                }


            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            label4.Visible = true;
            txtArama.Visible = true;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rbAnaKategori.Checked)
            {
                cUrunler c = new cUrunler();
                c.urunleriListeleByUrunAdi(lvGidaListesi,txtArama.Text);
            }
            else
            {
                cUrunCesitleri c = new cUrunCesitleri();
                c.UrunCesiletiniGetir(lvKategoriler, txtArama.Text);
            }
        }

        private void rbAltKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGidaListesi.Visible = false;
            yenile();
          /*  cUrunCesitler c = new cUrunCesitleri();
            c.UrunCesiletiniGetir(lvKategoriler);*/
        }

        private void rbAnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGidaListesi.Visible = true;
            yenile();
        }

        private void yenile()
        {
            cUrunCesitleri c = new cUrunCesitleri();
            c.UrunCesiletiniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            c.UrunCesiletiniGetir(lvKategoriler);
            cUrunler cu = new cUrunler();
            cu.UrunlerListele(lvGidaListesi);

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
    }
}
