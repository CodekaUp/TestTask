using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interface;

namespace TestTask.GeometricShapes
{
    public class Square : IFigure
    {
        readonly double side;

        public Square(double side)
        {
            if(side <= 0)
            {
                throw new ArgumentException("Сторона должна быть положительным числом"); 
            }

            this.side = side;
        }

        public double FigureArea()
        {
            return side * side;
        }

        public double FigurePerimeter()
        {
            return 4 * side;
        }
    }
}
