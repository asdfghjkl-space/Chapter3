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
            //var words = new List<string> { "Microsof", "Apple", "Google", "Oracle", "Facebook", };

            //var lower = words.Select(name => name.ToLower());



            ////並べ替え
            ////Console.WriteLine();
            ////var sortedNumbers = numbers.Orderby(n => n);
            ////foreach (var nums in sortedNumbers)
            ////{
            ////    Console.Write(nums + " ");
            ////}

            ////文字列の例
            //Console.WriteLine();
            //var woeds = new List<string> { "Microsof", "Apple", "Google", "Oracle", "Facebook", };

            ////var lower = woeds.Select(name => name.ToLower()).ToArray();

            ////オブジェクトの例
            //Console.WriteLine();
            //var books = Books.GetBooks();
            ////タイトルリスト
            //var titles = books.Select(name => name.Title);
            //foreach (var title in titles)
            //{
            //    Console.WriteLine(title + " ");
            //}

            ////ページ数の多い順に並び変え（または金額の高い順）
            //var sortedBooks = books.OrderByDescending(book => book.Pages).Take(3);
            //foreach (var book in sortedBooks)
            //{
            //    Console.WriteLine(book.Title + " " + book.Pages);
            //}



            //演習問題6-1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //3-1-1
            var Max = numbers.Max();
            Console.WriteLine(Max);

            //3-1-2 途中
            var del = numbers.Where(s => s > 0).Take(2);
            Console.WriteLine(del);
        }
    }
}
