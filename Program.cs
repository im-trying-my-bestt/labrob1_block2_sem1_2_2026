using System;
using System.Globalization;
using System.Collections.Generic;
/*Описати клас, який містять вказані поля і методи.
Клас “круг” – TDisk
Поля  для зберігання радіуса;
 для зберігання центра кола

Методи  конструктор без параметрів, конструктор з параметрами, конструктор копіювання;

 override public string ToString();
 введення/виведення даних;
 визначення площі круга;
 перевірка належності точки кругу;
 перевантаження операторів * (множення радіуса на число, при збереженні координат
центра; забезпечити, щоб домноження могло відбуватися хоч як «число*круг», хоч як
«круг*число»).*/
namespace Lab1sem1block22026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            MainTask();
            AdditionalTask();
        }
        static void MainTask()
        {
            //TDisk
            Console.WriteLine("_____________ КРУГ _____________");

            TDisk disk = new TDisk();

            disk.Input();

            Console.WriteLine($"\nПлоща круга: {disk.GetArea():F5}");

            Console.WriteLine($"\nЧи належить точка кругу.");

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

            Console.Write("\nВведіть число, на яке помножити радіус: ");
            double number = double.Parse(Console.ReadLine());

            TDisk newDisk = disk * number;

            Console.WriteLine("\nКруг після множення:");
            newDisk.Output();


            //TBall

            Console.WriteLine("\n_____________ КУЛЯ _____________");

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

        // Додаткове завдання: Equals та GetHashCode
        static void AdditionalTask()
        {
            Console.WriteLine("\n\nДОДАТКОВЕ ЗАВДАННЯ");

            //Пункт 2: HashSet<TDisk>
            Console.WriteLine("\n_____________ HashSet<TDisk> _____________");

            HashSet<TDisk> diskSet = new HashSet<TDisk>();
            TDisk disk = new TDisk(2, 1, 1);
            diskSet.Add(disk);

            TDisk sameDisk = new TDisk(2, 1, 1);

            if (diskSet.Contains(sameDisk))
                Console.WriteLine("Такий елемент знайдено.");
            else
                Console.WriteLine("Такий елемент не знайдено.");

            //Пункт 3: HashSet<TDiskF>
            Console.WriteLine("\n_____________ HashSet<TDiskF> _____________");

            HashSet<TDiskF> diskFSet = new HashSet<TDiskF>();
            TDiskF diskF = new TDiskF(2, 1, 1);
            diskFSet.Add(diskF);

            TDiskF sameDiskF = new TDiskF(2, 1, 1);

            if (diskFSet.Contains(sameDiskF))
                Console.WriteLine("Такий елемент знайдено.");
            else
                Console.WriteLine("Такий елемент не знайдено.");

            //Пункт 5: HashSet<TBall>
            Console.WriteLine("\n_____________ HashSet<TBall> _____________");

            HashSet<TBall> ballSet = new HashSet<TBall>();
            for (int i = 1; i <= 5; i++)
            {
                ballSet.Add(new TBall(3, 1, 2, i));
            }
            Console.WriteLine($"Кількість елементів у HashSet: {ballSet.Count}");

            //Пункт 6: HashSet<TBallF>
            Console.WriteLine("\n_____________ HashSet<TBallF> _____________");

            HashSet<TBallF> ballFSet = new HashSet<TBallF>();
            for (int i = 1; i <= 5; i++)
            {
                ballFSet.Add(new TBallF(3, 1, 2, i));
            }
            Console.WriteLine($"Кількість елементів у HashSet: {ballFSet.Count}");

            Console.WriteLine("\nЕлементи HashSet<TBallF>:");
            foreach (TBallF b in ballFSet)
            {
                b.Output();
            }
        }
    }

}