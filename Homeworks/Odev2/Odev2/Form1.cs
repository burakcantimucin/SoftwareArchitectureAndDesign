using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            IDusman dusman = new AdapterDusmanRobotu();
            MessageBox.Show(dusman.DusmanAdi());
            MessageBox.Show(dusman.SilahKullan());
            MessageBox.Show(dusman.Hizlan());
        }
    }
}
