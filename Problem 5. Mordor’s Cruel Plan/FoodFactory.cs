using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Mordor_s_Cruel_Plan
{
    public class FoodFactory
    {
        public static List<Foods> ProduceFood(string inputline)
        {
            var foods = new List<Foods>();
            var input_info = inputline.Split(new[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);

            foreach(var input in input_info)
            {
                switch(input)
                {
                    case "Cram": foods.Add(new Cram()); break;
                    case "cram": foods.Add(new Cram()); break;
                    case "Apple": foods.Add(new Apple()); break;
                    case "apple": foods.Add(new Apple()); break;
                    case "HoneyCake": foods.Add(new HoneyCake()); break;
                    case "honeycake": foods.Add(new HoneyCake()); break;
                    case "honeyCake": foods.Add(new HoneyCake()); break;
                    case "lembas": foods.Add(new Lembas()); break;
                    case "Lembas": foods.Add(new Lembas()); break;
                    case "Melon": foods.Add(new Melon()); break;
                    case "melon": foods.Add(new Melon()); break;
                    case "Mushrooms": foods.Add(new Mushrooms()); break;
                    case "mushrooms": foods.Add(new Mushrooms()); break;
                    default: foods.Add(new Everything_Else()); break;

                }
            }
            return foods;
        }

    }
}
