using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs36_paskaita_Async
{
    public class ProgressBar
    {
        // (1) Sukurkite klasę ProgressBar, kuris turėtų int lauką progress.
        public int Progress { get; set; }

        public ProgressBar(int progress)
        {
            Progress = progress;
        }
    }
}
