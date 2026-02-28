using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Изменение_исходного_массива
{
    public class Изменение_исходного_массива
    {
        public void Номера()
        {
            Console.Write("Введите номер задания: ");
            byte a1 = 1, b1 = 0;
            while (b1 == 0)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (a1 <= 0 || a1 > 5)
                    Console.Write("В дз всего 5 заданий, Введите номер задания еще раз ");
                else
                    b1++;
            }
            switch (a1)
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
                    break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
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
                    else if (a < 5)
                        Console.Write("Ошибка! При таком кол-ве элементов массива невозможно поменять 2-й и 5-й элементы местами\nВведите кол-во элементов еще раз ");
                    else
                        c++;

                }
                double[] massiv = new double[a];
                Random random = new Random();
                Console.Write("Начальный массив: ");
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round( random.NextDouble() * 150 - 50, 3);
                    //massiv[i] = random.Next(-50, 100);
                }
                Console.WriteLine(string.Join("; ", massiv));
                Console.WriteLine("a) Поменяны местами 2-й и 5-й элементы: ");
                double hellp = massiv[1];
                massiv[1] = massiv[4];
                massiv[4] = hellp;
                Console.WriteLine(string.Join("; ", massiv));
                //=========================
                Console.WriteLine("Поменять местами m-й и n-й элементы массива");
                Console.Write("Введите число m ");
                int m = 1; byte outm = 0;
                while (outm == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out m))
                        Console.Write("Ошибка! Введите m еще раз ");
                    else if (m <= 0 || m > a)
                        Console.Write("Число m не может быть неположительным и больше, чем кол-во элементов\nВведите m еще раз ");
                    else
                        outm++;
                }
                Console.Write("Введите число n ");
                int n = 1; byte outn = 0;
                while (outn == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                        Console.Write("Ошибка! Введите n еще раз ");
                    else if (n <= 0 || n > a)
                        Console.Write("Число n не может быть неположительным и больше, чем кол-во элементов\nВведите n еще раз ");
                    else
                        outn++;
                }
                double hellp1 = massiv[m-1];
                massiv[m-1] = massiv[n-1];
                massiv[n-1] = hellp1;
                Console.WriteLine($"б) Поменяны местами {m}-й и {n}-й элементы: "+string.Join("; ", massiv));
                //==============================
                int maxind = Array.FindIndex(massiv, f => f == massiv.Max()); 
                double hellp2 = massiv[2];
                massiv[2] = massiv[maxind];
                massiv[maxind] = hellp2;
                Console.WriteLine("в) 3 и макс элементы поменяны местами: " + string.Join("; ", massiv));
                //===============================
                int minind = Array.FindLastIndex(massiv, f => f == massiv.Min());
                double hellp3 = massiv[0];
                massiv[0] = massiv[minind];
                massiv[minind] = hellp3;
                Console.WriteLine("г) 1 и мин элементы поменяны местами: " + string.Join("; ", massiv));
            }
            void n2 ()
            {
                Console.Write("Введите кол-во элементов массива (должно быть четным!) ");
                int kolvoElenents = 0; bool outkolvoElements = true;
                while (outkolvoElements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoElenents))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents % 2 != 0)
                        Console.Write("Кол-во элементов массива ДОЛЖНО БЫТЬ ЧЕТНЫМ. Введите кол-во элементов массива еще раз ");
                    else 
                        outkolvoElements = false;
                }
                //Console.WriteLine("Длин массива: " + kolvoElenents);
                double [] massiv = new double[kolvoElenents];
                Random random = new Random();
                for (int i = 0; i < kolvoElenents; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //==========================
                double hellp;
                for (int i = 0; i < kolvoElenents/2; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[(kolvoElenents/2)+i];
                    massiv[(kolvoElenents/2)+i] = hellp;
                }
                Console.WriteLine("а) Поменяны местами половины массива: "+string.Join("; ", massiv));
                //==========================
                for (int i = 0; i < kolvoElenents; i+=2)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[i+1];
                    massiv[i+1] = hellp;
                }
                Console.WriteLine("б) Поменяны местами первый со вторым, третий с четвертым и т.д.: " + string.Join("; ", massiv));
                //==========================
                for (int i = 0; i < kolvoElenents / 2; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[kolvoElenents - i -1];
                    massiv[kolvoElenents - i - 1] = hellp;
                }
                Console.WriteLine("в) Поменяны местами первый с последним, второй с предпоследним и т.д.: " + string.Join("; ", massiv));
            }
            void n3 ()
            { 
                double [] massiv = new double [20];
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                double hellp;
                for (int i = 0; i < 3; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[20-3+i];
                    massiv[20-3+i] = hellp;
                }
                Console.WriteLine("Поменяны последние три элемента и первые три элемента: "+string.Join("; ", massiv));
            }
            void n4 ()
            { 
                double[] massiv = new double [15], massiv1 = new double [8];
                Random random = new Random();
                for (int i = 0;i < 15;i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //==================================
                Array.ConstrainedCopy(massiv, 2, massiv1, 0, 8);
                Array.Reverse(massiv1);
                Array.ConstrainedCopy(massiv1, 0, massiv, 2, 8);
                Console.WriteLine("а) бла бла бла: "+string.Join ("; ", massiv));
                //=======================================
                
                int k; bool outk;
                void vvodk()
                {
                    k = 0;
                    outk = true;
                    Console.Write("Введите k ");
                    while (outk)
                    {
                        if (!int.TryParse(Console.ReadLine(), out k))
                            Console.Write("Ошибка! Введите k еще раз ");
                        else if (k <= 0 || k > 15)
                            Console.Write("k не может быть неположительным и больше длины массива (15)\nВведите k еще раз ");
                        else
                            outk = false;
                    }
                }
                //Console.WriteLine("это к "+k);
                vvodk();
                
                int s = 0; bool outs = true;string h;
                while (outs)
                {
                    h= Console.ReadLine();
                    if (h.ToLower() == "повторить")
                        vvodk();
                    else if (!int.TryParse(h, out s))
                        Console.Write("Ошибка! Введите s еще раз ");
                    else if (s <= 0 || s > 15)
                        Console.Write("s не может быть неположительным и больше длины массива (15)\nВведите s еще раз ");
                    else if (k >= s)
                        Console.Write($"s должно быть больше чем k ({k}), введите k еще раз или введите \"Повторить\", для того чтобы ввести k еще раз ");
                    else
                        outs = false;
                }
                Console.WriteLine("k: " + k + "\ns: " + s);
            }
            void n5( )
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoElenents = 0; bool outkolvoElements = true;
                while (outkolvoElements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoElenents))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else
                        outkolvoElements = false;
                }
                //Console.WriteLine("Длин массива: " + kolvoElenents);
                double[] massiv = new double[kolvoElenents];
                Random random = new Random();
                for (int i = 0; i < kolvoElenents; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                int firstotr = Array.FindIndex(massiv, d => d < 0);
                int lastpol = Array.FindLastIndex(massiv, d => d > 0);
                if (Array.Find(massiv, f => f < 0) == 0)
                {
                    Console.WriteLine("В массиве нет отрицательных элементов ");
                    return;
                }
                if (Array.FindLast(massiv, g => g > 0) == 0)
                {
                    Console.WriteLine("в массиве нет положительных элементов ");
                    return;
                }
                double hellp = massiv[firstotr];
                massiv[firstotr] = massiv[lastpol];
                massiv[lastpol] = hellp;
                Console.WriteLine("Поменяны местами первый отрицательный и последний положительный элементы: "+string.Join("; ", massiv));
            }
            //Изменение_исходного_массива.Изменение_исходного_массива ы = new Изменение_исходного_массива.Изменение_исходного_массива(); ы.Номера();
            Console.Write($"Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
