using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine();
            var animals = new List<Animals>();
            while (!inputline.Equals("Beast!"))
            {
                try
                {
                    var typeofbeast = inputline;
                    var beastinfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var name = beastinfo[0];
                    var age = int.Parse(beastinfo[1]);
                    var gender = beastinfo[2];
                    switch (typeofbeast)
                    {
                        case "Cat": animals.Add(new Cat(name, age, gender)); break;
                        case "cat": animals.Add(new Cat(name, age, gender)); break;
                        case "Tomcat": animals.Add(new Cat(name, age, "Male"));break;
                        case "tomcat": animals.Add(new Cat(name, age, "Male")); break;
                        case "Kitten": animals.Add(new Cat(name, age, "Female")); break;
                        case "kitten": animals.Add(new Cat(name, age, "Female")); break;
                        case "dog": animals.Add(new Dog(name, age, gender)); break;
                        case "Dog": animals.Add(new Dog(name, age, gender)); break;
                        case "Frog": animals.Add(new Frog(name, age, gender)); break;
                        case "frog": animals.Add(new Dog(name, age, gender)); break;
                        default: Console.WriteLine("Invalid info"); break;
                    }
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                inputline = Console.ReadLine();
            }
            foreach(var x in animals)
            {
                Console.WriteLine($"{x.GetType()}");
                Console.WriteLine($"{x.Name} {x.Age} {x.Gender}");
                Console.WriteLine($"{x.ProduceSound()}");
            }
        }
    }
