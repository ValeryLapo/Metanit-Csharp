using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Matrix
    {
        int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get => numbers[i, j];
            set => numbers[i, j] = value;
        }
    }
}
