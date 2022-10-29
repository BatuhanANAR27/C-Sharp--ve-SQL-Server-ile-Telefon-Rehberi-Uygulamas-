using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TelefonRehberi
{
    public partial class Kullanıcı : Form
    {
       

        private SqlConnection baglanti;
        public Kullanıcı()
        {
            InitializeComponent();
            SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-SLDHV1K ;Initial Catalog= REHBER;  Integrated Security = True "); 
            // sql deki database e bağlanmak için kullanırız.

        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        //public object Form1 { get; private set; }

        private void GirisiButton_Click(object sender, EventArgs e)
        {
            string KullanıcıAdı = KullanıcıTextBox.Text; // kullanıcı Adı ve şifrenin string olarak atıyoruz.
            string Sifre = SifreTextBox.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-SLDHV1K ;Initial Catalog= REHBER;  Integrated Security = True "); //sql ile bağlantı yaptık.
            cmd = new SqlCommand(); // veri tabanı üzerinde işlem yapacağımızı belirtir
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM KullanıcıGiris where KullanıcıAdı='" + KullanıcıTextBox.Text + "' AND Sifre='" + SifreTextBox.Text + "'";
            // veri tabanından bilgileri alır.
            baglanti.Open(); // veri tabanı açma
            dr = cmd.ExecuteReader(); //SqlCommand’da yazılan sorguları çalıştırınca sorgunun dönen değerlerini okumaya yarayan ve kullanmamıza yarar.
            if (dr.Read()) // eğer dönen değerleri okuduğuunda
            {    // kullanıcı adı ve şifre doğru ise bağlantı yapıldı.
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                formTel formTel = new formTel(); // bağlantı doğru olunca telefon rehberini çalıştırmak için form1 ile bağlantı sağlamak için kullanırız.
                formTel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz."); // bilgiler yanlış ise bunları yaz.
            }
          
            baglanti.Close();   // bağlantı kapat.
        }

        
    }
}
