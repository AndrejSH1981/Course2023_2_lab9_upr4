using System;

namespace Distance1
{
    public class Program
    {
        public struct Distance
        {
            public int l1;
            public int l2;
            public int l3;

            public int l1d;
            public int l2d;
            public int l3d;

        }
        public static void Main(string[] args)

            {

            Distance myDistance;

            Console.Write("введите футы 1й переменной: ");
            string? name1 = Console.ReadLine();
            myDistance.l1 = Convert.ToInt16(name1);
            Console.Write("введите дюймы 1й переменной: ");
            string? name2 = Console.ReadLine();
            myDistance.l1d = Convert.ToInt16(name2);

            if (myDistance.l1d % 12 >= 1)
            {
                myDistance.l1 = myDistance.l1 + myDistance.l1d / 12;
                myDistance.l1d = myDistance.l1d % 12;
            }

            Console.Write("введите футы 2й переменной: ");
            string? name3 = Console.ReadLine();
            myDistance.l2 = Convert.ToInt16(name3);
            Console.Write("введите дюймы 2й переменной: ");
            string? name4 = Console.ReadLine();
            myDistance.l2d = Convert.ToInt16(name4);

            if (myDistance.l2d % 12 >= 1)
            {
                myDistance.l2 = myDistance.l2 + myDistance.l2d / 12;
                myDistance.l2d = myDistance.l2d % 12;
            }

            Console.WriteLine("футы и дюймы первой переменной:" + "  " + myDistance.l1 + "' - " + myDistance.l1d + "'' ");
            Console.WriteLine("футы и дюймы второй переменной:" + "  " + myDistance.l2 + "' - " + myDistance.l2d + "'' ");


            myDistance.l3 = myDistance.l1 + myDistance.l2;
            myDistance.l3d = myDistance.l1d + myDistance.l2d;

            if (myDistance.l3d % 12 >= 1)
            {
                myDistance.l3 = myDistance.l3 + myDistance.l3d / 12;
                myDistance.l3d = myDistance.l3d % 12;
            }

            Console.WriteLine("футы и дюймы 3й переменной (сумма футов и дюймой 1й и 2й переменных):" + " " + myDistance.l3 + "' - " + myDistance.l3d + "'' ");

        }
        }


    }

