using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.CreationalDP.Cor
{
    public abstract class Calisan
    {
        protected Calisan _ustCalisan;

        public void SetUstCalisan(Calisan UstCalisan)
        {
            _ustCalisan = UstCalisan;
        }

        public abstract void IslemYap(ParaCek paraCek);
    }
}
