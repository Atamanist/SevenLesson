using System;
using System.Collections.Generic;
using System.Text;

namespace SevenLesson
{
    public struct Col
    {
        Note[] db;


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
            for(int i=index;i<count-1;i++)
            {
                db[index] = db[index + 1];
            }
            Array.Resize(ref db, db.Length - 1);
        }
        public void Edit(int index,Note note)

        {
            db[index] = note;
        }
    }
}
