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
    public partial class ZaferCömert : Form
    {
        public ZaferCömert()
        {
            InitializeComponent();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Giriş form = new Giriş();
            form.Show();
            this.Close();
        }

        private void buttonsec_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }
    }
}
