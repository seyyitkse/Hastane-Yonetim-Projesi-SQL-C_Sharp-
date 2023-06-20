namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    partial class HastaKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            this.MskHastaTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHastaSifre = new System.Windows.Forms.TextBox();
            this.TxtHastaTC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHastaEkran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHastaSoyad = new System.Windows.Forms.TextBox();
            this.TxtHastaAd = new System.Windows.Forms.TextBox();
            this.RadioKadin = new System.Windows.Forms.RadioButton();
            this.RadioErkek = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.BtnAnaSayfa);
            this.groupBox1.Controls.Add(this.RadioKadin);
            this.groupBox1.Controls.Add(this.RadioErkek);
            this.groupBox1.Controls.Add(this.MskHastaTel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtHastaSifre);
            this.groupBox1.Controls.Add(this.TxtHastaTC);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnKaydol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnHastaEkran);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtHastaSoyad);
            this.groupBox1.Controls.Add(this.TxtHastaAd);
            this.groupBox1.Location = new System.Drawing.Point(-23, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 478);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.Location = new System.Drawing.Point(220, 425);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(137, 32);
            this.BtnAnaSayfa.TabIndex = 10;
            this.BtnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.BtnAnaSayfa.UseVisualStyleBackColor = true;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // MskHastaTel
            // 
            this.MskHastaTel.Location = new System.Drawing.Point(221, 294);
            this.MskHastaTel.Mask = "(999) 000-0000";
            this.MskHastaTel.Name = "MskHastaTel";
            this.MskHastaTel.Size = new System.Drawing.Size(136, 24);
            this.MskHastaTel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cinsiyetiniz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Şifreniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon Numaranız:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "TC Kimlik Numaranız:";
            // 
            // TxtHastaSifre
            // 
            this.TxtHastaSifre.Location = new System.Drawing.Point(220, 324);
            this.TxtHastaSifre.MaxLength = 10;
            this.TxtHastaSifre.Name = "TxtHastaSifre";
            this.TxtHastaSifre.Size = new System.Drawing.Size(137, 24);
            this.TxtHastaSifre.TabIndex = 7;
            // 
            // TxtHastaTC
            // 
            this.TxtHastaTC.Location = new System.Drawing.Point(220, 232);
            this.TxtHastaTC.MaxLength = 11;
            this.TxtHastaTC.Name = "TxtHastaTC";
            this.TxtHastaTC.Size = new System.Drawing.Size(137, 24);
            this.TxtHastaTC.TabIndex = 3;
            this.TxtHastaTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaTC_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(197, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 52525;
            this.label4.Text = "Acil Şifalar Dileriz...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(180, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 42);
            this.label3.TabIndex = 5252;
            this.label3.Text = "Hasta Kayıt";
            // 
            // BtnKaydol
            // 
            this.BtnKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydol.Location = new System.Drawing.Point(241, 354);
            this.BtnKaydol.Name = "BtnKaydol";
            this.BtnKaydol.Size = new System.Drawing.Size(91, 27);
            this.BtnKaydol.TabIndex = 8;
            this.BtnKaydol.Text = "Kaydol";
            this.BtnKaydol.UseVisualStyleBackColor = true;
            this.BtnKaydol.Click += new System.EventHandler(this.BtnKaydol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadınız:";
            // 
            // BtnHastaEkran
            // 
            this.BtnHastaEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaEkran.Location = new System.Drawing.Point(178, 387);
            this.BtnHastaEkran.Name = "BtnHastaEkran";
            this.BtnHastaEkran.Size = new System.Drawing.Size(222, 32);
            this.BtnHastaEkran.TabIndex = 9;
            this.BtnHastaEkran.Text = "Hasta Giriş Ekranına Dön";
            this.BtnHastaEkran.UseVisualStyleBackColor = true;
            this.BtnHastaEkran.Click += new System.EventHandler(this.BtnHastaEkran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adınız:";
            // 
            // TxtHastaSoyad
            // 
            this.TxtHastaSoyad.Location = new System.Drawing.Point(220, 200);
            this.TxtHastaSoyad.MaxLength = 10;
            this.TxtHastaSoyad.Name = "TxtHastaSoyad";
            this.TxtHastaSoyad.Size = new System.Drawing.Size(137, 24);
            this.TxtHastaSoyad.TabIndex = 2;
            this.TxtHastaSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaSoyad_KeyPress);
            // 
            // TxtHastaAd
            // 
            this.TxtHastaAd.Location = new System.Drawing.Point(220, 170);
            this.TxtHastaAd.MaxLength = 10;
            this.TxtHastaAd.Name = "TxtHastaAd";
            this.TxtHastaAd.Size = new System.Drawing.Size(137, 24);
            this.TxtHastaAd.TabIndex = 1;
            this.TxtHastaAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaAd_KeyPress);
            // 
            // RadioKadin
            // 
            this.RadioKadin.AutoSize = true;
            this.RadioKadin.Location = new System.Drawing.Point(294, 263);
            this.RadioKadin.Name = "RadioKadin";
            this.RadioKadin.Size = new System.Drawing.Size(63, 22);
            this.RadioKadin.TabIndex = 5;
            this.RadioKadin.TabStop = true;
            this.RadioKadin.Text = "Kadın";
            this.RadioKadin.UseVisualStyleBackColor = true;
            // 
            // RadioErkek
            // 
            this.RadioErkek.AutoSize = true;
            this.RadioErkek.Location = new System.Drawing.Point(220, 263);
            this.RadioErkek.Name = "RadioErkek";
            this.RadioErkek.Size = new System.Drawing.Size(65, 22);
            this.RadioErkek.TabIndex = 4;
            this.RadioErkek.TabStop = true;
            this.RadioErkek.Text = "Erkek";
            this.RadioErkek.UseVisualStyleBackColor = true;
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 467);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HastaKayitForm";
            this.Text = "HastaKayitForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnHastaEkran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHastaSoyad;
        private System.Windows.Forms.TextBox TxtHastaAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtHastaSifre;
        private System.Windows.Forms.TextBox TxtHastaTC;
        private System.Windows.Forms.Button BtnAnaSayfa;
        private System.Windows.Forms.MaskedTextBox MskHastaTel;
        private System.Windows.Forms.RadioButton RadioKadin;
        private System.Windows.Forms.RadioButton RadioErkek;
    }
}