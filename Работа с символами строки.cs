using System;

namespace Stroki
{
    public class Simvol
    {
        public void TipoMain()
        {
            Console.WriteLine("Работа с символами строки");
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
                    case 8: n8(); break;
                    case 9: n9(); break;
                    case 10: n10(); break;
                    case 11: n11(); break;
                    case 12: n12(); break;
                    case 13: n13(); break;
                    case 14: n14(); break;
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
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 3)
                        Console.Write("Слово должно состоять из не менее 3-х букв. Введите слово еще раз ");
                    else
                        break;
                }
                Console.WriteLine("Третий символ в слове: " + Slovo[2]);

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
                Console.WriteLine("Последний символ в слове: " + Slovo[Slovo.Length-1]);
            }
            void n3()
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
                Console.WriteLine("Вывести на экран k-й символ ");
                Console.Write("Введите k ");
                int k;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out k))
                        Console.Write("Ошибка! Введите k еще раз ");
                    else if (k <= 0 || k > Slovo.Length)
                        Console.Write($"k должна быть положительной и меньше чем кол-во символов в слове  ({Slovo.Length}). Введите k еще раз ");
                    else
                        break;
                }
                Console.WriteLine("k-й символ в слове: " + Slovo[k - 1]);
            }
            void n4()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 4)
                        Console.Write("Слово должно состоять из не менее 4-х букв. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Slovo = Slovo.ToLower();
                //Console.WriteLine(Slovo);
                if (Slovo[1] == Slovo[3])
                    Console.WriteLine("Второй и четвертый символы одинаковы");
                else
                    Console.WriteLine("Второй и четвертый символы не одинаковы");
            }
            void n5()
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
                Slovo = Slovo.ToLower();
                if (Slovo[0] == Slovo[Slovo.Length - 1])
                    Console.WriteLine("Слово начинается и заканчивается на одну и ту же букву");
                else
                    Console.WriteLine("Слово не начинается и не заканчивается на одну и ту же букву");
            }
            void n6()
            {
                string VvodSlov(int NomerSlova)
                {
                    Console.Write($"Введите {NomerSlova}-e слово ") ;
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
                string Slovo2 = VvodSlov(2);
                if (Slovo1[0] == Slovo2[Slovo2.Length - 1])
                    Console.WriteLine("Верно, первое слово начинается на ту же букву, на которую заканчивается второе");
                else
                    Console.WriteLine("Не верно, первое слово не начинается на ту же букву, на которую заканчивается второе");
            }
            void n7()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 4)
                        Console.Write("Слово должно состоять из не менее 4-х букв. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Console.WriteLine("Буквосочетание из 2-го и 4-го символов: " + Slovo[1] + Slovo[3]);
            }
            void n8()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 3)
                        Console.Write("Слово должно состоять из не менее 3-х букв. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Console.WriteLine("Буквосочетание из 3-го и последнего символов: " + Slovo[2] + Slovo[Slovo.Length-1]);
            }
            void n9()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length < 4)
                        Console.Write("Слово должно состоять из не менее 4-х букв. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Console.WriteLine("Часть слова из 2-го, 3-го и 4-го символов: " + Slovo[1] + Slovo[2] + Slovo[3]);
            }
            void n10()
            {
                Console.Write("Введите слово ");
                string Slovo;
                while (true)
                {
                    Slovo = Console.ReadLine();
                    if (Slovo.Length == 0 && Slovo.Length % 2 != 0)
                        Console.Write("Слово должно состоять из не менее 1-й буквы и кол-во символов должно быть четным. Введите слово еще раз ");
                    else
                        break;
                }
                //=============
                Console.WriteLine("Первая половина слова: "+ Slovo.Substring(0, Slovo.Length / 2));
            }
            void n11()
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
                Console.WriteLine("Получить часть слова, от m по n");
                
                int m = VvodMN('m');
                int n = VvodMN('n');
                int  VvodMN(char var)
                {
                    Console.Write($"Введите {var} ");
                    int mn;
                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out mn))
                            Console.Write($"Ошибка! Введите {var} еще раз ");
                        else if (mn <= 0 || mn > Slovo.Length)
                            Console.Write($"{var} не может быть отрицательным и больше кол-ва символов в строке ({Slovo.Length}). Введите {var} еще раз ");
                        else
                            break;
                    }
                    return mn;
                }
                Console.WriteLine("Часть слова, от m до n: " + Slovo.Substring(m-1, n - m + 1));
            }
            void n12()
            {
                string Abloko = "яблоко";
                Console.WriteLine("Из яблоко в око: " + Abloko.Substring(3));
                Console.WriteLine("Из яблоко в блок: " + Abloko.Substring(1, 4));
            }
            void n13()
            {
                string Abloko = "информатика";
                Console.WriteLine("Из информатика в форма: " + Abloko.Substring(2, 5));
                Console.WriteLine("Из информатика в тик: " + Abloko.Substring(7, 3));
            }
            void n14()
            { 
            
            }

        }
    }
}