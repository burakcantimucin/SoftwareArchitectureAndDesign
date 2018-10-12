using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public class KenarPD : PencereDekoratoru
    {
        public KenarPD(IPencere Pencere) : base(Pencere)
        {
            KenarOlustur();
        }

        public string KenarOlustur()
        {
            return "Kenar oluşturuldu.";
        }
    }
}
