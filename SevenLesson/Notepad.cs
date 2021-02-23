using System;
using System.Collections.Generic;
using System.Text;

namespace SevenLesson
{
    public class Notepad
    {
        string Path;
        Col cols;
        public Notepad(string Path)
        {
            this.Path = Path;
            cols = new Col(string.Empty);
        }
        public Notepad(params Note[] args)
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
        public void Edit(int index, Note note)
        {
            cols.Edit(index,note);
        }

    }
}
