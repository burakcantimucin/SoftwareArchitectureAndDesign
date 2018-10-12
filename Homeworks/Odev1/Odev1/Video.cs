using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Video : Goruntu, IOynatabilen
    {
        public TimeSpan Sure { get; set; }
        public double IMDBpuani { get; set; }

        public string Oynat()
        {
            return "Video oynatıldı.";
        }

        public string Durdur()
        {
            return "Video durduruldu.";
        }
    }
}
