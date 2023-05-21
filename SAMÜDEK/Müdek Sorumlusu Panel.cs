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
    public partial class Müdek_Sorumlusu_Panel : Form
    {
        public Müdek_Sorumlusu_Panel()
        {
            InitializeComponent();
        }

        private void enBaşarılıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\VİZE.pdf");
        }

        private void enBaşarısızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\VİZE.pdf");
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\VİZE.pdf");
        }

        private void enBaşarılıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\FİNAL.pdf");
        }

        private void enBaşarısızToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\FİNAL.pdf");
        }

        private void ortalamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\FİNAL.pdf");
        }

        private void enBaşarılıToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\ÖDEV.pdf");
        }
        private void enBaşarısızToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\ÖDEV.pdf");
        }

        private void ortalamaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\ÖDEV.pdf");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giriş form = new Giriş();
            form.Show();
            this.Close();
        }

        private void bilgiPaketiToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\lineer.pdf");
        }

        private void bilgiPaketiToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\diferansiyel.pdf");
        }

        private void bilgiPaketiToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\ayrık.pdf");
        }

        private void bilgiPaketiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\algoritma_tas.pdf");
        }

        private void bilgiPaketiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\yazılım_gereksinimi.pdf");
        }

        private void bilgiPaketiToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\nesne.pdf");
        }

        private void bilgiPaketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\yaz_tas.pdf");
        }

        private void bilgiPaketiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\bilgisayarbilimleri.pdf");
        }

        private void bilgiPaketiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\sadik\\OneDrive\\Masaüstü\\Yeni klasör\\C#\\SAMÜDEK\\pdf\\mikro.pdf");
        }
    }
}
