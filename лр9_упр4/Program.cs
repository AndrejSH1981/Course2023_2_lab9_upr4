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
            Console.WriteLine("Выберете фигуру:");
            Console.WriteLine("1 - треугольник \n2 - квадрат \n3 - круг");
            int num = 0;
            num = Convert.ToInt16(Console.ReadLine());
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            //Треугольник-------------------------------------------------
            if (num == 1)
            {
                Console.WriteLine("\n выбрана фигура треугольник \n");
                Console.WriteLine("Выберете тип треугольника:");
                Console.WriteLine("1 - равносторонний \n 2 - с разными сторонами");
                num = 0;
                num = Convert.ToInt16(Console.ReadLine());

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
            // Квадрат-------------------------------------------------
            if (num == 2)
                {
                        Console.WriteLine("\n выбрана фигура квадрат \n");
                        Console.WriteLine("Введите одну сторону квадрата:");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        new Kvadrat(a1);
                        Kvadrat New_Kvadrat = new Kvadrat(a1);
                        New_Kvadrat.Init();
                        a1 = New_Kvadrat.a;
                        b1 = New_Kvadrat.b;
                        c1 = New_Kvadrat.c;
                        d1 = New_Kvadrat.d;

                    Console.Clear();
                    num = 0;
                    if (num == 0)
                    {
                        New_Kvadrat.Chek_Pppp(a1, b1, c1, d1);
                    }
                    Console.WriteLine("Выберете нужное действие:");
                    Console.WriteLine("1. Периметр квадрата");
                    Console.WriteLine("2. Площадь квадрата");
                    Console.WriteLine("3. Вывести стороны квадрата на экран");
                    Console.WriteLine("--. Проверка существования квадрата автоматическая\n");
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num == 1)
                    {
                        New_Kvadrat.Pppp(a1, b1, c1, d1);
                    }
                    if (num == 2)
                    {
                        New_Kvadrat.Area_Pppp(a1, b1, c1, d1);
                    }
                    if (num == 3)
                    {
                        New_Kvadrat.Write_Pppp(a1, b1, c1, d1);
                    }
                }
            // Круг-------------------------------------------------
            if (num == 3)
            {
                double pi = 3.14;
                Console.WriteLine("\n выбрана фигура круг \n");
                Console.WriteLine("Введите длинну радиуса круга:");
                a1 = Convert.ToDouble(Console.ReadLine());
                new Circle(a1);
                Circle New_Circle = new Circle(a1);
                New_Circle.Init();
                a1 = New_Circle.a;

                Console.Clear();
                num = 0;
                if (num == 0)
                {
                    New_Circle.Chek_R(a1);
                }
                Console.WriteLine("Выберете нужное действие:");
                Console.WriteLine("1. Длинна окружнсти круга");
                Console.WriteLine("2. Площадь круга");
                Console.WriteLine("3. Вывести длинну радиуса на экран");
                Console.WriteLine("--. Проверка существования круга автоматическая\n");
                num = Convert.ToInt16(Console.ReadLine());
                if (num == 1)
                {
                    New_Circle.R(a1, pi);
                }
                if (num == 2)
                {
                    New_Circle.Area_R(a1, pi);
                }
                if (num == 3)
                {
                    New_Circle.Write_R(a1);
                }
            }
        }
        public class Shape
        {
            //Для треуголника-------------------------------------------------
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
            //Для квадрата-------------------------------------------------
            public void Pppp(double a1, double b1, double c1, double d1)
            {
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    Console.WriteLine("\n периметр квадрата не будет расчитан \n ");
                }
                else
                {
                    Console.WriteLine("\n периметр квадрата = " + (a1 + b1 + c1 + d1));
                }
            }
            public void Area_Pppp(double a1, double b1, double c1, double d1)
            {
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    Console.WriteLine("\n площадь квадрата не будет расчитана \n ");
                    Console.WriteLine(" ( " + (a1 + b1 + c1 + d1) + " ) \n");
                }
                else
                {
                    Console.WriteLine("\n площадь квадрата = " + (a1 + b1 + c1 + d1));
                }
            }
            public void Write_Pppp(double a1, double b1, double c1, double d1)
            {
                Console.Clear();
                Console.WriteLine("\n 1я сторона = " + a1 + ",  2я сторона = " + b1 + ",  3я сторона = " + c1 + ",  4я сторона = " + d1);

                if (a1 > 0 && b1 > 0 && c1 > 0 && d1 > 0)
                {
                    Chek_Pppp(a1, b1, c1, d1);
                }
            }
            public void Chek_Pppp(double a1, double b1, double c1, double d1)
            {
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    Write_Pppp(a1, b1, c1, d1);
                    Console.WriteLine("\n это не квадрат \n ");
                }
                else
                {
                    Console.WriteLine("\n это есть квадрат \n ");
                }
            }
            public void Area_Ppp_kv(double a1, double b1, double c1, double d1)
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
            //Для круга-------------------------------------------------
            public void R(double a1, double pi)
            {
                if (a1 == 0)
                {
                    Console.WriteLine("\n длинна окружности круга не будет расчитан \n ");
                }
                else
                {
                    Console.WriteLine("\n длинна окружности круга = " + (2 * pi * a1));
                }
            }
            public void Area_R(double a1, double pi)
            {
                if (a1 == 0)
                {
                    Console.WriteLine("\n площадь круга не будет расчитана \n ");
                    Console.WriteLine(" ( " + (pi * (a1 * a1)) + " ) \n");
                }
                else
                {
                    Console.WriteLine("\n площадь круга = " + (pi * (a1 * a1)));
                }
            }
            public void Write_R(double a1)
            {
                Console.Clear();
                Console.WriteLine("\n радиус круга = " + a1);

                if (a1 > 0)
                {
                    Chek_R(a1);
                }
            }
            public void Chek_R(double a1)
            {
                if (a1 == 0)
                {
                    Write_R(a1);
                    Console.WriteLine("\n круга нет \n ");
                }
                else
                {
                    Console.WriteLine("\n круг есть \n ");
                }
            }
        }
            public class Triangle: Shape
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
                new public void Ppp(double a1, double b1, double c1)
                {
                base.Ppp(a1, b1, c1);
                }
                new public void Area_Ppp(double a1, double b1, double c1)
                {
                base.Area_Ppp(a1, b1, c1);
                }
                new public void Write_Ppp(double a1, double b1, double c1)
                {
                base.Write_Ppp(a1, b1, c1);
                }
                new public void Chek_Ppp(double a1, double b1, double c1)
                {
                base.Chek_Ppp(a1, b1, c1);
                }
            }
            public class Kvadrat: Shape
            {
                public double a;
                public double b;
                public double c;
                public double d;
                public void Init()
                {
                    double x2 = a;
                    double y2 = b;
                    double z2 = c;
                    double w2 = d;
                }
                public Kvadrat(double x)
                {
                    this.a = x;
                    this.b = x;
                    this.c = x;
                    this.d = x;
                }
                new public void Pppp(double a1, double b1, double c1, double d1)
                {
                base.Pppp(a1, b1, c1, d1);
                }
                new public void Area_Pppp(double a1, double b1, double c1, double d1)
                {
                base.Area_Pppp(a1, b1, c1, d1);
                }
                new public void Write_Pppp(double a1, double b1, double c1, double d1)
                {
                base.Write_Pppp(a1, b1, c1, d1);
                }
                new public void Chek_Pppp(double a1, double b1, double c1, double d1)
                {
                base.Chek_Pppp(a1, b1, c1, d1);
                }
            }
        public class Circle : Shape
        {
            public double a;
            public void Init()
            {
                double x2 = a;
            }
            public Circle(double x)
            {
                this.a = x;
            }
            new public void R(double a1, double pi)
            {
                base.R(a1, pi);
            }
            new public void Area_R(double a1, double pi)
            {
                base.Area_R(a1, pi);
            }
            new public void Write_R(double a1)
            {
                base.Write_R(a1);
            }
            new public void Chek_R(double a1)
            {
                base.Chek_R(a1);
            }
        }

    }
}

