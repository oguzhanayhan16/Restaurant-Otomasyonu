namespace Restaurant_Otomasyon
{
    partial class frmMusteriAra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.txtAdisyonId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frmAdisyonBul = new System.Windows.Forms.Button();
            this.frmGeriDon = new System.Windows.Forms.Button();
            this.frmSiparisler = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(881, 69);
            this.txtMusteriAd.Multiline = true;
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(305, 145);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYAD";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(46, 69);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 36);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.AutoSize = true;
            this.txtAdres.BackColor = System.Drawing.Color.Transparent;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.Color.White;
            this.txtAdres.Location = new System.Drawing.Point(917, 20);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(108, 31);
            this.txtAdres.TabIndex = 0;
            this.txtAdres.Text = "ADRES";
            this.txtAdres.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(476, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = " TELEFON";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(491, 69);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(172, 36);
            this.txtTelefon.TabIndex = 1;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyAd.Location = new System.Drawing.Point(268, 69);
            this.txtSoyAd.Multiline = true;
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.Size = new System.Drawing.Size(172, 36);
            this.txtSoyAd.TabIndex = 1;
            this.txtSoyAd.TextChanged += new System.EventHandler(this.txtSoyAd_TextChanged);
            // 
            // txtAdisyonId
            // 
            this.txtAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdisyonId.Location = new System.Drawing.Point(703, 69);
            this.txtAdisyonId.Multiline = true;
            this.txtAdisyonId.Name = "txtAdisyonId";
            this.txtAdisyonId.Size = new System.Drawing.Size(172, 36);
            this.txtAdisyonId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(703, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "ADİSYON ID";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(46, 111);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(829, 412);
            this.lvMusteriler.TabIndex = 2;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.SelectedIndexChanged += new System.EventHandler(this.lvMusteriler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " Telefon";
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 154;
            // 
            // frmAdisyonBul
            // 
            this.frmAdisyonBul.BackColor = System.Drawing.Color.Transparent;
            this.frmAdisyonBul.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_36;
            this.frmAdisyonBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmAdisyonBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmAdisyonBul.Location = new System.Drawing.Point(881, 220);
            this.frmAdisyonBul.Name = "frmAdisyonBul";
            this.frmAdisyonBul.Size = new System.Drawing.Size(305, 142);
            this.frmAdisyonBul.TabIndex = 3;
            this.frmAdisyonBul.UseVisualStyleBackColor = false;
            this.frmAdisyonBul.Click += new System.EventHandler(this.frmAdisyonBul_Click);
            // 
            // frmGeriDon
            // 
            this.frmGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.frmGeriDon.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_141;
            this.frmGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmGeriDon.Location = new System.Drawing.Point(882, 380);
            this.frmGeriDon.Name = "frmGeriDon";
            this.frmGeriDon.Size = new System.Drawing.Size(155, 143);
            this.frmGeriDon.TabIndex = 3;
            this.frmGeriDon.UseVisualStyleBackColor = false;
            this.frmGeriDon.Click += new System.EventHandler(this.frmGeriDon_Click);
            // 
            // frmSiparisler
            // 
            this.frmSiparisler.BackColor = System.Drawing.Color.Transparent;
            this.frmSiparisler.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_281;
            this.frmSiparisler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmSiparisler.Location = new System.Drawing.Point(882, 529);
            this.frmSiparisler.Name = "frmSiparisler";
            this.frmSiparisler.Size = new System.Drawing.Size(276, 143);
            this.frmSiparisler.TabIndex = 3;
            this.frmSiparisler.UseVisualStyleBackColor = false;
            this.frmSiparisler.Click += new System.EventHandler(this.frmSiparisler_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGuncelle.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_35;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(599, 529);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(276, 143);
            this.btnMusteriGuncelle.TabIndex = 3;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriSec.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_34;
            this.btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriSec.Location = new System.Drawing.Point(317, 529);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(276, 143);
            this.btnMusteriSec.TabIndex = 3;
            this.btnMusteriSec.UseVisualStyleBackColor = false;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.yeni_resimler;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Location = new System.Drawing.Point(35, 529);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(276, 143);
            this.btnYeniMusteri.TabIndex = 3;
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_14;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(110, 678);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(90, 83);
            this.btnGeriDon.TabIndex = 8;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_15;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(14, 678);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 83);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.dark_grey_windows_8_background_by_gifteddeviant_d4yvcut_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 770);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.frmAdisyonBul);
            this.Controls.Add(this.frmGeriDon);
            this.Controls.Add(this.frmSiparisler);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.txtSoyAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtAdisyonId);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriAra";
            this.Text = "Müşteri Arama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusteriAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.TextBox txtAdisyonId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button frmAdisyonBul;
        private System.Windows.Forms.Button frmSiparisler;
        private System.Windows.Forms.Button frmGeriDon;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
    }
}