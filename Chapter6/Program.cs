using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20).ToArray();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
