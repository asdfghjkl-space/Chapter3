using System;
using System.Collections.Generic;
using System.Globalization;
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
            //var mozi = Console.ReadLine();
            //var mozi2 = Console.ReadLine();

            //if(String.Compare(mozi,mozi2,true) == 0)
            //{
            //    Console.WriteLine("等しい");
            //}
            //else
            //{
            //    Console.WriteLine("等しくない");
            //}

            //5-2
            //var suuzi = Console.ReadLine();

            //int num;    //変換後の数値格納
            //if(int.TryParse(suuzi, out num))
            //{
            //    Console.WriteLine(num.ToString("#,#"));
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません。");
            //}

            //5-3
            var text = "Jackdaws love my big sphinx of quartz";
            //5-3-1
            //var count = text.Count(s => s == ' ');
            //Console.WriteLine("空白の数:{0}",count);

            //5-3-2
            //var moji = text.Replace("big", "small");
            //Console.WriteLine(moji);

            //5-3-3
            //var count = text.Split(' ').Length;
            //Console.WriteLine(count);

            //5-3-4
            //var count = text.Split(' ').Where(s => s.Length <= 4);
            //foreach (var item in count)
            //{
            //    Console.WriteLine(item);
            //}

            //5-3-5
            var words = text.Split(' ').ToArray();

            if (words.Length > 0)
            {
                var sb = new StringBuilder(words[0]);

                foreach (var item in words.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(item);
                }
                var word = sb.ToString();

                Console.WriteLine(word);

            }

        }
    }
}
