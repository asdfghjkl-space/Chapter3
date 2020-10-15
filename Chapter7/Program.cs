using Section01;
using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("*辞書登録プログラム*");
            Console.WriteLine("********************");

            var dict = new Dictionary<string, List<string>>();

            Console.WriteLine("1.登録  2.内容を表示  3.終了");

            while (true)
            {
                var sel = int.Parse(Console.ReadLine());

                if (sel == 1)
                {
                    Console.Write("KEYを入力:");
                    var key = Console.ReadLine();

                    Console.Write("VALUEを入力:");
                    var value = Console.ReadLine();

                    Console.WriteLine("登録しました！");

                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key] = new List<string> { value };
                    }

                }

                if (sel == 2)
                {
                    foreach (var item in dict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                    break;
                }

                if (sel == 3)
                {
                    Console.WriteLine("終了");
                    break;
                }

            }


        }

        //public void DuplicateKeySample()
        //{
        //    // ディクショナリの初期化
        //    var dict = new Dictionary<string, List<string>>() {
        //       { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
        //       { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
        //    };

        //    // ディクショナリに追加
        //    var key = "EC";
        //    var value = "電子商取引";
        //    if (dict.ContainsKey(key))
        //    {
        //        dict[key].Add(value);
        //    }
        //    else
        //    {
        //        dict[key] = new List<string> { value };
        //    }

        //    // ディクショナリの内容を列挙
        //    foreach (var item in dict)
        //    {
        //        foreach (var term in item.value)
        //        {
        //            Console.WriteLine("{0} : {1}", item.key, term);
        //        }
        //    }

        //public void DuplicateKeySample()
        //{
        //    // ディクショナリの初期化
        //    var dict = new Dictionary<string, List<string>>();

        //    // ディクショナリに追加
        //    Console.Write("KEYを入力:");
        //    var key = Console.ReadLine();

        //    Console.Write("VALUEを入力:");
        //    var value = Console.ReadLine();

        //    Console.WriteLine("登録しました！");

        //    if (dict.ContainsKey(key))
        //    {
        //        dict[key].Add(value);
        //    }
        //    else
        //    {
        //        dict[key] = new List<string> { value };
        //    }

        //    // ディクショナリの内容を列挙
        //    foreach (var item in dict)
        //    {
        //        foreach (var term in item.Value)
        //        {
        //            Console.WriteLine("{0} : {1}", item.Key, term);
        //        }
        //    }

        //}
    }
}
