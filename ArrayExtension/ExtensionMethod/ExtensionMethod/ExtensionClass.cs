using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    static class ExtensionClass
    {
        public static void ExtensionMethod (this Array array)
        {
            System.Array.Sort(array.arr);

            foreach (var item in array.arr)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
