using Chapter06;
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
            var numbers = new List<int> { 4, 9, -4, 8, 7, 4, 2, 3, -7, 1, 3, 5, 8, 4, 6, 8 };
            Console.WriteLine($"平均値:{numbers.Average()}");
            Console.WriteLine($"合計値:{numbers.Sum()}");
            Console.WriteLine($"最小値:{numbers.Where(s => s > 0).Min()}");
            Console.WriteLine($"最大値:{numbers.Max()}");

            var books = Books.GetBooks();
            Console.WriteLine($"値段の平均値:{books.Average(s => s.Price)}");
            Console.WriteLine($"値段の合計値:{books.Sum(s => s.Price)}");
            Console.WriteLine($"本のページの最大:{books.Max(s => s.Pages)}");
            Console.WriteLine($"高価な本:{books.Max(s => s.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{books.Where(s => s.Title.Contains("物語")).Count()}");
        }
    }
}
