using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////問題3-1-1
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);

            //if (exists)
            //    Console.WriteLine("存在しています。");
            //else
            //    Console.WriteLine("存在していません。");

            //問題3-1-2
            //numbers.ForEach(s => Console.WriteLine(s /2.0 ));

            //問題3-1-3
            //IEnumerable<int> query = numbers.Where(s => s >= 50);

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //問題3-1-4
            //List<int> lists = numbers.Select(s => s * 2).ToList();
            //foreach (var item in lists)
            //{
            //    Console.WriteLine(item);
            //}

            //問題3-2
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hog kong",
            };

            //問題3 - 2 - 1
            //Console.WriteLine("都市名を入力してください。");
            //var line = Console.ReadLine();
            //var index = names.FindIndex(s => s == line);
            //Console.WriteLine(index);

            //空白で終了の処理
            Console.WriteLine("都市名を入力。空白で終了。");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);

            //問題3-2-2
            //var index = names.Count(s => s.Contains('o'));
            //Console.WriteLine(index);

            //問題3-2-3
            //var index = names.Where(s => s.Contains('o')).ToArray();

            //foreach (var item in index)
            //{
            //    Console.WriteLine(item);
            //}

            //問題3-2-4
            //var index = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            //foreach (var item in index)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
