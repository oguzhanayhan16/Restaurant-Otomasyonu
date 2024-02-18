using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyon
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
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

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusteriGetirRezervasyon(lvMusteriler);
            cMasalar masa = new cMasalar();
            masa.masaKapasitesiDurumGetir(cbMasa);
            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;
            timer1.Interval = 60000; // 1 dakikada bir kontrol etmek için
            timer1.Tick += timer1_Tick;

            // Zamanlayıcıyı başlat
            timer1.Start();
        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusteriGetirAd(lvMusteriler,txtMusteriAd.Text);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusteriGetirTlf(lvMusteriler, txtTelefon.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusteriGetirAd(lvMusteriler, txtAdres.Text);
        }
        void Temizle()
        {
            txtAdres.Clear();
            txtKisiSayisi.Clear();
            txtMasa.Clear();
            txtTarih.Clear();
            txtAciklama.Clear();
            txtMusteriAd.Clear();
            txtTelefon.Clear();
        }

        private void btnRezervasyonAc_Click(object sender, EventArgs e)
        {
            cRezervasyon r = new cRezervasyon();
            if (lvMusteriler.SelectedItems.Count>0)
            {
                bool sonuc = r.rezervasyonAcikmiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                if (sonuc)
                {
                    if (txtTarih.Text!=" ")
                    {
                        if (txtKisiSayisi.Text!=" ")
                        {
                            cMasalar masa= new cMasalar();
                            if (masa.TableGetByState(Convert.ToInt32(txtMasaNo.Text), 1))
                            {
                                cAdisyon a = new cAdisyon();
                                a.Tarih=Convert.ToDateTime(txtTarih.Text);
                                a.ServisTurNo = 1;
                                a.MasaId = Convert.ToInt32(txtMasaNo.Text);
                                a.PersonelId = cGenel._personelId;
                                r.ClientID=Convert.ToInt32(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                                r.TableID = Convert.ToInt32(txtMasaNo.Text);
                                r.Date = Convert.ToDateTime(txtTarih.Text);
                                r.CleintCount = Convert.ToInt32(txtKisiSayisi.Text);
                                r.AdditionID = a.AdisyonRezervasyonAc(a);
                                sonuc = r.rezervasyonAc(r);

                                string tarihMetni = txtTarih.Text.Replace("  ", " ").Trim();
                                DateTime rezervasyonTarihi;

                                // Tarih çözümleme işlemi
                                if (DateTime.TryParseExact(tarihMetni, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out rezervasyonTarihi))
                                {
                                    // Başarılıysa, rezervasyon tarihini kullanabilirsiniz
                                    if (rezervasyonTarihi.Date == DateTime.Today)
                                    {
                                        masa.setChangeTableState(txtMasaNo.Text, 3);
                                    }
                                }
                                else
                                {
                                    // Hata durumunu ele alabilirsiniz
                                    MessageBox.Show("Geçerli bir tarih ve saat formatı bekleniyor.");
                                }


                                if (sonuc)
                                {
                                    MessageBox.Show("Rezervasyon başarıyla açılmıştır.");
                                    Temizle();
                                    cMusteriler m = new cMusteriler();
                                    m.MusteriGetirRezervasyon(lvMusteriler);
                                }
                                else
                                {
                                    MessageBox.Show("Rezervasyon açılamamıştır..");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon yapılamadı.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Lütfen kisi sayısı seçiniz seçiniz.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir tarih seçiniz.");

                    }
                }
                else
                {
                    MessageBox.Show("Bu müşteri üzerine açık rezervasyon bulunmaktadır.");

                }

            }
            else
            {
                MessageBox.Show("asdasd.");
            }
        }

        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;

        }

        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 20;

        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text=dtTarih.Value.ToString();
        }

        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text=cbKisiSayisi.SelectedItem.ToString();
        }

        

        private void cbMasa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbKisiSayisi.Enabled = true;
            txtMasa.Text = cbMasa.SelectedItem.ToString();
            cMasalar kapasitesi = (cMasalar)cbMasa.SelectedItem;

            

            int kapasite = kapasitesi.Kapasite;
            txtMasaNo.Text = Convert.ToString(kapasitesi.ID);

            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapasite; i++)
            {
                cbKisiSayisi.Items.Add(i + 1);
            }
        }

        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 250;
        }

        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 20;
        }



        
        
      

        private void cbKisiSayisi_MouseEnter_1(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 50;
        }

        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 20;
        }

        private void btnSiparisKontrol_Click(object sender, EventArgs e)
        {
           /* frmSiparisKontrol frm = new frmSiparisKontrol();*/
           frmRezervasyonKontrol frm = new frmRezervasyonKontrol(); 
            this.Close();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkleme frm = new MusteriEkleme();
            cGenel._MusteriEkleme = 0;
            frm.GuncelleButonDurumunuAyarla(false);
            frm.EkleButonDurumAyarla(true);
            this.Close(); 
            frm.Show();

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {
                MusteriEkleme me = new MusteriEkleme();
              
                cGenel._MusteriEkleme = 0;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                me.GuncelleButonDurumunuAyarla(true);
                me.EkleButonDurumAyarla(false);
                this.Close();
                me.Show();

            }
        }

        private void txtMasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMasaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tarihMetni = txtTarih.Text.Replace("  ", " ").Trim();
            DateTime rezervasyonTarihi;

            // Tarih çözümleme işlemi
            if (DateTime.TryParseExact(tarihMetni, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out rezervasyonTarihi))
            {
                // Başarılıysa, rezervasyon tarihini kontrol edebilirsiniz
                if (rezervasyonTarihi.Date == DateTime.Today)
                {
                    cMasalar masa = new cMasalar();
                    masa.setChangeTableState(txtMasaNo.Text, 3);

                    // İşlem tamamlandıktan sonra zamanlayıcıyı durdurabilirsiniz
                    timer1.Stop();
                }
            }
            else
            {
                // Hata durumunu ele alabilirsiniz
                MessageBox.Show("Geçerli bir tarih ve saat formatı bekleniyor.");
            }
        }
    }
}
