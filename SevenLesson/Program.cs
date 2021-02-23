using System;

namespace SevenLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.txt";

            Repository rep = new Repository(path);

            rep.PrintDbToConsole();
            //Console.WriteLine(rep.Count);
            rep.Add(new Note(5, "Новая Фамилия", "Новая должность", "важно", DateTime.Now));
            //rep.Save("newdata.csv");

            Console.ReadKey();
        }
    }
}
