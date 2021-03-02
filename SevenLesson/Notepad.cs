using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SevenLesson
{
    public class Notepad
    {
        string Path;
        Col cols;

        public Note[] Notes { get { return cols.db; } }

        public Notepad(string Path)
        {
            this.Path = Path;
            cols = new Col(String.Empty);
        }
        public Notepad(Note[] args)
        {
            cols = new Col(args);
        }
        public void Add(Note note)
        {
            cols.Add(note);
        }
        public void Remove(int index)
        {
            cols.Remove(index);
        }
        public void Edit(int index)
        {
            cols.Edit(index);
        }
        public void FindDate(string path, DateTime data1, DateTime data2)
        {
            cols.FindDate(path, data1, data2);
        }

        public string Print()
        {
            StringBuilder t = new StringBuilder();           
            int count = cols.Count;
            for (int i=0;i<count;i++)
            {
                t.Append($"{cols[i]}\n");
            }
            return t.ToString();
        }
        public void SortByDate()
        {
            cols.db = cols.db.OrderBy(e => e.DateN).ToArray();
        }
        public void SortByNumber()
        {
            cols.db = cols.db.OrderBy(e => e.Number).ToArray();
        }
        public void SortByAuthor()
        {
            cols.db = cols.db.OrderBy(e => e.Author).ToArray();
        }
        public void SortByTitle()
        {
            cols.db = cols.db.OrderBy(e => e.Title).ToArray();
        }
        public void SortByText()
        {
            cols.db = cols.db.OrderBy(e => e.Text).ToArray();
        }

        public void SortBy()
        {
                Console.WriteLine(@"1 Number\2 Author\3 Title\4 Text\5 Date");
                switch (Console.ReadLine())
                {
                    case "1": SortByNumber(); break;
                    case "2": SortByAuthor(); break;
                    case "3": SortByTitle(); break;
                    case "4": SortByText(); break;
                    case "5": SortByDate(); break;
                    default: Console.WriteLine("of course"); break;
                }
        }
    }

}
