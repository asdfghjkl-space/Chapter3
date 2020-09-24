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
        //デリゲートの宣言(int型の引数を受け取ってbool値を返すメソッド)
        public delegate bool Judgement(int value);

        static void Main(string[] args)
        {
            var numbers = new[] { 5, 4, 8, 4, 8, 4, 1, 9, 6, 4, 7, 2 };

            //匿名メソッドを使用した例
            //int count = Count(numbers , delegate (int n) { return (n >= 5); });
            int count = Count(numbers, n => n >= 5 && n <= 8);   //5～8
            Console.WriteLine($"{count}");
        }

        #region nが偶数かどうかを調べる
        //public static bool IsEven(int n)
        //{
        //    return (n % 2 == 0);
        //    #region ↑と一緒の意味
        //    //if( n % 2 == 0)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //    #endregion
        //}
        #endregion

        #region nが5以上かどうか調べる
        //public static bool IsEven(int n)
        //{
        //    return (n >= 5);
        //}
        #endregion

        public static int Count(int[] numbers, Judgement judeg)
        {
            int count = 0;

            foreach (var n in numbers)
            {
                if( judeg(n) == true)
                {
                    count++;
                }
            }

            return count;
        }


    }
}
