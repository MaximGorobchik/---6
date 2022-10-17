using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Mordor_s_Cruel_Plan
{
    public class GandalfMood : Moods
    {
        public GandalfMood(int x)
        {
            this.mood = x;
        }
        public int mood { get; set; }
        private string type()
        {
            if(this.mood < -5)
            {
                return "Angry";
            }
            if (this.mood >= -5 && this.mood < 0)
            {
                return "Sad";
            }
            if (this.mood >= 1 && this.mood <= 15)
            {
                return "Happy";
            }
            else
                return "JavaScript";
        }
        public override string ToString()
        {
            var line = new StringBuilder();
            line.Append(this.mood);
            line.Append(Environment.NewLine);
            line.Append(this.type());
            return line.ToString();
        }
    }
}
