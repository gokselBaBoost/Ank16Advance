using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    #region Kotu Yazım
    //public class Ekran
    //{

    //    public void KareCiz()
    //    {
    //        Kare kare = new Kare();

    //        Console.WriteLine(kare.Ciz());
    //    }

    //    public void DaireCiz()
    //    {
    //        Daire daire = new Daire();

    //        Console.WriteLine(daire.Ciz());
    //    }
    //}

    //public class Kare
    //{
    //    public Kare()
    //    {

    //    }

    //    public Kare(int size)
    //    {

    //    }

    //    public string Ciz()
    //    {
    //        return "Kare çizildi";
    //    }
    //}

    //public class Daire
    //{
    //    public string Ciz()
    //    {
    //        return "Daire çizildi";
    //    }
    //} 
    #endregion

    public interface ISekil
    {
        string Ciz();
    }

    public abstract class Sekil : ISekil
    {
        public abstract string Ciz();
        public virtual string CizDiger()
        {
            return "Beni Abstract yazdı";
        }
        public string BenimCizgim()
        {
            return "Bunu sadece Abstract yazar";
        }
    }

    public class Kare : Sekil
    {
        public Kare()
        {
            Console.WriteLine("KARE: Beni de oluşturdunuz");
        }

        public override string Ciz()
        {
            return "Kare şekli çizildi";
        }
    }

    public class Daire : Sekil
    {
        public Daire()
        {
            Console.WriteLine("Daire: Beni de oluşturdunuz");
        }

        public override string Ciz()
        {
            return "Daire şekli çizildi";
        }
    }


    public class Ekran
    {
        private ISekil _sekil;

        public Ekran(ISekil sekil)
        {
            _sekil = sekil;
            Console.WriteLine("Ekran: Beni de oluşturdunuz.");
        }

        public void EkranYaz() 
        {
            Console.WriteLine(_sekil.Ciz());
        }

        public void EkranYazDIP(ISekil sekil)
        {
            Console.WriteLine(sekil.Ciz());
        }
    }
}
