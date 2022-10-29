using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelefonRehberi
{
    public partial class formTel : Form   // formTel yani bizim telefon rehberindeki işlemleri yapmak için sınıf oluşturduk.
    {
        SqlConnection baglanti = Class1.baglan();  // class1 de oluşturduğumuz veri tabanına bağlanmak için kullandım.
        public formTel()
        {
            InitializeComponent();
        }
        
        SqlCommand cmd;
      
        void KisiGetir()       // veri tabanındaki sınıfmızdaki verileri almak için kisi getir nesnesi oluşturduk.
        {

            baglanti.Open();    // veri tabanını açtık.
            dataGrivKisiler.DataSource = Class1.dtdoldur("select * from TelefonRehberi"); // form1 de oluşturduğumuz dataGriv tablosuna verileri girmek için 
            // veri tabanında verileri aldık.doldurduk.
            baglanti.Close();  // işimiz bittiği için veri tabanı kapattık.
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiGetir();
            //this.telefonRehberiTableAdapter1.Fill(this.rEHBERDataSet1.TelefonRehberi);
            //  Bu kod satırı rEHBERDataSet1.TelefonRehberi tablosuna veri yüklemek için kullandım.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGrivKisiler.DataSource = Class1.dtdoldur("select * from TelefonRehberi where Ad like '%" + textAra.Text + "%'");
            // Bu kodu dataGriv deki telefon rehberimdeki kişileri arama kısmına baş harflerini, isimlerini girince filtrelemesi bulması için kullandım.
        }

        private void güncellebutonu_Click(object sender, EventArgs e) // güncelle butonu için nesne oluşturdum.
        {
            try
            {
                string sorgu = "update TelefonRehberi Set ad=@Ad, soyad=@Soyad,kayıttürü=@KayıtTürü, telefontürü=@TelefonTürü, telefon=@Telefon, cinsiyet=@Cinsiyet Where ID=@ID";
                // yukarıdaki kod kişinin bilgilerini ıd numarasına göre güncellemsi için kullandım.
                cmd = new SqlCommand(sorgu, baglanti);  // yukarıda yapmış olduğumuz güncelleme komutunu çalıştırıyoruz.
                cmd.Parameters.AddWithValue("@Ad", textAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", textSoyad.Text);
                cmd.Parameters.AddWithValue("@KayıtTürü", textKayıt.Text); // tüm bu kodlar textlere girdiğimiz güncelleyeceğimiz kişilerin bilgilerini textlere eklemek için kullanılır. 
                cmd.Parameters.AddWithValue("@TelefonTürü", textTelTür.Text);
                cmd.Parameters.AddWithValue("@Telefon", textTelefon.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", textCinsiyet.Text);
                cmd.Parameters.AddWithValue("@ID", dataGrivKisiler.CurrentRow.Cells[0].Value);
                baglanti.Open();
                cmd.ExecuteNonQuery(); //Bu kod geriye int olarak update, insert, delete olaylarından etkilenen satır sayısı döndürüyor.
                baglanti.Close();
                MessageBox.Show("Kişi Bilgileri Başarıyla Güncellenmiştir...");
                KisiGetir();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Güncelleme Yapılamadı");
            }
        }

        private void kaydetbutonu_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into TelefonRehberi (Ad,Soyad,KayıtTürü,TelefonTürü,Telefon,Cinsiyet) values (@Ad,@Soyad,@KayıtTürü,@TelefonTürü, @Telefon,@Cinsiyet)";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Ad", textAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", textSoyad.Text);
            cmd.Parameters.AddWithValue("@KayıtTürü", textKayıt.Text);
            cmd.Parameters.AddWithValue("@TelefonTürü", textTelTür.Text);
            cmd.Parameters.AddWithValue("@Telefon", textTelefon.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", textCinsiyet.Text);
           // cmd.Parameters.AddWithValue("@ID", dataGrivKisiler.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Bilgileri Başarıyla Kaydedildi...");
            KisiGetir();
        }

        private void silbutonu_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE TelefonRehberi Where ID=@ID";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@ID", dataGrivKisiler.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Bilgileri Başarıyla Silindi...");
            KisiGetir();
        }


        private void dataGrivKisiler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGrivKisiler.CurrentRow;
            textId.Text = satır.Cells[0].Value.ToString();
            textAd.Text = satır.Cells[1].Value.ToString();
            textSoyad.Text = satır.Cells[2].Value.ToString();
            textKayıt.Text = satır.Cells[3].Value.ToString();
            textTelTür.Text = satır.Cells[4].Value.ToString();
            textTelefon.Text = satır.Cells[5].Value.ToString();
            textCinsiyet.Text = satır.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
