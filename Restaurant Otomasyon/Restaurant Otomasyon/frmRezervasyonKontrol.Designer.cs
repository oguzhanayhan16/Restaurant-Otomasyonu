namespace Restaurant_Otomasyon
{
    partial class frmRezervasyonKontrol
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
            this.lvRezervasyon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAdSil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriSoyadiSil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarihSil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRezerveSil = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvRezervasyon
            // 
            this.lvRezervasyon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvRezervasyon.FullRowSelect = true;
            this.lvRezervasyon.GridLines = true;
            this.lvRezervasyon.HideSelection = false;
            this.lvRezervasyon.LabelWrap = false;
            this.lvRezervasyon.Location = new System.Drawing.Point(12, 86);
            this.lvRezervasyon.Name = "lvRezervasyon";
            this.lvRezervasyon.Size = new System.Drawing.Size(882, 620);
            this.lvRezervasyon.TabIndex = 0;
            this.lvRezervasyon.UseCompatibleStateImageBehavior = false;
            this.lvRezervasyon.View = System.Windows.Forms.View.Details;
            this.lvRezervasyon.SelectedIndexChanged += new System.EventHandler(this.lvRezervasyon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MüsteriID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MasaID";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "AdisyonID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müşteri Adı";
            this.columnHeader4.Width = 202;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri Soyad";
            this.columnHeader5.Width = 203;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 198;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Masa Durumu";
            this.columnHeader7.Width = 271;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_14;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(108, 745);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(90, 83);
            this.btnGeriDon.TabIndex = 10;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_15;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(12, 745);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 83);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.Screenshot_39;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(905, 337);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(378, 141);
            this.btnSil.TabIndex = 15;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Müşteri Adı:";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(158, 37);
            this.txtMusteriAd.Multiline = true;
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(184, 29);
            this.txtMusteriAd.TabIndex = 17;
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(931, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Müşteri Adı:  ";
            // 
            // txtMusteriAdSil
            // 
            this.txtMusteriAdSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdSil.Location = new System.Drawing.Point(1078, 131);
            this.txtMusteriAdSil.Multiline = true;
            this.txtMusteriAdSil.Name = "txtMusteriAdSil";
            this.txtMusteriAdSil.ReadOnly = true;
            this.txtMusteriAdSil.Size = new System.Drawing.Size(205, 29);
            this.txtMusteriAdSil.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(900, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Müşteri Soyad:";
            // 
            // txtMusteriSoyadiSil
            // 
            this.txtMusteriSoyadiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyadiSil.Location = new System.Drawing.Point(1078, 188);
            this.txtMusteriSoyadiSil.Multiline = true;
            this.txtMusteriSoyadiSil.Name = "txtMusteriSoyadiSil";
            this.txtMusteriSoyadiSil.ReadOnly = true;
            this.txtMusteriSoyadiSil.Size = new System.Drawing.Size(205, 29);
            this.txtMusteriSoyadiSil.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(997, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tarih:";
            // 
            // txtTarihSil
            // 
            this.txtTarihSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarihSil.Location = new System.Drawing.Point(1078, 237);
            this.txtTarihSil.Multiline = true;
            this.txtTarihSil.Name = "txtTarihSil";
            this.txtTarihSil.ReadOnly = true;
            this.txtTarihSil.Size = new System.Drawing.Size(205, 29);
            this.txtTarihSil.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(905, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Masa Durumu:";
            // 
            // txtRezerveSil
            // 
            this.txtRezerveSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRezerveSil.Location = new System.Drawing.Point(1078, 284);
            this.txtRezerveSil.Multiline = true;
            this.txtRezerveSil.Name = "txtRezerveSil";
            this.txtRezerveSil.ReadOnly = true;
            this.txtRezerveSil.Size = new System.Drawing.Size(205, 29);
            this.txtRezerveSil.TabIndex = 25;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(1289, 131);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(35, 29);
            this.txtMusteriID.TabIndex = 26;
            this.txtMusteriID.Visible = false;
            // 
            // frmRezervasyonKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Otomasyon.Properties.Resources.dark_grey_windows_8_background_by_gifteddeviant_d4yvcut_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1398, 840);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.txtRezerveSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarihSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMusteriSoyadiSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriAdSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lvRezervasyon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyonKontrol";
            this.Text = "frmRezervasyonKontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezervasyonKontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRezervasyon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriSoyadiSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarihSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRezerveSil;
        private System.Windows.Forms.TextBox txtMusteriID;
    }
}