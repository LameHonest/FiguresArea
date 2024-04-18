using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.FiguresInheritance.Figures
{
    public class Square : Figure
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

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
