using Tyuiu.AndreevIA.Sprint1.Task2.V21.Lib;

namespace Tyuiu.AndreevIA.Sprint1.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Андреев И. А. | РППб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема. Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины стороны прямоугольника. Вычислить площадь прямоугольника *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Длина первой стороны прямоугольника (целое число):");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Длина второй стороны прямоугольника (целое число):");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь прямоугольника (целое число): " + ds.CalculateRectangleSquare(x,y));

            Console.ReadLine();
        }
    }
}