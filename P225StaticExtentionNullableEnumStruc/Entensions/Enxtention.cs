using System;
using System.Collections.Generic;
using System.Text;

namespace P225StaticExtentionNullableEnumStruc.Entensions
{
    //Task - 1
    //IsOdd() - int obyektler ucun hemin obyektin tek eded olub olmadigini
    //geri qaytaran (true/false) method

    static class Enxtention
    {
        public static bool CheckStr(this string asdasd)
        {
            if (asdasd.Length > 8)
            {
                return true;
            }
            return false;
        }

        public static bool CheckStr(this string asdasd, char letter)
        {
            return asdasd.ToLower().Contains(char.ToLower(letter));
        }
    }
}
