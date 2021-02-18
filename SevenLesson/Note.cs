using System;
using System.Collections.Generic;
using System.Text;

namespace SevenLesson
{
    public struct Note
    {
        private int number;
        public int Number { get; set; }

        private string author;
        public string Author { get; set; }

        private string Description;
        public string description { get; set; }

        private string Importent;
        public string importent { get; set; }

        private DateTime DateDesc;
        public DateTime dateDesc { get; set; }
    }
}
