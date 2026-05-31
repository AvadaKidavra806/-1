using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class Rabota_So_Strokami
{
    string slovostr = string.Empty;
    public void TipoMain()
    {
        Console.WriteLine("Итоговая работа со строками ");
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
                case 1: n1(); break;//не сделано
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
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            ConsoleKey Klavisha;
            Console.WriteLine("Для выбора след задания нажмите Y, Для завершения программы N (Y or N)");
            do
            {
                Klavisha = Console.ReadKey(true).Key;
            }
            while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
            if (Klavisha == ConsoleKey.N)
                break;
        }
    }
    void n1()
    {
        const int Kolvoslov = 3;
        string VvodSlov(int nomerslova)
        {
            Console.Write($"Введите {nomerslova}-е слово ");
            while (ProverkaVvodaSlova()) ;
            return slovostr;
        }
        var Slova = new string[Kolvoslov];
        var DlinuSlov = new int[Kolvoslov];
        for (int i = 0; i < Slova.Length; i++)
        {
            Slova[i] = VvodSlov(i + 1);
            DlinuSlov[i] = Slova[i].Length;
        }
        for (int i = 0; i < Kolvoslov; i++)
        {
            for (int j = i + 1; j < Kolvoslov; j++)
            {
                if (DlinuSlov[i] < DlinuSlov[j])
                {
                    (DlinuSlov[i], DlinuSlov[j]) = (DlinuSlov[j], DlinuSlov[i]);
                    (Slova[i], Slova[j]) = (Slova[j], Slova[i]);
                }
            }
        }
        //Console.WriteLine("Слова: " + string.Join(", ", Slova));
        var BigSlova = new List<string>();
        int y = 0;
        while (DlinuSlov[y] == DlinuSlov[y + 1] && y < Kolvoslov)
        {
            BigSlova.Add(Slova[y + 1]);
        }
        var SmalSlova = new List<string>();
        /*for (int i = 0; i < Kolvoslov; i++)
        { 
        if ()
        }*/

        // int[] dlinuslov = new int[] { Slovo1.Length, Slovo2.Length, Slovo3.Length };

        /* if (Dlina1 == Dlina2 && Dlina2 == Dlina3)
             Console.WriteLine("Все слова одинаковой длины");
         else
         {
             if (Dlina1 < Dlina2 || Dlina1 < Dlina3)
             {
                 if (Dlina1 < Dlina2 && Dlina1 < Dlina3)
                 {
                     if (Dlina2 < Dlina3)
                     {
                         Console.WriteLine($"Самое короткое слово: {Slovo1}");
                         Console.WriteLine($"Самое длинное слово: {Slovo3}");
                     }
                 }
                 else if (Dlina2 < Dlina3)
                     Console.WriteLine($"Самое короткое слово: {Slovo2}");
                 else
                     Console.WriteLine($"Самое короткое слово: {Slovo3}");
             }
         } //чем гуще лес, ох зря я туда полез*/
    }
    void n2()
    {
        Console.WriteLine("Дано слово. Вывести на экран его k-й символ. Переставить первые три и последние три буквы, сохранив порядок их следования.");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova(3)) ;
        int k = ZaprosNomeraBukvu("k");
        Console.WriteLine($"k-й символ слова: {slovostr[k - 1]}");
        var SlovoSB = new StringBuilder(slovostr);
        for (int i = 0; i < 3; i++)
        {
            (SlovoSB[i], SlovoSB[SlovoSB.Length - 3 + i]) = (SlovoSB[SlovoSB.Length - 3 + i], SlovoSB[i]);
        }
        Console.WriteLine("Измененное слово: " + SlovoSB);
    }
    void n3()
    {
        Console.WriteLine("Дано предложение. Определить долю (в %) букв а в нем");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        slovostr = slovostr.ToLower();
        double countbukv = 0;
        char bukva = 'а';
        for (int i = 0; i < slovostr.Length; i++)
        {
            if (slovostr[i] == bukva)
                countbukv++;
        }
        Console.WriteLine($"Доля букв {bukva} в процентах: " + countbukv / slovostr.Length * 100);
    }
    void n4()
    {
        Console.WriteLine("Дано предложение. Определить порядковые номера первой пары одинаковых соседних символов. Если таких символов нет, то вывеси соотетствующее сообщение");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        bool indekator = true;
        for (int i = 0; i < slovostr.Length - 1; i++)
        {
            if (slovostr[i] == slovostr[i + 1])
            {
                Console.WriteLine("Номера первых одинаковых символов: " + (i + 1) + ", " + (i + 2));
                indekator = false;
                break;
            }
        }
        if (indekator)
            Console.WriteLine("В предложении нет соседних одинаковых символов");
    }
    void n5()
    {
        Console.WriteLine("Дано предложение. Все символы на нечетных местах поменять на \"_\"");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        var Predlosh = new StringBuilder(slovostr);
        for (int i = 0; i < Predlosh.Length; i += 2)
        {
            Predlosh[i] = '_';
        }
        Console.WriteLine("Измененное предложение: " + Predlosh);
    }
    void n6()
    {
        Console.WriteLine("Дано предложение. Удалить из него все символы с n1-го по n2-й");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        var N1 = ZaprosNomeraBukvu("n1");
        var N2 = ZaprosNomeraBukvu("n2");
        var NomeraBukv = new int[N2 - N1 + 1];
        for (int i = 0; i < NomeraBukv.Length; i++)
        {
            NomeraBukv[i] = N1 + i;
        }
        Array.Sort(NomeraBukv);
        Console.WriteLine("Измененное слово: " + UdalenieBukv(NomeraBukv));
    }
    void n7()
    {
        Console.WriteLine("Дано предложение, оканчивающееся символом «_». Вставить заданную букву перед последней буквой и.");
        Console.Write("Введите слово, которая оканчивается \"_\" и есть хотя бы одна буква \"и\": ");
        char bukva = 'и';
        char sim = '_';
        while (ProverkaVvodaPredlosh() || ProverkaNaBukvu(bukva) || ProverkaNaKonez(sim)) ;
        Console.Write("Введите символ, который необходимо вставить ");
        char SimS = VvodChara();
        int IndexBukvu = Array.FindLastIndex(slovostr.ToCharArray(), d => d == bukva);
        var Slovo = new StringBuilder(slovostr);
        Slovo[Slovo.Length - 1] = SimS;
        for (int i = Slovo.Length - 1; i > IndexBukvu; i--)
        {
            (Slovo[i], Slovo[i - 1]) = (Slovo[i - 1], Slovo[i]);
        }
        Console.WriteLine("Измененное слово: " + Slovo);
    }
    void n8()
    {
        Console.WriteLine("Дан текст. Найти сумму всех имеющихся в нем чисел. Найти максимальное и минимальное из имеющихся в нем чисел.");
        Console.Write("Введите текст ");
        while (ProverkaVvodaPredlosh()) ;
        var Slovo = new StringBuilder(slovostr);
        var ChislaAsSB = new StringBuilder(" ");
        for (int i = 0; i < Slovo.Length; i++)
        {
            if (IsZifra(Slovo[i]))
                ChislaAsSB.Append(Slovo[i]);
            else
                ChislaAsSB.Append(' ');
        }
        var ChislaAsString = ChislaAsSB.ToString().Trim();
        Console.WriteLine("ChislaAsString: " + ChislaAsString);
        var ChislaAsMassiv = Array.ConvertAll(ChislaAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        Console.WriteLine("Сумма чисел: " + ChislaAsMassiv.Sum() + "\nМаксимальное: " + ChislaAsMassiv.Max() + "\nМинимальное: " + ChislaAsMassiv.Min());
    }
    void n9()
    {
        var Slovo1 = VvodSlov(1);
        var Slovo2 = VvodSlov(2);
        string VvodSlov(int nomerslova)
        {
            Console.Write($"Введите {nomerslova}-е слово ");
            while (ProverkaVvodaSlova()) ;
            return slovostr;
        }
        char[] Bukvu1 = Slovo1.ToCharArray();
        bool indikator = true;
        for (int i = 0; i < Slovo2.Length; i++)
        {
            if (ProverkaMassiva(Slovo2[i]))
                indikator &= true;
            else
                indikator &= false;
        }
        if (!indikator)
            Console.WriteLine("Нельзя");
        else
            Console.WriteLine("Можно");
        bool ProverkaMassiva(char Bukva)
        {
            for (int i = 0; i < Bukvu1.Length; i++)
            {
                if (Bukva == Bukvu1[i])
                {
                    Bukvu1[i] = '@';
                    return true;
                }
            }
            return false;
        }
    }
    void n10()
    {
        Console.WriteLine("Дано слово. Определить сколько различных букв в нем ");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova()) ;
        string UnikSlovo = string.Concat(slovostr.ToLower().Distinct());
        Console.WriteLine("Различных букв: " + UnikSlovo.Length);
    }
    void n11()
    {
        Console.WriteLine("Дано предложение. Напечатать все его слова в порядке неубывания их длин.");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        var Slova = slovostr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var DlinuSlov = new int[Slova.Length];
        for (int i = 0; i < Slova.Length; i++)
        {
            //Slova[i] = VvodSlov(i + 1);
            DlinuSlov[i] = Slova[i].Length;
        }
        for (int i = 0; i < Slova.Length; i++)
        {
            for (int j = i + 1; j < Slova.Length; j++)
            {
                if (DlinuSlov[i] < DlinuSlov[j])
                {
                    (DlinuSlov[i], DlinuSlov[j]) = (DlinuSlov[j], DlinuSlov[i]);
                    (Slova[i], Slova[j]) = (Slova[j], Slova[i]);
                }
            }
        }
        Console.WriteLine("Слова в порядке неубывания: " + string.Join(", ", Slova));
    }
    //=======================
    bool IsZifra(char simbol)
    {
        var Zifru = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        if (Array.Exists(Zifru, h => h == simbol))
            return true;
        else
            return false;
    }
    char VvodChara()
    {
        char Vremynka;
        while (true)
        {
            if (char.TryParse(Console.ReadLine(), out Vremynka))
            {
                return Vremynka;
            }
            else
            {
                Console.Write("Ошибка! Введите символ еще раз ");
            }
        }
    }
    bool ProverkaVvodaPredlosh()
    {
        slovostr = Console.ReadLine().Trim();
        if (slovostr.Length == 0)
        {
            Console.Write("В предложении должно быть минимум одно слово. Введите предложение еще раз ");
            return true;
        }
        else
            return false;
    }
    bool ProverkaVvodaSlova(int minbukv = 1)
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
        else
            return false;
    }
    bool ProverkaNaBukvu(char bukva)
    {
        if (Array.Exists(slovostr.ToCharArray(), h => h == bukva))
            return false;
        else
        {
            Console.Write($"В предложении должно быть хотя бы одна буква \"{bukva}\". Введите предложение еще раз ");
            return true;
        }
    }
    bool ProverkaNaKonez(char simb)
    {
        if (slovostr[slovostr.Length - 1] == simb)
            return false;
        else
        {
            Console.Write($"В конце предложения должен быть символ \"{simb}\". Введите предложение еще раз ");
            return true;
        }
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
                Console.Write($"Номер буквы не может быть неположительным и больше кол-ва букв в слове ({slovostr.Length}).Введите номер {name} буквы еще раз ");
            else
                break;
        }
        return NomerBukvu;
    }
    string UdalenieBukv(int[] NomeraBukv)
    {
        string Slovo = string.Empty;
        int hellp = 0;
        for (int i = 0; i < NomeraBukv.Length; i++)
        {
            var help = slovostr.Substring(hellp, NomeraBukv[i] - hellp - 1);
            // Console.WriteLine("help: " + help);
            hellp = NomeraBukv[i];
            Slovo += help;
        }
        Slovo += slovostr.Substring(hellp);
        Slovo += new string('_', NomeraBukv.Length);
        return Slovo;
    }
}