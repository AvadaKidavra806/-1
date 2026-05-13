using System;
using System.Collections.Generic;


namespace Obrabotka
{
    public class Strok 
    {
        public void TipoMain() 
        {
            Console.WriteLine("Обработка строк циклом ");
            byte NomerZadaniy; bool NomerZadaniyOut;
            bool OutZadanie = true;
            do
            {
                Console.Write("Введите номер задания: ");
                NomerZadaniy = 1; NomerZadaniyOut = true;
                while (NomerZadaniyOut)
                {
                    if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                        Console.Write("Ошибка! Введите номер задания еще раз ");
                    /*else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                        Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");*/
                    else
                        NomerZadaniyOut = false;

                }
                ConsoleKey Klavisha;
                switch (NomerZadaniy)
                {
                    case 1: n1(); break;
                    case 2: n2(); break;
                    case 3: n3(); break;
                    case 4: n4(); break;
                    case 5: n5(); break;
                    case 6: n6(); break;
                    case 7: n7(); break;
                    case 8: n8(); break;/*
                    case 9: n9(); break;
                    case 10: n10(); break;
                    case 11: n11(); break;
                    case 12: n12(); break;
                    case 13: n13(); break;
                    case 14: n14(); break;*/
                    default:
                        Console.WriteLine("Пока что не готов этот номер");
                        break;
                }
                do
                {
                    Console.WriteLine("Y or N");
                    Klavisha = Console.ReadKey(true).Key;
                }
                while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
                if (Klavisha == ConsoleKey.Y)
                    OutZadanie = true;
                else if (Klavisha == ConsoleKey.N)
                    OutZadanie = false;
            }
            while (OutZadanie);
            void n1() 
            {
                Console.Write("Введите название футбольного клуба ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 1)
                        Console.Write("Название футбольного клуба должно состоять из не менее 1-й буквы. Введите название футбольного клуба еще раз ");
                    else
                        break;
                }
                for (int i = 0; i < Slovo.Length; i++)
                {
                    Console.WriteLine(Slovo[i]);
                }
            }
            void n2()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 1)
                        Console.Write("Слово должно состоять из не менее 1-й буквы. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Console.Write("Слово наоборот: ");
                for (int i = Slovo.Length - 1; i >= 0 ; i--)
                {
                    Console.Write(Slovo[i]);
                }
                Console.WriteLine();
            }
            void n3()
            {
                string VvodSlov(int NomerSlova)
                {
                    Console.Write($"Введите {NomerSlova}-e слово ");
                    string Slovo;
                    while (true)
                    {
                        Slovo = Console.ReadLine();
                        if (Slovo.Length < 1)
                            Console.Write("Слово должно состоять из не менее 1-й буквы. Введите слово еще раз ");
                        else
                            break;
                    }
                    //=============
                    //Slovo = Slovo.ToLower();
                    return Slovo;
                }
                string Slovo1 = VvodSlov(1);
               // string Slovo2 = "";
                
                 //List<int> Otriz = new List<int>();
                 List<string> strings = new List<string> { };
                 for (int i = 0; i <Slovo1.Length; i++)
                 {
                     if ((i + 1) % 2 == 0)
                         strings.Add(Slovo1[i].ToString());
                 }
                string Slovo2 = string.Concat(strings);
                 Console.WriteLine($"Slovo2: " + Slovo2);
                
                /*for (int i = 0; i < Slovo1.Length; i++)
                {
                    if (i % 2 == 0)
                        Slovo2 += Slovo1[i];
                }*/
                Console.WriteLine($"Слово из нечетных букв первого слово: {Slovo2}");
            }
            void n4()
            {
                string VvodSlov(int NomerSlova)
                {
                    Console.Write($"Введите {NomerSlova}-e слово ");
                    string Slovo;
                    while (true)
                    {
                        Slovo = Console.ReadLine();
                        if (Slovo.Length < 1)
                            Console.Write("Слово должно состоять из не менее 1-й буквы. Введите слово еще раз ");
                        else
                            break;
                    }
                    //=============
                    Slovo = Slovo.ToLower();
                    return Slovo;
                }
                string Slovo1 = VvodSlov(1);
                string Slovo2 = "";
                for (int i = Slovo1.Length - 1; i >= 0; i--)
                {
                    Slovo2 += Slovo1[i];
                }
                Console.WriteLine($"Слово наоборот из первого слова: {Slovo2}");
            }
            void n5()
            {
                /*int kolvostar = 5;
                for (int i = 0; i < kolvostar; i++) Console.Write("*");
                Console.WriteLine();*/
                string Slovo = new string('*', 5);
                Console.WriteLine(Slovo);
            }
            void n6()
            {
                /*int kolvopodcherk = 8;
                for (int i = 0; i < kolvopodcherk; i++) Console.Write("_");
                Console.WriteLine();*/
                string Slovo = new string ('-', 8);
                Console.WriteLine(Slovo);
            }
            void n7()
            {
                Console.Write("Введите количество символов в строке: ");
                int Simvols = 0; bool OutSimvols = true;
                while (OutSimvols)
                {
                    if (!int.TryParse(Console.ReadLine(), out Simvols))
                        Console.Write("Ошибка! Введите количество символов еще раз ");
                    else if (Simvols < 0)
                        Console.Write("Количество символов не может быть меньше 0. Введите количество символов еще раз ");
                    else
                        OutSimvols = false;
                }
                Console.Write("Введите символ, который хотите видеть в строке: ");
                char Simvol;
                while (true)
                {
                    if (!char.TryParse(Console.ReadLine(), out Simvol))
                        Console.Write("ошибка! Введите символ еще раз ");
                    else
                        break;
                }
               /* for (int i = 0; i < Simvols; i++) Console.Write(Simvol);
                Console.WriteLine();*/
                string Slovo = new string(Simvol, Simvols);
                Console.WriteLine(Slovo);
            }
            void n8()
            {
                string VvodSlov(int NomerSlova)
                {
                    Console.Write($"Введите {NomerSlova}-e слово ");
                    string Slovo;
                    while (true)
                    {
                        Slovo = Console.ReadLine();
                        if (Slovo.Length < 1)
                            Console.Write("Слово должно состоять из не менее 1-й буквы. Введите слово еще раз ");
                        else
                            break;
                    }
                    //=============
                    //Slovo = Slovo.ToLower();
                    return Slovo;
                }
                string Slovo1 = VvodSlov(1);
                string Slovo2 = new string('+', 4);
                Slovo2 += Slovo1;
                Slovo2 += "-----";
                Console.WriteLine(Slovo2);
               
            }
        }
    }
}