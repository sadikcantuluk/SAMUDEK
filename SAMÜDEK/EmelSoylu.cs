using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMÜDEK
{
    public partial class EmelSoylu : Form
    {
        public EmelSoylu()
        {
            InitializeComponent();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Giriş form = new Giriş();
            form.Show();
            this.Close();
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void buttonsec_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            //if (openFileDialog.ShowDialog()==DialogResult.OK)
            //{
            //    MessageBox.Show($"{openFileDialog.FileName} adlı PDF dosyası yüklendi.");
            //}
            MessageBox.Show($"{openFileDialog.FileName} adlı PDF dosyası yüklendi.");
        }
    }
}
