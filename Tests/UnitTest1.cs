using FiguresArea.FiguresInheritance.Figures;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class FigureTests
        {
            [Test]
            public void Circle_Area_CorrectCalculation()
            {
                var circle = new Circle(5);
                var expectedArea = Math.PI * 25;
                Assert.AreEqual(expectedArea, circle.GetArea(), 0.01, "Area of the circle is incorrect.");
            }

            [Test]
            public void Triangle_IsRightAngled_TrueFor345()
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.IsTrue(triangle.IsRightAngled(), "Triangle 3, 4, 5 should be right angled.");
            }

            [Test]
            public void Triangle_Area_CorrectCalculation()
            {
                var triangle = new Triangle(3, 4, 5);
                var expectedArea = 6;
                Assert.AreEqual(expectedArea, triangle.GetArea(), 0.01, "Area of the triangle is incorrect.");
            }

            [Test]
            public void Square_Area_CorrectCalculation()
            {
                var square = new Square(4);
                var expectedArea = 16;
                Assert.AreEqual(expectedArea, square.GetArea(), "Area of the square is incorrect.");
            }
        }
    }
}