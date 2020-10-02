using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-1
            var mozi = Console.ReadLine();
            var mozi2 = Console.ReadLine();

            if(String.Compare(mozi,mozi2,true) == 0)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }

            //5-2

        }
    }
}
