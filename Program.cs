using System;
using System.Globalization;

namespace Lab1sem1block22026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            //TDisk

            TDisk disk = new TDisk();

            disk.Input();

            Console.WriteLine($"\nПлоща круга: {disk.GetArea():F5}");

            Console.Write("\nВведіть координату X точки для перевірки: ");
            double pointX = double.Parse(Console.ReadLine());

            Console.Write("Введіть координату Y точки для перевірки: ");
            double pointY = double.Parse(Console.ReadLine());

            if (disk.IsInside(pointX, pointY))
                Console.WriteLine("Точка знаходиться всередині круга.");
            else
                Console.WriteLine("Точка не знаходиться всередині круга.");

            Console.WriteLine("\nІнформація про круг:");
            disk.Output();


            //*

            Console.Write("\nВведіть число, на яке помножити радіус: ");
            double number = double.Parse(Console.ReadLine());

            TDisk newDisk = disk * number;

            Console.WriteLine("\nКруг після множення:");
            newDisk.Output();


            //TBall

            Console.WriteLine("\n========== КУЛЯ ==========");

            TBall ball = new TBall();

            ball.Input();

            Console.WriteLine($"\nОб'єм кулі: {ball.GetVolume():F5}");

            Console.WriteLine("\nІнформація про кулю:");
            ball.Output();


            //Конструктор копіювання
            TBall copyBall = new TBall(ball);

            Console.WriteLine("\nКопія кулі:");
            copyBall.Output();
        }
    }
}