using System;

namespace Stroki
{
    public class AAAAAA
    {
        public void TipoMain()
        {
            Console.WriteLine("String ");
            do
            {
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
                    case 4: n4(); break;
                    case 5: n5(); break;
                    case 7: n7(); break;
                    case 8: n8(); break;
                    case 9: n9(); break;
                    default:
                        Console.WriteLine("Пока что не готов этот номер");
                        break;
                }
            }
            while (true);
            void n1()
            {
                Console.Write("Введите ваше имя ");
                var i = Console.ReadLine();
                Console.WriteLine("Ваше имя: " + i);
                Console.WriteLine("Привет, " + i + "!");
            }
            void n2()
            {
                Console.Write("Введите название футбольной команды ");
                var i = Console.ReadLine();
                Console.WriteLine(i + " - это чемпион");
            }
            void n3()
            {
                Console.Write("Введите имя ");
                var i = Console.ReadLine();
                Console.Write("Введите фамилию ");
                var r = Console.ReadLine();
                Console.WriteLine("Ваше ФИ: " + r + " "+ i);
            }
            void n4()
            {
                Console.Write("Введите название государства ");
                var Gos = Console.ReadLine();
                string Stol = " ";
                if (Gos.ToLower() == "россия" || Gos.ToLower() == "российская федерация")
                {
                    bool df = true;
                    do
                    {

                        vvodstol();
                        if (Stol.ToLower() != "москва")
                            Console.Write("Ошибка! Введите столицу еще раз ");
                        else
                            df = false;
                    }
                    while (df);
                }
                void vvodstol()
                {
                    Console.Write($"Введите название столицы государства {Gos} ");
                    Stol = Console.ReadLine();
                }
                Console.WriteLine($"Столица государства {Gos} - город {Stol}");
            }
            void n5()
            {
                Console.Write("Введите название романа ");
                var fg = Console.ReadLine();
                Console.Write("Введите фамиию автора ");
                var jkjh = Console.ReadLine();
                Console.WriteLine($"Писатель {jkjh} - автор романа {fg}");
            }
            void n7()
            {
                Console.Write("Введите название футбольного клуба ");
                var asdfghjkl = Console.ReadLine();
                Console.WriteLine("Кол-во символов в названии футбольного клуба " + asdfghjkl.Length);
            }
            void n8()
            {
                Console.Write("Введите название города ");
                var asdfghjkl = Console.ReadLine();
                string jgkslgjdskljhsf = asdfghjkl.Length % 2 == 0 ? ("четно") : ("не четно");
                Console.WriteLine("Кол-во символов в названии города " + jgkslgjdskljhsf);
            }
            void n9()
            {
                Console.Write("Введите первую фамилию ");
                var sdfjk = Console.ReadLine();
                Console.Write("Введите Вторую фамилию ");
                var sdfjk1 = Console.ReadLine();
                if (sdfjk.Length == sdfjk1.Length)
                    Console.WriteLine("Они одинаковой длины");
                else if (sdfjk.Length > sdfjk1.Length)
                    Console.WriteLine("Первая фамилия длинее, чем вторая");
                else
                    Console.WriteLine("Первая фамилия короче, чем вторая");
            }
        }
    }
}