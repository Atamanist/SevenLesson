﻿using System;
using System.Collections.Generic;
using System.Text;

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
            Console.Write("Text");
            note.Text = Console.ReadLine();
            Console.Write("Author");
            note.Author = Console.ReadLine();
            Console.Write("Title");
            note.Title = Console.ReadLine();
            DateTime dt = new DateTime();
            bool r = false;
            do
            {
                Console.Write("Date");
                r = DateTime.TryParse(Console.ReadLine(), out dt);
            } while (!r);

            note.DateN =dt;


            return note;
        }




        static int GetIndex()
        {
            int index;
            bool r = false;
            do
            { 
                Console.Write("Index");
                r = int.TryParse(Console.ReadLine(), out index);
            } while (!r);
            return index;

        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine(@"What to do?\0 save\1 add\2 delete\3 show\4 import\5 exit\6 sort\7 edit");
                switch(Console.ReadLine())
                {
                    case "0": new DataSaver(notepad.Notes).Save(GetPath());break;
                    case "1": notepad.Add(GetNote());break;
                    case "2": notepad.Remove(GetIndex());break;
                    case "3": Console.WriteLine(notepad.Print());break;
                    case "4": break;
                    case "5": break;
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
                Console.Write("Path");
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