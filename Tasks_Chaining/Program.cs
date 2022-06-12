using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(CreateArray10integers);

            Console.WriteLine("Hello World!");
        }

        public static Array CreateArray10integers()
        {
            Random randInt = new Random();
            int[] array = Enumerable.Repeat(0, 10)
                                    .Select(i => randInt.Next(int.MinValue, int.MaxValue)).ToArray();
            return array;
        }
    }
}
