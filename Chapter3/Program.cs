using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //問題3-1-1
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);

            if (exists)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");
        
        }

    }
}
