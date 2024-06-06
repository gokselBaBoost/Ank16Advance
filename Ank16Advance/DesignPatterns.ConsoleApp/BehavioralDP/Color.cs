using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.BehavioralDP
{
    public abstract class Color
    {
        protected Color(string name) 
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
