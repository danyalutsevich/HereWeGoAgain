using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMColors
{
    class ColorContainer
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public override string ToString()
        {
            return $"R:{R}G:{G}B:{B}A:{A}";
        }
    }
}
