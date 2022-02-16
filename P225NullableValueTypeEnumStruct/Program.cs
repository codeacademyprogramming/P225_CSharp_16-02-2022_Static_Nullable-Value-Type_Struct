using System;

namespace P225NullableValueTypeEnumStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nullable Value Type
            //Nulable Value type

            //Simple Type
            //bool check = false;  //true / false
            //Nulable Value Type
            //Nullable Value Typlernin Default Deyeri null-dir
            //bool? check1 = null; // true / false / null
            //int? age = null;
            //age = 5;
            #endregion

            #region Struct
            int a = 5;
            Int32 b = new Int32();
            b = 5;

            AreaCalculate areaCalculate = new AreaCalculate();
            areaCalculate.A = 9;
            areaCalculate.B = 10;
            Console.WriteLine(areaCalculate.Calculate());

            //AreaCalculate areaCalculate1 = new AreaCalculate(7, 5);

            //Console.WriteLine(areaCalculate1.Calculate());

            AreaCalculate areaCalculate2;
            areaCalculate2.A = 5;
            //areaCalculate2.C = 3;

            //areaCalculate2.Calculate();
            #endregion
        }
    }
}
