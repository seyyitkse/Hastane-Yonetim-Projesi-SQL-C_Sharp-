namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    partial class HastaGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisForm));
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            this.LinkLblYeniHasta = new System.Windows.Forms.LinkLabel();
            this.TxtHastaTC = new System.Windows.Forms.TextBox();
            this.TxtHastaSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(240, 201);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(92, 33);
            this.BtnGiris.TabIndex = 0;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.Location = new System.Drawing.Point(204, 310);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(164, 32);
            this.BtnAnaSayfa.TabIndex = 1;
            this.BtnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.BtnAnaSayfa.UseVisualStyleBackColor = true;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // LinkLblYeniHasta
            // 
            this.LinkLblYeniHasta.AutoSize = true;
            this.LinkLblYeniHasta.Location = new System.Drawing.Point(273, 275);
            this.LinkLblYeniHasta.Name = "LinkLblYeniHasta";
            this.LinkLblYeniHasta.Size = new System.Drawing.Size(132, 18);
            this.LinkLblYeniHasta.TabIndex = 2;
            this.LinkLblYeniHasta.TabStop = true;
            this.LinkLblYeniHasta.Text = "Yeni Üyelik Oluştur";
            this.LinkLblYeniHasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblYeniHasta_LinkClicked);
            // 
            // TxtHastaTC
            // 
            this.TxtHastaTC.Location = new System.Drawing.Point(202, 144);
            this.TxtHastaTC.MaxLength = 11;
            this.TxtHastaTC.Name = "TxtHastaTC";
            this.TxtHastaTC.Size = new System.Drawing.Size(166, 24);
            this.TxtHastaTC.TabIndex = 3;
            this.TxtHastaTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaTC_KeyPress);
            // 
            // TxtHastaSifre
            // 
            this.TxtHastaSifre.Location = new System.Drawing.Point(202, 174);
            this.TxtHastaSifre.MaxLength = 10;
            this.TxtHastaSifre.Name = "TxtHastaSifre";
            this.TxtHastaSifre.Size = new System.Drawing.Size(166, 24);
            this.TxtHastaSifre.TabIndex = 4;
            this.TxtHastaSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC Kimlik Numaranız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifreniz:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnAnaSayfa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LinkLblYeniHasta);
            this.groupBox1.Controls.Add(this.TxtHastaSifre);
            this.groupBox1.Controls.Add(this.TxtHastaTC);
            this.groupBox1.Location = new System.Drawing.Point(-4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 365);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Üyeliğin yok mu ?";
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
            this.label4.Location = new System.Drawing.Point(179, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acil Şifalar Dileriz...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Girişi";
            // 
            // HastaGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 362);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HastaGirisForm";
            this.Text = "Hasta Girişi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnAnaSayfa;
        private System.Windows.Forms.LinkLabel LinkLblYeniHasta;
        private System.Windows.Forms.TextBox TxtHastaTC;
        private System.Windows.Forms.TextBox TxtHastaSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}