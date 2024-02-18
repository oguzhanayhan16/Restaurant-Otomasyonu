namespace Restaurant_Otomasyon
{
    partial class frmRezervasyon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.cbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.MusteriNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisKontrol = new System.Windows.Forms.Button();
            this.btnRezervasyonAc = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(156, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kişi Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Masa Seç:";
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(319, 113);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(235, 39);
            this.txtTarih.TabIndex = 5;
            // 
            // txtMasa
            // 
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasa.Location = new System.Drawing.Point(319, 185);
            this.txtMasa.Multiline = true;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.ReadOnly = true;
            this.txtMasa.Size = new System.Drawing.Size(235, 39);
            this.txtMasa.TabIndex = 6;
            this.txtMasa.TextChanged += new System.EventHandler(this.txtMasa_TextChanged);
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiSayisi.Location = new System.Drawing.Point(319, 261);
            this.txtKisiSayisi.Multiline = true;
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.ReadOnly = true;
            this.txtKisiSayisi.Size = new System.Drawing.Size(235, 39);
            this.txtKisiSayisi.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(319, 335);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(235, 251);
            this.txtAciklama.TabIndex = 8;
            // 
            // dtTarih
            // 
            this.dtTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTarih.Location = new System.Drawing.Point(560, 113);
            this.dtTarih.MaximumSize = new System.Drawing.Size(250, 800);
            this.dtTarih.MinimumSize = new System.Drawing.Size(4, 39);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(17, 39);
            this.dtTarih.TabIndex = 9;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            this.dtTarih.Enter += new System.EventHandler(this.dtTarih_Enter);
            this.dtTarih.MouseEnter += new System.EventHandler(this.dtTarih_MouseEnter);
            this.dtTarih.MouseLeave += new System.EventHandler(this.dtTarih_MouseLeave);
            // 
            // cbMasa
            // 
            this.cbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(561, 185);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(16, 39);
            this.cbMasa.TabIndex = 10;
            this.cbMasa.SelectedIndexChanged += new System.EventHandler(this.cbMasa_SelectedIndexChanged_1);
            this.cbMasa.MouseEnter += new System.EventHandler(this.cbMasa_MouseEnter);
            this.cbMasa.MouseLeave += new System.EventHandler(this.cbMasa_MouseLeave);
            // 
            // cbKisiSayisi
            // 
            this.cbKisiSayisi.Enabled = false;
            this.cbKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKisiSayisi.FormattingEnabled = true;
            this.cbKisiSayisi.Location = new System.Drawing.Point(560, 261);
            this.cbKisiSayisi.Name = "cbKisiSayisi";
            this.cbKisiSayisi.Size = new System.Drawing.Size(16, 39);
            this.cbKisiSayisi.TabIndex = 11;
            this.cbKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cbKisiSayisi_SelectedIndexChanged);
            this.cbKisiSayisi.MouseEnter += new System.EventHandler(this.cbKisiSayisi_MouseEnter_1);
            this.cbKisiSayisi.MouseLeave += new System.EventHandler(this.cbKisiSayisi_MouseLeave);
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaNo.Location = new System.Drawing.Point(583, 185);
            this.txtMasaNo.Multiline = true;
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(10, 39);
            this.txtMasaNo.TabIndex = 12;
            this.txtMasaNo.Visible = false;
            this.txtMasaNo.TextChanged += new System.EventHandler(this.txtMasaNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1516, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "ADRES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1157, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "TELEFON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(795, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "MÜŞTERİ";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(802, 85);
            this.txtMusteriAd.Multiline = true;
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(286, 53);
            this.txtMusteriAd.TabIndex = 18;
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(1523, 85);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(286, 53);
            this.txtAdres.TabIndex = 19;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(1164, 85);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(286, 53);
            this.txtTelefon.TabIndex = 20;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriNo,
            this.Ad,
            this.Soyad,
            this.Telefon,
            this.Adres,
            this.Email});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.HoverSelection = true;
            this.lvMusteriler.Location = new System.Drawing.Point(802, 157);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(1007, 429);
            this.lvMusteriler.TabIndex = 21;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.SelectedIndexChanged += new System.EventHandler(this.lvMusteriler_SelectedIndexChanged);
            // 
            // MusteriNo
            // 
            this.MusteriNo.Text = "MusteriNo";
            this.MusteriNo.Width = 0;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 133;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 145;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 165;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 324;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 230;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.yeni_resimler;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Location = new System.Drawing.Point(238, 592);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(369, 189);
            this.btnYeniMusteri.TabIndex = 22;
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_37;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1363, 592);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(369, 189);
            this.btnMusteriGuncelle.TabIndex = 23;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnSiparisKontrol
            // 
            this.btnSiparisKontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisKontrol.BackgroundImage")));
            this.btnSiparisKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisKontrol.Location = new System.Drawing.Point(988, 592);
            this.btnSiparisKontrol.Name = "btnSiparisKontrol";
            this.btnSiparisKontrol.Size = new System.Drawing.Size(369, 189);
            this.btnSiparisKontrol.TabIndex = 24;
            this.btnSiparisKontrol.UseVisualStyleBackColor = true;
            this.btnSiparisKontrol.Click += new System.EventHandler(this.btnSiparisKontrol_Click);
            // 
            // btnRezervasyonAc
            // 
            this.btnRezervasyonAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezervasyonAc.BackgroundImage")));
            this.btnRezervasyonAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezervasyonAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonAc.Location = new System.Drawing.Point(613, 592);
            this.btnRezervasyonAc.Name = "btnRezervasyonAc";
            this.btnRezervasyonAc.Size = new System.Drawing.Size(369, 189);
            this.btnRezervasyonAc.TabIndex = 25;
            this.btnRezervasyonAc.UseVisualStyleBackColor = true;
            this.btnRezervasyonAc.Click += new System.EventHandler(this.btnRezervasyonAc_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_141;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(1738, 592);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(174, 189);
            this.btnKapat.TabIndex = 26;
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_14;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(273, 878);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(90, 83);
            this.btnGeriDon.TabIndex = 27;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_15;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(177, 878);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 83);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.dark_grey_windows_8_background_by_gifteddeviant_d4yvcut_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 973);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnRezervasyonAc);
            this.Controls.Add(this.btnSiparisKontrol);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.cbKisiSayisi);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.Text = "frmRezervasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader MusteriNo;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnSiparisKontrol;
        private System.Windows.Forms.Button btnRezervasyonAc;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Timer timer1;
    }
}