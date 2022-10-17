using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberofsongs = int.Parse(Console.ReadLine());
            var list = new List<RadioData>();
            for (int i = 0; i < numberofsongs; i++)
            {
                var line = Console.ReadLine().ToLower().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    var time = line[2].Split(':').ToArray();
                    int num1; int num2;
                    if (int.TryParse(time[0], out num1) && int.TryParse(time[1], out num2))
                    {
                            list.Add(new RadioData(line[0], line[1], num1, num2));
                            Console.WriteLine("Song added");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }


                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var totalDuration = list.Sum(x => x.Minutes * 60 + x.Seconds);
            var totalHours = totalDuration / 60 / 60;
            var totalMinutes = (totalDuration / 60) - (totalHours * 60);
            long totalSeconds = totalDuration % 60;


            Console.WriteLine($"Songs added: {list.Count}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}
