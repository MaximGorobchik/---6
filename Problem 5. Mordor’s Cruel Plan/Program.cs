using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Mordor_s_Cruel_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputline = Console.ReadLine(); var g = new GandalfMood(0);
            var foods = FoodFactory.ProduceFood(inputline);
            MoodFactory.Mood(g, foods);
            Console.WriteLine(g);
        }
    }
}
