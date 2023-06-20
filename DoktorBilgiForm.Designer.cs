namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    partial class DoktorBilgiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgiForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDoktorAd = new System.Windows.Forms.Label();
            this.LblDoktorTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchHasta = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBilgiDuzenle = new System.Windows.Forms.Button();
            this.BtnErisim = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BtnErisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDoktorAd);
            this.groupBox1.Controls.Add(this.LblDoktorTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblDoktorAd
            // 
            this.LblDoktorAd.AutoSize = true;
            this.LblDoktorAd.Location = new System.Drawing.Point(88, 68);
            this.LblDoktorAd.Name = "LblDoktorAd";
            this.LblDoktorAd.Size = new System.Drawing.Size(62, 18);
            this.LblDoktorAd.TabIndex = 4;
            this.LblDoktorAd.Text = "Null Null";
            // 
            // LblDoktorTc
            // 
            this.LblDoktorTc.AutoSize = true;
            this.LblDoktorTc.Location = new System.Drawing.Point(88, 32);
            this.LblDoktorTc.Name = "LblDoktorTc";
            this.LblDoktorTc.Size = new System.Drawing.Size(96, 18);
            this.LblDoktorTc.TabIndex = 3;
            this.LblDoktorTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchHasta);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay:";
            // 
            // RchHasta
            // 
            this.RchHasta.Location = new System.Drawing.Point(6, 23);
            this.RchHasta.Name = "RchHasta";
            this.RchHasta.Size = new System.Drawing.Size(248, 115);
            this.RchHasta.TabIndex = 0;
            this.RchHasta.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(277, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 444);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sizin Randevularınız";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(879, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(9, 23);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(104, 26);
            this.BtnBilgiDuzenle.TabIndex = 1;
            this.BtnBilgiDuzenle.Text = "Bilgi Düzenle";
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = true;
            this.BtnBilgiDuzenle.Click += new System.EventHandler(this.BtnBilgiDuzenle_Click);
            // 
            // BtnErisim
            // 
            this.BtnErisim.Controls.Add(this.BtnCikis);
            this.BtnErisim.Controls.Add(this.BtnDuyuru);
            this.BtnErisim.Controls.Add(this.BtnBilgiDuzenle);
            this.BtnErisim.Location = new System.Drawing.Point(12, 370);
            this.BtnErisim.Name = "BtnErisim";
            this.BtnErisim.Size = new System.Drawing.Size(260, 95);
            this.BtnErisim.TabIndex = 7;
            this.BtnErisim.TabStop = false;
            this.BtnErisim.Text = "Hızlı Erişim";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(26, 55);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(212, 26);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Location = new System.Drawing.Point(147, 23);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(107, 26);
            this.BtnDuyuru.TabIndex = 2;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // DoktorBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1196, 477);
            this.Controls.Add(this.BtnErisim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoktorBilgiForm";
            this.Text = "Doktor Bilgi";
            this.Load += new System.EventHandler(this.DoktorBilgiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BtnErisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDoktorAd;
        private System.Windows.Forms.Label LblDoktorTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RchHasta;
        private System.Windows.Forms.Button BtnBilgiDuzenle;
        private System.Windows.Forms.GroupBox BtnErisim;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnDuyuru;
    }
}