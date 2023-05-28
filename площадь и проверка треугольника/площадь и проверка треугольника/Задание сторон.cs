using System;
using System.Collections.Generic;

using System.Text;
public class Program
{
   public static void Main(string [] args)
        {
            double a;
            double b;
            double c;
            double d;
        string tip_tr;
            Console.WriteLine("Треугольник равносторонний? (да):");
            tip_tr = Convert.ToString(Console.ReadLine());

            if (tip_tr == ("да"))
            {
                Console.WriteLine("Треугольник равносторонний");
                Console.Write("введите сторону равностороннего треугольника: ");
                d = double.Parse(Console.ReadLine());
        Operation.Swap(d);
        }
        else
            {
                Console.WriteLine("Введите три стороны треугольника поочереди:");
                Console.Write("первая:");
                a = double.Parse(Console.ReadLine());
                Console.Write("вторая:");
                b = double.Parse(Console.ReadLine());
                Console.Write("третья:");
                c = double.Parse(Console.ReadLine());
                double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
           Console.Write("Площадь треугольника: ");
               Console.WriteLine(Math.Round(S, 5));
            Operation.Main_2(a, b, c);
            }
        }
    }

