using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugol
{
    public class Glav_metod
    {

        public static void Main()
        {
            Console.WriteLine("Введите стороны треугольника:");
            Triangle New_Triangle = new Triangle();  // создание объекта класса Triangle
            double a1 = New_Triangle.a;
            double b1 = New_Triangle.b;
            double c1 = New_Triangle.c;

            Console.Clear();

            int num = 0;
            if (num == 0)
            {
                New_Triangle.Chek_Ppp(a1, b1, c1);
            }
            Console.WriteLine("Выберете нужное действие:");
            Console.WriteLine("1. Периметр треугольника");
            Console.WriteLine("2. Площадь треугольника");
            Console.WriteLine("3. Вывести стороны треугольника на экран");
            Console.WriteLine("--. Проверка существования треугольника автоматическая\n");
            num = Convert.ToInt16(Console.ReadLine());
            if (num == 1)
            {
                New_Triangle.Ppp(a1, b1, c1);
            }
            if (num == 2)
            {
                New_Triangle.Area_Ppp(a1, b1, c1);
            }
        if (num == 3)
            {
                New_Triangle.Write_Ppp(a1, b1, c1);
            }
        }
    }
    public class Triangle
    {
        public double a = Convert.ToDouble(Console.ReadLine());
        public double b = Convert.ToDouble(Console.ReadLine());
        public double c = Convert.ToDouble(Console.ReadLine());
        public void Ppp(double a1, double b1, double c1)
        {
            
            if (a1 == 0 | b1 == 0 | c1 == 0)
            {
                Console.WriteLine("\n периметр треугольника не будет расчитан \n ");
            }
            else
            {
                Console.WriteLine("периметр треугольника = " + (a1 + b1 + c1));

            }
        }

        public void Area_Ppp(double a1, double b1, double c1)
        { 
            if (a1 == 0 | b1 == 0 | c1 == 0 | Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))<0)
            {
                Console.WriteLine("\n площадь треугольника не будет расчитана \n ");
                Console.WriteLine(" ( " + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2) + " )");
            }
            else
            {
                Console.WriteLine("площадь треугольника = " + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2));
            }
        }
        public void Write_Ppp(double a1, double b1, double c1)
        {
            Console.Clear();
            Console.WriteLine("1я сторона = " + a1 + ",  2я сторона = " + b1 + ",  3я сторона = " + c1);

            if (a1 > 0 && b1 > 0 && c1 > 0)
            {
                Chek_Ppp(a1, b1, c1);
            }
        }
        public void Chek_Ppp(double a1, double b1, double c1)
        {
            if (a1 == 0 | b1 == 0 | c1 == 0)
            {
                Write_Ppp(a1, b1, c1);
                Console.WriteLine("\n это не треугольник \n ");
            }
            else
            {
                Console.WriteLine("\n это есть треугольник \n ");
            }
        }
    }

}
    
