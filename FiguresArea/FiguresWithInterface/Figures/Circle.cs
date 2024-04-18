using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.FiguresWithInterface.Figures
{
    public class Circle: IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must be more than 0.");
            Radius = radius;
        }

        public double GetArea()
        {
            //S = π × r2
            return Math.PI * Radius * Radius;
        }
    }
}
