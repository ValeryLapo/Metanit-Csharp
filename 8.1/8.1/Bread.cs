using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Bread
    {
        public int Weight { get; set; }

        public static Sandwich operator +(Bread br, Butter but)
        {
            return new Sandwich { Weight = br.Weight + but.Weight };
        }
    }
}
