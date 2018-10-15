using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapeMaster;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберете тип фигуры");
                string[] names = Enum.GetNames(typeof(ShapeType));
                for (int i = 0; i < names.Length; i++) Console.WriteLine(names[i] + " = " + (i));
                int res;
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }
                ShapeType type = (ShapeType)res;
                Shape shape;
                switch (type)
                {
                    case ShapeType.circle:
                        Console.WriteLine("Введите диаметр круга:");
                        try
                        {
                            shape = new CircleShape(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("Площадь круга равна: " + shape.S);
                        }
                        catch
                        {
                            Console.WriteLine("Введите число!");
                            continue;
                        }
                        break;
                    case ShapeType.triangle:
                        Console.WriteLine("Введите длины сторон:");
                        try
                        {
                            Console.WriteLine("Введите длину стороны a:");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину стороны b:");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину стороны c:");
                            double c = Convert.ToDouble(Console.ReadLine());
                            shape = new TriangleShape(a, b, c);
                            Console.WriteLine("Площадь треугольника равна: " + shape.S);
                        }
                        catch
                        {
                            Console.WriteLine("Введите число!");
                            continue;
                        }
                        break;
                }
            }
        }
    }
}
