using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Обработка_массива
{
    public class Обработка_массива
    {
        public void Задание()
        {
            Console.WriteLine("Обработка массива");
            Console.Write("Введите номер задания: ");
            byte a1 = 1, b1 = 0;
            while (b1 == 0)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1) || a1<=0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (a1 <= 0 || a1 > 8)
                    Console.Write("В дз всего 8 заданий, Введите номер задания еще раз ");*/
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
                    break;
                /*case 6:
                    n6();
                    break;
                case 7:
                    n7();
                    break;
                case 8:
                    n8();
                    break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void n1()
            {
                Console.Write("Введите длину массива: ");
                byte outa = 0, a = 1;
                while (outa == 0)
                {
                    if (!byte.TryParse(Console.ReadLine(), out a))
                        Console.Write("оШИБКА, введите длину массива еще раз: ");
                    else if (a1 <= 0)
                        Console.Write("длина массива не может быть неположительной\nВведите длину массива еще раз ");
                    else
                        outa++;
                }
                int[] массив = new int[a];
                Random r = new Random();
                byte qw = 0;
                while (qw == 0)
                {
                    for (int i = 0; i < массив.Length; i++)
                    {
                        массив[i] = r.Next(-1, 10);
                        if (массив[i] == 5)
                        qw++;
                    }
                }
                Console.WriteLine("Наш массив");
                foreach (int i in массив)
                    Console.WriteLine(i);
                Console.WriteLine($"номер первого элемента равного 5: {Array.FindIndex(массив, n => n == 5) + 1}\nномер последнего элемента равного 5: {Array.FindLastIndex(массив, n => n == 5) + 1} ");
            }
            void n2()
            {
                Console.Write("Введите длину массива: ");
                byte outa = 0, a = 1;
                while (outa == 0)
                {
                    if (!byte.TryParse(Console.ReadLine(), out a))
                        Console.Write("оШИБКА, введите длину массива еще раз: ");
                    else if (a1 <= 0)
                        Console.Write("длина массива не может быть неположительной\nВведите длину массива еще раз ");
                    else
                        outa++;
                }
                int[] массив = new int[a];
                Random r = new Random();
                byte qw = 0;
                while (qw == 0)
                {
                    for (int i = 0; i < массив.Length; i++)
                    {
                        массив[i] = r.Next(10000,66000);
                        if (массив[i] > 65530)
                            qw++;
                    }
                }
                Console.WriteLine("Наш массив");
                foreach (int i in массив)
                    Console.WriteLine(i);
                Console.WriteLine($"номер первого элемента большего 65530: {Array.FindIndex(массив, n => n > 65530) + 1}\nномер последнего элемента равного 5: {Array.FindLastIndex(массив, n => n > 65530) + 1} ");
            }
            void n3()
            {
                Console.Write("Введите длину массива: ");
                byte outa = 0, a = 1;
                while (outa == 0)
                {
                    if (!byte.TryParse(Console.ReadLine(), out a))
                        Console.Write("оШИБКА, введите длину массива еще раз: ");
                    else if (a1 <= 0)
                        Console.Write("длина массива не может быть неположительной\nВведите длину массива еще раз ");
                    else
                        outa++;
                }
                int[] массив = new int[a];
                Random r = new Random();
                byte qw = 0;
                while (qw == 0)
                {
                    for (int i = 0; i < массив.Length; i++)
                    {
                        массив[i] = r.Next(-1, 10);
                        if (массив[i] == 0)
                            qw++;
                    }
                }
                Console.WriteLine("Наш массив");
                for (int i = 0; i < массив.Length; i++)
                {
                    Console.Write($"{массив[i]} ");
                        }
                //Console.WriteLine("\nja"+Array.FindIndex(массив, n => n == 0));
                //Console.WriteLine("kaf"+Array.FindLastIndex(массив, n => n == 0));
                Console.WriteLine("\nВсе элементы кроме первого нулевого элемента: ");
                for (int  i = 0; i < массив.Length; i++)
                {
                    if (i != (Array.FindIndex(массив, n => n == 0)))
                        Console.Write($"{массив[i]} ");
                }
                Console.WriteLine("\nВсе элементы кроме последнего нулевого элемента: ");
                for (int i = 0; i < массив.Length; i++)
                {
                    if (i != (Array.FindLastIndex(массив, n => n == 0)))
                        Console.Write($"{массив[i]} ");
                }
                Console.WriteLine();
               //Console.WriteLine($"номер первого элемента равного 5: {Array.FindIndex(массив, n => n == 5) + 1}\nномер последнего элемента равного 5: {Array.FindLastIndex(массив, n => n == 5) + 1} ");
            }
            void n4()
            {
                Console.Write("Введите кол-во элементов массива ");
                int a2 = 1; byte c = 0;
                while (c == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out a2))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (a2 <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else
                        c++;

                }
                double[] massiv = new double[a2];
                Random random = new Random();
                for (int i = 0; i < a2; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                   // massiv[i] = random.Next(-50, 100);
                }
                Array.Sort(massiv);
                Console.WriteLine("Начальный массив:" + string.Join("; ", massiv ));
                Console.Write("Введите число a: ");
                double a = 0;byte oute = 0;string aw;// byte d;
                while (oute == 0)
                {   
                    //d=0;
                    aw = Console.ReadLine();
                    if (!double.TryParse(aw, out a))
                        Console.Write("Ошибка! Введите а еще раз ");
                    else if (a <= massiv[0] || a >= massiv[a2 - 1] || Array.FindAll(massiv, g => g == a).ToArray().Length !=0)
                        Console.Write("а не удовлетворяет условию задания \nВведите а еще раз ");
                        else 
                            oute++;
                }
                //ограничение а не равно не олному из элементов массива 
                 Console.WriteLine($"a) Все элементы массива меньших {a}: " + string.Join("; ",Array.FindAll(massiv, at => at < a)));
                //=================================================
                Console.Write("Введите число n: ");
                double n = 0; byte outn  = 0; 
                while (outn == 0)
                {
                    if (!double.TryParse(Console.ReadLine(), out n))
                        Console.Write("Ошибка! Введите n еще раз ");
                    else if (n <=massiv[0] || n >massiv[ a2-1])
                        Console.Write($"n не может быть <= чем 1 элемент массива ({massiv[0]}) и >= чем последний элемент массива массива({massiv[a2-1]})\nВведите n еще раз  ");
                    else
                        outn = 1;
                }
                Console.WriteLine($"б) n лежит между {Array.FindLast(massiv, ay => ay < n)} ({Array.FindLastIndex(massiv, ay => ay < n)+ 1}) и {Array.Find(massiv, ay => ay > n)} ({Array.FindIndex(massiv, ay => ay > n) + 1})");
                //=================================================
                double  ak, al, af, ar; //хреново работает 
                ak = Array.FindLast(massiv, ay => ay < a); //с меньшей стороны
                al = Array.Find(massiv, ay => ay > a); //с большей стороны
                af = Math.Round(Math.Abs(Math.Abs(ak) - Math.Abs(a)), 2);
                ar = Math.Round(Math.Abs(Math.Abs(al) - Math.Abs(a)), 2);
                if ( af < ar )
                    Console.WriteLine($"в) Элемент ближайший к {a}: {ak} ({Array.FindLastIndex(massiv, av => av == ak)+1})");
                else if (af > ar)
                    Console.WriteLine($"в) Элемент ближайший к {a}: {al} ({Array.FindIndex(massiv, av => av == al)+1})");
                else 
                    Console.WriteLine($"в) Элементы, между которыми находится {a} равно удалены от {a}. Их значения и номера элемента {ak} ({Array.FindLastIndex(massiv, av => av == ak) + 1}) и {al} ({Array.FindIndex(massiv, av => av == al)+1})"); //надо дптсать
                //Console.WriteLine("my: " + af + ", " + ar);
            }
            void n5()
            {
                Random rnd = new Random();
                int a = 15; // кол-во учеников
                double[] massiv = new double[a];
                byte s;
                for (int i = 0; i < a; i++)
                {
                    s = 0;
                    massiv[i] = Math.Round(rnd.NextDouble() * 221 +50, 3);
                    while (s == 0)
                    {
                        if (massiv[i] == Array.Find(massiv, n => n == massiv[i]))
                        {
                            massiv[i] = Math.Round(rnd.NextDouble() * 221 + 50, 3);
                            s = 1;
                        }
                    }
                }
                Array.Sort(massiv);
                Console.WriteLine("Рост пятнадцати учеников: "+string.Join("; ", massiv));
                double d = 0; byte outd = 0;
                Console.Write("Введите рост нового ученика: ");
                while (outd == 0)
                {
                    if (!double.TryParse(Console.ReadLine(), out d))
                        Console.Write("Ошибка! Введите рост нового ученика еще раз ");
                    else if (d <= massiv[0] || d >= massiv[a - 1] || d == Array.Find(massiv, g => g == d))
                        Console.Write("Рост нового ученика не соответствует условиям задания\nВведите рост нового ученика еще раз ");
                    else
                        outd++;
                }
                Console.WriteLine($"Место, которое займет новый ученик в перечне роста учеников: {Array.FindLastIndex(massiv, h => h < d)+2}");
            }
           // Обработка_массива.Обработка_массива МАрк = new Обработка_массива.Обработка_массива(); МАрк.Задание();
        
        Console.Write("Для завершения программы нажмите любую клавишу ");
            Console.ReadKey();
        }
    }
}