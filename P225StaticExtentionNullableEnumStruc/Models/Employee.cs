using System;
using System.Collections.Generic;
using System.Text;

namespace P225StaticExtentionNullableEnumStruc.Models
{
    internal static class Employee
    {
        private static int _count = 1520;
        //public int No;
        //public string Name = "Test";
        //public string SurName;

        public static int Age { get; set; } = 75;

        static Employee()
        {
            Console.WriteLine($"Ilk Employee yarandi: Ilk Employee No: {_count}");
        }

        //public Employee()
        //{
        //    _count++;
        //    No = _count;
        //    Console.WriteLine("Employee yarandi");
        //}

        //public void Test()
        //{
        //    Console.WriteLine($"{No} {_count} ");
        //}

        public static void CountOfEmployeObject()
        {
            Console.WriteLine(_count);
        }

        public static bool Check(string str)
        {
            if (str.Length > 8)
            {
                return true;
            }
            return false;
        }

    }
}
