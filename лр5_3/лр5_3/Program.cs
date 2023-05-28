using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Arraydata
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int sum = 0;
            int pologitSum = 0;
            int otricatSum = 0;
            int nechetSum = 0;
            int chetSum = 0;
            int max = arr[0];
            int min = arr[0];
            int max_Index = 0;
            int min_Index = 0;

            // Ввод элементов массива и:.......
            // ..............Создание массива и сумма всех элементов массива
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите элемент массива " + (i + 1) + " : ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];

                // .....Сумма положит и отрицат элементов массива
                if (arr[i] > 0)
                {
                    pologitSum += arr[i];
                }
                else if (arr[i] < 0)
                {
                    otricatSum += arr[i];
                }

                // .....Сумма элементов с нечётными и чётными индексами
                if (i % 2 == 0)
                {
                    chetSum += arr[i];
                }
                else
                {
                    nechetSum += arr[i];
                }

                // ....Макс и Мин элемнт массива и его индекс
                if (arr[i] > max)
                {
                    max = arr[i];
                    max_Index = i;
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                    min_Index = i;
                }
            }


                // Среднее значение массива
                double srednee = (double)sum / arr.Length;


            // Вывод результата
            Console.WriteLine("Сумма всех элементов массива: " + sum);
            Console.WriteLine("Среднее значение массива: " + srednee);
            Console.WriteLine("Сумма положительных элементов: " + pologitSum);
            Console.WriteLine("Сумма отрицательных элементов: " + otricatSum);
            Console.WriteLine("Сумма элементов с нечётными индексами: " + nechetSum);
            Console.WriteLine("Сумма элементов с чётными индексами: " + chetSum);
            Console.WriteLine("Максимальный элемент: " + max + " , его индекс: " + max_Index);
            Console.WriteLine("Минимальный элемент: " +  min + " , его элемент: " + min_Index);
          
        }
    }
}