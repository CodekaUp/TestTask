using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.GeometricShapes;
using TestTask.Interface;

namespace TestTask.CreateFigure
{
    public class Create
    {
        public static IFigure CreateCircle(double radius) 
        {
            return new Circle(radius);
        }

        public static IFigure CreateRectangle(double length, double width) 
        {
            return new Rectangle(length, width);
        }

        public static IFigure CreateSquare(double side)
        {
            return new Square(side);
        }
    }
}
