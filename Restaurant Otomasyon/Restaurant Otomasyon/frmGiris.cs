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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        
       private void frmGiris_Load(object sender, EventArgs e)
        {
           cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cbKullanici);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p=new cPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text,cGenel._personelId);

            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri
                {
                    PersonelId = cGenel._personelId,
                    Islem = "Giriş yaptı",
                    Tarih = DateTime.Now
                };
                ch.PersonelActionSave(ch);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Şifreniz yanlış?", "Uyarı!!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._personelGorevId = p.GorevId;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
