using System;

//ProverkaUslovia.PosleRaschetov posle = new ProverkaUslovia.PosleRaschetov(); posle.DmumerMassiv();
namespace ProverkaUslovia
{
    public class PosleRaschetov
    {
        public void DmumerMassiv()
        {
            Console.WriteLine("Двумерный массив проверка условия после выполнения рассчетов ");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                    Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");*/
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
            {
                case 1: n1(); break;
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;/*
                case 5: n5(); break;
                case 6: n6(); break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void n1()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    /*else if (kolvostrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент второй строки. Введите кол-во строк еще раз ");*/
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти произведение элементов второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int [KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int proiz = 1;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (j == 1)
                            proiz *= massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                if (Math.Abs(proiz)>99 && Math.Abs(proiz) <= 999)
                    Console.WriteLine($"a) Произведение элементов второго столбца является 3х значным числом ({proiz})") ;
                else
                    Console.WriteLine($"a) Произведение элементов второго столбца не является 3х значным числом ({proiz})");
                //===================
                Console.WriteLine("Определить верно ли, что сумма элементов строки массива превышает заданное число");
                Console.Write($"Введите номер строки для нахождения суммы элементов этой строки для проверки условия ");
                int NomerStroki = 0; bool OutNomerStroki = true;
                while (OutNomerStroki)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (NomerStroki <= 0 || NomerStroki > KolvoStrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({KolvoStrok}). Введите номер строки еще раз ");
                    else
                        OutNomerStroki = false;
                }
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                int sum = 0;
                for (int i = 0; i < KolvoStolb; i++) sum += massiv[NomerStroki - 1, i];
                if (sum > Chislo)
                    Console.WriteLine($"б) Верно, сумма элементов заданной строки превышает заданное число (sum: {sum}, chislo: {Chislo})");
                else
                    Console.WriteLine($"б) Не верно, сумма элементов заданной строки не превышает заданное число (sum: {sum}, chislo: {Chislo})");
            }
            void n2()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (KolvoStrok < 4)
                        Console.Write("При таком кол-ве строк нельзя найти сумму элементов четвертой строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");/*
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти произведение элементов второго столбца. Введите кол-во столбцов еще раз ");*/
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int sum = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 3)
                            sum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                if (Math.Abs(sum) > 9 && Math.Abs(sum) <= 99)
                    Console.WriteLine($"a) Сумма элементов четвертой строки является 2х значным числом ({sum})");
                else
                    Console.WriteLine($"a) Сумма элементов четвертой строки не является 2х значным числом ({sum})");
                //===================
                Console.WriteLine("Определить верно ли, что произведение элементов столбца массива не превышает заданное число");
                Console.Write($"Введите номер строки для нахождения суммы элементов этой строки для проверки условия ");
                int NomerStolb = 0; bool OutNomerStolb = true;
                while (OutNomerStolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStolb))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (NomerStolb <= 0 || NomerStolb > KolvoStolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({KolvoStolb}). Введите столбца строки еще раз ");
                    else
                        OutNomerStolb = false;
                }
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                int proiz = 1;
                for (int i = 0; i < KolvoStolb; i++) proiz *= massiv[i, NomerStolb - 1];
                if (proiz < Chislo)
                    Console.WriteLine($"б) Верно, произведение элементов заданного столбца не превышает заданное число (proiz: {proiz}, chislo: {Chislo})");
                else
                    Console.WriteLine($"б) Не верно, произведение элементов заданного столбца превышает заданное число (proiz: {proiz}, chislo: {Chislo})");
            }
            void n3()
            {
                const int KolvoStrok = 18;
                const int KolvoStolb = 12;
                double[,] massiv = new double [KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                double GodSum = 0;
                Console.WriteLine("информация о зарплатах 18 работников за год (тыс): ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(rnd.NextDouble() * 200, 3);
                        Console.Write(massiv[i, j] + "\t");
                        if (j == 0)
                            GodSum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                Console.WriteLine("Определить верно ли, что годовой оклад 1-го работника больше некоторого числа");
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                if (GodSum > Chislo)
                    Console.WriteLine($"Верно, годовой оклад 1-го работника больше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
                else
                    Console.WriteLine($"Не верно, годовой оклад 1-го работника меньше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");

            }
            void n4()
            {
                const int KolvoStrok = 10;
                const int KolvoStolb = 12;
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                double GodSum = 0;
                Console.WriteLine("информация о доходе 10 магазинов за год (тыс): ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(rnd.NextDouble() * 200, 3);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 8)
                            GodSum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                Console.WriteLine("Определить верно ли, что общий доход фирмы за сентябрь больше некоторого числа");
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                if (GodSum > Chislo)
                    Console.WriteLine($"Верно, общий доход фирмы за сентябрь больше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
                else
                    Console.WriteLine($"Не верно, общий доход фирмы за сентябрь меньше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
            }
        }
    }

}