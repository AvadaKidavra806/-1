//using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using Код_по_блок_схеме_на_10._02._26;
//using Расчет_суммы_или_колва_элементов_массива_9_2_26;

namespace Main
{
    internal class ClaasMain
    {
        static void Main()
        {
            //ClassForMassiv.Help help = new ClassForMassiv.Help(); help.help();
            //DvumerMasMaxMin.Reshenie reshenie = new DvumerMasMaxMin.Reshenie(); reshenie.Nomerov();
            //Zadachi.Zapolnenie zapolnenie = new Zadachi.Zapolnenie(); zapolnenie.Vuvod();
            //Metod.Hellp hellp = new Metod.Hellp(); hellp.Heellp();
            //ProverkaUslovia.PosleRaschetov posle = new ProverkaUslovia.PosleRaschetov(); posle.DmumerMassiv();
            Otrabotka.Metodov metodov = new Otrabotka.Metodov(); metodov.TipoMain();
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
