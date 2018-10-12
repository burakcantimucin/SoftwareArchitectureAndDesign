using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class AdapterDusmanRobotu : IDusman
    {
        private DusmanRobotu dusmanRobot;
        public AdapterDusmanRobotu()
        {
            dusmanRobot = new DusmanRobotu();
        }

        public string DusmanAdi()
        {
            return dusmanRobot.RobotIsim();
        }

        public string Hizlan()
        {
            return dusmanRobot.Yuru();
        }

        public string SilahKullan()
        {
            return dusmanRobot.YumrukAt();
        }
    }
}
