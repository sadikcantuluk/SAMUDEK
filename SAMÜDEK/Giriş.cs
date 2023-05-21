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

namespace SAMÜDEK
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=SADIK;Initial Catalog=Mudekuser;Integrated Security=True");

        void Guvenlikkodu()
        {
            string[] s1 = { "X", "Y", "Z", "Q", "V", "P", "T", "J", "G", "B", "P" };
            string[] s2 = { "#", "$", "s", "i", "y", "t", "s", "a", "k", "l", "m" };

            Random rnd = new Random();

            int sayi1 = rnd.Next(11);
            int sayi2 = rnd.Next(11);
            int sayi3 = rnd.Next(11);
            int sayi4 = rnd.Next(11);

            string guvenlikkodu = s1[sayi1] + s2[sayi2] + s1[sayi3] + s2[sayi4];

            textBox1.Text = guvenlikkodu;
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            Guvenlikkodu();
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guvenlikkodu();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select userkulad,userpassord from tbl_mudek where userkulad=@p1 and userpassord=@p2", connection);
            command.Parameters.AddWithValue("@p1", textBox2.Text);
            command.Parameters.AddWithValue("@p2", textBox3.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() && textBox1.Text == textBox4.Text)
            {
                string giris = reader["userkulad"].ToString() + reader["userpassord"].ToString();
                switch (giris)
                {
                    case "mudekmudek55":
                        Müdek_Sorumlusu_Panel panel = new Müdek_Sorumlusu_Panel();
                        panel.Show();
                        this.Hide();
                        break;
                    case "adminadmin55":
                        AdminPanel panel1 = new AdminPanel();
                        panel1.Show();
                        this.Hide();
                        break;
                    case "emelsoyluemelsoylu55":
                        EmelSoylu panel2 = new EmelSoylu();
                        panel2.Show();
                        this.Hide();
                        break;
                    case "zafercomertzafercomert55":
                        ZaferCömert panel3 = new ZaferCömert();
                        panel3.Show();
                        this.Hide();
                        break;
                    case "haticemutihaticemuti55":
                        HaticeMuti panel4 = new HaticeMuti();
                        panel4.Show();
                        this.Hide();
                        break;
                    case "aliyilmazaliyilmaz55":
                        AliYılmaz panel5 = new AliYılmaz();
                        panel5.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Güvenlik Kodu Hatalı veya Kayıtlı Değilsiniz");
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
