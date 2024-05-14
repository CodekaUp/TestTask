using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interface;

namespace TestTask.GeometricShapes
{
    public class Circle : IFigure
    {
        readonly double radius;

        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом");
            }

            this.radius = radius;
        }

        public double FigureArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double FigurePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
