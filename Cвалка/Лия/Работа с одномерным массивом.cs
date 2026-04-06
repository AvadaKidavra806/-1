using Dvumerny_massiv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Qwerty.Zadaniy fg = new Qwerty.Zadaniy(); fg.Nomer();
namespace Qwerty
{
    public class Zadaniy
    {
        public void Nomer()
        {
            Console.WriteLine("Работа с одномерным массивом");
            Console.Write("Введите номер задания: ");
            byte nomerzadaniy = 1; bool outnomerzadaniy = true;
            while (outnomerzadaniy)
            {
                if (!byte.TryParse(Console.ReadLine(), out nomerzadaniy))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (nomerzadaniy <= 0 || nomerzadaniy > 10)
                    Console.Write("Всего 10 заданий, Введите номер задания еще раз ");
                else
                    outnomerzadaniy = false;
            }
            switch (nomerzadaniy)
            {
                case 1:
                    n1();
                    break;
                case 2:
                    n2();
                    break;
                case 3:
                    n3();
                    break;
                case 4:
                    n4();
                    break;
                case 5:
                    n5();
                    break;/*
                case 6:
                    n6();
                    break;
                case 7:
                    n7();
                    break;
                case 8:
                    n8();
                    break;
                case 9:
                    n9();
                    break;
                case 10:
                    n10();
                    break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void n1()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 1; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        outkolvoelements = false;
                }
                double[] massiv = new double[kolvoelements];
                Random random = new Random();
                for (int i = 0; i < kolvoelements; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                    //massiv[i] = random.Next(-50, 100);
                }
                Console.WriteLine("Массив: "+String.Join("; ", massiv));
                //=======================
                Console.Write("Введите индекс элемента, который необходимо вывести ");
                int index = 0; byte outindex = 0;
                while (outindex == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out index))
                        Console.Write("Ошибка! Введите индекс элемента еще раз ");
                    else if (index < 0 || index > kolvoelements - 1)
                        Console.Write($"Индекс элемента не может быть отрицательным и больше чем {kolvoelements-1}. Введите индекс элемента еще раз "); 
                    else
                        outindex++;
                }
                Console.WriteLine($"Элемент с индексом {index}: " + massiv[index]);
            }
            void n2()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 1; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        outkolvoelements = false;
                }
                int[] massiv = new int[kolvoelements];
                Random random = new Random();
                int sum = 0; double sumkv = 0;
                for (int i = 0; i < kolvoelements; i++)
                {
                    //massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                    massiv[i] = random.Next(-50, 100);
                    sum += massiv[i];
                    sumkv += Math.Pow(massiv[i], 2);
                }
                Console.WriteLine("Массив: " + String.Join(", ", massiv));
                //===================
                if (sum % 2 == 0 && sum != 0)
                    Console.WriteLine($"a)Верно, что сумма элементов массива четное число ({sum})");
                else
                    Console.WriteLine($"a)Неверно, что сумма элементов массива четное число ({sum})");
                //======================
                if (sumkv.ToString().Length == 5)
                    Console.WriteLine($"б) Сумма квадратов элементов массива пятизначное число ({sumkv})");
                else
                    Console.WriteLine($"б) Сумма квадратов элементов массива не пятизначное число ({sumkv})");
            }
            void n3()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 1; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        outkolvoelements = false;
                }
                double[] massiv = new double[kolvoelements];
                Random random = new Random();
                for (int i = 0; i < kolvoelements; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                    //massiv[i] = random.Next(-50, 100);
                }
                Console.WriteLine("Первоначальный массив: " + String.Join("; ", massiv));
                for (int i = 0; i < kolvoelements; i++)
                {
                    if (massiv[i] > 10)
                        massiv[i] = Math.Round(Math.Sqrt(massiv[i]), 3);
                    if ((i + 1) % 2 == 0)
                        massiv[i] = Math.Abs(massiv[i]);
                }
                Console.WriteLine("Измененный массив: " + String.Join("; ", massiv));
            }
            void n4()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 1; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        outkolvoelements = false;
                }
                int[] massiv = new int[kolvoelements];
                Random random = new Random();
                int kolvootr = 0, kolvopol = 0, kolvochet = 0, kolov5 = 0; 
                for (int i = 0; i < kolvoelements; i++)
                {
                    //massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                    massiv[i] = random.Next(-50, 100);
                    if (massiv[i] < 0)
                        kolvootr++;
                    if (massiv[i] > 0)
                        kolvopol++;
                    if (massiv[i] % 2 == 0 && massiv[i] != 0)
                        kolvochet++;
                    if (Math.Abs(massiv[i] % 10)  == 5)
                        kolov5++;
                }
                //Console.WriteLine("Все элементы на конце 5: " + String.Join(", ", Array.FindAll(massiv, f => Math.Abs(f % 10 )== 5)));
                Console.WriteLine("Массив: " + String.Join(", ", massiv));
                Console.WriteLine($"Кол-во отрицательных - {kolvootr}, положительных - {kolvopol}, четных - {kolvochet}, оканчивающихся на 5 - {kolov5} элементов массива");
            }
            void n5()
            { 
            
            }
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}