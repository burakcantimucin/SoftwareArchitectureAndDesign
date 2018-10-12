using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public abstract class Pencere : IPencere
    {
        private IPencere dekorePencere;

        public Pencere(IPencere Pencere)
        {
            dekorePencere = Pencere;
        }

        public string Boya()
        {
            return "Pencere oluşturuldu.";
        }
    }
}
