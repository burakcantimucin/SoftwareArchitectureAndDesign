using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmFactory af = new AlgorithmFactory();
            Sort[] s = new Sort[3];
            for (int i = 0; i < 3; i++)
            {
                s[i] = af.CreateAlgorithm(i + 1);
            }
            foreach (Sort sort in s)
            {
                MessageBox.Show(sort.Run());
            }
        }
    }
}
