using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Restaurant_Otomasyon
{
    public partial class frmRapor : Form
    {
        public frmRapor()
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

        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            Istatistik("Ana Yemekler Grafiği",1,Color.Red);
        }
        private void Istatistik(string gfName,int katId,Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            cUrunler c = new cUrunler();
            lvIstatistik.Items.Clear();
            c.UrunleriListeleIstatiklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, katId);
            gbIstatistik.Text = gfName;
            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Bu tarihler arası satış yapan ürün yoktur. Lütfen başka tarihler arası seçim yapınız.");
            }
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği", 2, Color.Orange);
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            Istatistik("Tatlılar Grafiği", 3, Color.Blue);
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            Istatistik("Salata Grafiği", 4, Color.Green);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            Istatistik("FastFood Grafiği", 5, Color.LightBlue);
        }

        private void btnCorba_Click(object sender, EventArgs e)
        {
            Istatistik("Çorba Grafiği", 6, Color.Yellow);
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            Istatistik("Makarna Grafiği", 7, Color.Purple);
        }

        private void btnAraSicak_Click(object sender, EventArgs e)
        {
            Istatistik("Ara Sıcaklar Grafiği", 8, Color.DarkOrange);
        }

        private void btnZraporu_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.GreenYellow;
            cUrunler c = new cUrunler();
            lvIstatistik.Items.Clear();
            c.UrunleriListeleIstatiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            gbIstatistik.Text = "Tüm Ürünler";
            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Bu tarihler arası satış yapan ürün yoktur. Lütfen başka tarihler arası seçim yapınız.");
            }
        }
    }
}
