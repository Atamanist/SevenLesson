﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SevenLesson
{
    public struct Col
    {
        public Note this[int index]
        {
            get { return db[index]; }
        }
        public int Count 
        { 
            get { return db.Length; } 
        }

        public Note[] db;


        public Col(string name)
        {
            db = new Note[0];
        }
        public Col(Note[]arg)
        {
            db = arg;
        }
        public void Add(Note arg)
        {
            Array.Resize(ref db, db.Length + 1);
            db[db.Length - 1] = arg;
        }
        public void Remove(int index)
        {
            int count = db.Length;

            int findindex = -1;

            for(int i=0;i<count;i++)
            {
                if (db[i].Number == index)
                    findindex = i;
            }
            if (findindex == -1) return;

            for(int i=findindex;i<count-1;i++)
            {
                db[findindex] = db[findindex + 1];
            }
            Array.Resize(ref db, db.Length - 1);
        }
        public void Edit(int index)
        {
            index--;
            db[index].Number = index+1;
            Console.Write("Author");
            db[index].Author = Console.ReadLine(); ;
            Console.Write("Text");
            db[index].Text = Console.ReadLine(); ;
            Console.Write("Title");
            db[index].Title = Console.ReadLine(); ;
            DateTime dt = new DateTime();
            bool r = false;
            do
            {
                Console.Write("Date");
                r = DateTime.TryParse(Console.ReadLine(), out dt);
            } while (!r);
            db[index].DateN = dt;
        }

    }
}
