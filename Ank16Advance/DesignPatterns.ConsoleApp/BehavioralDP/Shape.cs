using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.BehavioralDP
{
    public abstract class Shape
    {
        protected Shape(string name) 
        { 
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Draw(Color color, int size)
        {
            Console.WriteLine($"{color.Name} {Name} şeklinin {size} boyunda çizildi");
        }
    }
}
