using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public abstract class PencereDekoratoru : IPencere
    {
        protected IPencere dekorePencere;

        public PencereDekoratoru(IPencere Pencere)
        {
            dekorePencere = Pencere;
        }

        public string Boya()
        {
            return "Pencere oluşturuldu.";
        }
    }
}
