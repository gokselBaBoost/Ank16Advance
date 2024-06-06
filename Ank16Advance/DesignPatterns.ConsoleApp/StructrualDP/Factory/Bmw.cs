using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.StructrualDP.Factory
{
    public class Bmw : ICar
    {
        private Color _color;
        private decimal _price;
        private List<(string Model, decimal Price)> models = new List<(string Model, decimal Price)>();
        private string _model;

        public Bmw(Color color, decimal price)
        {
            _color = color;
            _price = price;


            models.Add(("530", 4500));
            models.Add(("740Ld", 5500));
            models.Add(("320i", 3500));
            models.Add(("116", 1500));

            _model = models.Where(m => m.Price < price).FirstOrDefault().Model;
        }

        public string getColor()
        {
            return _color.ToString();
        }

        public decimal getPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return $"BMW {_model} modelli {_color} renkli {_price} fiyatlı bir arabanız oldu";
        }
    }
}
