using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.StructrualDP.Factory
{
    public class CarFactory
    {
        public static ICar CreateCar(string brand, Color color, decimal price)
        {
            switch (brand.ToLower())
            {
                case "mercedes":
                    return new Mercedes(color, price);
                case "bmw":
                    return new Bmw(color, price);
            }

            throw new Exception($"Fabrikamızda {brand} bu markadan araç bulunmamaktadır.");
        }
    }
}
