using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    
    public static void Main()
    {
       
       double x = Convert.ToDouble(Console.ReadLine());
       Koren(x);
        double flag = Koren(x);

        Console.WriteLine(flag * flag);
        
    }
    public static double Koren(double x)
    {
        double x1 = Math.Sqrt(x);
        return(x1);
    }
}
