using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeUygulama
{
    public class SekilCizici
    {
        private ISekil kare;
        private ISekil dikdortgen;
        private ISekil cember;

        public SekilCizici()
        {
            this.kare = new Kare();
            this.dikdortgen = new Dikdortgen();
            this.cember = new Cember();
        }

        public string KareCiz()
        {
            return kare.Ciz();
        }

        public string DikdortgenCiz()
        {
            return dikdortgen.Ciz();
        }

        public string CemberCiz()
        {
            return cember.Ciz();
        }
    }
}
