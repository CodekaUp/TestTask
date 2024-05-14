using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interface;

namespace TestTask.GeometricShapes
{
    public class Rectangle : IFigure
    {
        readonly double length;
        readonly double width;

        public Rectangle(double length, double width)
        {
            if(length <= 0 || width <= 0) 
            {
                throw new ArgumentException("Длина и ширина должны быть положительными числами");
            }

            this.length = length;
            this.width = width;
        }
        public double FigureArea()
        {
            return length * width;
        }

        public double FigurePerimeter()
        {
            return (length + width) * 2;
        }
    }
}
