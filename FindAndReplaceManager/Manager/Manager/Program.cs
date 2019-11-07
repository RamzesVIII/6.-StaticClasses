using System;

namespace Manager
{
    internal class Book
    {
        public void FindNext (string str)
        {
            Console.WriteLine("Поиск строки :" + str);
        }
    }

    internal static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Hello");
        }
    }
}
