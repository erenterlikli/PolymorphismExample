using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇokŞekillilikÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Ekmek ek = new Ekmek("Uno", 8,"Kepekli", 100);
            spt.Urunekle(ek);
            MessageBox.Show(spt.ToplamTutar().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Telefon tel = new Telefon("Samsung", 3300, "Galaxy A51");
            spt.Urunekle(tel);
            MessageBox.Show(spt.ToplamTutar().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Tekstil tek = new Tekstil("Kazak", 80, "Yün", "L");
            spt.Urunekle(tek);
            MessageBox.Show(spt.ToplamTutar().ToString());
        }
    }
}
