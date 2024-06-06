using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.StructrualDP.Factory
{
    public class Mercedes : ICar
    {
        private Color _color;
        private decimal _price;
        private List<(string Model, decimal Price)> models = new List<(string Model, decimal Price)>();
        private string _model;

        public Mercedes(Color color, decimal price)
        {
            _color = color;
            _price = price;

            models.Add(("S500", 4500));
            models.Add(("S600", 5500));
            models.Add(("E320", 3500));
            models.Add(("C200", 1500));

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
            return $"Mercedes {_model} modelli {_color} renkli {_price} fiyatlı bir arabanız oldu";
        }
    }
}
