using FiguresArea.FiguresWithInterface.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.FiguresWithInterface
{
    public static class FiguresFactory
    {
        //Using factory to create new figures
        public static IFigure CreateFigure(string type, params double[] dimensions)
        {
            switch (type.ToLower())
            {
                case "circle":
                    return new Circle(dimensions[0]);
                case "triangle":
                    return new Triangle(dimensions[0], dimensions[1], dimensions[2]);
                case "square":
                    return new Square(dimensions[0]);
                default:
                    throw new ArgumentException("Invalid figure type.");
            }
        }
    }
}
