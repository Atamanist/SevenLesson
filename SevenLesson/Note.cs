using System;
using System.Collections.Generic;
using System.Text;


namespace SevenLesson
{/// <summary>
/// Запись из 5ти составляющих nuvber,title,author,text,daten
/// </summary>
    public struct Note
    {
        public int Number { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public DateTime DateN { get; set; }

        public override string ToString()
        {
            return $"{Number,5} {Author,7} {Title,7} {Text,5} {DateN,5}";
        }

    }

}

