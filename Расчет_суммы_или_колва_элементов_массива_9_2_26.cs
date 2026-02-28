using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расчет_суммы_или_колва_элементов_массива_9_2_26
{
    class Program
    {
         public void Начало()
         {
            Console.Write("Введите номер задания: ");
            byte a1 = 1, b1 = 0;
            while (b1 == 0)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (a1 <= 0 || a1 > 9)
                    Console.Write("В дз всего 9 заданий, Введите номер задания еще раз ");
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
                double sum = 0, sumA = 0;//min = double.MaxValue, max = double.MinValue, del;
                for (int i = 0; i < a; i++)
                {
                    //massiv[i] = random.NextDouble() * 150 - 50;
                    massiv[i] = random.Next(-50, 100);
                    Console.Write($"{Math.Round(massiv[i], 3)}; ");
                    if (massiv[i] <= 20)
                        sum += massiv[i];
                }
                Console.WriteLine($"\nСумма элементов, не превышающих 20: {sum}");
                Console.Write("Введите число а ");
                int A = 1; byte c2 = 0;
                while (c2 == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out A))
                        Console.Write("Ошибка! Введите a еще раз ");
                    /*else if (A <= 0)
                        Console.Write("Ошибка! a не может быть неположительным ");*/
                    else
                        c2++;

                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] > A)
                        sumA += massiv[i];
                }
                Console.WriteLine($"Сумма элементов массива, больших а: {sumA} ");
            }
            void n2()
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
                int[] massiv = new int[a];
                Random random = new Random();
                Console.Write("Начальный массив: ");
                double sumnch = 0, sumA = 0, sumAB = 0;//min = double.MaxValue, max = double.MinValue, del;
                for (int i = 0; i < a; i++)
                {
                    //massiv[i] = random.NextDouble() * 150 - 50;
                    massiv[i] = random.Next(-50, 100);
                    Console.Write($"{massiv[i]}; ");
                    if (massiv[i] % 2 != 0)
                        sumnch += massiv[i];
                }
                Console.WriteLine($"\nСумма нечетных элементов: {sumnch}");
                Console.Write("Введите число а ");
                int A = 1; byte c2 = 0;
                while (c2 == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out A))
                        Console.Write("Ошибка! Введите a еще раз ");
                    else if (A <= 0)
                        Console.Write("Ошибка! a не может быть неположительным ");
                    else
                        c2++;

                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] % A == 0 && massiv[i] != 0)
                        sumA += massiv[i];
                }
                Console.WriteLine($"Сумма элементов массива, кратных а: {sumA} ");
                Console.Write("Введите число b ");
                int b = 1; byte c3 = 0;
                while (c3 == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out b))
                        Console.Write("Ошибка! Введите b еще раз ");
                    else if (A <= 0)
                        Console.Write("Ошибка! b не может быть неположительным ");
                    else
                        c3++;

                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((massiv[i] % A == 0 || massiv[i] % b == 0) && massiv[i] != 0)
                        sumAB += massiv[i];
                }
                Console.WriteLine($"Сумма элементов массива, кратных а или b: {sumAB} ");
            }
            void n3()
            {
                Console.Write("Введите номер месяца или его название ");
                byte outm = 0; int nomermesyc = 0; bool da = true; string nasmec = " ";
                string[] mesyca = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
                while (outm == 0)
                {
                    nasmec = Console.ReadLine();
                    ga1(nasmec);
                    if (da)
                        Console.Write("Ошибка! Введите номер месяца или его название еще раз ");
                    else if (nomermesyc<=0 || nomermesyc >12)
                        Console.Write("Номер месяца не может быть меньше 1 и больше 12\nВведите название или номер месяца еще раз ");
                    else
                        outm++;
                }
                int колводней = 0;
                bool d = (nomermesyc < 8 && nomermesyc % 2 != 0) || (nomermesyc > 7 && nomermesyc % 2 == 0); // 31 день
                if (nomermesyc == 2)
                {
                    string[] god = { "весокосный", "невесокосный" };
                    int ngod = 0; byte outgod = 0; 
                    Console.Write("Введите год (Весокосный, невесокосный или просто цифры): ");
                    while (outgod == 0)
                    {
                        ga2(Console.ReadLine());
                        if (da)
                            Console.Write("Ошибка! Введите год еще раз ");
                        else
                            outgod++;
                    }
                    void ga2(string da1)
                    {
                        if (int.TryParse(da1, out ngod))
                        {
                            da = false;
                            return;
                        }
                        else 
                        {
                            for (int i = 0; i < god.Length; i++)
                            {

                                if (da1.ToLower() == god[i])
                                {
                                    if (i == 0)
                                        ngod = 4;
                                    else
                                        ngod = 5;
                                        da = false;
                                    return;
                                }

                            }
                        }
                            da = true;
                            return;
                    }
                    if (ngod % 4 == 0)
                        колводней = 29;
                    else
                        колводней = 28;
                }
                else
                if (d)
                    колводней = 31;
                else
                    колводней = 30;
                void ga1(string da1)
                {
                    if (int.TryParse(da1, out nomermesyc))
                    {
                        nasmec = mesyca[nomermesyc - 1];
                        da = false;
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < mesyca.Length; i++)
                        {

                            if (da1.ToLower() == mesyca[i])
                            {

                                nomermesyc = Array.FindIndex(mesyca, n => n == da1.ToLower()) + 1;
                                da = false;
                                return;
                            }

                        }
                    }
                    da = true;
                    return;
                }
                double[] massiv = new double[колводней]; double sumch = 0, sumnch = 0; int sumwithoutosadki = 0;
                Random random = new Random();
                Console.WriteLine($"Далее указаны данные об осадках для каждого дня месяца {nasmec}:");
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.NextDouble() * 100;
                    Console.WriteLine($"{i + 1}\t{Math.Round(massiv[i], 3)}");
                    if ((i + 1) % 2 == 0)
                        sumch += massiv[i];
                    else 
                        sumnch += massiv[i];
                    if (massiv[i]==0)
                        sumwithoutosadki++;
                }
                string ras = "Верно";
                if (sumch < sumnch)
                    ras = "Не верно";
                Console.WriteLine($"Общие число осадков за четные числа: {Math.Round(sumch, 3)}. {ras}, что по четным числам ({Math.Round(sumch, 3)}) выпало больше осадков, чем по нечетным ({Math.Round(sumnch, 3)}). Кол-во дней без осадков: {sumwithoutosadki}");
            }
            void n4()
            {
                Console.Write("Введите названия или номера месяцев, для которых нужно найти общее число осадков, через точку с запятой или пробел ");
                string s = Console.ReadLine();
                string[] chislastr = s.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                //string[] chislastr = h.Distinct();
                
                //Console.WriteLine(chislastr.Length);

                //foreach (string ch in chislastr) Console.WriteLine(ch);
                int[] chisladou = new int[chislastr.Length];
                byte outm = 0; bool da; 
                string[] mesyca = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
                for (int i = 0; i < chislastr.Length; i++)
                {
                    //Console.WriteLine($"Начало цикла for. i: {i} ");
                    outm = 0;
                    while (outm == 0)
                    {
                        //nasmec = Console.ReadLine();
                        ga1(chislastr[i], i);
                        if (da)
                        {
                            Console.Write($"Ошибка! Введите номер ({i + 1}) месяца или его название еще раз ");
                            chislastr[i] = Console.ReadLine();
                        }
                        else if (chisladou[i] <= 0 || chisladou[i] > 12)
                        {
                            Console.Write($"Номер ({i + 1}) месяца не может быть меньше 1 и больше 12\nВведите название или номер месяца еще раз ");
                            chislastr[i] = Console.ReadLine();
                        }
                        else
                        {
                            outm++;
                            chislastr[i] = mesyca[chisladou[i] - 1];
                        }
                    }
                }
                void ga1(string da1, int i)
                {
                    if (int.TryParse(da1, out chisladou[i]))
                    {
                       
                        da = false;
                        return;
                    }
                    else
                    {
                        for (int i1 = 0; i1 < mesyca.Length; i1++)
                        {

                            if (da1.ToLower() == mesyca[i1])
                            {
                                chisladou[i] = Array.FindIndex(mesyca, n => n == da1.ToLower()) + 1;
                                da = false;
                                return;
                            }

                        }
                    }
                    da = true;
                    return;

                }
                chislastr = chislastr.Distinct().ToArray();
                chisladou = chisladou.Distinct().ToArray();
                Array.Sort(chisladou);
                for (int i = 0; i < chisladou.Length; i++)
                {
                    chislastr[i] = mesyca[chisladou[i]-1];
                }
                int[] колводней = new int[chisladou.Length];
                for (int i = 0; i < chisladou.Length; i++)
                {
                    bool d = (chisladou[i] < 8 && chisladou[i] % 2 != 0) || (chisladou[i] > 7 && chisladou[i] % 2 == 0); // 31 день
                    if (chisladou[i] == 2)
                    {
                        string[] god = { "весокосный", "невесокосный" };
                        int ngod = 0; byte outgod = 0;
                        Console.Write("Введите год (Весокосный, невесокосный или просто цифры): ");
                        while (outgod == 0)
                        {
                            ga2(Console.ReadLine());
                            if (da)
                                Console.Write("Ошибка! Введите год еще раз ");
                            else
                                outgod++;
                        }
                        void ga2(string da1)
                        {
                            if (int.TryParse(da1, out ngod))
                            {
                                da = false;
                                return;
                            }
                            else
                            {
                                for (int i1 = 0; i1 < god.Length; i1++)
                                {

                                    if (da1.ToLower() == god[i1])
                                    {
                                        if (i1 == 0)
                                            ngod = 4;
                                        else
                                            ngod = 5;
                                        da = false;
                                        return;
                                    }

                                }
                            }
                            da = true;
                            return;
                        }
                        if (ngod % 4 == 0)
                            колводней[i]= 29;
                        else
                            колводней[i] = 28;
                    }
                    else
                    if (d)
                        колводней[i] = 31;
                    else
                        колводней[i] = 30;
                }
                Random random = new Random(); double sum = 0;
                double[][] allusedmounth= new double[chisladou.Length] [];
                for (int i = 0; i < chisladou.Length; i++) 
                {
                    allusedmounth[i] = new double[колводней[i]];
                }
                for (int i = 0; i < allusedmounth.Length; i++)
                {
                    Console.WriteLine($"===============================\n{chislastr[i]}");
                    for (int j = 0; j < allusedmounth[i].Length; j++)
                    {
                        allusedmounth[i][j]=random.NextDouble()*100;
                        Console.WriteLine((j+1)+"\t"+Math.Round(allusedmounth[i][j], 3));
                        sum += allusedmounth[i][j];
                    }
                }
                Console.WriteLine("Общее кол-во осадков за все месяцы: " + Math.Round(sum, 3));
                //Console.WriteLine(string.Join(",", chisladou));
            }
            void n5()
            {
                Console.Write("Введите кол-во элементов массива: ");
                byte outa = 0; int a = 0;
                while (outa == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (a <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным,\nВведите кол-во элементов массива еще раз ");
                    else
                        outa = 1;
                }
                double[] massiv = new double[a];
                Random rand = new Random();
                double sumpol = 0, sumotr = 0;
                for (int i = 0; i < a; i++)
                {
                    massiv[i]=Math.Round(rand.NextDouble()*100-50, 3);
                    if (massiv[i] < 0)
                        sumotr += massiv[i];
                    if (massiv[i] > 0)
                        sumpol+= massiv[i];
                }
                Console.WriteLine($"Наш массив: {string.Join("; ", massiv)}");
                Console.WriteLine($"Частное от суммы положительных элементов массива и модуля суммы отрицательных элементов массива = {Math.Round(sumpol/Math.Abs(sumotr), 3)}");
                Console.WriteLine($"Для проверки.\nПоложительные элементы массива: {string.Join("; ", Array.FindAll(massiv, n => n > 0))}\nОтрицательные элементы: {string.Join("; ", Array.FindAll(massiv, n => n < 0))}\nСумма положительных элементов: {sumpol}\nСумма отрицательных элементов: {sumotr}");
            }
            void n6()
            {
                Console.Write("Введите кол-во элементов массива: ");
                byte outa = 0; int a = 0;
                while (outa == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (a <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным,\nВведите кол-во элементов массива еще раз ");
                    else
                        outa = 1;
                }
                int[] massiv = new int[a];
                Random rand = new Random();
                int sum20 = 0, sum50 = 0;
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = rand.Next(-100,101);
                    if (massiv[i] > 20)
                        sum20 += massiv[i];
                    if (massiv[i]<50)
                        sum50 += massiv[i];
                }
                Console.WriteLine("Наш массив: " +  string.Join(", ", massiv));
                string x = "Верно", s = "Не верно";
                if (sum20 < 100)
                    x = "Не верно";
                if (sum50 % 2 == 0 && sum50 != 0)
                    s = "Верно";
                Console.WriteLine($"{x}, что сумма элементов, которые больше 20 ({sum20}), превышает 100");
                Console.WriteLine($"{s}, что сумма элементов, которые меньше 50 ({sum50}), есть четное число ");

            }
            void n7()
            {
                Console.Write("Введите кол-во домов на этой улице: ");
                byte outa = 0; int a = 0;
                while (outa == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во домов еще раз ");
                    else if (a <= 0)
                        Console.Write("Кол-во домов не может быть неположительным,\nВведите кол-во домов еще раз ");
                    else
                        outa = 1;
                }
                int[] massiv = new int[a];
                Random rand = new Random();
                int sumch = 0, sumnch = 0;
                Console.WriteLine("Номер дома\tЧисло жителей");
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = rand.Next(9);
                    Console.WriteLine($"{i + 1}\t\t{massiv[i]}");
                    if ((i + 1) % 2 == 0)
                        sumch += massiv[i];
                    else
                        sumnch += massiv[i];
                }
                string f = "больше";
                if (sumch > sumnch)
                    f = "меньше";
                Console.WriteLine($"На нечетной ({sumnch}) стороне проживает {f} людей чем на четной ({sumch})");
            }
            void n8()
            {
                Console.Write("Введите кол-во элементов массива: ");
                byte outa = 0; int a = 0;
                while (outa == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (a <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным,\nВведите кол-во элементов массива еще раз ");
                    else
                        outa = 1;
                }
                double[] massiv = new double[a];
                Random rand = new Random();
                int kolvoneotr = 0;
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round(rand.NextDouble() * 201 - 100, 3);
                    if (massiv[i] >= 0)
                        kolvoneotr++;
                }
                Console.WriteLine($"Наш массив: {string.Join("; ", massiv)}\nКол-во неотрицательных элементов: {kolvoneotr}\nДля проверки. Неотрицательные элементы: {string.Join("; ", Array.FindAll(massiv, n => n>=0))}");
            }
            void n9 ()
            {
                Console.Write("Введите кол-во элементов массива: ");
                byte outa = 0; int a = 0;
                while (outa == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (a <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным,\nВведите кол-во элементов массива еще раз ");
                    else
                        outa = 1;
                }
                int[] massiv = new int[a];
                Random rand = new Random();
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = rand.Next(-100, 101);
                }
                Console.WriteLine($"Наш массив: {string.Join(", ", massiv)}");
                Console.WriteLine("Кол-во элементов отличных от последнего элемента: " + Array.FindAll(massiv, n => n != massiv.Last()).Length);
                Console.Write("Введите число а ");
                int A = 1; byte c2 = 0;
                while (c2 == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out A))
                        Console.Write("Ошибка! Введите a еще раз ");
                    else
                        c2++;

                }
                if (A == 0)
                    Console.WriteLine($"Кол-во элементов массива, кратных {A}: {Array.FindAll(massiv, n => n == 0).Length} ");
                else
                {
                    Console.WriteLine($"Кол-во элементов массива, кратных {A}: {Array.FindAll(massiv, n => n % A == 0).Length} ");
                    Console.WriteLine($"Элементы, кратные {A}: {string.Join(", ", Array.FindAll(massiv, f => f%A==0))}");
                }
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
                     break;
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
                 n9 ();
                 break;
                /*default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;*/
            }
            Console.Write($"Для завершения программы нажмите Enter");
            Console.ReadLine();

        }
    }
}
