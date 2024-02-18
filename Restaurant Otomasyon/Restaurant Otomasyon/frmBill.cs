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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void lvUurunler_SelectedIndexChanged(object sender, EventArgs e)
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
        cSiparis cs=new cSiparis();
        int odemeTuru = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirmTutarı.TextChanged += new EventHandler(txtIndirmTutarı_TextChanged);
                cs.getByOrder(lvUrunler,Convert.ToInt32(lblAdisyonId.Text));
                if(lvUrunler.Items.Count > 0) {
                    decimal toplam = 0;
                    for(int i = 0;i<lvUrunler.Items.Count;i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 20 / 100;
                    lblKDV.Text = string.Format("{0:0.000}", kdv);
                }
         
                txtIndirmTutarı.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc= new cPaketler();
                odemeTuru = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirmTutarı.TextChanged += new EventHandler(txtIndirmTutarı_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if (odemeTuru == 1)
                {
                    rbKrediKarti.Checked=true;
                }
                else if (odemeTuru == 2)
                {
                    rbKrediKarti.Checked = true;
                    
                }
                else if (odemeTuru == 3)
                {
                   rbTicket.Checked=true;
                }
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 20 / 100;
                    lblKDV.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirmTutarı.Clear();
            }
        }

        private void txtIndirmTutarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirmTutarı.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirmTutarı.Text));
                    }
                    catch (Exception)
                    {
                  

                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !!!");
                }
            }
            catch (Exception)
            {
                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndırım_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndırım.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirmTutarı.Clear();
            }
            else
            
                {  gbIndirim.Visible = false;
                txtIndirmTutarı.Clear();
            }
            
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text)>0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text)-Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);

            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text)*20/100;
            lblKDV.Text=string.Format("{0:0.000}", kdv);
        }
        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (lvUrunler.Items.Count>0)
            {

            
            if (cGenel._ServisTurNo == 1)
            {
                int masaid = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriId = 0;

                if (masalar.TableGetByState(masaid,4)==true)
                {
                    musteriId=rezerve.getByClientIdFromRezervasyon(masaid);
                }
                else
                {
                    musteriId = 1;
                }
                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;

                }
                if (rbKrediKarti.Checked)
                {
                    odemeTurId = 2;

                }
                if (rbTicket.Checked)
                {
                    odemeTurId = 3;

                }
                cOdeme odeme = new cOdeme();
                odeme.AdisyonID= Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurID= odemeTurId;
                odeme.MusteriID = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKDV.Text);
                odeme.GenelToplam=Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indırım=Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                   if (masalar.TableGetByState(masaid, 4) == true)
                   {
                            masalar.setChangeTableState(Convert.ToString(masaid), 1);
                            cRezervasyon c = new cRezervasyon();
                         //   c.rezervationClose(Convert.ToInt32(lblAdisyonId.Text));

                            cAdisyon a = new cAdisyon();
                            MessageBox.Show("Hesap Kapatıldı.");
                            cMusteriler cMusteriler = new cMusteriler();

                            int sonuc = cMusteriler.MusteriSil(Convert.ToInt32(musteriId));
                            c.rezervationKapat(Convert.ToInt32(musteriId));
                            a.adisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 1);
                            this.Close();

                            frmMasalar frm = new frmMasalar();
                            frm.Show();

                        }

                        else {
                            masalar.setChangeTableState(Convert.ToString(masaid), 1);
                            cRezervasyon c = new cRezervasyon();
                            c.rezervationClose(Convert.ToInt32(lblAdisyonId.Text));

                            cAdisyon a = new cAdisyon();
                            MessageBox.Show("Hesap Kapatıldı.");
                            a.adisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 1);
                            this.Close();

                            frmMasalar frm = new frmMasalar();
                            frm.Show();
                        }

                }
                else
                {
                    MessageBox.Show("Hesap kapatılırken bir hata oluştu.Lütfen yetkililere bildiriniz.");
                }

            }
            else if (cGenel._ServisTurNo == 2)
            {
                cOdeme odeme = new cOdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                if (rbNakit.Checked)
                {
                    odemeTuru = 1;

                }
                if (rbKrediKarti.Checked)
                {
                    odemeTuru = 2;

                }
                if (rbTicket.Checked)
                {
                    odemeTuru = 3;

                }
                odeme.OdemeTurID = odemeTuru;
                odeme.MusteriID = 1;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKDV.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indırım = Convert.ToDecimal(lblIndirim.Text);
                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap Kapatıldı.");
                    cPaketler p= new cPaketler();
                    p.OrderSeriveceClose(Convert.ToInt32(lblAdisyonId.Text));
                

                    cAdisyon a = new cAdisyon();

                    a.adisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 0);
                    this.Close();

                    frmMasalar frm = new frmMasalar();
                    frm.Show();


                }
                else
                {
                    MessageBox.Show("Hesap kapatılırken bir hata oluştu.Lütfen yetkililere bildiriniz.");
                }
                }
            }
            else
            {
                MessageBox.Show("Hesap kapatılırken bir hata oluştu.Lütfen yetkililere bildiriniz.");
            }
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font Baslik = new Font("Verdana",15,FontStyle.Bold);
        Font altBaslik = new Font("Verdana",12,FontStyle.Regular);
        Font icerik = new Font("Verdana",10);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("İtadakimasu RESTAURANT",Baslik,sb,350,100,st);
            e.Graphics.DrawString("---------------------",altBaslik,sb,350,120,st);
            e.Graphics.DrawString("Ürün adı                     Adet        Fiyat",altBaslik,sb,150,250,st);
            e.Graphics.DrawString("-----------------------------------------------------",altBaslik,sb,150,280,st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text,icerik,sb,150,300+i*30,st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text,icerik,sb,350,300+i*30,st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text,icerik,sb,420,300+i*30,st);
            }
            e.Graphics.DrawString("-----------------------------------------------------", altBaslik, sb, 150, 300+30*lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutar          :----------------------"+ lblIndirim.Text +" TL", altBaslik,sb, 250, 300+30*(lvUrunler.Items.Count+1), st);
            e.Graphics.DrawString("KDV Tutarı          :----------------------"+ lblKDV.Text +" TL", altBaslik,sb, 250, 300+30*(lvUrunler.Items.Count+2), st);
            e.Graphics.DrawString("Toplam Tutar          :----------------------"+ lblToplamTutar.Text +" TL", altBaslik,sb, 250, 300+30*(lvUrunler.Items.Count+3), st);
            e.Graphics.DrawString("Ödeyeceğiniz Tutar          :----------------------"+ lblOdenecek.Text +" TL", altBaslik,sb, 250, 300+30*(lvUrunler.Items.Count+4), st);
        }
    }
}
