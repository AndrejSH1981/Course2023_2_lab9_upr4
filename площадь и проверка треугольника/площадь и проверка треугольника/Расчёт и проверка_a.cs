using System;
    public class Operation
    {
    public static void Swap(double d)
    {
        double a = d;
        double b = d;
        double c = d;

        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.Write("площадь равностороннего треугольника равна: ");
        Console.WriteLine(Math.Round(S, 2));
        Main_2(a, b, c); 

    }
    public static void Main_2(double x, double y, double z)
    {
        double test_tr = x * y * z;
        bool test_tr_bool = false;
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.WriteLine(z);

        if (test_tr == 0)
        {
            test_tr_bool = true;
        }
        if (test_tr_bool == true)
        {
            Console.WriteLine("нет треугольника");
        }
    }
    }

