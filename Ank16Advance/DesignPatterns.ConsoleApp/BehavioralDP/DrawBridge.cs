using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.BehavioralDP
{
    public class DrawBridge
    {
        public DrawBridge(Shape shape, Color color, int size)
        {
            Shape = shape;
            Color = color;
            Size = size;
        }

        public Shape Shape { get; set; }
        public Color Color { get; set; }
        public int Size { get; set; }

        public void Draw() {
            Shape.Draw(Color, Size);
        }
    }
}
