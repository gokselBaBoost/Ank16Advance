using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.StructrualDP.Factory
{
    public interface ICar
    {
        string getColor();
        decimal getPrice();
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
        Black,
        White
    }
}
