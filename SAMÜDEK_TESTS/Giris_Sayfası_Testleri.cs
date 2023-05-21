using System.Data.SqlClient;
namespace SAMÜDEK_TESTS
{
    public class Giris_Sayfası_Testleri
    {
        [Fact]
        public void Giriş_Kodu_Test()
        {
            string[] s1 = { "X", "Y", "Z", "Q", "V", "P", "T", "J", "G", "B", "P" };
            string[] s2 = { "#", "$", "s", "i", "y", "t", "s", "a", "k", "l", "m" };

            Random rnd = new Random();

            int sayi1 = rnd.Next(11);
            int sayi2 = rnd.Next(11);
            int sayi3 = rnd.Next(11);
            int sayi4 = rnd.Next(11);

            string guvenlikkodu = s1[sayi1] + s2[sayi2] + s1[sayi3] + s2[sayi4];

            Assert.Equal(4, guvenlikkodu.Length);
        }

        [Fact]
        public void Veritabanı_Test()
        {
            SqlConnection connection = new SqlConnection("Data Source=SADIK;Initial Catalog=Mudekuser;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("select userkulad,userpassord from tbl_mudek where userkulad=@p1 and userpassord=@p2", connection);
            command.Parameters.AddWithValue("@p1", "admin");
            command.Parameters.AddWithValue("@p2", "admin55");

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string giris = reader["userkulad"].ToString() + reader["userpassord"].ToString();
                Assert.Equal("adminadmin55", giris);
            }
            connection.Close();

            
        }
    }
}