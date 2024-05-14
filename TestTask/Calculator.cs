
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interface;

namespace TestTask
{
    public class Calculator
    {
        public double FigureArea(IFigure figure)
        {
            return figure.FigureArea();
        }

        public double FigurePerimeter(IFigure figure)
        {
            return figure.FigurePerimeter();
        }
    }
}
