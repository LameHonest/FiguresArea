using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.FiguresInheritance.Figures
{
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All triangle sides must be more than 0.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Sum of the two sides must be more than third side.");

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            //S = √p · (p — A)(p — B)(p — C)
            //where p is half the perimeter of a triangle
            //perimeter is a sum of all sides (A+B+C)
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightAngled()
        {
            //To say that triangle is right angled we can use Pythagorean theorem
            //Formula: a^2 + b^2 = c^2, where c - hypotenuse
            //In that triangle we wanna C to be hypotenuse, but just in case lets sort all sides
            double[] sides = { A, B, C };
            Array.Sort(sides);
            return sides[2] * sides[2] == (sides[0] * sides[0] + sides[1] * sides[1]);
        }
    }
}
