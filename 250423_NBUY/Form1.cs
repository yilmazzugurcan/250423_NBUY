using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _250423_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {

            
            //server=localhost veya . konulursa pcdeki servera baglanır.
            baglanti.ConnectionString = "Server=localhost;Database=Northwind;User=sa;Pwd=123";
            SqlCommand cmd = new SqlCommand();
            //yeni bir command nesnesi oluşturuluyor. içerisine işlem yazılacağı için
            cmd.CommandText = "Select * from Urunler";
            cmd.Connection = baglanti;
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string adi = reader["UrunAdi"].ToString();
                string fiyat = reader["BirimFiyati"].ToString();
                string stok = reader["HedefStokDuzeyi"].ToString();
                LstUrunler.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyat, stok));

            }
            baglanti.Close();
            KategoriListele();
            TedarikciListele();
        }
        private void KategoriListele()
        {
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string KategoriID = reader["KategoriID"].ToString();
                string KategoriAdi = reader["KategoriAdi"].ToString();
                string tanimi = reader["Tanimi"].ToString();
                LstKategori.Items.Add(string.Format("{0}-{1}-{2}", KategoriID, KategoriAdi, tanimi));
            }
            baglanti.Close();
        }
        private void TedarikciListele()
        {
            SqlCommand cmd = new SqlCommand("Select * from Tedarikciler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string TedarikciID = reader["TedarikciID"].ToString();
                string SirketAdi = reader["SirketAdi"].ToString();
                string Sehir = reader["Sehir"].ToString();
                LstTedarikci.Items.Add(string.Format("{0}-{1}-{2}", TedarikciID, SirketAdi, Sehir));
            }
            baglanti.Close();
        }
    }
}
