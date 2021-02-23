using System;
using System.Collections.Generic;
using System.Text;


namespace SevenLesson
{
    public struct Note
    {
        public int Number { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public DateTime DateN { get; set; }


        #region Записи

        ///// <summary>
        ///// Создание записи
        ///// </summary>
        ///// <param name="Number">Имя</param>
        ///// <param name="Author">Фамилия</param>
        ///// <param name="Description">Должность</param>
        ///// <param name="Importent">Отдел</param>
        ///// <param name="DateDesc">Оплата труда</param>
        //public Note(int Number, string Author, string Description, string Importent, DateTime DateDesc)
        //{
        //    this.number = Number;
        //    this.author = Author;
        //    this.description = Description;
        //    this.importent = Importent;
        //    this.datedesc = DateDesc;
        //}

        //#endregion

        //#region Методы

        //public string Print()
        //{
        //    return $"{this.number,15} {this.author,15} {this.description,15} {this.importent,15} {this.datedesc,10}";
        //}

        //#endregion

        //#region Свойства

        ///// <summary>
        ///// Номер записи
        ///// </summary>
        //public int Number { get { return this.number; } set { this.number = value; } }

        ///// <summary>
        ///// Автор
        ///// </summary>
        //public string Author { get { return this.author; } set { this.author = value; } }

        ///// <summary>
        ///// Запись
        ///// </summary>
        //public string Description { get { return this.description; } set { this.description = value; } }

        ///// <summary>
        ///// Важность
        ///// </summary>
        //public string Importent { get { return this.importent; } set { this.importent = value; } }

        ///// <summary>
        ///// Время записи
        ///// </summary>
        //public DateTime DateDesc { get { return this.datedesc; } set { this.datedesc = value; } }

        ///// <summary>
        ///// Текущее время
        ///// </summary>
        //public DateTime HourRate
        //{
        //    get
        //    {
        //        DateDesc = DateTime.Now;
        //        return DateDesc;
        //    }
        //}

        //#endregion

        //#region Поля

        ///// <summary>
        ///// Поле "Номер записи"
        ///// </summary>
        //private int number;

        ///// <summary>
        ///// Поле "Автор"
        ///// </summary>
        //private string author;

        ///// <summary>
        ///// Поле "Запись"
        ///// </summary>
        //private string description;

        ///// <summary>
        ///// Поле "Важность"
        ///// </summary>
        //private string importent;

        ///// <summary>
        ///// Поле "Время записи"
        ///// </summary>
        //private DateTime datedesc;

        #endregion
    }

}

