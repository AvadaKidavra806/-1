using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Поиск_максимума_и_минимума_2._2._2026
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите номер задания: ");
            byte a1 = 1, b1 = 0;
            while (b1 == 0)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (a1 <= 0 || a1 > 8)
                    Console.Write("В дз всего 8 заданий, Введите номер задания еще раз ");
                else
                    b1++;

            }
            void n1()
            {
                Console.Write("Введите кол-во элементов массива ");
                int a = 1; byte c = 0;
                while (c == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (a <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        c++;

                }
                double[] massiv = new double[a];
                Random random = new Random();
                Console.Write("Начальный массив: ");
                double min = double.MaxValue, max = double.MinValue, del;
                for (int i = 0; i < a; i++)
                {
                    //massiv[i] = random.NextDouble() * 150 - 50;
                    massiv[i] = random.Next(-50, 100);
                    Console.Write($"{Math.Round(massiv[i], 3)}; ");
                    if (massiv[i] <= min)
                        min = massiv[i];
                    if (massiv[i] >= max)
                        max = massiv[i];
                }
                del = max - min;
                Console.Write($"\nМаксимальный элемент: {Math.Round(max, 3)}\nМинимальный элемент: {Math.Round(min, 3)}\nМин элемент меньше макс на: {Math.Round(del, 3)}\nИндекс(ы) мин элемента(тов): ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] == min)
                        Console.Write($"{i} ");
                }
                Console.Write("\nИндекс(ы) макс элемента(тов): ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] == max)
                        Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            void n2()
            {
                Console.WriteLine("В массиве хранится информация о стоимости каждой из 50 марок легковых автомобилей:");
                double[] massiv = new double[50];
                Random random = new Random();
                double max = 0;
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() * 50000000;
                    Console.WriteLine($"{i + 1}\t{Math.Round(massiv[i], 3)}");
                    if (massiv[i] > max)
                        max = massiv[i];
                }
                Console.WriteLine($"Самый дорогой автомобиль стоит: {Math.Round(max, 3)} ");
            }
            void n3()
            {
                Console.WriteLine("В массиве хранится информация о стоимости 1 кг 20 видов конфет: ");
                double[] massiv = new double[20];
                Random random = new Random();
                double min = 1001; int s = 0;
                for (int i = 0; i < massiv.Length; i++)
                {
                    
                    massiv[i] = random.NextDouble() * 1000;
                    //massiv[i] = random.Next(10);
                    Console.WriteLine($"{i + 1}\t{Math.Round(massiv[i], 3)}");
                    if (massiv[i] < min)
                        min = massiv[i];
                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] == min)
                        s++;
                }
                if (s == 1)
                    Console.WriteLine($"Самый дешевый вид только один, его стоимость: {Math.Round(min, 3)}; его номер: {Array.FindIndex(massiv, n => n == min) + 1}");
                else
                {
                    Console.WriteLine($"Самые дешевые виды стоят: {Math.Round(min, 3)}");
                    Console.WriteLine($"Первый номер минимального элемента: {Array.FindIndex(massiv, n => n == min) + 1}");
                    Console.WriteLine($"Последний номер минимального элемента: {Array.FindLastIndex(massiv, n => n == min) + 1}");
                }
            }
            void n4()
            {
                Console.WriteLine("В массиве хранится информация о результатах 25 спортсменов, участвовавших в лыжной гонке ");
                double[] massiv = new double[25];
                Random random = new Random(); double min = double.MaxValue;byte s = 0;
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() * 200 +200;
                    //massiv[i] = random.Next(10);
                    Console.WriteLine($"{i + 1}\t{Math.Round(massiv[i], 4)} мин");
                    if (massiv[i] < min)
                        min = massiv[i];
                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] == min)
                        s++;
                }
                if (s == 1)
                    Console.WriteLine($"Результат победителя гонки: {Math.Round(min, 4)}; его номер: {Array.FindIndex(massiv, n => n == min) + 1}");
                else
                    Console.WriteLine($"Самый лучший результат имеют сразу несколько человек, их результат: {Math.Round(min, 4)}");
            }
            void n5() 
            {
                Console.WriteLine("В массиве хранится информация о росте 25 человек ");
                double[] massiv = new double[25];
                Random random = new Random(); double min = double.MaxValue, max = double.MinValue;
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() * 150 + 50;
                    //massiv[i] = random.Next(10);
                    Console.WriteLine($"{i + 1}\t{Math.Round(massiv[i], 2)} см");
                    if (massiv[i] < min)
                        min = massiv[i];
                    if (massiv[i]>max)
                        max = massiv[i];
                }
                Console.WriteLine($"Рост самого низкого: {Math.Round(min, 2)} ({Array.FindIndex(massiv, n => n == min)+1}) и самого высокого: {Math.Round(max, 2)} ({Array.FindIndex(massiv, n => n == max)+1}) отличается на {Math.Round(max - min, 2)}"); 
            }
            void n6()
            { 
                int[] godrosd = new int[30]; int min = int.MaxValue, max = int.MinValue, c = 0;
                Random random = new Random();
                for (int i = 0; i < godrosd.Length; i++)
                {
                    Console.WriteLine($"{i + 1}\t{godrosd[i] = random.Next(1930, 2026)}");
                    if (godrosd[i] < min)
                        min = godrosd[i];
                    if (godrosd[i] > max)
                        max = godrosd[i];
                }
                for (int i = 0; i < godrosd.Length; i++)
                {
                    if (godrosd[i]==min)
                        c++;
                }
                Console.WriteLine($"Возраст самого старшего человека превышает возраст самого молодого на {max - min}");
                if (c != 1)
                    Console.WriteLine($"Самых старших людей несколько, номер первого из них: {Array.FindIndex(godrosd, n => n == min)+1}, номер последнего из них: {Array.FindLastIndex(godrosd, n => n == min)+1}");
                else
                    Console.WriteLine($"Самый старший человек только один, его порядковый номер: {Array.FindIndex(godrosd, n => n == min) + 1}");
            }
            void n7()
            {
                byte a = 0; int  b = 0;
                Console.Write("Введите кол-во голосов судей ");
                while (a == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out b))
                        Console.Write("Ошибка! Введите кол-во голосов судей еще раз ");
                    else if (b <= 0)
                        Console.Write("Кол-во голосов судей должно быть положительным,\nВведите кол-во голосов судей еще раз ");
                    else if (b == 2 || b == 1)
                    {
                        Console.WriteLine("При количестве голосов равном 2 или 1, данных для вычисления недостаточно (макс и мин значение откидываем и среднее неисчего вычислять)");
                        return;
                    }
                    else
                        a = 1;
                }
                double[] ocenka = new double[b]; double max = double.MinValue, min = double.MaxValue;
                double sum = 0;
                for (int i = 0; i < b; i++)
                {
                    a = 0;
                    Console.Write($"Введите оценку {i + 1} судьи ");
                    while (a == 0)
                    {
                        if (!double.TryParse(Console.ReadLine(), out ocenka[i]))
                            Console.Write($"Ошибка! Введите оценку {i+1} судьи еще раз ");
                        else if (ocenka[i] < 0)
                            Console.Write($"Оценка судьи должна быть неотрицательной,\nВведите оценку {i+1} судьи еще раз ");
                        else
                            a = 1;
                    }
                    if (ocenka[i]>max)
                        max=ocenka[i];
                    if (ocenka[i]<min) 
                        min=ocenka[i];
                    sum += ocenka[i];
                }
                //
                //Console.WriteLine($"Мин: {min}, макс: {max}, sum: {sum}");
                Console.WriteLine($"Оценка, которая пойдет в зачет спортсмену: {(sum - max - min) / (b - 2)}");
            }
            void n8()
            {
                Console.Write($"Введите кол-во элементов массива: ");
                int a = 1; byte c = 0;
                while (c == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (a <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        c++;

                }
                int[] massiv = new int[a]; int max = int.MinValue, min = int.MaxValue, k = 0, s = 0;  
                Random random = new Random();
                for (int i = 0; i < massiv.Length; i++)
                {
                    Console.Write($"{massiv[i] = random.Next(-50, 100)}, ");
                    if (massiv[i] > max)
                        max = massiv[i];
                    if (massiv[i] < min)
                        min = massiv[i];
                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] == max)
                        k++;
                    if (massiv[i] == min)
                        s++;
                }
                Console.WriteLine($"\nКол-во минимальных элементов ({min}): {s}\nКол-во максимальных элементов ({max}): {k} ");
            }
            switch (a1)
            {
                case 1: n1 ();
                    break;
                case 2: n2 ();
                    break;
                case 3:  n3 ();
                    break;
                case 4: n4();
                    break;
                case 5: n5();
                    break;
                case 6: n6 ();
                    break;
                case 7: n7 ();
                    break;
                case 8: n8();
                    break;
                /*default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;*/
            }
            Console.Write("Для завершения программы нажмите любую клавишу ");
            Console.ReadKey();  
        }
    }
}
