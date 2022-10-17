using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Mordor_s_Cruel_Plan
{
    public class MoodFactory
    {
        public static void Mood(Moods x, List<Foods> y)
        {
            foreach(var food in y)  
            {
                x.mood += food.Happines;
            }
        }
    }
}
