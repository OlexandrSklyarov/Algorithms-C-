using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //BubleSort<int> algorithm = new BubleSort<int>();
            //CocktailSort<int> algorithm = new CocktailSort<int>();
            //InsertSort<int> algorithm = new InsertSort<int>();
            //ShellSort<int> algorithm = new ShellSort<int>();
            //TreeSort<int> algorithm = new TreeSort<int>();
            //HeapSort<int> algorithm = new HeapSort<int>();
            SelectionSort<int> algorithm = new SelectionSort<int>();

            var rnd = new Random();

            //заполняем список случайными числами
            for (int i = 0; i < 20; i++)
            {
                var n = rnd.Next(0, 100);
                algorithm.Items.Add(n);
            }

            //выводим список до сортировки
            Console.WriteLine("До сортировки:");
            Output(algorithm.Items);

            //сортируем
            algorithm.Sort();

            Console.WriteLine();

            //выводим список после сортировки
            Console.WriteLine("После сортировки:");
            Output(algorithm.Items);

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
