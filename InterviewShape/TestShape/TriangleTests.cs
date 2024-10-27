using InterviewShape;
using InterviewShape.Interfaces;

namespace TestShape
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 6, 7, 14.70)]
        [InlineData(6.31, 3.01, 6.31, 9.22)]
        public void TestArea(double a, double b, double c, double area)
        {
            IShape triangle = new Triangle(a, b, c);
            double result = triangle.getArea();

            Assert.Equal(area, Math.Round(result, 2));
        }


        [Theory]
        [InlineData(3, -4, 5)]
        [InlineData(0, 6, 0)]
        [InlineData(99, 3.01, 6.31)]
        public void TestWrongArguments(double a, double b, double c)
        {
            Action act = () => new Triangle(a, b, c);

            var ex = Record.Exception(act);

            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
        }
    }
}