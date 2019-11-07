using System;

namespace Notes
{
    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки :" + str + Notes);
        }

        public class Notes
        {
            public string note;
            public void MakeNote (string note)
            {
                this.note = note;
                Console.WriteLine(note);

            }
        }
    }

    internal static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
        public static void MakeNote(string note)
        {
            Book.Notes note1 = new Book.Notes();
            note1.MakeNote(note);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Hello");
            Book.Notes mybook = new Book.Notes();
            mybook.MakeNote("world!");

        }
    }
}
