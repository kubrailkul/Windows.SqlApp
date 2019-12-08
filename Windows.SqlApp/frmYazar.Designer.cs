namespace Windows.SqlApp
{
    partial class frmYazar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.dtYazarOlumTarih = new System.Windows.Forms.DateTimePicker();
            this.dtYazarDtar = new System.Windows.Forms.DateTimePicker();
            this.chckyasiyor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yazar Ölüm Tarihi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(150, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(125, 34);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(100, 20);
            this.txtYazarAd.TabIndex = 9;
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(125, 73);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtYazarSoyad.TabIndex = 10;
            // 
            // dtYazarOlumTarih
            // 
            this.dtYazarOlumTarih.Location = new System.Drawing.Point(128, 162);
            this.dtYazarOlumTarih.Name = "dtYazarOlumTarih";
            this.dtYazarOlumTarih.Size = new System.Drawing.Size(135, 20);
            this.dtYazarOlumTarih.TabIndex = 14;
            // 
            // dtYazarDtar
            // 
            this.dtYazarDtar.Location = new System.Drawing.Point(128, 118);
            this.dtYazarDtar.Name = "dtYazarDtar";
            this.dtYazarDtar.Size = new System.Drawing.Size(135, 20);
            this.dtYazarDtar.TabIndex = 15;
            // 
            // chckyasiyor
            // 
            this.chckyasiyor.AutoSize = true;
            this.chckyasiyor.Location = new System.Drawing.Point(269, 165);
            this.chckyasiyor.Name = "chckyasiyor";
            this.chckyasiyor.Size = new System.Drawing.Size(60, 17);
            this.chckyasiyor.TabIndex = 16;
            this.chckyasiyor.Text = "Yaşıyor";
            this.chckyasiyor.UseVisualStyleBackColor = true;
            this.chckyasiyor.CheckedChanged += new System.EventHandler(this.Chckyasiyor_CheckedChanged);
            // 
            // frmYazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.chckyasiyor);
            this.Controls.Add(this.dtYazarDtar);
            this.Controls.Add(this.dtYazarOlumTarih);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmYazar";
            this.Text = "frmYazar";
            this.Load += new System.EventHandler(this.frmYazar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.DateTimePicker dtYazarOlumTarih;
        private System.Windows.Forms.DateTimePicker dtYazarDtar;
        private System.Windows.Forms.CheckBox chckyasiyor;
    }
}