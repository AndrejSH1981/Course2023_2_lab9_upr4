using System;

namespace Shot_to_meshen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Центр мишени случайно распологается в пределах координат от 0 до 100 \n Расчёт очков: \n +/-10 от центра мишени = 10, \n  +/-20 от центра мишени = 5, \n   +/-30 от центра мишени = 1, \n       больше чем +/-30 от центра мишени = 0  ");


            Random rnd = new Random();
            //Создание объекта для генерации чисел координаты х центра мишении

            //Получить случайное число для координат центра мишени по осу х
            int O_x = rnd.Next(0, 100);
            //Вывод координаты х центра мишени
            //Console.WriteLine(O_x);

            //Создание объекта для генерации чисел координаты у центра мишении
            //Получить случайное число для координат центра мишени по осу у
            int O_y = rnd.Next(0, 100);
            //Вывод координаты у центра мишени
            //Console.WriteLine(O_y);

            int rezult_obsh10;
            int rezult_obsh5;
            int rezult_obsh1;
            int[] rezult_obsh0 = new int[3];
            int i1_0;
            int i1_1;
            int i1_2;
            int i1_3;
            int i;
            int radius_mishen;
            double radius_shot_ot_mishen;

            for (i = 1; i < 4; i++)

            {
                if (i == 1)
                { Console.WriteLine("Произведите 1й выстрел, для этого введите координаты"); }
                if (i == 2)
                { Console.WriteLine("Произведите 2й выстрел, для этого введите координаты"); }
                if (i == 3)
                { Console.WriteLine("Произведите 3й выстрел, для этого введите координаты"); }

                //Координаты выстрела по шкале х
                Console.Write("-введите координату х: ");
                int x_shot = Convert.ToInt16(Console.ReadLine());

                //Координаты выстрела по шкале у
                Console.Write("-введите координату у: ");
                int y_shot = Convert.ToInt16(Console.ReadLine());

                radius_mishen = Math.Abs((O_x - x_shot)) ^ 2 + Math.Abs((O_y - y_shot)) ^ 2;
                radius_shot_ot_mishen = Math.Sqrt(Convert.ToDouble(radius_mishen));
                //Console.WriteLine("радиус до мишени:" + radius_shot_ot_mishen);

                //Условия определения очков от попадания по оси х
                var razryd_10 = 0;
                var razryd_5 = 0;
                var razryd_1 = 0;

                if (radius_shot_ot_mishen >= -30 && radius_shot_ot_mishen <= 30)
                { razryd_1 = 1; }
                else
                { razryd_1 = 0; }

                if (radius_shot_ot_mishen >= -20 && radius_shot_ot_mishen <= 20)
                { razryd_5 = razryd_1 + 4; }
                else
                { razryd_5 = razryd_1; }

                if (radius_shot_ot_mishen >= -10 && radius_shot_ot_mishen <= 10)
                { razryd_10 = 5 + razryd_5; }
                else
                { razryd_10 = razryd_5; }

                //Условия определения очков от попадания по оси у

                //Console.WriteLine("Вывод очков: " + "  " + razryd_10 + "  " + razryd_5 + "  " + razryd_1);
 

                if (razryd_1 >= 1)
                { rezult_obsh1 = 1; }
                else
                { rezult_obsh1 = 0; }

                if (razryd_5 >= 5)
                { rezult_obsh5 = 5; }
                else
                { rezult_obsh5 = rezult_obsh1; }

                if (razryd_10 >= 10)
                { rezult_obsh10 = 10; }
                else
                { rezult_obsh10 = rezult_obsh5; }

                //Console.WriteLine("Вывод очков: " + "  " + rezult_obsh10 + "  " + rezult_obsh5 + "  " + rezult_obsh1);

                if (i == 1)
                {
                    rezult_obsh0[0] = rezult_obsh10;
                }

                if (i == 2)
                {
                    rezult_obsh0[1] = rezult_obsh10;
                }
                if (i == 3)
                {
                    rezult_obsh0[2] = rezult_obsh10;
                }

            }
            i1_1 = rezult_obsh0[0];
            i1_2 = rezult_obsh0[1];
            i1_3 = rezult_obsh0[2];
            i1_0 = i1_1 + i1_2 + i1_3;

            //Console.WriteLine("Вывод очков общих: " + "  " + rezult_obsh0);
            Console.WriteLine("Результат каждого выстрела: " + "" + $" 1й = {rezult_obsh0[0]}, 2й = {rezult_obsh0[1]}, 3й = {rezult_obsh0[2]},");
            Console.WriteLine("Вывод сыммы очков после 3 выстрелов: " + "" + i1_0);
        }
    }
}