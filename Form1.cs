using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d_55_Menu_Strip_Ornegii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkimizdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkimizdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje can tarafindan yapildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=UtjGTrVwRr4");
            label1.Text = "Mad Max";
        }

        private void aynıYıldızınAltındakilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=twejC_Gt0Sw");
            label1.Text = "Ayni Yildiz Altındakiler";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E");
            label1.Text = "Korku Filmi";
        }
    }
}
