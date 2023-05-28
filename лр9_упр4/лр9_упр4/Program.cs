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
            string name_f;
            string name1;
            string name2;
            string name3;
            string name;
            string name_d1;
            //Треугольник-------------------------------------------------
            if (num == 1)
            {
                name_f = ("треугольник");
                name_d1 = (" -----");
                Shape ds = new Shape();
                ds.INI_f(name_f);

                Console.WriteLine("Выберете тип фигуры " + name_f + ":");
                Console.WriteLine("1 - равносторонний \n 2 - с разными сторонами");
                
                num = 0;
                num = Convert.ToInt16(Console.ReadLine());

                name1 = ("Переиметр фигуры ");
                name2 = ("Площадь фигуры ");
                name3 = ("Стороны фигуры ");
               

                if (num == 1)
                {
                    Console.WriteLine("\n треугольник равносторонний \n");
                    name_d1 = ("длинну одной стороны фигуры ");
                    ds.INI_vibor(name_f, name_d1);
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    name_d1 = ("одну сторону фигуры ");
                    new Shape();
                    ds.INI_f(name_f, name1, name2, name3, name_d1);

                    new Triangle(a1);
                    Triangle New_Treangle = new Triangle(a1);

                    a1 = New_Treangle.a;
                    b1 = New_Treangle.b;
                    c1 = New_Treangle.c;
  
                    num = 0;
                }
                if (num == 2)
                {
                    Console.WriteLine("\n треугольник обычный \n");
                    name_d1 = ("поочереди длинну трёх сторон фигуры ");
                    ds.INI_vibor(name_f, name_d1);

                    a1 = Convert.ToInt16(Console.ReadLine());
                    b1 = Convert.ToInt16(Console.ReadLine());
                    c1 = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    new Triangle(a1, b1, c1);
                    Triangle New_Treangle = new Triangle(a1, b1, c1);

                    a1 = New_Treangle.a;
                    b1 = New_Treangle.b;
                    c1 = New_Treangle.c;

                    ds = new Shape();
                    ds.INI_f(name_f, name1, name2, name3, name_d1);
                    num = 0;
                }

                num = 0;
                if (num == 0)
                {
                    Triangle New_Treangle = new Triangle(a1, b1, c1);

                    New_Treangle.Chek_Ppp(a1, b1, c1, name_f);
                }

                num = Convert.ToInt16(Console.ReadLine());
                if (num == 1)
                {
                    name = ("периметр фигуры");
                    Triangle New_Treangle = new Triangle(a1, b1, c1);
                    New_Treangle.Ppp(a1, b1, c1);
                }
                if (num == 2)
                {
                    name = ("площадь фигуры ");
                    Triangle New_Treangle = new Triangle(a1, b1, c1);
                    New_Treangle.Area_Ppp(a1, b1, c1);
                }
                if (num == 3)
                {
                    name = ("стороны фигуры ");
                    Triangle New_Treangle = new Triangle(a1, b1, c1);
                    New_Treangle.Write_Ppp(a1, b1, c1, name_f);
                }

                num = 0;
            }
            // Квадрат-------------------------------------------------
           
            if (num == 2)
            {
                name_f = ("квадрат");
                name1 = ("Переиметр фигуры ");
                name2 = ("Площадь фигуры ");
                name3 = ("Стороны фигуры ");
                name_d1 = ("длинну стороны фигуры ");
              Shape ds = new Shape();
              ds.INI_f(name_f);
                ds.INI_vibor(name_f, name_d1);

                        a1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                ds.INI_f(name_f, name1, name2, name3, name_d1);
                new Kvadrat(a1);
                        Kvadrat New_Kvadrat = new Kvadrat(a1);
                        a1 = New_Kvadrat.a;
                        b1 = New_Kvadrat.b;
                        c1 = New_Kvadrat.c;
                        d1 = New_Kvadrat.d;

                    num = 0;
                    if (num == 0)
                    {
                        New_Kvadrat.Chek_Pppp(a1, b1, c1, d1, name_f);
                    }

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
                        New_Kvadrat.Write_Pppp(a1, b1, c1, d1, name_f);
                    }
                new Shape();

                num = 0;
            }
            // Круг-------------------------------------------------
       
            if (num == 3)
            {
                name_f = ("круг");
                name1 = ("Длинна окружности фигуры ");
                name2 = ("Площадь фигуры ");
                name3 = ("Длинна радиуса фигуры ");
                name_d1 = ("длинну радиуса фигуры ");

                Shape ds = new Shape();
                ds.INI_f(name_f);

                double pi = 3.14;

                ds.INI_vibor(name_f, name_d1);

                a1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                new Shape();
                ds.INI_f(name_f, name1, name2, name3, name_d1);

                new Circle(a1);
                Circle New_Circle = new Circle(a1);
                a1 = New_Circle.a;

                num = 0;
                if (num == 0)
                {
                    New_Circle.Chek_R(a1, name_f);
                }

                num = Convert.ToInt16(Console.ReadLine());
                if (num == 1)
                {
                    New_Circle.R(a1, pi, name_f);
                }
                if (num == 2)
                {
                    New_Circle.Area_R(a1, pi, name_f);
                }
                if (num == 3)
                {
                    New_Circle.Write_R(a1, name_f);
                }
                num = 0;
            }
            Console.WriteLine("\n Вращение треугольника и квадрата: для вращения фигур введите ДА \n");
            string string1 = "да";
           string string2 = Console.ReadLine();
            int q = string.Compare(string1, string2);
            if (q == 0)
            {
                Console.WriteLine("\n ! ТРЕУГОЛЬНИК И КВАДРАТ ВРАЩАЮТСЯ !\n");
            }
            else
            {
                Console.WriteLine("\n ТРЕУГОЛЬНИК И КВАДРАТ ОСТАЛИСЬ БЕЗ ВРАЩЕНИЯ\n");
            }
        }



        class Shape
        {
            public double a;
            public double b;
            public double c;
            public double d;

            public void INI_f(string name_f)
            {
            Console.WriteLine("Выбрана фигура " + name_f + ":\n");
            }

            public void INI_vibor(string name_f, string name_d1)
            {
                Console.WriteLine("Введите  " + name_d1 + name_f +":\n");
            }

            public void INI_f (string name_f, string name1, string name2, string name3, string name_d1)
            {
                
                Console.WriteLine("Выберете нужное действие:");
                Console.WriteLine("1.  " + name1 + " " + name_f);
                Console.WriteLine("2.  " + name2 + " " + name_f);
                Console.WriteLine("3.  " + name3 + " " + name_f);
                Console.WriteLine("--. Проверка существования фигуры " + name_f + " автоматическая\n");

            }
            public void NO(string name)
            {
                Console.WriteLine(name + " расчитываться не будет" );
            }
            public void NO_figure(string name_f)
            {
                Console.WriteLine(" это не " + name_f);
            }
            public void YES_figure(string name_f)
            {
                Console.WriteLine(" это есть " + name_f);
            }

        }
        //-----------------------------------------------
             class Triangle: Shape
            {
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
                {
                    string name = ("периметр треугольника ");
                    if (a1 == 0 | b1 == 0 | c1 == 0)
                    {       
                        base.NO(name);
                    }
                    else
                    {
                        Console.WriteLine("\n " + name + "= " + (a1 + b1 + c1));
                    }
                }
                }
                public void Area_Ppp(double a1, double b1, double c1)
                {
                string name = ("площадь треугольника ");
                if (a1 == 0 | b1 == 0 | c1 == 0 | Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1)) < 0)
                    {
                    base.NO(name);
                        Console.WriteLine(" ( " + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2) + " )\n");
                    }
                    else
                    {
                        Console.WriteLine("\n " + name + " = "  + Math.Round((Math.Sqrt((a1 + b1 + c1) / 2) * ((((a1 + b1 + c1) / 2) - a1) * (((a1 + b1 + c1) / 2) - b1) * (((a1 + b1 + c1) / 2) - c1))), 2));
                }
                }
            public void Write_Ppp(double a1, double b1, double c1, string name_f)
            {
                Console.Clear();
                Console.WriteLine("\n 1я сторона = " + a1 + ",  2я сторона = " + b1 + ",  3я сторона = " + c1);

                if (a1 > 0 && b1 > 0 && c1 > 0)
                {
                    Chek_Ppp(a1, b1, c1, name_f);
                }
            }
            public void Chek_Ppp(double a1, double b1, double c1, string name_f)
            {
                if (a1 == 0 | b1 == 0 | c1 == 0)
                {
                    Write_Ppp(a1, b1, c1, name_f);
                    base.NO_figure(name_f);
                }
                else
                {
                    base.YES_figure(name_f);
                }
            }
        }
        //-----------------------------------------------
        class Kvadrat : Shape
            {
                public Kvadrat(double x)
                {
                    this.a = x;
                    this.b = x;
                    this.c = x;
                    this.d = x;
                }
            public void Pppp(double a1, double b1, double c1, double d1)
            {
                string name = ("периметр квадрата ");
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    base.NO(name);
                }
                else
                {
                    Console.WriteLine("\n " + name + "= " + (a1 + b1 + c1 + d1));
                }
            }
            public void Area_Pppp(double a1, double b1, double c1, double d1)
            {
                string name = ("площадь квадрата ");
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    base.NO(name);
                    Console.WriteLine(" ( " + (a1 + b1 + c1 + d1) + " ) \n");
                }
                else
                {
                    Console.WriteLine("\n " + name + "= " + (a1 + b1 + c1 + d1));
                }
            }
            public void Write_Pppp(double a1, double b1, double c1, double d1, string name_f)
            {
                Console.Clear();
                Console.WriteLine("\n 1я сторона = " + a1 + ",  2я сторона = " + b1 + ",  3я сторона = " + c1 + ",  4я сторона = " + d1);

                if (a1 > 0 && b1 > 0 && c1 > 0 && d1 > 0)
                {
                    Chek_Pppp(a1, b1, c1, d1, name_f);
                }
            }
            public void Chek_Pppp(double a1, double b1, double c1, double d1, string name_f)
            {
                if (a1 == 0 | b1 == 0 | c1 == 0 | d1 == 0)
                {
                    Write_Pppp(a1, b1, c1, d1, name_f);
                    base.NO_figure(name_f);
                }
                else
                {
                    base.YES_figure(name_f);
                }
            }
            
        }
        //-----------------------------------------------
        class Circle : Shape
        {
            public Circle(double x)
            {
                this.a = x;
            }
            public void R(double a1, double pi, string name_f)
            {
                string name = ("длинна окружности фигуры " + name_f + " ");
                if (a1 == 0)
                {
                    base.NO(name);
                }
                else
                {
                    Console.WriteLine("\n " + name + " = " + (2 * pi * a1));
                }
            }
            public void Area_R(double a1, double pi, string name_f)
            {
                string name = ("площадь фигуры  " + name_f + " ");
                if (a1 == 0)
                {
                    base.NO(name);
                    Console.WriteLine(" ( " + (pi * (a1 * a1)) + " ) \n");
                }
                else
                {
                    Console.WriteLine("\n " + name  + " = " + (pi * (a1 * a1)));
                }
            }
            public void Write_R(double a1, string name_f)
            {
                Console.Clear();
                string name = ("радиус фигуры  " + name_f + " ");
                Console.WriteLine(name + " = " + a1);

                if (a1 > 0)
                {
                    Chek_R(a1, name_f);
                }
            }
            public void Chek_R(double a1, string name_f)
            {
                if (a1 == 0)
                {
                    Write_R(a1, name_f);
                    base.NO_figure(name_f);
                }
                else
                {
                    base.YES_figure(name_f);
                }
            }
        }
    }
}

