using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IColorable
    {
        public string Paint(string coolor);
    }
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape, IColorable
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.Round(Math.PI* Radius * Radius,4);
        }
        public string Paint(string color){
            return "Painting the circle "+color+".";
        }

    }

    public class Rectangles : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width*Height;
        }
    }


}
