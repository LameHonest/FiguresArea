using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.FiguresWithInterface.Figures
{
    public class Square : IFigure
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("The side length must be a positive number.");
            }
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
