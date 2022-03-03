using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs36_paskaita_Async
{
    public class Solution_02
    {
        // Sukurkite programą, kuri po paleidimo, kas 5 sekundes komandinėje eilutėje
        // atspausdintų Jūsų vartotojo darbastalio (desktop) katalogo turinį
        public static void DesktopContentPrinting()
        {
            // @"C:\Users\Vytautas\Desktop"
            // @"/Users/surkus/Desktop"

            //string[] allFiles = Directory.GetFiles(@"C:\Users\Vytautas\Desktop", "*.*", SearchOption.AllDirectories);
            string[] allFiles = Directory.GetFiles(@"/Users/surkus/Desktop", "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < allFiles.Length; i++)
            {
                Console.WriteLine(allFiles[i]);
            }
        }

        public static async Task DesktopContentPrintingAsync()
        {
            await Task.Run(() =>
            {
                for (int w = 0; w < 10; w++)
                {
                    //string[] allFiles = Directory.GetFiles(@"C:\Users\Vytautas\Desktop", "*.*", SearchOption.AllDirectories);
                    string[] allFiles = Directory.GetFiles(@"/Users/surkus/Desktop", "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < allFiles.Length; i++)
                    {
                        Console.WriteLine(allFiles[i]);
                    }
                    Task.Delay(5000).Wait();
                }
            });
        }
    }
}
