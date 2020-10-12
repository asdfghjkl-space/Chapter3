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
            #region
            //var employeeDict = new Dictionary<int,Employee>()
            //{
            //    {100,new Employee(100,"清水？？") },
            //    {112,new Employee(112,"？？？？") },
            //    {125,new Employee(125,"岩瀬？？？") },
            //};

            ////Console.WriteLine($"{employeeDict.Sum(s => s.Value.Id)}");

            //var employees = employeeDict.Where(emp => emp.Value.Id % 2 == 0);

            //foreach (/*KeyValuePair<int,Employee> → varがない場合は左尾用に書く*/var item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //}

            //var employee = new List<Employee>()
            //{
            //    new Employee(100,"清水？？"),
            //    new Employee(112,"？？？？"),
            //    new Employee(125,"岩瀬？？？"),
            //    new Employee(143,"山田太郎"),
            //    new Employee(148,"池田次郎"),
            //    new Employee(152,"高田三郎"),
            //    new Employee(155,"石川幸也"),
            //    new Employee(161,"中沢信也"),
            //};

            ////IDが偶数のみディクショナリに変換する
            //var employeeDict = employee.ToDictionary(emp => emp.Id);

            //foreach (var item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Value.Id} {item.Value.Name}");
            //}
            #endregion

            var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);

            foreach (var word in we.Extract())
            {
                Console.WriteLine(word);
            }

            //var dict = new Dictionary<MonthDay, string>
            //{
            //    {new MonthDay(3,5),"？？の日"},
            //    {new MonthDay(8,4),"？の日"},
            //    {new MonthDay(10,3),"登山の日"},
            //};

            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);
        }
    }
}
