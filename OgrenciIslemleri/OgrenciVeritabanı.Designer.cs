namespace OgrenciIslemleri
{
	partial class OgrenciVeritabanı
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnDetay = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAra = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnYeniOgrenci = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtRehberOgretmen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSinifOgretmeni = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHobi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBolum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAdSoyad = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSil);
			this.panel1.Controls.Add(this.btnDetay);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnAra);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.txtAra);
			this.panel1.Controls.Add(this.Label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(614, 359);
			this.panel1.TabIndex = 0;
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(554, 177);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(45, 23);
			this.btnSil.TabIndex = 15;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnDetay
			// 
			this.btnDetay.Location = new System.Drawing.Point(554, 148);
			this.btnDetay.Name = "btnDetay";
			this.btnDetay.Size = new System.Drawing.Size(45, 23);
			this.btnDetay.TabIndex = 14;
			this.btnDetay.Text = "Detay";
			this.btnDetay.UseVisualStyleBackColor = true;
			this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(563, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "İşlem";
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(134, 17);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(75, 23);
			this.btnAra.TabIndex = 12;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(544, 257);
			this.dataGridView1.TabIndex = 4;
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(17, 19);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(100, 20);
			this.txtAra.TabIndex = 1;
			this.txtAra.Text = "Ara...";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(3, 3);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(29, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Filtre";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.txtID);
			this.panel2.Controls.Add(this.btnYeniOgrenci);
			this.panel2.Controls.Add(this.btnKaydet);
			this.panel2.Controls.Add(this.txtRehberOgretmen);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtSinifOgretmeni);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtHobi);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBolum);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtAdSoyad);
			this.panel2.Location = new System.Drawing.Point(635, 15);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(245, 386);
			this.panel2.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "ID";
			this.label8.Visible = false;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(12, 48);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(96, 20);
			this.txtID.TabIndex = 12;
			this.txtID.Visible = false;
			// 
			// btnYeniOgrenci
			// 
			this.btnYeniOgrenci.Location = new System.Drawing.Point(148, 17);
			this.btnYeniOgrenci.Name = "btnYeniOgrenci";
			this.btnYeniOgrenci.Size = new System.Drawing.Size(84, 23);
			this.btnYeniOgrenci.TabIndex = 11;
			this.btnYeniOgrenci.Text = "Yeni Öğrenci";
			this.btnYeniOgrenci.UseVisualStyleBackColor = true;
			this.btnYeniOgrenci.Click += new System.EventHandler(this.btnYeniOgrenci_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(86, 349);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 10;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtRehberOgretmen
			// 
			this.txtRehberOgretmen.Location = new System.Drawing.Point(12, 315);
			this.txtRehberOgretmen.Name = "txtRehberOgretmen";
			this.txtRehberOgretmen.Size = new System.Drawing.Size(220, 20);
			this.txtRehberOgretmen.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 293);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Rehber Öğretmen";
			// 
			// txtSinifOgretmeni
			// 
			this.txtSinifOgretmeni.Location = new System.Drawing.Point(12, 260);
			this.txtSinifOgretmeni.Name = "txtSinifOgretmeni";
			this.txtSinifOgretmeni.Size = new System.Drawing.Size(220, 20);
			this.txtSinifOgretmeni.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Sınıf Öğretmeni";
			// 
			// txtHobi
			// 
			this.txtHobi.Location = new System.Drawing.Point(12, 209);
			this.txtHobi.Name = "txtHobi";
			this.txtHobi.Size = new System.Drawing.Size(220, 20);
			this.txtHobi.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Hobi";
			// 
			// txtBolum
			// 
			this.txtBolum.Location = new System.Drawing.Point(12, 152);
			this.txtBolum.Name = "txtBolum";
			this.txtBolum.Size = new System.Drawing.Size(220, 20);
			this.txtBolum.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Bölüm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ad Soyad";
			// 
			// txtAdSoyad
			// 
			this.txtAdSoyad.Location = new System.Drawing.Point(12, 100);
			this.txtAdSoyad.Name = "txtAdSoyad";
			this.txtAdSoyad.Size = new System.Drawing.Size(220, 20);
			this.txtAdSoyad.TabIndex = 0;
			// 
			// OgrenciVeritabanı
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 458);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "OgrenciVeritabanı";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Öğrenci Listesi";
			this.Load += new System.EventHandler(this.OgrenciVeritabanı_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtAra;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAdSoyad;
		private System.Windows.Forms.TextBox txtSinifOgretmeni;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtHobi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBolum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRehberOgretmen;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnYeniOgrenci;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnDetay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label8;
	}
}

