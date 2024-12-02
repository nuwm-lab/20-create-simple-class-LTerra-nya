// на мові C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication1
{
    public class Circle
    {
        // Поле
        public int[] coordinates2d;
        public double radius;
        // Конструктор
        public Circle()
        {
            coordinates2d = [0,0];
            radius = 1;
        }

        // Методи
        public void SetCoordinates(int x, int y)
        {
            coordinates2d[0] = x;
            coordinates2d[1] = y;
        }

        public void SetRadius(double x)
        {
            radius = x;
        }

        public void GiveArea() {
            Console.WriteLine(3.14 * (radius*radius));
        }
    }
    class TestPerson
    {
        static void Main()
        {
            Circle test = new Circle();
            Console.WriteLine(test.coordinates2d[0] + " " + test.coordinates2d[1]);
            Console.WriteLine(test.radius);

            // Задаємо координати
            test.SetCoordinates(1,1);
            // Задаємо радіус
            test.SetRadius(2.5);

            Console.WriteLine(test.coordinates2d[0] + " " + test.coordinates2d[1]);
            Console.WriteLine(test.radius);

            // Викликаємо метод для виводу площі.
            test.GiveArea();
            test.SetCoordinates(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            test.SetRadius(double.Parse(Console.ReadLine()));
            Console.WriteLine(test.coordinates2d[0] + " " + test.coordinates2d[1]);
            Console.WriteLine(test.radius);
            // Чекати на нажаття будь-якої клавіші.

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
