using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Черновик
{
    public class Черновик
    {
        public void Решение()
        {
            void Счетчик_символов_строки()
            {
                string a = Console.ReadLine();
                Console.WriteLine(a.Length);
            }
            void gh()
            {
                Console.Write("Введите функцию ");
                var function = new Exception(Console.ReadLine());
                Console.WriteLine(function);
                Console.ReadLine();
            }
            void for_chisl_metod()
            {
                double x = 0, xn;
                Console.WriteLine("Введите х ");
                x = double.Parse(Console.ReadLine());
                xn = x * ((Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x - 1) / (4 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) - 1));
                Console.WriteLine($"nx = {xn}");
                Console.WriteLine("Продолжить? (y/n)");
                string s = Console.ReadLine();
                while (s == "y")
                {
                    x = xn;
                    xn = x * ((Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x - 1) / (4 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) - 1));
                    Console.WriteLine($"nx = {xn}");
                    Console.WriteLine("Продолжить? (y/n)");
                    s = Console.ReadLine();
                }

                //-0,59375
            }
            //for_chisl_metod();
            Console.WriteLine("Это черновик!");
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
            //Console.Write(Console.ReadLine().ToLower());
            //==========
            /*Console.Write("Введите колво элементов массива ");
                int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Ошибка! Введите колво элементов массива еще раз ");
            double[] b=new double [a];
            int c = 0;
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите элемент №{i+1} ");
                while (!double.TryParse(Console.ReadLine(), out b[i]))
                    Console.Write($"Ошибка! Введите элемент массива №{i+1} еще раз ");
                if (b[i] == 0)
                {
                    c++;
                }
            }
            Console.WriteLine("Цифр 0 в массиве: " + c);*/
            //===========
            /*Console.WriteLine($"Степень двойки: \tСтепень равна");
            for (int i=0; i<=10;i++)
            {
                Console.WriteLine($"{i} \t\t\t{Math.Pow(2,i)}");
            }*/
            //===========
            /*Console.WriteLine("Таблица умножения:");
            for (int i1 = 1; i1 <= 10; i1++)
            {
                for (int i = 1; i<=10; i++)
                {
                    Console.Write(i * i1 + "\t");
                }
                Console.Write("\n");
            }  */
            //============
            //массив 
            /*void Массив ()
            {
                int[] a = { 1, 2, 7, 9, 7, 0 };
                //Console.WriteLine(a[a.Length-3]);
                foreach (int i in a)
                    Console.Write(i + " ");
                Console.Write("\n");
                //двумерный массив
                string[,] str =
                {
                {"один", "два", "три" },
                {"четыре", "пять", "шест" }
                };
                Console.Write(str[0, 1]);
                    }*/
            //==========
            /*void  Сложнаястрока ()
            {
                Console.Write("Введите числа через точку с запятой или пробел ");
                string s=Console.ReadLine();
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
                        chislastr[i] = Convert.ToString(chisladou[i]);
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
            Сложнаястрока();*/
            //===============
            /*130.Написать программу проверки знания таблицы умножения.
            //Программа должна вывести 10 примеров и выставить оценку:
            //за 10 правильных ответов "отлично", за 9 и 8 - "хорошо",
            //за 7 и 6 - "удовлетворительно", за 6 и менее "плохо".
            /*void Таблицаумножения ()
            {
                int a, c = 0;
                Random ran = new Random();
                Console.WriteLine("Привет! Сейчас тебе будут даны задачки на умножение,\nтвоя задача ответить правильно как можно больше раз. Удачи!");
                for (int i = 0; i < 10; i++)
                {
                    int per = ran.Next(2, 10), per1 = ran.Next(2, 10);
                    Console.Write($"{per}*{per1} = ");
                    while (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите число еще раз ");
                    if (per * per1 == a)
                        c++;
                    else if (i!=9)
                        Console.WriteLine("К сожалению ответ неверный. Следующий пример:");
                }
                if (c == 10)
                    Console.WriteLine("Оценка: Отлично");
                else if (c > 7)
                    Console.WriteLine("Оценка: Хорошо");
                else if (c > 5)
                    Console.WriteLine("Оценка: Удовлетворительно");
                else
                    Console.WriteLine("Оценка: Неудовлетворительно");
                //когда послелнее значение нужно убрать ошибку
            }
            Таблицаумножения();*/
            //====================
            //Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление 5.Возведение в степень 6.Извлечение корня" (мб факториал добавить)
            //Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2.
            //Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
            //Для определения операции по введенному номеру используйте конструкцию switch...case.
            //Если введенное пользователем число не соответствует никакой операции(например, число 120), то выведите пользователю сообщение о том, что операция неопределена.
            //Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия(например, при вводе числа 3 числа умножаются).
            //Результат операции выводиться на консоль.
            /*void Недокалькулятор ()
            {
                Console.Write("Эта программа недокалькулятор) решает примеры, но только определенные :}\n");
                Console.Write("Введите номер производимой операции (1.Сложение 2.Вычитание 3.Умножение 4.Деление 5.Возведение в степень 6.Извлечение корня) ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || a <= 0 || a > 7)
                        Console.Write("Введен неверный операции. Попробуйте еще раз ");
                switch (a)
                {
                    case 1:
                    case 4: Деление; break;
                    
                }
                //Console.Write("Введите ");
            }
             void Деление ()
            {
                double d, d1;
                Console.Write("Введите делимое ");
                while(!double.TryParse(Console.ReadLine(), out d))
                    Console.Write("Ошибка! Число введено неверно. Введите делимое еще раз ");
                Console.Write("Введите делитель ");
                while (!double.TryParse(Console.ReadLine(), out d1) || d1 == 0)
                {
                    if (d1 == 0)
                        Console.Write("Ошибка! На 0 делить нельзя\nВведите делитель еще раз ");
                    else
                        Console.Write("Ошибка! Введите делитель еще раз ");
                }
                return d / d1;
                //гнезакончено
            }
            Недокалькулятор();*/
        }
        /*class Program1
        {
            public void Main()
            {
                Random rnd = new Random();
                int[] a = Enumerable.Repeat(0, 20).Select(x => rnd.Next(0, 20)).ToArray();
                Console.WriteLine("Весь массив: ");
                Console.WriteLine(string.Join(" ", a));
                Console.WriteLine("Уникальные элементы: ");
                Console.WriteLine(string.Join(" ", a.Distinct()));
                Console.WriteLine("Повторяющиеся: ");
                Console.WriteLine(string.Join(" ", a.Where(x => a.Count(y => x == y) > 1).Distinct()));
                Console.ReadKey(true);
            } 
        }*/
    }
}
