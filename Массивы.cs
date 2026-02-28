using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_19._01._26__обработка_массивов__Юшина_и_Ильенко
{
    internal class Program
    {
        static void Main()
        {
            void n1()
            {
                Console.Write("Задание 1");
                double[] mas1 = new double[10];
                Random rnd1 = new Random();
                Console.Write("\nНаш массив: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd1.Next(-100, 101);
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i]}.");
                    else
                        Console.Write($"{mas1[i]}, ");
                }
                //=============
                Console.Write("\nВведите номер элемента, для которого надо вычислить квадратный корень: ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || a > 10 || a <= 0)
                {
                    if (a > 10)
                        Console.Write("error. Номер элемента не может быть больше чем длина массива(10) \nВведите номер элемента, для которого надо вычислить квадратный корень еще раз ");
                    else
                        Console.Write("Ошибка. Введите номер элемента еще раз ");
                }
                if (mas1[a - 1] >= 0)
                {
                    Console.WriteLine($"Квадратный корень из элемента номер {a} равен: {Math.Round(Math.Sqrt(mas1[a - 1]), 3)} ");
                }
                else Console.WriteLine("Невозможно вычислить квадратный корень из данного элемента, так как он отрицательный ");
                //===========================
                Console.Write("Введите первый номер элемента, для которого надо вычислить среднее арифметическое: ");
                int a1;
                while (!int.TryParse(Console.ReadLine(), out a1) || a1 > 10 || a <= 0)
                {
                    if (a1 > 10)
                        Console.Write("error. Номер элемента не может быть больше чем длина массива(10) \nВведите первый номер элемента, для которого надо вычислить среднее арифметическое еще раз ");
                    else
                        Console.Write("Ошибка. Введите номер элемента еще раз ");
                }
                Console.Write("Введите второй номер элемента, для которого надо вычислить среднее арифметическое: ");
                int a2;
                while (!int.TryParse(Console.ReadLine(), out a2) || a2 > 10 || a <= 0)
                {
                    if (a2 > 10)
                        Console.Write("error. Номер элемента не может быть больше чем длина массива(10) \nВведите номер элемента, для которого надо вычислить среднее арифметическое ");
                    else
                        Console.Write("Ошибка. Введите номер элемента еще раз ");
                }
                double result = (mas1[a1 - 1] + mas1[a2 - 1]) / 2.0;
                Console.WriteLine("Среднее арифметическое этих элементов = " + result);
                //==================================================
            }
            //n1();
            void n2()
            {
                Console.Write("Задание 2");
                double[] mas1 = new double[10];
                Random rnd1 = new Random();
                Console.Write("\nНаш массив: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd1.Next(-1, 1);
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i]}.");
                    else
                        Console.Write($"{mas1[i]}, ");
                }

                Console.Write("\nВведите номер элемента, для которого надо вычислить положительность: ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || a > 10 || a <= 0)
                {
                    if (a > 10)
                        Console.Write("error. Номер элемента не может быть больше чем длина массива(10) \nВведите номер элемента, для которого надо вычислить положительность еще раз ");
                    else
                        Console.Write("Ошибка. Введите номер элемента еще раз ");
                }
                if (mas1[a - 1] > 0)
                    Console.Write($"Элемент массива под номером {a} положительный ");
                else
                    Console.Write($"Элемент массива под номером {a} неположительный ");
                //==============================
                Console.Write("\nВведите номер элемента, для которого надо вычислить четность: ");
                int k;
                while (!int.TryParse(Console.ReadLine(), out k) || k > 10 || k <= 0)
                {
                    if (k > 10)
                        Console.Write("error. Номер элемента не может быть больше чем длина массива(10) \nВведите номер элемента, для которого надо вычислить положительность еще раз ");
                    else
                        Console.Write("Ошибка. Введите номер элемента еще раз ");
                }
                if (mas1[k - 1] % 2 == 0 && mas1[k - 1] != 0)
                    Console.WriteLine($"Элемент массива под номером {k} четный ");
                else if (mas1[k - 1] == 0)
                    Console.WriteLine($"Элемент массива под номером {k} равен 0, для которого невозможно определить четность");
                else
                    Console.WriteLine($"Элемент массива под номером {k} нечетный ");
                //====================================
                if (mas1[a - 1] > mas1[k - 1])
                    Console.WriteLine($"Элемент под номером {a} больше чем элемент под номером {k} ");
                else if (mas1[a] == mas1[k])
                    Console.WriteLine($"Элемент под номером {a} равен элементу под номером {k} ");
                else
                    Console.WriteLine($"Элемент под номером {a} меньше чем элемент под номером {k} ");
            }
            //n2();
            void n3()
            {
                Console.Write("Задание 3");
                double[] mas1 = new double[10];
                Random rnd1 = new Random();
                Console.Write("\nНаш массив: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd1.Next(-100, 101);
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i]}.");
                    else
                        Console.Write($"{mas1[i]}, ");
                }
                //=====================================
                Console.Write("\nВсе элементы увеличены в 2 раза: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    //mas1[i] = mas1[i] * 2;
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i] * 2}.");
                    else
                        Console.Write($"{mas1[i] * 2}, ");
                }
                //=======================================
                int a;
                Console.Write("\nВведите число A (на сколько уменьшаем) ");
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.Write("Ошбка! Введите число А еще раз ");
                Console.Write($"Все элементы уменьшены на {a}: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    //mas1[i] = mas1[i] - a;
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i] - a}.");
                    else
                        Console.Write($"{mas1[i] - a}, ");
                }
                //===============================================
                if (mas1[0] == 0)
                    Console.WriteLine("\nПервый элемент массива равен 0, а на 0 делить нельзя ");
                else
                    Console.Write($"\nВсе элементы поделены на первый элемент: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    //mas1[i] = mas1[i] % mas1[0];
                    if (i == mas1.Length - 1)
                        Console.Write($"{Math.Round(mas1[i] / mas1[0], 3)}.");
                    else
                        Console.Write($"{Math.Round(mas1[i] / mas1[0], 3)}, ");
                }
                Console.WriteLine();
            }
            //n3();
            void n4()
            {
                Console.Write("Задание 4");
                double[] mas1 = new double[10];
                Random rnd1 = new Random();
                Console.Write("\nНаш массив: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd1.Next(-100, 101);
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i]}.");
                    else
                        Console.Write($"{mas1[i]}, ");
                }
                //=====================================
                Console.Write("\nВсе элементы уменьшены на 20: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i] - 20}.");
                    else
                        Console.Write($"{mas1[i] - 20}, ");
                }
                //=======================================
                Console.Write($"\nВсе элементы умножены на последний элемент: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i] * mas1[mas1.Length - 1]}.");
                    else
                        Console.Write($"{mas1[i] * mas1[mas1.Length - 1]}, ");
                }
                //===============================================
                int a;
                Console.Write("\nВведите число B (на сколько увеличиваем) ");
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.Write("Ошбка! Введите число В еще раз ");
                Console.Write($"Все элементы увеличены на {a}: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i] + a}.");
                    else
                        Console.Write($"{mas1[i] + a}, ");
                }
                Console.WriteLine();
            }
            //n4();
            void n5()
            {
                Console.Write("Задание 5");
                int [] mas1 = new int [10];
                Random rnd1 = new Random();
                Console.Write("\nНаш массив: ");
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd1.Next(-100, 101);
                    if (i == mas1.Length - 1)
                        Console.Write($"{mas1[i]}.");
                    else
                        Console.Write($"{mas1[i]}, ");
                }
                //=====================================
                int sum = 0, sumk = 0, sum6 = 0; double sred = 0, pro = 1;
                for (int i = 0; i <mas1.Length; i++)
                {
                    sum += mas1[i];
                    pro *= mas1[i];
                    sumk += (int)Math.Pow(mas1[i], 2);
                    if (i < 6)
                        sum6 += mas1[i];
                    sred = sum / mas1.Length;
                }
                Console.WriteLine($"\nСумма всех элементов массива: {sum}");
                Console.WriteLine($"Произведение всех элементов массива: {pro}");
                Console.WriteLine($"Сумма квадраов всех элементов массива: {sumk}");
                Console.WriteLine($"Среднее арифметическое всех элементов массива: {sred}\n");
                //==============================
                int k1, k2;
                Console.Write("Введите k1-й элемент массива ");
                while (!int.TryParse(Console.ReadLine(), out k1) || k1 <= 0 || k1 > mas1.Length)
                {
                    if (k1 <= 0 || k1 > mas1.Length)
                        Console.Write($"Ошибка! Номер элемента не может выходить за рамки длины массива\nВведите k1 еще раз ");
                    else
                        Console.Write($"Ошибка! Введите k1 еще раз ");
                }
                //=========================
                Console.Write("Введите k2-й элемент массива ");
                while (!int.TryParse(Console.ReadLine(), out k1) || k1 <= 0 || k1 > mas1.Length)
                {
                    if (k1 <= 0 || k1 > mas1.Length)
                        Console.Write($"Ошибка! Номер элемента не может выходить за рамки длины массива\nВведите k2 еще раз ");
                    else
                        Console.Write($"Ошибка! Введите k2 еще раз ");
                }


            }
            n5();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
