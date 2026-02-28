using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Дихотомия
{
    internal class Дихотомия
    {
         public void Решение()
        {
            void чтобынемешало()
            {
                byte ВыходВыборФункции = 1; int ВыборФункции = 0;
                Console.WriteLine("Эта программа вычисляет корни уравнения методом дихотомии с заданной точностью ");
                Console.Write("Введите тип уравнения \n1 - линейное уравнение\n2 - квадратное уравнение (Только с указанием отрезков изоляции)\nи другие: ");
                while (ВыходВыборФункции != 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out ВыборФункции))
                        Console.Write("Ошибка! Тип уравнения введен неверно, введите еще раз ");
                    else if (ВыборФункции <= 0)
                        Console.Write("Тип уравнения должен быть от 0 до (надо прописать будет) ");
                    else
                        ВыходВыборФункции = 0;
                }
                //Console.WriteLine(ВыборФункции);
                switch (ВыборФункции)
                {
                    case 1:
                        ЛинейноеУравнение();
                        break;
                    case 2:
                        КвадратноеУравнение();
                        break;
                    default:
                        Console.WriteLine("Пока что недоступно");
                        break;
                }
                //Console.Write("Введите уравнение по образцу: (надо прописать образец)");
            }
            //чтобынемешало();
            void vvodfunkcii ()
            {
                Console.Write("Введите функцию: ");
                string func = Console.ReadLine();
                //string[] vfunc = func.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                //string[] vfunc = new string[func.Length];
                for (int i = 0; i<func.Length; i++)
                {
                    if (func[i]!=' ')
                    Console.WriteLine(func[i]);
                }
                //foreach (string gh in vfunc) Console.WriteLine(gh);

            }
            vvodfunkcii();
            void ЛинейноеУравнение ()
            {
                double kLin = 0, bLin = 0; byte ВыходaLin = 0, ВыходbLin = 0, ВыходЭпсилон = 0; string Закончить; int эпсилон = 0;
                Console.WriteLine("Линейное уравнение имеет вид: kx+b=0");
                Console.Write("Введите k ");
                while (ВыходaLin == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить == "Конец")
                        return;
                    else if (!double.TryParse(Закончить, out kLin))
                        Console.Write("Ошибка! Введите k еще раз ");
                    else if (kLin == 0)
                        Console.Write("При k = 0 k = 0 (как бы уравнения нет)\nВведите k еще раз или Введите \"Конец\" для завершения программы ");
                    else
                        ВыходaLin++;
                }
                Console.Write("Введите b ");
                while (ВыходbLin == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить == "Конец")
                        return;
                    else if (!double.TryParse(Закончить, out bLin))
                        Console.Write("Ошибка! Введите b еще раз ");
                    else
                        ВыходbLin++;
                }
                Console.Write("Введите точность (эпсилон) кол-во цифр после запятой ");
                while (ВыходЭпсилон == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить == "Конец")
                        return;
                    else if (!int.TryParse(Закончить, out эпсилон))
                        Console.Write("Ошибка! Введите эпсилон еще раз ");
                    else if (эпсилон <= 0)
                        Console.Write("Эпсилон не может быть неположительным\nВведите эпсилон еще раз  ");
                    else
                        ВыходЭпсилон++;
                }
                Console.WriteLine ($"Ответ: {линейноевычисление(kLin, bLin, эпсилон)}");
            }
            double линейноевычисление (double k, double b, int эпсилон)
            {
                if (b == 0)
                {
                    //Console.WriteLine("Ответ: 0");
                    return 0;
                }
                //здесь нахожу отрезок изоляции
                double x = 0; byte d = 0;
                bool p = (b > 0 && k > 0) || (b < 0 && k < 0);
                while (d == 0)
                {
                    //Console.WriteLine("Начало цикла ");
                    if (Math.Sign(y(x + 1)) * Math.Sign(y(x)) <= 0/*перегрузка очень возможна*/)
                        d = 1;
                    else
                    {
                        if (p)
                            x--;
                        else
                            x++;
                    }
                }
                //для целых корней
                if (y(x + 1) == 0 && !p)
                    return x + 1;
                else if  (y(x) == 0 && p)
                    return x;
                else
                {
                    //Console.WriteLine($"Мои у: {y(x)} и у1: {y(x+1)}"); //for me
                    //Console.WriteLine($"Мой х: {x} и х: {x+1}"); //строчка для меня
                    double xsr, x1 = x + 1, del;
                    do
                    {

                        xsr = (x + x1) / 2.0;
                        //Console.WriteLine("Начало цикла " + xsr);
                        if (y(xsr) * y(x) < 0) //от нижней границы до среднего
                        {
                            del = Math.Abs(xsr - x);
                            x1 = xsr;
                            //Console.WriteLine($"От низа до среднего, значение y(xsr): {y(xsr)}");
                        }
                        else //от середины до верхней границы
                        {
                            del = Math.Abs(x1 - xsr);
                            x = xsr;
                            //Console.WriteLine($"От среднего до верха, значение y(xsr): {y(xsr)}");
                        }
                        //Console.WriteLine("Конец цикла");

                    }
                    while ((Math.Pow(10, -эпсилон) * 2) < del);
                    return Math.Round(xsr, эпсилон);
                }
                //Console.WriteLine($"Ответ: {Math.Round(xsr, эпсилон)}");
                double y(double z) => k * z + b;
            }
            void квадратноевычисление (double a, double b, double c, int эпсилон, double d, out double корень, out double корень1)
            {
                
                byte z = 0; double x = -1;
                if (d > 0)
                {
                    //первый корень 
                    {
                        while (z == 0) //первый корень
                        {
                            //Console.WriteLine("Начало цикла ");
                            if (y(x + 1) * y(x) <= 0/*перегрузка очень возможна*/)
                                z = 1;
                            else
                                x++;
                        }
                        if (y(x + 1) == 0)
                            корень = x;
                        else
                        {
                            double xsr, x1 = x + 1, del;
                            do
                            {

                                xsr = (x + x1) / 2.0;
                                //Console.WriteLine("Начало цикла " + xsr);
                                if (y(xsr) * y(x) < 0) //от нижней границы до среднего
                                {
                                    del = Math.Abs(xsr - x);
                                    x1 = xsr;
                                    //Console.WriteLine($"От низа до среднего, значение y(xsr): {y(xsr)}");
                                }
                                else //от середины до верхней границы
                                {
                                    del = Math.Abs(x1 - xsr);
                                    x = xsr;
                                    //Console.WriteLine($"От среднего до верха, значение y(xsr): {y(xsr)}");
                                }
                                //Console.WriteLine("Конец цикла");

                            }
                            while ((Math.Pow(10, -эпсилон) * 2) < del);
                            корень = Math.Round(xsr, эпсилон);
                        }
                    }
                    //Второй корень
                    {
                        z = 0; x = 0;
                        while (z == 0) //второй корень
                        {
                            //Console.WriteLine("Начало цикла ");
                            if (y(x + 1) * y(x) <= 0/*перегрузка очень возможна*/)
                                z = 1;
                            else
                                x--;
                        }
                        if (y(x) == 0)
                            корень1 = x;
                        else
                        {
                            double xsr1, x11 = x + 1, del1;
                            do
                            {

                                xsr1 = (x + x11) / 2.0;
                                //Console.WriteLine("Начало цикла " + xsr);
                                if (y(xsr1) * y(x) < 0) //от нижней границы до среднего
                                {
                                    del1 = Math.Abs(xsr1 - x);
                                    x11 = xsr1;
                                    //Console.WriteLine($"От низа до среднего, значение y(xsr): {y(xsr)}");
                                }
                                else //от середины до верхней границы
                                {
                                    del1 = Math.Abs(x11 - xsr1);
                                    x = xsr1;
                                    //Console.WriteLine($"От среднего до верха, значение y(xsr): {y(xsr)}");
                                }
                                //Console.WriteLine("Конец цикла");

                            }
                            while ((Math.Pow(10, -эпсилон) * 2) < del1);
                            корень1 = Math.Round(xsr1, эпсилон);
                        }
                    }
                    //return Math.Round(xsr1, эпсилон);
                }
                else
                {
                    //нужно другие варианты прописать
                    корень = 345;
                    корень1 = 890;
                    //return 670;
                }
               double y (double f) => (a * Math.Pow(f, 2)) + (b * f) +c;
            }
            //ПРОБЛЕМА оба корня могут быть на одном луче ох и когда корень = 0,0
            ///ЛинейноеУравнение();
            void КвадратноеУравнение ()
            {
                double akvad = 0, bkvad = 0, ckvad = 0; byte Выходakvad = 0, Выходbkvad = 0, Выходckvad = 0, ВыходЭпсилон = 0; string Закончить; int эпсилон = 0;
                Console.WriteLine("Квадратное уравнение имеет вид: ax^2 + bx + c = 0");
                Console.Write("Введите a ");
                while (Выходakvad == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить.ToLower() == "конец")
                        return;
                    else if (Закончить.ToLower() == "да") 
                    {
                        akvad = 0;
                        Выходakvad++;
                    }
                    else if (!double.TryParse(Закончить, out akvad))
                        Console.Write("Ошибка! Введите a еще раз ");
                    else if (akvad == 0)
                        Console.Write("При a = 0 уравнение принимает вид линейного\nВведите a еще раз или введите \"Да\" для расчета корня с а=0, \"конец\"  для завершения программы ");
                    else
                        Выходakvad++;
                }
                Console.Write("Введите b ");
                while (Выходbkvad == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить.ToLower() == "конец")
                        return;
                    else if (!double.TryParse(Закончить, out bkvad))
                        Console.Write("Ошибка! Введите b еще раз ");
                    else if (bkvad == 0 && akvad == 0)
                        Console.Write("При a = 0 и b = 0 => c = 0 (как бы уравнения нет)\nВведите b еще раз или введите \"Конец\" для завершения программы ");
                    else
                        Выходbkvad++;
                }
                Console.Write("Введите c ");
                while (Выходckvad == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить.ToLower() == "конец")
                        return;
                    else if (!double.TryParse(Закончить, out ckvad))
                        Console.Write("Ошибка! Введите c еще раз ");
                    /*else if (bkvad == 0 && akvad == 0)
                        Console.Write("При a = 0 и b = 0 => c = 0 (как бы уравнения нет)\nВведите c еще раз или введите \"Конец\" для завершения программы ");
                    */else
                        Выходckvad++;
                }
                Console.Write("Введите точность (эпсилон) кол-во цифр после запятой ");
                while (ВыходЭпсилон == 0)
                {
                    Закончить = Console.ReadLine();
                    if (Закончить == "Конец")
                        return;
                    else if (!int.TryParse(Закончить, out эпсилон))
                        Console.Write("Ошибка! Введите эпсилон еще раз ");
                    else if (эпсилон <= 0)
                        Console.Write("Эпсилон не может быть неположительным\nВведите эпсилон еще раз  ");
                    else
                        ВыходЭпсилон++;
                }
                //Console.WriteLine($"a: {akvad}, b: {bkvad}, c: {ckvad}, эпсилон: {эпсилон} ");
                double d = Math.Pow(bkvad, 2) - 4 * akvad * ckvad;
                if (akvad == 0)
                {
                    Console.WriteLine($"Ответ: {линейноевычисление(bkvad, ckvad, эпсилон)}");
                }
                else if (d > 0)
                {
                    квадратноевычисление(akvad, bkvad, ckvad, эпсилон, d, out double корень, out double корень1);
                    Console.WriteLine($"Ответ: Первый корень: {корень}, второй корень: {корень1}");
                }
                else if (d == 0)
                {
                    квадратноевычисление(akvad, bkvad, ckvad, эпсилон, d, out double корень, out double корень1);
                    Console.WriteLine($"Ответ: {корень}");
                }
                Console.WriteLine("Это d: " + d);
            }
            //КвадратноеУравнение();
            //образец для ввода
            /*while (a != 0)
            {
                if (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Ошибка! x введен неверно, введите еще раз ");
                else if (x <= 0)
                    Console.Write("При таком значении x основание натурального логарифма неположительно, т.к. область определения z, z>0" +
                        "\nПри произведении получится положительное число только если оба множителя положительны \nВведите x еще раз ");
                else
                    a = 0;
            }*/
            void СложныеСтроки()
            {
                Console.Write("Введите числа через точку с запятой или пробел ");
                string s = Console.ReadLine();
                string[] chislastr = s.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                double[] chisladou = new double[chislastr.Length];
                double sum = 0, del = 0;
                for (int i = 0; i < chislastr.Length; i++)
                {
                    if (!double.TryParse(chislastr[i], out chisladou[i]))
                    {
                        Console.Write($"Элемент под номером {i + 1} введен не верно! Введите еще раз ");
                        while (!double.TryParse(Console.ReadLine(), out chisladou[i]))
                            Console.Write($"Элемент под номером {i + 1} введен не верно! Введите еще раз ");
                        chislastr[i] = /*chisladou[i];*/Convert.ToString(chisladou[i]); //это преобразование объяснить надо
                    }
                    sum += chisladou[i];
                    del++;
                }
                for (int i = 0; i < chislastr.Length; i++)
                {
                    if (i != chisladou.Length - 1)
                        Console.Write($"{chislastr[i]};  ");
                    else
                        Console.Write($"{chislastr[i]}");
                }
                if (del != 0)
                    Console.WriteLine($"\nСреднее арифметическое чисел равно: {Math.Round((sum / del), 3)}");
                //можно сортировку сделать
            }
            //СложныеСтроки();
            //==================================
            Console.Write("Для завершения программы нажмите Enter ");
            Console.ReadLine();
        }
    }
}