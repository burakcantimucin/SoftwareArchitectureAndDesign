using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IPencere Pencere = new BasitPencere();

        private void btnBasitPencere_Click(object sender, EventArgs e)
        {
            BasitPencere bp = new BasitPencere();
            MessageBox.Show(bp.Boya());
        }

        private void btnKenarOlustur_Click(object sender, EventArgs e)
        {
            KenarPD k = new KenarPD(Pencere);
            MessageBox.Show(k.KenarOlustur());
        }

        private void btnGolgeOlustur_Click(object sender, EventArgs e)
        {
            GolgePD g = new GolgePD(Pencere);
            MessageBox.Show(g.GolgeOlustur());
        }
    }
}
