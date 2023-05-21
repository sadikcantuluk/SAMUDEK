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
using static System.Net.Mime.MediaTypeNames;

namespace SAMÜDEK
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=SADIK;Initial Catalog=Mudekuser;Integrated Security=True");
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mudekuserDataSet.Tbl_mudek' table. You can move, or remove it, as needed.
            this.tbl_mudekTableAdapter.Fill(this.mudekuserDataSet.Tbl_mudek);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_mudekTableAdapter.Fill(this.mudekuserDataSet.Tbl_mudek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_mudek (userad,usersoyad,userdurum,usermeslek,usermaas,usercinsiyet,usersehir,userkulad,userpassord) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection);
            command.Parameters.AddWithValue("@p1", textBox2.Text);
            command.Parameters.AddWithValue("@p2", textBox3.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text is "Evli" ? 1 : 0);
            command.Parameters.AddWithValue("@p4", textBox7.Text);
            command.Parameters.AddWithValue("@p5", textBox6.Text);
            command.Parameters.AddWithValue("@p6", radioButton4.Checked ? 1 : 0);
            command.Parameters.AddWithValue("@p7", textBox8.Text);
            command.Parameters.AddWithValue("@p8", textBox4.Text);
            command.Parameters.AddWithValue("@p9", textBox5.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı Eklendi!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox1.Focus();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectrow = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[selectrow].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selectrow].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selectrow].Cells[2].Value.ToString();
            if (dataGridView1.Rows[selectrow].Cells[3].Value.ToString() == "True")
                comboBox1.Text = "Evli";
            else comboBox1.Text = "Bekar";
            textBox7.Text = dataGridView1.Rows[selectrow].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[selectrow].Cells[5].Value.ToString();
            if (dataGridView1.Rows[selectrow].Cells[6].Value.ToString() == "True")
                radioButton4.Checked = true;
            else radioButton3.Checked = true;
            textBox8.Text = dataGridView1.Rows[selectrow].Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selectrow].Cells[8].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selectrow].Cells[9].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tbl_mudek where userid=@p1");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"ID = {textBox1.Text} Kayıt Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tbl_mudek set userad=@p1,usersoyad=@p2,userdurum=@p3,usermeslek=@p4,usermaas=@p5,usercinsiyet=@p6,usersehir=@p7,userkulad=@p8,userpassord=@p9 where userid=@p10", connection);
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", textBox2.Text);
            command.Parameters.AddWithValue("@p2", textBox3.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text == "Evli" ? 1 : 0);
            command.Parameters.AddWithValue("@p4", textBox7.Text);
            command.Parameters.AddWithValue("@p5", textBox6.Text);
            command.Parameters.AddWithValue("@p6", radioButton4.Checked ? 1 : 0);
            command.Parameters.AddWithValue("@p7", textBox8.Text);
            command.Parameters.AddWithValue("@p8", textBox4.Text);
            command.Parameters.AddWithValue("@p9", textBox5.Text);
            command.Parameters.AddWithValue("@p10", textBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"ID = {textBox1.Text} Kayıt Güncellendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Giriş form = new Giriş();
            form.Show();
            this.Close();
        }
    }
}
