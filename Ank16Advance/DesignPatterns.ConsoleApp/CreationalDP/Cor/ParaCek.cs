using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.CreationalDP.Cor
{
    public class ParaCek
    {
        public ParaCek(string musteriId, decimal miktar, string paraBirimi, string hesabNo)
        {
            MusteriId = musteriId;
            Miktar = miktar;
            ParaBirimi = paraBirimi;
            HesabNo = hesabNo;
        }

        public string MusteriId { get; set; }
        public decimal Miktar { get; set;}
        public string ParaBirimi { get; set; }
        public string HesabNo { get; set; }
    }
}
