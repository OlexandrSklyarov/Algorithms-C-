using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //создаем екземпляр алгоритма
            BubleSort<int> buble = new BubleSort<int>();

            //заполняем его список
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" Введите число: ");
               
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    buble.items.Add(value);                   
                }
                Console.WriteLine();
            }

            //выводим список до сортировки
            Console.WriteLine("Вывод:");
            Output(buble.items);

            //сортируем
            buble.Sort();

            //выводим список после сортировки
            Console.WriteLine("Вывод после сортировки:");
            Output(buble.items);

            Console.ReadKey();
        }


        //выводи список в один ряд
        static void Output(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write(i + " | ");
            }

            Console.WriteLine();
        }
    }
}
