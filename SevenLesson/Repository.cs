using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SevenLesson
{
    class Repository
    {
        #region
        //private Note[] notes; // Основной массив для хранения данных

        //private string path; // путь к файлу с данными

        //int index; // текущий элемент для добавления в note

        //string[] titles; // массив, храняий заголовки полей. используется в PrintDbToConsole

        ///// <summary>
        ///// Констрктор
        ///// </summary>
        ///// <param name="Path">Путь в файлу с данными</param>
        //public Repository(string Path)
        //{
        //    this.path = Path; // Сохранение пути к файлу с данными
        //    this.index = 0; // текущая позиция для добавления сотрудника в workers
        //    this.titles = new string[0]; // инициализаия массива заголовков   
        //    this.notes = new Note[1]; // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет

        //    this.Load(); // Загрузка данных
        //}

        ///// <summary>
        ///// Метод увеличения текущего хранилища
        ///// </summary>
        ///// <param name="Flag">Условие увеличения</param>
        //private void Resize(bool Flag)
        //{
        //    if (Flag)
        //    {
        //        Array.Resize(ref this.notes, this.notes.Length * 2);
        //    }
        //}

        ///// <summary>
        ///// Метод добавления записи в хранилище
        ///// </summary>
        ///// <param name="ConcreteWorker">Сотрудник</param>
        //public void Add(Note ConcreteWorker)
        //{
        //    this.Resize(index >= this.notes.Length);
        //    this.notes[index] = ConcreteWorker;
        //    this.index++;
        //}
        ///// <summary>
        ///// Метод удаления записи в хранилище
        ///// </summary>
        ///// <param name="ConcreteWorker">Сотрудник</param>
        //public void Del()
        //{

        //}
        ///// <summary>
        ///// Метод редактирования записи в хранилище
        ///// </summary>
        ///// <param name="ConcreteWorker">Сотрудник</param>
        //public void Ed(Note ConcreteWorker)
        //{
        //    this.Resize(index >= this.notes.Length);
        //    this.notes[index] = ConcreteWorker;
        //    this.index++;
        //}

        ///// <summary>
        ///// Метод загрузки данных
        ///// </summary>
        //private void Load()
        //{
        //    using (StreamReader sr = new StreamReader(this.path))
        //    {
        //        titles = sr.ReadLine().Split(',');


        //        while (!sr.EndOfStream)
        //        {
        //            string[] args = sr.ReadLine().Split(',');

        //            Add(new Note(Convert.ToInt32( args[0]), args[1], args[2], args[3], Convert.ToDateTime( args[4])));
        //        }
        //    }
        //}

        ///// <summary>
        ///// Метод сохранения данных
        ///// </summary>
        ///// <param name="Path">Путь к файлу сохранения</param>
        //public void Save(string Path)
        //{
        //    string temp = String.Format("{0},{1},{2},{3},{4}",
        //                                    this.titles[0],
        //                                    this.titles[1],
        //                                    this.titles[2],
        //                                    this.titles[3],
        //                                    this.titles[4]);

        //    File.AppendAllText(Path, $"{temp}\n");

        //    for (int i = 0; i < this.index; i++)
        //    {
        //        temp = String.Format("{0},{1},{2},{3},{4}",
        //                                this.notes[i].Number,
        //                                this.notes[i].Author,
        //                                this.notes[i].Description,
        //                                this.notes[i].Importent,
        //                                this.notes[i].DateDesc);
        //        File.AppendAllText(Path, $"{temp}\n");

        //    }
        //}

        ///// <summary>
        ///// Вывод данных в консоль
        ///// </summary>
        //public void PrintDbToConsole()
        //{
        //    Console.WriteLine($"{this.titles[0],15} {this.titles[1],15} {this.titles[4],15} {this.titles[2],15} {this.titles[3],10}");

        //    for (int i = 0; i < index; i++)
        //    {
        //        Console.WriteLine(this.notes[i].Print());
        //    }
        //}

        ///// <summary>
        ///// Количество сотрудников в хранилище
        ///// </summary>
        //public int Count { get { return this.index; } }

        #endregion


        static Random rand = new Random();
        static public Note[] GetRepository()
        {
            int count = rand.Next(2, 3);
            Note[] t = new Note[count];
            for(int i=0;i<count;i++)
            {
                t[i] = new Note 
                {
                Number=i+1,
                DateN=DateTime.Now+new TimeSpan(days:rand.Next(20),hours:0,minutes:0,seconds:0),
                Title=$"Заг_{i+1}",
                Text=Guid.NewGuid().ToString(),
                Author=$"Авт_{i+1}",
                };
            }
            return t;
        }
    }
}
