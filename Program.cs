using System;

namespace LabRob4
{
    class Program
    {
        static void Main(string[] args)
        {

            double f;
            double min;
            double max;
        m1: Console.WriteLine("Введите значение Х"); // введение значений 
            double x = double.Parse((Console.ReadLine()));
            Console.WriteLine("Введите значения У");
            double y = double.Parse((Console.ReadLine()));
            Console.WriteLine("Введите значение Z");
            double z = double.Parse((Console.ReadLine()));
            if (x > y) // поиск максимального значения из х и у;
            {
                max = x; 
            }
            else 
            {
                max = y;
            }

            if (x < y + z) //поиск минимального значения из x, y + z
            { 
                min = x; 
            }
            else 
            { 
                min = y + z; 
            }

            double c = max + Math.Sin(z);
            if (c == 0) // Если знаменатель = 0
            {
                Console.WriteLine("Знаменатель равен нулю, что бы ввести значение по новой нажмите любую клавишу"+ '\n' +"Для завершения програмы нажмите Enter.");
                
                string j = Console.ReadLine();
                if (j != "") goto m1;
                goto m1;
            }
            else // если знаменатьль не рованяется 0
            { 
                f = min / max + Math.Sin(z); 
            }
            Console.WriteLine('\n' + " Дано: Х = " + x + " Y = " + y + " Z = " + z +'\n' + " Результат: F = " + f);
            Console.WriteLine('\n' + "Для повторного ввода" + "набрать любую клавишу." + '\n' + "Для завершения програмы нажмите Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m1;

        }
    }
}
