using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класссворк_26._01._26__if_для_массивов_
{
    internal class Program
    {
        static void Main()
        {
            void клв1 ()
            {
                Console.WriteLine("Задание 1");
                Random random = new Random();
                Console.Write("Введите колво элементов массива ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                    Console.Write("Ошибка! Колво элементов введено не правильно, попробуйте еще раз ");
                int[] massiv = new int[a];
                Console.Write("Полученный массив: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (i != massiv.Length - 1)
                    {
                        massiv[i] = random.Next(-50, 151);
                        Console.Write($"{massiv[i]}; ");
                    }
                    else
                    {
                        massiv[i] = random.Next(-50, 151);
                        Console.Write($"{massiv[i]}.");
                    }
                }
                Console.Write("\nВсе неотрицательные элементы: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] >= 0)
                    {
                            Console.Write($"{massiv[i]}; ");
                    }
                }
                Console.Write("\nВсе элементы, не превышающие число 100: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] <= 100)
                    {
                        Console.Write($"{massiv[i]}; ");
                    }
                }
                Console.Write("\nВсе четные элементы: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] % 2 == 0 && massiv[i] != 0)
                        Console.Write($"{massiv[i]}; ");
                }
                Console.Write("\nВсе элементы, оканчивающиеся нулем: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                     if (massiv[i] % 10 == 0)
                    {
                        Console.Write($"{massiv[i]}; ");
                    }
                }
                Console.WriteLine();
            }
            //клв1();
            void клв2()
            {
                Console.WriteLine("Задание 2");
                Console.Write("Введите колво элементов массива ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                    Console.Write("Ошибка! Введите колво элементов еще раз ");
                Random random = new Random();
                int[] massiv = new int[a];
                Console.Write("Начальный массив: ");
                for (int i = 0; i< massiv.Length; i++)
                {
                    massiv[i] = random.Next(500);
                    Console.Write($"{massiv[i]}; ");
                }
                Console.Write("\nВсе двузначные числа: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((massiv[i] / 100) == 0 && massiv[i] != 0 && massiv[i]/10!=0)
                        Console.Write($"{massiv[i]}; "); 
                }
                Console.Write("\nВсе трехзначные числа: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((massiv[i] / 1000) == 0 && (massiv[i] / 100) != 0)
                        Console.Write($"{massiv[i]}; ");
                }
                Console.WriteLine();
            }
            //клв2();
            void клв3()
            {
                //Дан массив. Напечатать: а) второй, четвертый и т.д. элементы; 6) третий, шестой и т. д. элементы.
                Console.WriteLine("Задание №3");
                Random random = new Random();
                int a;
                Console.Write("Введите колво элементов массива ");
                while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                    Console.Write("Ошибка! Длина массива введена неправильно\nВведите длину массива еще раз ");
                double[] massiv = new double[a];
                Console.Write("Первоначальный массив: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() *100 -50;
                    if (i != massiv.Length-1)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                    else 
                        Console.Write($"{Math.Round(massiv[i], 3)}.");
                }
                Console.Write("\nЭлементы массива, номера которых кратны 2: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((i + 1) % 2 == 0)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                }
                Console.Write("\nЭлементы массива, номера которых кратны 3: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((i + 1) % 3 == 0)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                }
                Console.WriteLine();
            }
            //клв3();
            void клв4()
            {
                //. Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.
                Console.WriteLine("Задание №4");
                Random random = new Random();
                int a;
                Console.Write("Введите колво элементов массива ");
                while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                    Console.Write("Ошибка! Длина массива введена неправильно\nВведите длину массива еще раз ");
                double[] massiv = new double[a];
                Console.Write("Первоначальный массив: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() * 100 - 50;
                    if (i != massiv.Length - 1)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                    else
                        Console.Write($"{Math.Round(massiv[i], 3)}.");
                }
                Console.Write("\nНеотрицательные элементы массива: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] >= 0)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                }
                Console.Write("\nОтрицательные элементы массива: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] < 0)
                        Console.Write($"{Math.Round(massiv[i], 3)}; ");
                }
                Console.WriteLine();
            }
            //клв4();
            void клв5()
            {
                //5. Дан массив целых чисел. Вывести на экран сначала его четные элементы, затем нечетные.
                    Console.WriteLine("Задание №5");
                    Random random = new Random();
                    int a;
                    Console.Write("Введите колво элементов массива ");
                    while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                        Console.Write("Ошибка! Длина массива введена неправильно\nВведите длину массива еще раз ");
                    int [] massiv = new int [a];
                    Console.Write("Первоначальный массив: ");
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        massiv[i] = random.Next(-50, 151);
                        if (i != massiv.Length - 1)
                            Console.Write($"{massiv[i]}; ");
                        else
                            Console.Write($"{massiv[i]}.");
                    }
                    Console.Write("\nЧетные элементы массива: ");
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        if (massiv[i] % 2 == 0 && massiv[i]!=0) //исключи 0
                            Console.Write($"{massiv[i]}; ");
                    }
                    Console.Write("\nНечетные элементы массива: ");
                    for (int i = 0; i < massiv.Length; i++)
                    {
                    if (massiv[i] % 2 != 0 && massiv[i] != 0) //исключи 0
                        Console.Write($"{massiv[i]}; ");
                }
                    Console.WriteLine();
                
            }
            //клв5();
            void клв6()
            {
                //6. Дан массив целых чисел. Найти номера элементов, оканчивающихся цифрой 0 (известно, что такие элементы в массиве есть).
                Console.WriteLine("Задание №6");
                Random random = new Random();
                int a;
                Console.Write("Введите колво элементов массива ");
                while (!int.TryParse(Console.ReadLine(), out a) || a<=0)
                    Console.Write("Ошибка! Длина массива введена неправильно\nВведите длину массива еще раз ");
                int[] massiv = new int[a];
                Console.Write("Первоначальный массив: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.Next(-50, 151);
                    if (i != massiv.Length - 1)
                        Console.Write($"{massiv[i]}; ");
                    else
                        Console.Write($"{massiv[i]}.");
                }
                Console.Write("\nВсе номера элементов, оканчивающиеся нулем: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] % 10 == 0)
                    {
                        Console.Write($"{i+1}; ");
                    }
                }
                Console.WriteLine();
            }
            //клв6();
            void клв7()
            {
                //7. В массиве хранится информация о количестве осадков, выпавших за каждый день января. Определить, в какие числа месяца осадков не было.
                Console.WriteLine("Задание №7");
                Random random = new Random();
                double[] massiv = new double[31];
                Console.WriteLine("Кол-во осадков для каждого дня января: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    //massiv[i] = random.NextDouble() * 100;
                    massiv[i] = random.Next(10);
                    if (i != massiv.Length - 1)
                        Console.Write($"{i+1}\t {Math.Round(massiv[i], 3)}\n");
                    else
                        Console.Write($"{i+1}\t {Math.Round(massiv[i], 3)}.");
                }
                Console.Write("\nЧисла месяца, в которых не было осадков: ");
                for (int i = 0;i < massiv.Length; i++)
                {
                    if (massiv[i] == 0)
                        Console.Write($"{i}, ");
                }
                Console.WriteLine();
            }
            //клв7();
            void клв8 ()
            {
                //8. В массиве хранится информация о количестве побед, одержанных 20 футбольными командами.
                //Определить номера команд, имеющих меньше трех побед.
                int[] massiv = new int[20];
                Random random = new Random();
                Console.Write("Дальнейший список показывает колво побед футбольных команд, номер элемента соответствует номеру команды:\n");
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.Next(10);
                    if (i!=massiv.Length-1)
                        Console.Write($"{i+1}\t {massiv[i]}\n");
                    else
                        Console.Write($"{i+1}\t {massiv[i]}."); 
                }
                Console.Write("\nНомера команд, имеющих меньше трех побед: ");
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] < 3)
                        Console.Write($"{i + 1}, ");
                }
                Console.WriteLine();
            }
            клв8();
            Console.Write("Для завершения программы нажмите любую кнопку ");
            Console.ReadKey(); 
        }
    }
}
