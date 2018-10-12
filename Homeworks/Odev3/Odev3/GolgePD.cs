using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public class GolgePD : PencereDekoratoru
    {
        public GolgePD(IPencere Pencere) : base(Pencere)
        {
            GolgeOlustur();
        }

        public string GolgeOlustur()
        {
            return "Gölge oluşturuldu.";
        }
    }
}
