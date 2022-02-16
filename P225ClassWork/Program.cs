using System;
using P225ClassWork.Extentions;

namespace P225ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Onur";
            char l = 'a';

            int[] arr = word.GetValueIndexes(l);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
