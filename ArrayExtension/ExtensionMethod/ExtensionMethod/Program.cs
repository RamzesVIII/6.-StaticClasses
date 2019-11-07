using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Array myarray = new Array();
            Console.WriteLine(new string('-', 15));
            myarray.MakeArray();
            myarray.ShowArray();
            Console.WriteLine(new string ('-',15));
            myarray.ExtensionMethod();
        }
    }
}
