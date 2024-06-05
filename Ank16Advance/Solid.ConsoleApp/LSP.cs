using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    public abstract class BasePrinter
    {
        public abstract void Print(string message);
    }

    public interface IScan
    {
        public void Scan(string message);
    }

    public class HpPrinter : BasePrinter
    {
        public override void Print(string message)
        {
            Console.WriteLine(this.GetType().Name + " Printer => " + message);
        }
    }

    public class EpsonPrinter : BasePrinter, IScan
    {
        public override void Print(string message)
        {
            Console.WriteLine(this.GetType().Name + " Printer => " + message);
        }

        public void Scan(string message)
        {
            Console.WriteLine(this.GetType().Name + " Scan => " + message);
        }
    }

}
