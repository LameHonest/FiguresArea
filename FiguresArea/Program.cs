using FiguresArea.FiguresInheritance.Figures;
using FiguresArea.FiguresWithInterface;
using FiguresArea.FiguresWithInterface.Figures;
using System.Net;

namespace FiguresArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting area with first solution...");

            List<Figure> figures = new List<Figure>
            {
                new FiguresInheritance.Figures.Circle(5),
                new FiguresInheritance.Figures.Triangle(3, 4, 5),
                new FiguresInheritance.Figures.Square(4)
            };

            GetFiguresInfoWithInheritance(figures);

            Console.WriteLine("Getting area with second solution");

            var figures2 = new List<IFigure>
            {
                FiguresFactory.CreateFigure("Circle", 5),
                FiguresFactory.CreateFigure("Triangle", 3, 4, 5),
                FiguresFactory.CreateFigure("Square", 4)
            };

            GetFiguresInfoWithInterface(figures2);
        }

        static void GetFiguresInfoWithInheritance(List<Figure> figuresList)
        {
            foreach (Figure figure in figuresList)
            {
                string className = figure.GetType().Name;
                double area = figure.GetArea();

                Console.WriteLine(className + " has an area = " + area);

                if (figure is FiguresInheritance.Figures.Triangle triangle)
                {
                    Console.WriteLine($"Is the triangle right angled: {triangle.IsRightAngled()}");
                }
            }
        }

        static void GetFiguresInfoWithInterface(List<IFigure> figuresList)
        {
            foreach (IFigure figure in figuresList)
            {
                string className = figure.GetType().Name;
                double area = figure.GetArea();

                Console.WriteLine(className + " has an area = " + area);

                if (figure is FiguresWithInterface.Figures.Triangle triangle)
                {
                    Console.WriteLine($"Is the triangle right angled: {triangle.IsRightAngled()}");
                }
            }
        }
    }
}