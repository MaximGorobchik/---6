using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Mordor_s_Cruel_Plan
{
    public abstract class Foods
    {
        public Foods(int hap)
        {
            this.Happines = hap;
        }
        public int Happines { get; set; }
    }
}
