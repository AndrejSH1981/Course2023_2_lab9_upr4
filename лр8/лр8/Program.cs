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
            Console.WriteLine("Выберете тип треугольника:");
            Console.WriteLine("1 - равносторонний \n 2 - с разными сторонами");
            int num = 0;
            num = Convert.ToInt16(Console.ReadLine());
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            if (num == 1)
            {
                Console.WriteLine("\n треугольник равносторонний \n");
                Console.WriteLine("Введите одну сторону треугольника:");
                a1 = Convert.ToDouble(Console.ReadLine());
                new Triangle(a1);
                Triangle New_Treangle = new Triangle(a1);
                New_Treangle.Init();
                a1 = New_Treangle.a;
                b1 = New_Treangle.b;
                c1 = New_Treangle.c;
            }
            if (num == 2)
            {
                Console.WriteLine("\n треугольник обычный \n");
                Console.WriteLine("Введите три стороны треугольника поочереди:");
                a1 = Convert.ToInt16(Console.ReadLine());
                b1 = Convert.ToInt16(Console.ReadLine());
                c1 = Convert.ToInt16(Console.ReadLine());
                new Triangle(a1, b1, c1);
                Triangle New_Treangle = new Triangle(a1, b1, c1);
                New_Treangle.Init();
                a1 = New_Treangle.a;
                b1 = New_Treangle.b;
                c1 = New_Treangle.c;
            }

            Console.Clear();
            num = 0;
            if (num == 0)
            {
                Triangle New_Treangle = new Triangle(a1, b1, c1);

                New_Treangle.Chek_Ppp(a1, b1, c1);
            }
            Console.WriteLine("Выберете нужное действие:");
            Console.WriteLine("1. Периметр треугольника");
            Console.WriteLine("2. Площадь треугольника");
            Console.WriteLine("3. Вывести стороны треугольника на экран");
            Console.WriteLine("--. Проверка существования треугольника автоматическая\n");
            num = Convert.ToInt16(Console.ReadLine());
            if (num == 1)
            {
                Triangle New_Treangle = new Triangle(a1, b1, c1);
                New_Treangle.Ppp(a1, b1, c1);
            }
            if (num == 2)
            {
                Triangle New_Treangle = new Triangle(a1, b1, c1);
                New_Treangle.Area_Ppp(a1, b1, c1);
            }
            if (num == 3)
            {
                Triangle New_Treangle = new Triangle(a1, b1, c1);
                New_Treangle.Write_Ppp(a1, b1, c1);
            }
        }
    }
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public void Init()
        {   
            double x2 = a;
            double y2 = b;
            double z2 = c;
        }
        public Triangle(double x)
        {
            this.a = x;
            this.b = x;
            this.c = x;   
        }
        public Triangle(double x1, double y1, double z1)
        {
            this.a = x1;
            this.b = y1;
            this.c = z1;
        }

        public void Ppp(double a1, double b1, double c1)
        {
            if (a1 == 0 | b1 == 0 | c1 == 0)
            {
                Console.WriteLine("\n периметр треугольника не будет расчитан \n ");
            }
            else
            {
                Console.WriteLine("\n периметр треугольника = " + (a1 + b1 + c1));
            }
        }
        public void Area_Ppp(double a1, double b1, double c1)
        {
            if (a1 == 0 | b1 == 0 | c1 == 0 | Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1)) < 0)
            {
                Console.WriteLine("\n площадь треугольника не будет расчитана \n ");
                Console.WriteLine(" ( " + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2) + " )\n");
            }
            else
            {
                Console.WriteLine("\n площадь треугольника = " + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2));
            }
        }
        public void Write_Ppp(double a1, double b1, double c1)
        {
            Console.Clear();
            Console.WriteLine("\n 1я сторона = " + a1 + ",  2я сторона = " + b1 + ",  3я сторона = " + c1);

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

