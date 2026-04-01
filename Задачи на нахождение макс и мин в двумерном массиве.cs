using System;
using System.Linq;

//с 1 по 6 1-5 перебором, 6 одномерным массивом
namespace DvumerMasMaxMin
{
    public class Reshenie
    {
        public void Nomerov()
        {
            Console.WriteLine("Двумерный массив макс и мин ");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                    Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
            {
                case 1: n1(); break;
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;
                case 5: n5(); break;
                case 6: n6(); break;
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void n1()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент второй строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (kolvostolb < 3)
                        Console.Write("При таком кол-ве столбцов нельзя найти макс элемент третьего столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                int h = 1;
                int max3 = massiv[0, 2];
                while (h < kolvostrok)
                {
                    if (massiv[h, 2] > max3)
                        max3 = massiv[h, 2];
                    h++;
                }
                Console.WriteLine("a) Макс элемент 3-его столбца: " + max3);
                //===================
                h = 1;
                int min2 = massiv[1, 0];
                while (h < kolvostolb)
                {
                    if (massiv[1, h] < min2)
                        min2 = massiv[1, h];
                    h++;
                }
                Console.WriteLine("б) Мин элемент 2-й строки: " + min2);
            }
            void n2()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 5)
                        Console.Write("При таком кол-ве строк нельзя найти макс элемент пятой строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (kolvostolb < 4)
                        Console.Write("При таком кол-ве столбцов нельзя найти мин элемент четвертого столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                int h = 1;
                int min5 = massiv[4, 0];
                while (h < kolvostolb)
                {
                    if (massiv[4, h] < min5)
                        min5 = massiv[4, h];
                    h++;
                }
                Console.WriteLine("a) Мин элемент 5-й строки: " + min5);
                //===================
                h = 1;
                int max4 = massiv[0, 3];
                while (h < kolvostrok)
                {
                    if (massiv[h, 3] > max4)
                        max4 = massiv[h, 3];
                    h++;
                }
                Console.WriteLine("б) Макс элемент 4-его столбца: " + max4);
            }
            void n3()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                Console.Write("Введите номер строки, для нахождения мин элемента среди элементов строки: ");
                int t = 0; bool outt = true;
                while (outt)
                {
                    if (!int.TryParse(Console.ReadLine(), out t))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (t <= 0 || t > kolvostrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                    else
                        outt = false;
                }
                int h = 1;
                int hellp = nums[t - 1, 0];
                while (h < kolvostolb)
                {
                    if (nums[t-1, h] < hellp)
                        hellp = nums[t-1, h];
                    h++;
                }
                Console.WriteLine($"a) Мин элемент {t}-й строки: " + hellp);
                //========================
                Console.Write("Введите номер столбца, для нахождения макс элемента среди элементов столбца: ");
                int x = 0; bool outx = true;
                while (outx)
                {
                    if (!int.TryParse(Console.ReadLine(), out x))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (x <= 0 || x > kolvostolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                    else
                        outx = false;
                }
                h= 1;
                hellp = nums[0, x - 1];
                while (h < kolvostrok)
                {
                    if (nums[h, x - 1] > hellp)
                        hellp = nums[h, x - 1];
                    h++;
                }
                Console.WriteLine($"б) Макс элемент {x}-го столбца: " + hellp);
            }
            void n4()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-100, 100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                Console.Write("Введите номер строки, для нахождения макс элемента среди элементов строки: ");
                int t = 0; bool outt = true;
                while (outt)
                {
                    if (!int.TryParse(Console.ReadLine(), out t))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (t <= 0 || t > kolvostrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                    else
                        outt = false;
                }
                int h = 1;
                int hellp = massiv[t - 1, 0];
                while (h < kolvostolb)
                {
                    if (massiv[t - 1, h] > hellp)
                        hellp = massiv[t - 1, h];
                    h++;
                }
                Console.WriteLine($"a) Макс элемент {t}-й строки: " + hellp);
                //========================
                Console.Write("Введите номер столбца, для нахождения мин элемента среди элементов столбца: ");
                int x = 0; bool outx = true;
                while (outx)
                {
                    if (!int.TryParse(Console.ReadLine(), out x))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (x <= 0 || x > kolvostolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                    else
                        outx = false;
                }
                h = 1;
                hellp = massiv[0, x - 1];
                while (h < kolvostrok)
                {
                    if (massiv[h, x - 1] < hellp)
                        hellp = massiv[h, x - 1];
                    h++;
                }
                Console.WriteLine($"б) Мин элемент {x}-го столбца: " + hellp);
            }
            void n5() 
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 4)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент четвертой строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (kolvostolb < 3)
                        Console.Write("При таком кол-ве столбцов нельзя найти макс элемент третьего столбца. Введите кол-во столбцов еще раз ");

                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-100, 100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                int h = 1; int ind = 0;
                int min2 = massiv[3, 0];
                while (h < kolvostolb)
                {
                    if (massiv[3, h] < min2)
                    {
                        min2 = massiv[3, h];
                    }
                    h++;
                }
                h = 0;
                while (h < kolvostolb)
                {
                    if (massiv[3, h] == min2)
                        ind++;
                    h++;
                }
                h = 0;
                while (h < kolvostolb && massiv[3, h] != min2)
                    h++;
                if (ind == 1)
                    Console.WriteLine("a) Номер столбца мин элемента 4-й строки: " + (h+1));
                else
                    Console.WriteLine("a) В 4-й строке несколько мин элементов. Номер столбца самого левого мин элемента 4-й строки: " + (h+1));
                //========================
                h = 1; ind = 0;
                int max3 = massiv[0, 2];
                while (h < kolvostrok)
                {
                    if (massiv[h, 2] > max3)
                        max3 = massiv[h, 2];
                    h++;
                }
                h = 0;
                while (h < kolvostrok)
                {
                    if (massiv[h, 2] == max3)
                        ind++;
                    h++;
                }
                h = kolvostrok - 1;
                while (h >= 0 && massiv[h, 2] != max3)
                    h--;
                if (ind == 1)
                    Console.WriteLine("б) Номер строки макс элемент 3-его столбца: " + (h + 1));
                else
                    Console.WriteLine("б) В 3-м столбце несколько макс элементов. Номер строки самого нижнего макс элемент 3-его столбца: " + (h + 1));
            }
            void n6()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 3)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент третьей строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (kolvostolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти макс элемент второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-100, 100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                int[] stolb2nd = new int[kolvostrok];
                for (int i = 0; i < kolvostrok; i++) stolb2nd[i] = massiv[i, 1];
                int max = stolb2nd.Max();
                if (Array.FindAll(stolb2nd, j => j == max).Length == 1)
                    Console.WriteLine("а) Номер строки макс элемента 2-го столбца: " + (Array.IndexOf(stolb2nd, max) + 1));
                else
                    Console.WriteLine("а) Во 2-м столбце несколько макс элементов. Номер строки самого верхнего макс элемента 2-го столбца: " + (Array.IndexOf(stolb2nd, max) + 1));
                //========================
                int[] stroka3rd = new int[kolvostolb];
                for (int i = 0; i < kolvostolb; i++) stroka3rd[i] = massiv[2, i];
                int min = stroka3rd.Min();
                if (Array.FindAll(stroka3rd, f => f == min).Length == 1) 
                    Console.WriteLine("б) Номер столбца мин элемента 3-й строки: " + (Array.IndexOf(stroka3rd, min) + 1));
                else
                    Console.WriteLine("б) В 3-й строке несколько мин элементов. Номер столбца самого правого мин элемента 3-й строки: " + (Array.LastIndexOf(stroka3rd, min) + 1));
            }
        }
    }
}