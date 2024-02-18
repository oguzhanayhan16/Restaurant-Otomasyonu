namespace Restaurant_Otomasyon
{
    partial class frmRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.gbIstatistik = new System.Windows.Forms.GroupBox();
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZraporu = new System.Windows.Forms.Button();
            this.btnAraSicak = new System.Windows.Forms.Button();
            this.btnMakarna = new System.Windows.Forms.Button();
            this.btnCorba = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnSalata = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.gbIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(701, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(883, 47);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(431, 41);
            this.dtBaslangic.TabIndex = 2;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(883, 106);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(431, 41);
            this.dtBitis.TabIndex = 3;
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.btnAraSicak);
            this.grpMenu.Controls.Add(this.btnMakarna);
            this.grpMenu.Controls.Add(this.btnCorba);
            this.grpMenu.Controls.Add(this.btnFastFood);
            this.grpMenu.Controls.Add(this.btnSalata);
            this.grpMenu.Controls.Add(this.btnTatlilar);
            this.grpMenu.Controls.Add(this.btnIcecekler);
            this.grpMenu.Controls.Add(this.btnAnaYemek);
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenu.Location = new System.Drawing.Point(47, 95);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(511, 510);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menü";
            // 
            // gbIstatistik
            // 
            this.gbIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.gbIstatistik.Controls.Add(this.lvIstatistik);
            this.gbIstatistik.Controls.Add(this.chRapor);
            this.gbIstatistik.ForeColor = System.Drawing.Color.White;
            this.gbIstatistik.Location = new System.Drawing.Point(586, 181);
            this.gbIstatistik.Name = "gbIstatistik";
            this.gbIstatistik.Size = new System.Drawing.Size(949, 591);
            this.gbIstatistik.TabIndex = 5;
            this.gbIstatistik.TabStop = false;
            // 
            // chRapor
            // 
            this.chRapor.BackColor = System.Drawing.Color.Transparent;
            this.chRapor.BackSecondaryColor = System.Drawing.Color.White;
            this.chRapor.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chRapor.Legends.Add(legend2);
            this.chRapor.Location = new System.Drawing.Point(42, 58);
            this.chRapor.Name = "chRapor";
            this.chRapor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Satislar";
            this.chRapor.Series.Add(series2);
            this.chRapor.Size = new System.Drawing.Size(889, 513);
            this.chRapor.TabIndex = 0;
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.HideSelection = false;
            this.lvIstatistik.Location = new System.Drawing.Point(875, 32);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(15, 20);
            this.lvIstatistik.TabIndex = 1;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adedi";
            // 
            // btnZraporu
            // 
            this.btnZraporu.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_44;
            this.btnZraporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZraporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZraporu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZraporu.Location = new System.Drawing.Point(174, 616);
            this.btnZraporu.Name = "btnZraporu";
            this.btnZraporu.Size = new System.Drawing.Size(336, 173);
            this.btnZraporu.TabIndex = 6;
            this.btnZraporu.UseVisualStyleBackColor = true;
            this.btnZraporu.Click += new System.EventHandler(this.btnZraporu_Click);
            // 
            // btnAraSicak
            // 
            this.btnAraSicak.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_26;
            this.btnAraSicak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAraSicak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAraSicak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAraSicak.Location = new System.Drawing.Point(258, 386);
            this.btnAraSicak.Name = "btnAraSicak";
            this.btnAraSicak.Size = new System.Drawing.Size(246, 114);
            this.btnAraSicak.TabIndex = 0;
            this.btnAraSicak.UseVisualStyleBackColor = true;
            this.btnAraSicak.Click += new System.EventHandler(this.btnAraSicak_Click);
            // 
            // btnMakarna
            // 
            this.btnMakarna.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_25;
            this.btnMakarna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakarna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakarna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakarna.Location = new System.Drawing.Point(6, 386);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(246, 114);
            this.btnMakarna.TabIndex = 0;
            this.btnMakarna.UseVisualStyleBackColor = true;
            this.btnMakarna.Click += new System.EventHandler(this.btnMakarna_Click);
            // 
            // btnCorba
            // 
            this.btnCorba.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_24;
            this.btnCorba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorba.Location = new System.Drawing.Point(258, 265);
            this.btnCorba.Name = "btnCorba";
            this.btnCorba.Size = new System.Drawing.Size(246, 115);
            this.btnCorba.TabIndex = 0;
            this.btnCorba.UseVisualStyleBackColor = true;
            this.btnCorba.Click += new System.EventHandler(this.btnCorba_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_23;
            this.btnFastFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastFood.Location = new System.Drawing.Point(6, 265);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(246, 115);
            this.btnFastFood.TabIndex = 0;
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnSalata
            // 
            this.btnSalata.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_22;
            this.btnSalata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalata.Location = new System.Drawing.Point(258, 144);
            this.btnSalata.Name = "btnSalata";
            this.btnSalata.Size = new System.Drawing.Size(246, 115);
            this.btnSalata.TabIndex = 0;
            this.btnSalata.UseVisualStyleBackColor = true;
            this.btnSalata.Click += new System.EventHandler(this.btnSalata_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_21;
            this.btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatlilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatlilar.Location = new System.Drawing.Point(6, 144);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(246, 115);
            this.btnTatlilar.TabIndex = 0;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_20;
            this.btnIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcecekler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIcecekler.Location = new System.Drawing.Point(258, 23);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(246, 115);
            this.btnIcecekler.TabIndex = 0;
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_19;
            this.btnAnaYemek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaYemek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaYemek.Location = new System.Drawing.Point(6, 23);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(246, 115);
            this.btnAnaYemek.TabIndex = 0;
            this.btnAnaYemek.UseVisualStyleBackColor = true;
            this.btnAnaYemek.Click += new System.EventHandler(this.btnAnaYemek_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_14;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(134, 823);
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
            this.btnCikis.Location = new System.Drawing.Point(38, 823);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 83);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.dark_grey_windows_8_background_by_gifteddeviant_d4yvcut_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 945);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnZraporu);
            this.Controls.Add(this.gbIstatistik);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMenu.ResumeLayout(false);
            this.gbIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnAraSicak;
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.Button btnCorba;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnSalata;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnAnaYemek;
        private System.Windows.Forms.GroupBox gbIstatistik;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnZraporu;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
    }
}