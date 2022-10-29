using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TelefonRehberi
{

    class Class1         // sınıf oluşturduk
    {
        private SqlConnection baglanti;
        public static SqlConnection baglan()       //sınıfa ait alt bir fonksiyon oluşturduk. Bunu fonk. içinde veri tabanına bağlantısı yapıcaz.
        {
            SqlConnection baglanti = new SqlConnection();   // veri tabanına bağlanmak için kullanılır.
            baglanti.ConnectionString = ("Data Source=DESKTOP-SLDHV1K ;Initial Catalog= REHBER;  Integrated Security = True ");  //Burada bağlantının yapılabilmesi için
         //gerekli olan,hangi ana makine’ye bağlantı yapılacağını, o ana makinedeki hangi veritabanına bağlanacağımızı, o veritabanına bağlanmak için gerekli olan
         //kullanıcı adı ve şifresi gibi bilgilerin bulunduğu koddur.
            return baglanti;
        }

        public static DataTable dtdoldur(string SqlSorgusu)   // Bu fonk. oluşturma amacımız veri tabanındakş tablodan çektiğimiz bilgileri form kısmında oluşturduğumuz
           // telefon rehber tablosunu doldurmak için kullandım.
        {


            SqlConnection baglanti = baglan();            //yukarıda veri tabanına bağlanmıştık baglan fonk ile bilgileri alalım.
            baglanti.Open();                              // bağlantı açtık.
            SqlDataAdapter sda = new SqlDataAdapter(SqlSorgusu, baglanti); // Burada veri tabanına bağlantı kurulduktan sonra yazılan SQL cümlesini çalıştırıp,
            // dönecek olan sonuç kümesini; bu sonuçları bellekte tutulacak olan nesnelere yükleme işlemini yaptım.
            DataTable dt = new DataTable();  // verilerin tutulması için veri tablosu oluşturuldu.
            sda.Fill(dt);  // gelen verileri datatable ekler ve yeniler.
            baglanti.Close(); // bağlantı kapattık.
            return dt;  // yenileme olacağı için döndürme işlemi yapılır.
        }
    }
}
