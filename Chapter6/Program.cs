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

            bool exists = numbers.Any(s => s % 7 == 0);

            var results = numbers.Where(s => s > 0).Take(5);
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }

            var books = Books.GetBooks();
            Console.WriteLine($"値段の平均値:{books.Average(s => s.Price)}");
            Console.WriteLine($"値段の合計値:{books.Sum(s => s.Price)}");
            Console.WriteLine($"本のページの最大:{books.Max(s => s.Pages)}");
            Console.WriteLine($"高価な本:{books.Max(s => s.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{books.Where(s => s.Title.Contains("物語")).Count()}");

            //６００ページ超える書籍はあるか
            Console.WriteLine(); //改行
            Console.Write("600ページを超える書籍は");
            Console.WriteLine(books.Any(s => s.Pages > 600) ? "ある":"ない");

            //すべてが２００ページ以上の書籍はあるか
            Console.WriteLine(); //改行
            Console.Write("200ページ以上の書籍は");
            Console.WriteLine(books.All(s => s.Pages >= 200) ? "ある" : "ない");

            //400ページを超える本は何冊目？
            Console.WriteLine(); //改行
            Console.WriteLine("400ページを超える本は何冊目？");
            var book = books.FirstOrDefault(s => s.Pages > 400);
            int i;
            for ( i = 0; i < books.Count; i++)
            {
                if(books[i].Title.Contains(book.Title))
                {
                    break;
                }
            }
            Console.WriteLine($"400ページを超える本は、{i + 1}冊目です。");

            //本の値段が４００円以下のものを３冊表示
            var booksMoney = books.Where(s => s.Price >= 400).Take(3);
            foreach (var item in booksMoney)
            {
                Console.WriteLine(item.Title + " ");
            }
        }
    }
}
