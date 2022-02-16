using System;
using System.Collections.Generic;
using System.Text;

namespace P225ClassWork.Extentions
{
    static class Extention
    {
        #region Task - 1
        //IsOdd() - int obyektler ucun hemin obyektin tek eded olub olmadigini
        //geri qaytaran (true/false) method
        public static bool IsOdd(this int num)
        {
            //bool check = true;

            //if (num % 2 == 0)
            //{
            //    check = false;
            //    return check;
            //}
            //else
            //{
            //    return check;
            //}

            return num % 2 == 1;
        }
        #endregion

        #region Task - 2
        //IsContainsDigit() - string obyektler ucun hemin obyektin daxilinde
        //digit charactre olub olmamsini geri qaytaran(true/false) metod
        public static bool IsContainsDigit(this string str, char digit)
        {
            foreach (char item in str)
            {
                if (item == digit)
                    return true;
            }
            return false;
        }
        #endregion

        #region Task - 3
        //GetValueIndexes() - string-ler ucun parameter oaraq gonderilen
        //charin stringin hansi indexlerinde yerlesdiyini tapan ve tapdigi
        //butun indexleri array olaraq geri qaytaran metod (hec bir deyer
        //tapilmazsa geriya bos (0 uzunluqlu) int[] qayidir)

        //Salam a >> [1,3]
        public static int[] GetValueIndexes(this string str, char letter)
        {
            int[] arr = { };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }

            return arr;
        }
        #endregion
    }
}
