using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SevenLesson
{
    class DataSaver
    {
        private Note[] notes;
        public DataSaver(params Note[] notes)
        {
            this.notes = notes;
        }
        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (var item in notes)
            {
                sw.WriteLine(item.Number);
                sw.WriteLine(item.Author);
                sw.WriteLine(item.Title);
                sw.WriteLine(item.Text);
                sw.WriteLine(item.DateN);
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
