using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciIslemleri
{
	public partial class OgrenciVeritabanı : Form
	{
		public OgrenciVeritabanı()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7R5E71O\\SQLEXPRESS;Initial Catalog=YuceDb;Integrated Security=True");

		void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from Ogrencis ", baglanti);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			
		}

		void Temizle()
		{
			txtID.Text = string.Empty;
			txtAdSoyad.Text = string.Empty;
			txtBolum.Text = string.Empty;
			txtHobi.Text = string.Empty;
			txtSinifOgretmeni.Text = string.Empty;
			txtRehberOgretmen.Text = string.Empty;
		}
		private void OgrenciVeritabanı_Load(object sender, EventArgs e)
		{
			Listele();
		}
		private void btnYeniOgrenci_Click(object sender, EventArgs e)
		{
			
			baglanti.Open();
			SqlCommand ogrenci = new SqlCommand("Insert into Ogrencis(AdSoyad,Bolum,Hobi,SinifOgretmeni,RehberOgretmeni) values ('" + txtAdSoyad.Text + "','" + txtBolum.Text + "','" + txtHobi.Text + "','" + txtSinifOgretmeni.Text + "','" + txtRehberOgretmen.Text + "')", baglanti);
			ogrenci.ExecuteNonQuery();
			baglanti.Close();

			MessageBox.Show("Kayıt Eklendi.");
			Listele();
			Temizle();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();

			SqlCommand ogrenci = new SqlCommand("Update Ogrencis Set AdSoyad = '" + txtAdSoyad.Text + "',Bolum = '" + txtBolum.Text + "',Hobi = '" + txtHobi.Text + "',SinifOgretmeni = '" + txtSinifOgretmeni.Text + "',RehberOgretmeni = '" + txtRehberOgretmen.Text + "' Where OgrenciID ='" + txtID.Text + "' ", baglanti);
			ogrenci.ExecuteNonQuery();
			baglanti.Close();

			MessageBox.Show("Kayıt Güncellendi.");
			Listele();
			Temizle();
		}


		private void btnDetay_Click(object sender, EventArgs e)
		{
			txtID.Text = dataGridView1.CurrentRow.Cells["OgrenciID"].Value.ToString();
			txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
			txtBolum.Text = dataGridView1.CurrentRow.Cells["Bolum"].Value.ToString();
			txtHobi.Text = dataGridView1.CurrentRow.Cells["Hobi"].Value.ToString();
			txtSinifOgretmeni.Text = dataGridView1.CurrentRow.Cells["SinifOgretmeni"].Value.ToString();
			txtRehberOgretmen.Text = dataGridView1.CurrentRow.Cells["RehberOgretmeni"].Value.ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kayıt Silinecek, Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				baglanti.Open();

				SqlCommand ogrenci = new SqlCommand("Delete from Ogrencis Where OgrenciID ='" + dataGridView1.CurrentRow.Cells["OgrenciID"].Value.ToString() + "' ", baglanti);
				ogrenci.ExecuteNonQuery();
				baglanti.Close();

				MessageBox.Show("Kayıt Silindi.");
				Listele();
				Temizle();
			}

		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from Ogrencis Where AdSoyad like '%" + txtAra.Text + "%' ", baglanti);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}


	}
}
