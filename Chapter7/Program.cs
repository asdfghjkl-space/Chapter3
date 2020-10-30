using Section01;
using Section02;
using Section03;
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
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            // 7.2.3 (Countの呼び出し例)
            // 上のAddメソッドで、２つのオブジェクトを追加しているので、読み込んだ単語数+2が、Countの値になる。
            var count = abbrs.Count;
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            // 7.2.3 (Removeの呼び出し例)
            if (abbrs.Remove("NPT"))
                Console.WriteLine(abbrs.Count);
            if (!abbrs.Remove("NPT"))
                Console.WriteLine("削除できません");
            Console.WriteLine();


            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }

    }
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("********************");
    //    Console.WriteLine("*辞書登録プログラム*");
    //    Console.WriteLine("********************");

    //    var dict = new Dictionary<string, List<string>>();

    //    Console.WriteLine("1.登録  2.内容を表示  3.終了");

    //    while (true)
    //    {
    //        var sel = int.Parse(Console.ReadLine());

    //        if (sel == 1)
    //        {
    //            Console.Write("KEYを入力:");
    //            var key = Console.ReadLine();

    //            Console.Write("VALUEを入力:");
    //            var value = Console.ReadLine();

    //            Console.WriteLine("登録しました！");

    //            if (dict.ContainsKey(key))
    //            {
    //                dict[key].Add(value);
    //            }
    //            else
    //            {
    //                dict[key] = new List<string> { value };
    //            }

    //        }

    //        if (sel == 2)
    //        {
    //            foreach (var item in dict)
    //            {
    //                foreach (var term in item.Value)
    //                {
    //                    Console.WriteLine("{0} : {1}", item.Key, term);
    //                }
    //            }
    //            break;
    //        }

    //        if (sel == 3)
    //        {
    //            Console.WriteLine("終了");
    //            break;
    //        }

    //    }


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
//    }
//}
