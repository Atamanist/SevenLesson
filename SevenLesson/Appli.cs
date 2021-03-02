using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SevenLesson
{
    class Appli
    {
        static int id = 2;


        static Notepad notepad = new Notepad(Repository.GetRepository());

        public static void Start()
        {
            Console.WriteLine(notepad.Print());
            Menu();
        }

        static Note GetNote()
        {
            Note note = new Note();
            note.Number = id++;
            Console.Write("Text: ");
            note.Text = Console.ReadLine();
            Console.Write("Author: ");
            note.Author = Console.ReadLine();
            Console.Write("Title: ");
            note.Title = Console.ReadLine();
            DateTime dt = new DateTime();
            bool r = false;
            do
            {
                Console.Write("Date: ");
                r = DateTime.TryParse(Console.ReadLine(), out dt);
            } while (!r);

            note.DateN =dt;


            return note;
        }

        //static Note GetNoteFile(string path)
        //{
        //    StreamReader sr = new StreamReader(path);
        //    Note note = new Note();
        //    while (!sr.EndOfStream)
        //    {
        //        string[] data = sr.ReadLine().Split(',');
        //        note.Number = Convert.ToInt32(data[0]);
        //        note.Author = data[2];
        //        note.Title = data[3];
        //        note.Text = data[1];
        //        note.DateN = Convert.ToDateTime(data[4]);
        //    }
        //    return note;
        //}
        static Note GetNoteFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            Note note = new Note();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                char[] charSeparators = new char[] { ' ', ',', '.' };
                string[] data = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                note.Number = Convert.ToInt32(data[0]);
                note.Author = data[2];
                note.Title = data[3];
                note.Text = data[1];
                note.DateN = /*Convert.ToDateTime(data[4])*/ DateTime.Now;
            }
            return note;
        }


        static DateTime GetDate()
        {
            DateTime Date;
            bool r = false;
            do
            {
                Console.Write("Date: ");
                r = DateTime.TryParse(Console.ReadLine(), out Date);
            } while (!r);
            return Date;
        }



        static int GetIndex()
        {
            int index;
            bool r = false;
            do
            { 
                Console.Write("Index: ");
                r = int.TryParse(Console.ReadLine(), out index);
            } while (!r);
            return index;

        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine(@"What to do?\0 save\1 add\2 delete\3 show\4 import\5 save by date\6 sort\7 edit");
                switch(Console.ReadLine())
                {
                    case "0": new DataSaver(notepad.Notes).Save(GetPath());break;
                    case "1": notepad.Add(GetNote());break;
                    case "2": notepad.Remove(GetIndex());break;
                    case "3": Console.WriteLine(notepad.Print());break;
                    case "4": notepad.Add(GetNoteFile(GetPath()));break;
                    case "5": notepad.FindDate(GetPath(), GetDate(), GetDate()); break;
                    case "6": notepad.SortBy();break;
                    case "7": notepad.Edit(GetIndex());break;
                    default:Console.WriteLine("of course"); break;
                }
            }
        }
        static string GetPath()
        {
            string path = String.Empty;
            do
            {
                Console.Write("Path: ");
                path = Console.ReadLine();
                bool f = true;
                for(int i=0; i< path.Length;i++)
                {
                    if(!Char.IsLetterOrDigit(path[i]))
                    {
                        f = false;
                        break;
                    }    
                }
                if (f) break;
            } while (true);
            return $"{path}.txt";
        }
    }
}
