using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    class Array
    {
        public int [] arr = new int[N];
        public static int N = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();

        public Array ()
        {
            
        }
        public void MakeArray()
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }
        public void ShowArray()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }


    }
}
