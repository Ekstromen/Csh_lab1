using System;


public class Methods
{
    public static double A(double x, double y)
    {
        return (Math.Sqrt(Math.Abs(x - 1) - Math.Sqrt(Math.Abs(y)))) / 1 + (Math.Pow(x, 2) / 2) + (Math.Pow(y, 2) / 4);
    }

    public static double B(double x, double z)
    {
        return Math.Pow(x, 3) * ((Math.Pow(Math.Atan(z), 3)) + Math.Exp(1));
    }

    public static double Square(int r, int R)
    {
        return Math.PI * (R - r);
    }

    public static double sqrt(double x1)
    {
        return Math.Sqrt(7 - (5 * x1));
    }

    public static int Perimeter(int a1, int b1, int c1)
    {
        return a1 + b1 + c1;
    }

    public static double SquareTri(int a1, int b1, int c1)
    {
        double p;
        p = (a1 + b1 + c1) / 2;
        return Math.Sqrt((p * (p - a1) * (p - b1) * (p - c1)));
    }

    public static double angle(int a1, int b1, int c1)
    {
        return Math.Acos((a1 * a1 + b1 * b1 - c1 * c1) / (2 * a1 * b1));
    }
}

public struct Truck
{
    double max_weight;//максимальный вес груза
    double max_speed;//максимальная скорость
    double turning_radius;//радиус поворота
    public void Print()
    {
        Console.WriteLine($"Максимальный вес груза: {max_weight} кг\nМаксимальная скорость: {max_speed} км/ч\nРадиус поворота: {turning_radius} м");
    }
    public void set_max_weight(double max_weight)
    {
        this.max_weight = max_weight;
    }
    public void set_max_speed(double max_speed)
    {
        this.max_speed = max_speed;
    }
    public void set_turning_radius(double turning_radius)
    {
        this.turning_radius = turning_radius;
    }
}

namespace FirstLab
{
    internal class program
    {

        public static void Main()
        {
            double x, x1, y, z;
            double a, b;
            int r = 20, R, a1, b1, c1, p;
            while (true)
            {
                Console.WriteLine("Выберите действие:\n1)Задание 1.1\n2)Задание 1.2\n3)Задание 1.3\n4)Задание 1.4\n5)Задание 2");
                int choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Задание 1.");
                        Console.WriteLine("Введите X, Y, Z.");
                        Console.WriteLine();
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вы ввели X: " + x);
                        Console.WriteLine();
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вы ввели Y: " + y);
                        Console.WriteLine();
                        z = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вы ввели Z: " + z);
                        Console.WriteLine();
                        Console.WriteLine("А = " + Methods.A(x, y));
                        Console.WriteLine("B = " + Methods.B(x, z));
                        break;

                    case 2:
                        Console.WriteLine("Задание 2. Расчет площади.");
                        R = Convert.ToInt16(Console.ReadLine());
                        if (R > 20)
                        {
                            Console.WriteLine("Вы ввели R: " + R);
                            Console.WriteLine("Square = " + Methods.Square(r, R));
                        }
                        else Console.WriteLine("Значение не соответствует условию R>20!");
                        break;

                    case 3:
                        Console.WriteLine("Задание 3.");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вы ввели X: " + x1);
                        Console.WriteLine("sqrt = " + Methods.sqrt(x1));
                        break;

                    case 4:
                        Console.WriteLine("Задание 4.");
                        a1 = Convert.ToInt16(Console.ReadLine());
                        b1 = Convert.ToInt16(Console.ReadLine());
                        c1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"Вы ввели стороны треугольника: {a1}, {b1}, {c1}");
                        Console.WriteLine("Введите р");
                        p = Convert.ToInt16(Console.ReadLine());
                        if (a1 + b1 > c1 && a1 + c1 > b1 && c1 + b1 > a1)
                        {
                            if (p == 1)
                            {
                                Console.WriteLine("Вы выбрали 1.");
                                Console.WriteLine("Perimeter = " + Methods.Perimeter(a1, b1, c1));
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("Вы выбрали 2.");
                                Console.WriteLine("Square = " + Methods.SquareTri(a1, b1, c1));
                            }
                            else if (p == 3)
                            {
                                Console.WriteLine("Вы выбрали 3.");
                                Console.WriteLine("Angle = " + Methods.angle(a1, b1, c1));
                            }
                            else Console.WriteLine("треугольник");
                        }
                        break;

                    case 5:
                        double max_weight;//максимальный вес груза
                        double max_speed;//максимальная скорость
                        double turning_radius;//радиус поворота
                        Truck A = new Truck();
                        Console.WriteLine("Укажите максимальный вес груза: ");
                        max_weight = Convert.ToDouble(Console.ReadLine());
                        A.set_max_weight(max_weight);
                        Console.WriteLine("Укажите максимальную скорость: ");
                        max_speed = Convert.ToDouble(Console.ReadLine());
                        A.set_max_speed(max_speed);
                        Console.WriteLine("Укажите радиус разворота в метрах: ");
                        turning_radius = Convert.ToDouble(Console.ReadLine());
                        A.set_turning_radius(turning_radius);
                        A.Print();
                        break;
                    case 6:
                        while (Console.ReadKey().Key != ConsoleKey.Escape) { }
                        break;
                }
            }
        }
    }
}