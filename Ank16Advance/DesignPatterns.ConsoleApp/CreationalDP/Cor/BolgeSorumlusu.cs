using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.CreationalDP.Cor
{
    public class BolgeSorumlusu : Calisan
    {
        public override void IslemYap(ParaCek paraCek)
        {
            if (paraCek.Miktar <= 500000)
                Console.WriteLine($"{this.GetType().Name} görevlisi {paraCek.MusteriId} müşterisi için {paraCek.HesabNo} nolu hesaptan {paraCek.Miktar} {paraCek.ParaBirimi} tutarında para çekildi.");
            else
            {
                Console.WriteLine($"{paraCek.Miktar} {paraCek.ParaBirimi} tutarı {this.GetType().Name} için üst limiti aşmıştır. Bir sonraki yöneticiye gidiniz.");
                _ustCalisan?.IslemYap(paraCek);
            }
        }
    }
}
