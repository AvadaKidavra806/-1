using System;
using System.Linq;
using System.Text;
//Metodu org = new Metodu(); org.Artem();
public class Metodu
{
    public void Artem()
    {
        Console.WriteLine("Практическая работа. Методы.");
        byte NomerZadaniy; bool NomerZadaniyOut;
        while (true)
        {
            Console.Write("Введите номер задания: ");
            NomerZadaniy = 1; NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");/*
                else if (NomerZadaniy <= 0 || NomerZadaniy > 15)
                    Console.Write("В дз всего 15 заданий, Введите номер задания еще раз ");*/
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
            {
                case 1: n1(); break;//доделaть
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;/*
                case 5: n5(); break;/*
                case 6: n6(); break;/*
                case 7: n7(); break;/*
                case 8: n8(); break;/*
                case 9: n9(); break;/*
                case 10: n10(); break;/*
                case 11: n11(); break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            ConsoleKey Klavisha;
            Console.WriteLine("Для выбора след задания нажмите Y, Для завершения программы N (Y or N)");
            do
            {
                Klavisha = Console.ReadKey(true).Key;
            }
            while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
            if (Klavisha == ConsoleKey.N)
                break;
        }
        void n1()
        {
            int a;
            int b;
            int c;
            while (true)
            {
                a = ReadPositiveInt("Введите первую сторону треугольника ");
                b = ReadPositiveInt("Введите вторую сторону треугольника ");
                c = ReadPositiveInt("Введите третью сторону треугольника ");

                if (CanTriangleExist(a, b, c))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Этот треугольник не существует! Повторите ввод.\n");
                }
            }
            Perimetrv(a, b, c);
            //int result = Perimetr(a, b, c);
            int ReadPositiveInt(string message)
            {
                while (true)
                {
                    Console.Write(message);
                    if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                    {
                        return value;
                    }
                    else
                    Console.WriteLine("Ошибка: сообщение передаёт не число или передаёт отрицательное значение. Попробуйте еще раз!");
                }
            }
        }
        void n2()
        {
            int a;
            int b;
            int c;
            while (true)
            {
                a = ReadPositiveInt("Введите первую сторону треугольника ");
                b = ReadPositiveInt("Введите вторую сторону треугольника ");
                c = ReadPositiveInt("Введите третью сторону треугольника ");

                if (CanTriangleExist(a, b, c))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Этот треугольник не существует! Повторите ввод.\n");
                }
            }
            //Perimetrv(a, b, c);
            int result = Perimetr(a, b, c);
            int ReadPositiveInt(string message)
            {
                while (true)
                {
                    Console.Write(message);
                    if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                    {
                        return value;
                    }
                    else
                        Console.WriteLine("Ошибка: сообщение передаёт не число или передаёт отрицательное значение. Попробуйте еще раз!");
                }
            }
        }
        void n3()
        {
           Console.WriteLine($"Число в степени: {Stp()}");
        }
        void n4()
        {
            Console.Write("Введите номер фигуры для вычисления (1 - круг, 2 - прямоугольник, 3 - треугольник): ");
            int fig = int.Parse(Console.ReadLine());
            switch(fig)
            {
                case 1:
                    {
                        double radius = ReadDouble("Введите радиус: ");
                        Console.WriteLine($"Площадь круга равна: {CalculateCircleArea(radius)}");
                    }
                    break;
                    case 2:
                    {
                        double length = ReadDouble("Введите длину прямоугольника: ");
                        double width = ReadDouble("Введите ширину прямоугольника: ");
                        Console.WriteLine($"Площадь прямоугольника равна: {CalculateRectangleArea(length, width)}");
                    }
                    break;
                case 3:
                    {
                        double baseLength = ReadDouble("Введите основание треугольника: ");
                        double heigth = ReadDouble("Введите высоту треугольника: ");
                        Console.WriteLine($"Площадь треугольника равна: {CalculateTriangleArea(baseLength, heigth)}");
                    }
                    break;
                default:
                    Console.WriteLine("Для таакой фигуры пока что не можем вычислить площадь!");
                    break;
            }
            double ReadDouble(string message)
            {
                while (true)
                {
                    Console.Write(message);
                    if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                    {
                        return value;
                    }
                    else
                    Console.WriteLine("Ошибка: сообщение не передаёт число или передаёт отрицательное значение. Попробуйте еще раз!");
                }
            }
        }
    }
    //=========

    int Perimetr(int a, int b, int c)
    {
        //Console.WriteLine($"Перимерт треугольника равен = {a + b + c}");
        return a + b + c;
    }
    void Perimetrv(int a, int b, int c)
    {
        Console.WriteLine($"Перимерт треугольника равен = {a + b + c}");
        //return a + b + c;
    }
    bool CanTriangleExist(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
    double Stp()
    {
        int num = ReadPositiveInt("Введите число ");
        int pow = ReadPositiveInt("Введите степень числа ");
        int ReadPositiveInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    return value;
                }
                else
                    Console.WriteLine("Ошибка: сообщение передаёт не число или передаёт отрицательное значение. Попробуйте еще раз!");
            }
        }
        double result = 1;
        for (int i = 0; i < pow; i++)
        {
            result *= num;
        }

        return result;
    }
    double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
    double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
