using System;
using System.Threading.Tasks;

namespace cs36_paskaita_Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs36_paskaita_Async-Multithreading");

            #region TEORIJA

            // Iki dabar mes rašėme synchronous code

            #endregion

            //Solution_01_Run();
            Solution_02_Run();


        }
        public static void Solution_01_Run()
        {
            // (2) Jūsų programėlės main metodas turėtų sukurti ProgressBar tipo objektą
            //     ir vykdyti ciklą, kuris didintų progress lauko reikšmę vienetu kas sekundę, tol
            //     kol reikšmė pasiekia 100.
            var progressBar = new ProgressBar(0);
            Solution_01.CountingAsync(progressBar);
            Solution_01.PrintingAsync(progressBar);
            Console.ReadKey(); // <-- Be šito niekas nebeveikia

        }

        public static void Solution_02_Run()
        {
            //Solution_02.DesktopContentPrinting();
            Solution_02.DesktopContentPrintingAsync();
            Console.ReadKey(); // <-- Be šito niekas nebeveikia
        }
    }
}
