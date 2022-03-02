using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs36_paskaita_Async
{
    public class Solution_01
    {
        // (1) Sukurkite klasę ProgressBar, kuris turėtų int lauką progress.
        // (2) Jūsų programėlės main metodas turėtų sukurti ProgressBar tipo objektą
        //     ir vykdyti ciklą, kuris didintų progress lauko reikšmę vienetu kas sekundę, tol
        //     kol reikšmė pasiekia 100.
        // (3) Sukurkite kitą giją, kuri kas 3 sekundes į konsolę išvestų ProgressBar objekto,
        //     progress lauko reikšmę, tol, kol programa veikia.
        public static async Task Counting(ProgressBar progressBar)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    //progressBar.Progress += 1;
                    Console.WriteLine($"{progressBar.Progress++} ++");
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static async Task Printing(ProgressBar progressBar)
        {
            // (3) Sukurkite kitą giją, kuri kas 3 sekundes į konsolę išvestų ProgressBar objekto,
            //     progress lauko reikšmę, tol, kol programa veikia.
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Task.Delay(3000).Wait();
                    Console.WriteLine($"{progressBar.Progress} <-- COUNTER Method");
                }
            });
        }
    }
}
