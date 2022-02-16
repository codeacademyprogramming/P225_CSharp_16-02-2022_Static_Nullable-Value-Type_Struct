using System;
using P225StaticExtentionNullableEnumStruc.Models;
using P225StaticExtentionNullableEnumStruc.Entensions;

namespace P225StaticExtentionNullableEnumStruc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee.CountOfEmployeObject();


            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //Employee employee3 = new Employee();
            //Employee employee4 = new Employee();
            //Employee employee2 = new Employee();
            //Employee employee3 = new Employee();
            //Employee employee4 = new Employee();
            //Employee employee5 = new Employee();

            //CreateEmployee1();

            //Employee.CountOfEmployeObject();

            //Console.WriteLine(Employee.Age);


            string str = "test";
            String str1 = new String("Test2");
            str1.ToString();
            str.ToString();
            Console.WriteLine(Employee.Check(str));

            //Enxtention.CheckStr(str);

            Console.WriteLine(str.CheckStr());
            Console.WriteLine(str.CheckStr('T'));
        }

        //static void CreateEmployee1()
        //{
        //    Employee employee1 = new Employee();
        //    Employee employee2 = new Employee();
        //    Employee employee3 = new Employee();
        //    Employee employee4 = new Employee();
        //    Employee employee5 = new Employee();

        //    CreateEmployee2();
        //}

        //static void CreateEmployee2()
        //{
        //    Employee employee1 = new Employee();
        //    Employee employee2 = new Employee();
        //    Employee employee3 = new Employee();
        //    Employee employee4 = new Employee();
        //}
    }
}
