using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMÜDEK_TESTS
{
    public class Admin_İslemleri_Tests
    {
        SqlConnection connection = new SqlConnection("Data Source=SADIK;Initial Catalog=Mudekuser;Integrated Security=True");

        int Listele()
        {
            connection.Open();
            var command = @"Select * from tbl_mudek";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            da.Fill(dt);

            var veriSayisi = dt.Rows.Count;

            connection.Close();

            return veriSayisi;
        }

        [Fact]
        public void Listeleme_Test()
        {
            var veriSayisi = Listele();
            Assert.Equal(10, veriSayisi);
        }

        [Fact]
        public void Kayıt_Test()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_mudek (userad,usersoyad,userdurum,usermeslek,usermaas,usercinsiyet,usersehir,userkulad,userpassord) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection);
            command.Parameters.AddWithValue("@p1", "Murat");
            command.Parameters.AddWithValue("@p2", "Tıkaç");
            command.Parameters.AddWithValue("@p3", 1);
            command.Parameters.AddWithValue("@p4", "Arş. Görevlisi");
            command.Parameters.AddWithValue("@p5", 13000);
            command.Parameters.AddWithValue("@p6", 0);
            command.Parameters.AddWithValue("@p7", "Tokat");
            command.Parameters.AddWithValue("@p8", "murattıkac");
            command.Parameters.AddWithValue("@p9", "murattıkac55");
            command.ExecuteNonQuery();
            connection.Close();

            var veriSayisi = Listele();
            Assert.Equal(11, veriSayisi);
        }

        [Fact]
        public void Silme_Test()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tbl_mudek where userid=@p1");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", 11);
            command.ExecuteNonQuery();
            connection.Close();

            var veriSayisi = Listele();
            Assert.Equal(9, veriSayisi);
        }

        [Fact]
        public void Güncelleme_Test()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tbl_mudek set userad=@p1,usersoyad=@p2 where userid=@p10", connection);
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", "Elif");
            command.Parameters.AddWithValue("@p2", "Sevinç");
            command.Parameters.AddWithValue("@p10", 12);
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            var command1 = new SqlCommand("select * from tbl_mudek where userid=12", connection);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                string ad = reader["userad"].ToString() + reader["usersoyad"].ToString();
                Assert.Equal(ad,"ElifSevinç");
            }
            connection.Close();
        }
    }
}
