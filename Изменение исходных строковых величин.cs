using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Nadoelo
{
    string slovostr = string.Empty;

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
                case 21: n21(); break;
                case 22: n22(); break;
                case 23: n23(); break;
                case 24: n24(); break;
                case 25: n25(); break;
                case 26: n26(); break;
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
        Console.WriteLine("Все буквы е заменить буквой и");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace('е', 'и');
        Console.WriteLine("Все \"е\" заменены на \"и\": " + predlosh);
    }
    void n2()
    {
        Console.WriteLine("Все пробелы заменить на \"_\"");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace(' ', '_');
        Console.WriteLine("Все \" \"заменены на \"_\": " + predlosh);
    }
    void n3()
    {
        Console.WriteLine("Все символы, стоящие на четных местах, заменить на ы");
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
        Console.WriteLine("Все символы, стоящие на третьем, шестом, девятом и т.д. местах, заменить на а");
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
        Console.WriteLine("Заменить в нем все вхождения буквосочетания ах на ух");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace("ах", "ух");
        Console.WriteLine("Все \"ах\"заменены на \"ух\": " + predlosh);
    }
    void n6()
    {
        Console.WriteLine("Заменить в нем все вхождения буквосочетания да на не");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace("да", "не");
        Console.WriteLine("Все \"да\"заменены на \"не\": " + predlosh);
    }
    void n7()
    {
        Console.WriteLine("Заменить в нем все вхождения буквосочетания про на нет");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace("про", "нет");
        Console.WriteLine("Все \"про\"заменены на \"нет\": " + predlosh);
    }
    void n8()
    {
        Console.WriteLine("Заменить в нем все вхождения буквосочетания бит на рог");
        Console.Write("Введите предложение ");
        string predlosh = Console.ReadLine();
        predlosh = predlosh.ToLower();
        predlosh = predlosh.Replace("бит", "рог");
        Console.WriteLine("Все \"бит\"заменены на \"рог\": " + predlosh);
    }
    void n9()
    {
        Console.WriteLine("Заменить в нем все вхождения подстроки s1 на подстроку s2");
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
        Console.WriteLine("Символьной строке s по ошибке вместо опечатка присвоено значение очепатка. Изменить значение s так, чтобы ошибки не было");
        var opechatka = new StringBuilder("очепатка");
        (opechatka[1], opechatka[3]) = (opechatka[3], opechatka[1]);
        Console.WriteLine("Исправленное значение: " + opechatka);
    }
    void n11()
    {
        Console.WriteLine("Поменять местами его вторую и пятую буквы");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova(5)) ;
        var slovo = new StringBuilder(slovostr);
        (slovo[1], slovo[4]) = (slovo[4], slovo[1]);
        Console.WriteLine("Измененное слово:" + slovo);
    }
    void n12()
    {
        Console.WriteLine("Поменять местами его третью и последнюю буквы");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova(3)) ;
        var slovo = new StringBuilder(slovostr);
        (slovo[2], slovo[slovo.Length - 1]) = (slovo[slovo.Length - 1], slovo[2]);
        Console.WriteLine("Измененное слово:" + slovo);
    }
    void n13()
    {
        Console.WriteLine("Поменять местами его m-ю и n-ю буквы");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova()) ;
        int m = ZaprosNomeraBukvu("m");
        int n = ZaprosNomeraBukvu("n");
        var slovo = new StringBuilder(slovostr);
        (slovo[m - 1], slovo[n - 1]) = (slovo[n - 1], slovo[m - 1]);
        Console.WriteLine("Измененное слово:" + slovo);
    }
    void n14()
    {
        Console.WriteLine("Дано слово из четного числа букв. Поменять местами первую букву со второй, третью — с четвертой и т. д.");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova() || ProverkaChet()) ;
        var slovo = new StringBuilder(slovostr);
        for (int i = 0; i < slovo.Length; i += 2)
        {
            (slovo[i], slovo[i + 1]) = (slovo[i + 1], slovo[i]);
        }
        Console.WriteLine("Измененное слово:" + slovo);
    }
    void n15()
    {
        Console.WriteLine("Дано слово из четного числа букв. Поменять местами его половины следующим способом: первую букву поменять с последней, вторую — с предпоследней и т. д.");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova() || ProverkaChet()) ;
        var slovo = new StringBuilder(slovostr);
        for (int i = 0; i < slovo.Length / 2; i++)
        {
            (slovo[i], slovo[slovo.Length - 1 - i]) = (slovo[slovo.Length - 1 - i], slovo[i]);
        }
        Console.WriteLine("Измененное слово:" + slovo);
    }
    //дз по 26
    void n20()
    {
        Console.WriteLine("а) Удалить из него третью букву");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova(3)) ;
        Console.WriteLine("a) Удалена третья буква: " + UdalenieBukv(3));
        //============
        Console.WriteLine("Удалить букву с номером k ");
        Console.WriteLine("б) Удалена k-я буква: " + UdalenieBukv(ZaprosNomeraBukvu("k")));

    }
    void n21()
    {
        Console.WriteLine("а) Удалить из него первую из букв о, если такая буква есть. б) Удалить из него последнюю из букв л, если такая буква есть");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova()) ;
        if (Array.Exists(slovostr.ToCharArray(), g => g == 'о'))
            Console.WriteLine("а) Удалена первая буква о: " + UdalenieBukv(Array.FindIndex(slovostr.ToCharArray(), g => g == 'о') + 1));
        else
            Console.WriteLine("а) В слове нет букв о");
        //==========
        if (Array.Exists(slovostr.ToCharArray(), g => g == 'л'))
            Console.WriteLine("б) Удалена последняя буква л: " + UdalenieBukv(Array.FindLastIndex(slovostr.ToCharArray(), g => g == 'л') + 1));
        else
            Console.WriteLine("б) В слове нет букв л");
    }
    void n22()
    {
        Console.WriteLine("Дано слово. Если его длина нечетная, то удалить среднюю букву, в противном случае — две средних буквы.");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova()) ;
        if (Chet())
            Console.WriteLine("Слово состоит из четного кол-ва букв. Измененное слово: " + UdalenieBukv(new int[] { slovostr.Length / 2, slovostr.Length / 2 }));
        else
            Console.WriteLine("Слово состоит из нечетного кол-ва букв. Измененное слово: " + UdalenieBukv(slovostr.Length / 2 + 1));
    }
    void n23()
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
    void n24()
    {
        Console.WriteLine("Дано предложение. Удалить из него все буквы с");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        char Sim = 'с';
        var slovo = new StringBuilder(slovostr);
        var NomeraBukv = new List<int>();
        for (int i = 0; i < slovo.Length; i++)
        {
            if (slovo[i] == Sim)
                NomeraBukv.Add(i + 1);
        }
        Console.WriteLine("Измененное слово: " + UdalenieBukv(NomeraBukv.ToArray()));
    }
    void n25()
    {
        Console.WriteLine("Дано слово. Удалить из него все повторяющиеся буквы, оставив их первые вхождения, т. е. в слове должны остаться только различные буквы");
        Console.Write("Введите слово ");
        while (ProverkaVvodaSlova()) ;
        var UnikSim = string.Concat(slovostr.ToCharArray().Distinct());
        Console.WriteLine("Измененное слово: " + UnikSim);
    }
    void n26()
    {
        Console.WriteLine("Дано предложение. Удалить из него все буквы о, стоящие на нечетных местах");
        Console.Write("Введите предложение ");
        while (ProverkaVvodaPredlosh()) ;
        char Sim = 'о';
        var slovo = new StringBuilder(slovostr);
        var NomeraBukv = new List<int>();
        for (int i = 0; i < slovo.Length; i++)
        {
            if (slovo[i] == Sim && i % 2 == 0)
                NomeraBukv.Add(i + 1);
        }
        Console.WriteLine("Измененное слово: " + UdalenieBukv(NomeraBukv.ToArray()));
    }
    //================
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
    bool ProverkaChet(int minbukv = 1)
    {
        if (!Chet())
        {
            Console.Write("Введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
            return true;
        }
        else
            return false;
    }
    bool Chet()
    {
        if (slovostr.Length % 2 == 0)
            return true;
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
    string UdalenieBukv(int NomeraBukv)
    {
        var slovo1 = new StringBuilder(slovostr);
        string Slovo = string.Empty;
        var help = slovostr.Substring(0, NomeraBukv - 1);
        Slovo += help;
        Slovo += slovostr.Substring(NomeraBukv);
        Slovo += '_';
        return Slovo;
    }
}
