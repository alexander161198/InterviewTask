using InterviewShape;
using InterviewShape.Interfaces;

namespace TestShape
{
    public class CircleTests
    {
        [Theory]
        [InlineData(4, 50.27)]
        [InlineData(2.5, 19.63)]
        [InlineData(0.69, 1.5)]
        public void TestArea(double r, double area)
        {
            IShape circle = new Circle(r);
            double result = circle.getArea();

            Assert.Equal(area, Math.Round(result,2));
        }


        [Theory]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(-0.21)]
        public void TestWrongArguments(double r)
        {
            Action act = () => new Circle(r);

            var ex = Record.Exception(act);

            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
        }
    }
}
