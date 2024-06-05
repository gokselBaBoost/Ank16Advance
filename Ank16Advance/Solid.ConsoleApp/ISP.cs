using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    public interface IHayvan 
    {
        void Konus();
        void YemekYe();
        void Uyu();
    }

    public abstract class Hayvan : IHayvan
    {
        public virtual void Konus()
        {
            Console.WriteLine("konuştu");
        }

        public virtual void Uyu()
        {
            Console.WriteLine("uyudu");
        }

        public virtual void YemekYe()
        {
            Console.WriteLine("yemek yiyor");
        }
    }

    public interface IUcabilirim
    {
        public void Uc();
    }

    public interface IYuzebilirim
    {
        public void Yuz();
    }

    public interface IYuruyebilirim
    {
        public void Yuru();
    }

    public class Aslan : Hayvan, IYuruyebilirim
    {
        public void Yuru()
        {
            Console.WriteLine("Şampiyonluğa yürüyoruz...");
        }

    }

    public class Hamsi : Hayvan, IYuzebilirim
    {
        public void Yuz()
        {
            Console.WriteLine("Şampiyonluğa yüzüyoruz...");
        }
    }

    public class Kanarya : Hayvan, IUcabilirim, IYuruyebilirim
    {
        public void Uc()
        {
            Console.WriteLine("Şampiyonluğa uçuyoruz...");
        }

        public void Yuru()
        {
            Console.WriteLine("Şampiyonluğa yürüyoruz...");
        }
    }

    public class Kaz : Hayvan, IUcabilirim, IYuruyebilirim, IYuzebilirim
    {
        public void Uc()
        {
            Console.WriteLine("Ben heryere uçarım...");
        }

        public void Yuru()
        {
            Console.WriteLine("Ben heryere yürürüm...");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben heryere yüzerim...");
        }
    }
}
