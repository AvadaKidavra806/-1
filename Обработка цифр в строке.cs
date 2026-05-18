using System;
using System.Collections.Generic;
using System.Linq;

public class ZifravStroke
{
    public void TipoMain()
    {
        Console.WriteLine("Обработка цифр в строке ");
        byte NomerZadaniy; bool NomerZadaniyOut;
        while (true)
        {
            Console.Write("Введите номер задания: ");
            NomerZadaniy = 1; NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (NomerZadaniy <= 0 || NomerZadaniy > 9)
                    Console.Write("В дз всего 9 заданий, Введите номер задания еще раз ");
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
                case 6: n6(); break;
                case 7: n7(); break;
                case 8: n8(); break;
                case 9: n9(); break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            ConsoleKey Klavisha;
            do
            {
                Console.WriteLine("Y or N");
                Klavisha = Console.ReadKey(true).Key;
            }
            while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
            if (Klavisha == ConsoleKey.N)
                break;
        }
        void n1()
        {
            Console.Write("Введите символ ");
            char sim;
            while (true)
            {
                try
                {
                    sim = Console.ReadKey().KeyChar;
                    break;
                }
                catch
                {
                    Console.Write("Возникла ошибка! Введите символ еще раз ");
                }
            }
            if (char.IsNumber(sim))
                Console.WriteLine("\nВведенный символ является цифрой");
            else 
                Console.WriteLine("\nВведенный символ не является цифрой");
        }
        void n2()
        {
            Console.Write("Введите текст ");
            string text = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i]))
                    count++;
            }
            if (count != 0)
            {
                Console.WriteLine();
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsNumber(text[i]))
                        Console.Write(text[i] + " ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("в тексте нет цифр!");
        }
        void n3()
        {
            Console.Write("Введите текст ");
            string text = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i]))
                    count++;
            }
            Console.WriteLine("Кол-во цифр в тексте: "+count);
        }
        void n4()
        {
            Console.Write("Введите текст ");
            string text = Console.ReadLine();
            int count = 0;
            int sum = 0;
            List<int> ints = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i]))
                {
                    count++;
                    ints.Add(int.Parse(text[i].ToString()));
                    sum += int.Parse(text[i].ToString());
                }
            }

            if (count != 0)
            {
                Console.WriteLine("MAX из цифр в тексте: " + ints.ToArray().Max());
                Console.WriteLine("Cумма цифр в тексте: " + sum);
            }
            else
                Console.WriteLine("В тексте нет цифр");
        }
    }
}