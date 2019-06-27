namespace AracKiralama.UI
{
    partial class frmAnaSayfa
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.dtpAlinacak = new System.Windows.Forms.DateTimePicker();
            this.dtpTeslimedilecek = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pcBoxArabalar = new System.Windows.Forms.PictureBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblModelYili = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArabalar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 17);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(208, 17);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre :";
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(395, 16);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(75, 23);
            this.btnKaydol.TabIndex = 3;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(314, 16);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(12, 10);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(139, 20);
            this.lblBilgi.TabIndex = 4;
            this.lblBilgi.Text = "ERP Rent A Car";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnKaydol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKirala);
            this.groupBox2.Controls.Add(this.lblKm);
            this.groupBox2.Controls.Add(this.lblModelYili);
            this.groupBox2.Controls.Add(this.lblModel);
            this.groupBox2.Controls.Add(this.dtpTeslimedilecek);
            this.groupBox2.Controls.Add(this.dtpAlinacak);
            this.groupBox2.Controls.Add(this.lblFiyat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblToplamFiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbArac);
            this.groupBox2.Controls.Add(this.cmbSinif);
            this.groupBox2.Location = new System.Drawing.Point(416, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 416);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(32, 42);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(154, 21);
            this.cmbSinif.TabIndex = 0;
            this.cmbSinif.Text = "Seçiniz";
            this.cmbSinif.SelectedIndexChanged += new System.EventHandler(this.cmbSinif_SelectedIndexChanged);
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(214, 42);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(190, 21);
            this.cmbArac.TabIndex = 0;
            this.cmbArac.Text = "Seçiniz";
            this.cmbArac.SelectedIndexChanged += new System.EventHandler(this.cmbArac_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sınıf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Araç";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(148, 20);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat : ";
            // 
            // dtpAlinacak
            // 
            this.dtpAlinacak.Location = new System.Drawing.Point(32, 154);
            this.dtpAlinacak.Name = "dtpAlinacak";
            this.dtpAlinacak.Size = new System.Drawing.Size(154, 20);
            this.dtpAlinacak.TabIndex = 3;
            this.dtpAlinacak.ValueChanged += new System.EventHandler(this.dtpAlinacak_ValueChanged);
            // 
            // dtpTeslimedilecek
            // 
            this.dtpTeslimedilecek.Location = new System.Drawing.Point(214, 154);
            this.dtpTeslimedilecek.Name = "dtpTeslimedilecek";
            this.dtpTeslimedilecek.Size = new System.Drawing.Size(190, 20);
            this.dtpTeslimedilecek.TabIndex = 3;
            this.dtpTeslimedilecek.ValueChanged += new System.EventHandler(this.dtpTeslimedilecek_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alınacak Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teslim Edilecek Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Fiyat";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(209, 209);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(19, 25);
            this.lblToplamFiyat.TabIndex = 1;
            this.lblToplamFiyat.Text = ".";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(476, 15);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pcBoxArabalar
            // 
            this.pcBoxArabalar.Location = new System.Drawing.Point(30, 87);
            this.pcBoxArabalar.Name = "pcBoxArabalar";
            this.pcBoxArabalar.Size = new System.Drawing.Size(366, 354);
            this.pcBoxArabalar.TabIndex = 7;
            this.pcBoxArabalar.TabStop = false;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(38, 89);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model : ";
            // 
            // lblModelYili
            // 
            this.lblModelYili.AutoSize = true;
            this.lblModelYili.Location = new System.Drawing.Point(157, 89);
            this.lblModelYili.Name = "lblModelYili";
            this.lblModelYili.Size = new System.Drawing.Size(24, 13);
            this.lblModelYili.TabIndex = 4;
            this.lblModelYili.Text = "Yıl :";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(211, 89);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(31, 13);
            this.lblKm.TabIndex = 4;
            this.lblKm.Text = "Km : ";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(79, 280);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(223, 77);
            this.btnKirala.TabIndex = 5;
            this.btnKirala.Text = "KİRALA";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.pcBoxArabalar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBilgi);
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArabalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.DateTimePicker dtpTeslimedilecek;
        private System.Windows.Forms.DateTimePicker dtpAlinacak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pcBoxArabalar;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblModelYili;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnKirala;
    }
}