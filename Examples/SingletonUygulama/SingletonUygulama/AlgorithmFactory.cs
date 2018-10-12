using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonUygulama
{
    public class AlgorithmFactory
    {
        public Sort CreateAlgorithm(int type)
        {
            if (type == 1) { return new BubbleSort(); }
            else if (type == 2) { return new SelectionSort(); }
            else if (type == 3) { return new QuickSort(); }
            else throw new Exception("Geçersiz işlem");
        }
    }
}
