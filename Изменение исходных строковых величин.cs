using System;
using System.Text;

public class Nadoelo
{
    delegate bool Proverki(int x);
    string slovostr = " ";

    public void TipoMain()
    {
        Console.WriteLine("Изменение исходных строковых величин ");
        byte NomerZadaniy; bool NomerZadaniyOut;
        while (true)
        {
            Console.Write("Введите номер задания: ");
            NomerZadaniy = 1; NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");/*
                else if (NomerZadaniy <= 0 || NomerZadaniy > 15)
                    Console.Write("В дз всего 15 заданий, Введите номер задания еще раз ");*/
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
                case 7: n7(); break;
                case 8: n8(); break;
                case 9: n9(); break;
                case 10: n10(); break;
                case 11: n11(); break;
                case 12: n12(); break;
                case 13: n13(); break;
                case 14: n14(); break;
                case 15: n15(); break;
                case 20: n20(); break;
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

        Proverki proverki;
        void n1()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace('е', 'и');
            Console.WriteLine("Все \"е\"заменены на \"и\": " + predlosh);
        }
        void n2()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace(' ', '_');
            Console.WriteLine("Все \" \"заменены на \"_\": " + predlosh);
        }
        void n3()
        {
            Console.Write("Введите предложение ");
            StringBuilder predlosh = new StringBuilder(Console.ReadLine());
            for (int i = 1; i < predlosh.Length; i += 2)
            {
                predlosh[i] = 'ы';
            }
            Console.WriteLine("Все символы, стоящие на четных местах заменены на \"ы\": " + predlosh);
        }
        void n4()
        {
            Console.Write("Введите предложение ");
            StringBuilder predlosh = new StringBuilder(Console.ReadLine());
            for (int i = 2; i < predlosh.Length; i += 3)
            {
                predlosh[i] = 'а';
            }
            Console.WriteLine("Все символы, стоящие на 3, 6, 9 и т.д. заменены на \"а\": " + predlosh);
        }
        void n5()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace("ах", "ух");
            Console.WriteLine("Все \"ах\"заменены на \"ух\": " + predlosh);
        }
        void n6()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace("да", "не");
            Console.WriteLine("Все \"да\"заменены на \"не\": " + predlosh);
        }
        void n7()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace("про", "нет");
            Console.WriteLine("Все \"про\"заменены на \"нет\": " + predlosh);
        }
        void n8()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            predlosh = predlosh.Replace("бит", "рог");
            Console.WriteLine("Все \"бит\"заменены на \"рог\": " + predlosh);
        }
        void n9()
        {
            Console.Write("Введите предложение ");
            string predlosh = Console.ReadLine();
            predlosh = predlosh.ToLower();
            Console.Write("Введите подстроку s1 ");
            var s1 = Console.ReadLine();
            Console.Write("Введите подстроку s2 ");
            var s2 = Console.ReadLine();
            predlosh = predlosh.Replace(s1, s2);
            Console.WriteLine("Все вхождения s1 заменены на s2: " + predlosh);
        }
        void n10()
        {
            var opechatka = new StringBuilder("очепатка");
            (opechatka[1], opechatka[3]) = (opechatka[3], opechatka[1]);
            Console.WriteLine("Исправленное значение: " + opechatka);
        }
        void n11()
        {
            Console.Write("Введите слово ");
            //string slovostr;
            proverki = Proverka;
            while (proverki(5)) ;
            /*bool Proverka()
            {
                slovostr = Console.ReadLine().Trim();
                if (slovostr.Length < 5)
                {
                    Console.Write("Слово должно быть минимум из пяти букв. Введите слово еще раз ");
                    return true;
                }
                else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                {
                    Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                    return true;
                }
                else
                    return false;
            }*/
            var slovo = new StringBuilder(slovostr);
            (slovo[1], slovo[4]) = (slovo[4], slovo[1]);
            Console.WriteLine("Измененное слово:" + slovo);
        }
        void n12()
        {
            Console.Write("Введите слово ");
            //string slovostr;
            proverki = Proverka;
            while (proverki( 3)) ;
            /*while (Proverka()) ;
            bool Proverka()
            {
                slovostr = Console.ReadLine().Trim();
                if (slovostr.Length < 3)
                {
                    Console.Write("Слово должно быть минимум из трех букв. Введите слово еще раз ");
                    return true;
                }
                else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                {
                    Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                    return true;
                }
                else
                    return false;
            }*/
            var slovo = new StringBuilder(slovostr);
            (slovo[2], slovo[slovo.Length - 1]) = (slovo[slovo.Length - 1], slovo[2]);
            Console.WriteLine("Измененное слово:" + slovo);
        }
        void n13()
        {
            Console.Write("Введите слово ");
            //string slovostr;
            proverki = Proverka;
            while (proverki(1)) ;
            /*while (Proverka()) ;
            bool Proverka()
            {
                slovostr = Console.ReadLine().Trim();
                if (slovostr.Length < 1)
                {
                    Console.Write("Слово должно быть минимум одной буквы. Введите слово еще раз ");
                    return true;
                }
                else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                {
                    Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                    return true;
                }
                else
                    return false;
            }*/
            
            int m = ZaprosNomeraBukvu("m");
            int n = ZaprosNomeraBukvu("n");
            var slovo = new StringBuilder(slovostr);
            (slovo[m - 1], slovo[n - 1]) = (slovo[n - 1], slovo[m - 1]);
            Console.WriteLine("Измененное слово:" + slovo);
        }
        //================

        
            void n14()
            {
                Console.Write("Введите слово ");
                proverki = Proverka;
                proverki += ProverkaChet;
                while (proverki(1)) ;
                /*while (Proverka()) ;
                bool Proverka()
                {
                    slovostr = Console.ReadLine().Trim();
                    if (slovostr.Length < 1)
                    {
                        Console.Write("Слово должно быть минимум одной буквы. Введите слово еще раз ");
                        return true;
                    }
                    else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                    {
                        Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                        return true;
                    }
                    else if (slovostr.Length % 2 != 0)
                    {
                        Console.Write("введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                        return true;
                    }
                    else
                        return false;
                }*/
                var slovo = new StringBuilder(slovostr);
                for (int i = 0; i < slovo.Length; i += 2)
                {
                    (slovo[i], slovo[i + 1]) = (slovo[i + 1], slovo[i]);
                }
                Console.WriteLine("Измененное слово:" + slovo);
            }
            void n15()
            {
                Console.Write("Введите слово ");


            
            proverki = Proverka;
            proverki += ProverkaChet;
            while (proverki(1)) ;
            /*while (Proverka()) ;
                bool Proverka()
                {
                    slovostr = Console.ReadLine().Trim();
                    if (slovostr.Length < 1)
                    {
                        Console.Write("Слово должно быть минимум одной буквы. Введите слово еще раз ");
                        return true;
                    }
                    else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                    {
                        Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                        return true;
                    }
                    else if (slovostr.Length % 2 != 0)
                    {
                        Console.Write("введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                        return true;
                    }
                    else
                        return false;
                }*/
                var slovo = new StringBuilder(slovostr);
                for (int i = 0; i < slovo.Length / 2; i++)
                {
                    (slovo[i], slovo[slovo.Length - 1 - i]) = (slovo[slovo.Length - 1 - i], slovo[i]);
                }
                Console.WriteLine("Измененное слово:" + slovo);
            }
            void n20()
            {
                Console.Write("Введите слово ");
            }
            bool Proverka(int minbukv = 1)
            {
                slovostr = Console.ReadLine().Trim();
                if (slovostr.Length < minbukv)
                {
                    Console.Write($"Слово должно быть минимум из {minbukv} букв. Введите слово еще раз ");
                    return true;
                }
                else if (slovostr.Split(new char[] { ' ' }).Length != 1)
                {
                    Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                    return true;
                }
                /*else if (slovostr.Length % 2 != 0)
                {
                    Console.Write("Введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                    return true;
                }*/
                else
                    return false;

            }
            bool ProverkaChet( int minbukv = 1)
            {
                if (slovostr.Length % 2 != 0)
                {
                    Console.Write("Введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                    return true;
                }
                else
                    return false;
            }
            int ZaprosNomeraBukvu(string name)
            {
                Console.Write($"Введите номер {name} буквы ");
                int NomerBukvu;
                while (true)
                {

                    if (!int.TryParse(Console.ReadLine(), out NomerBukvu))
                        Console.Write($"Ошибка! Введите номер {name} буквы еще раз ");
                    else if (NomerBukvu <= 0 || NomerBukvu > slovostr.Length)
                        Console.Write($"Номер буквы не может быть неположительным и больше кол-ва букв в слове ({slovostr.Length}).Введите номер {name} буквы еще раз  ");
                    else
                        break;
                }
                return NomerBukvu;
            }
        
    }
}
