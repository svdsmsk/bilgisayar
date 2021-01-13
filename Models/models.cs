using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class models
    {
        public models(string pcRAM, string pcHDD, string pcPSUWATT, string pcEKRANKARTI, string pcANAKART)
        {
            PcRAM = pcRAM;
            PcHDD = pcHDD;
            PcPSUWATT = pcPSUWATT;
            PcEKRANKARTI = pcEKRANKARTI;
            PcANAKART = pcANAKART;
        }

        public string PcRAM { get; set; }
        public string PcHDD { get; set; }
        public string PcPSUWATT { get; set; }
        public string PcEKRANKARTI { get; set; }
        public string PcANAKART { get; set; }
    }
}
