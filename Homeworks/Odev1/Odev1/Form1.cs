using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fotograf fotograf1 = new Fotograf();
        Video video1 = new Video();

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            fotograf1.Ad = "Afgan Kızı";
            fotograf1.CekenKisi = "Steve McCurry";
            fotograf1.CekimYili = 1984;
            fotograf1.RenkDagilimi = "180";

            MessageBox.Show("1. Fotoğraf Bilgileri" + Environment.NewLine +
                            "Ad: " + fotograf1.Ad + Environment.NewLine +
                            "Çeken Kişi: " + fotograf1.CekenKisi + Environment.NewLine +
                            "Çekim Yılı: " + fotograf1.CekimYili + Environment.NewLine +
                            "Renk Dağılımı: " + fotograf1.RenkDagilimi);

            video1.Ad = "Mustafa Hakkında Her Şey";
            video1.CekenKisi = "Çağan Irmak";
            video1.CekimYili = 2003;
            video1.IMDBpuani = 7.6;
            video1.Sure = TimeSpan.Parse("1:55:19");

            MessageBox.Show("1. Video Bilgileri" + Environment.NewLine +
                            "Ad: " + video1.Ad + Environment.NewLine +
                            "Çeken Kişi: " + video1.CekenKisi + Environment.NewLine +
                            "Çekim Yılı: " + video1.CekimYili + Environment.NewLine +
                            "IMDB Puanı: " + video1.IMDBpuani + Environment.NewLine +
                            "Süre: " + video1.Sure);
        }

        private void btnVideoyuBaslat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(video1.Oynat());
        }

        private void btnVideoyuDurdur_Click(object sender, EventArgs e)
        {
            MessageBox.Show(video1.Durdur());
        }
    }
}
