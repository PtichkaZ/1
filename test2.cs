using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_closest_range
{
    public struct Range
    {
        public int range;
        public int min;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение, с которым будут сравниваться все значения радиуса: ");
            bool g = false;
            int rang;
            do
            {
                g = int.TryParse(Console.ReadLine(), out rang);
            }
            while (g == false);

            Console.Write("Введите количество радиусов, которые будут сравниваться: ");
            g = false;
            int n;
            do
            {
                g = int.TryParse(Console.ReadLine(), out n);
            }
            while (g == false);

            Random rand = new Random();
            Range[] range = new Range[n];
            for (int q = 0; q < n; q++)
            {
                range[q].range = rand.Next(0, 10);
                range[q].min = Math.Abs(range[q].range - rang);
                Console.WriteLine("\t"+range[q].range);
            }

            Console.WriteLine("Ближайшие значения радиусов:");
            bool l = false;
            int min = range[0].min;
            var sortedUsers = range.OrderBy(u => u.min);
            foreach (Range u in sortedUsers)
            {
                if (l == false)
                {
                    min = u.min;
                    l = true;
                }

                if (min == u.min) Console.WriteLine("\t{0} (разница {1})", u.range, u.min);
            }

            /*var sortedRange = from u in range
                              orderby u.min
                              select u;*/

            /*min = range[0].min;
            int r = 0;
            Console.WriteLine("Ближайшие значения раниусов:");
            do
            {
                Console.WriteLine("\t{0}", range[r].range);
                r++;
            }
            while (min == range[r].min);*/
            
        }
    }
}