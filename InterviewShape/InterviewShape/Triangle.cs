using InterviewShape.Interfaces;

namespace InterviewShape
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        //длины сторон треугольника
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                CheckPossible(value, _sideB, _sideC);
                _sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                CheckPossible(_sideA, value, _sideC);
                _sideB = value;
            }
        }
        public double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                CheckPossible(_sideA, _sideB, value);
                _sideC = value;
            }
        }


        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckPossible(sideA, sideB, sideC);

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Проверка на возможность существования треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException"></exception>
        private void CheckPossible(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина сторон треугольника должна быть больше нуля");

            if ((a >= b + c) || (b >= a + c) || (c >= a + b))
                throw new ArgumentException("Длина одной из сторон треугольника больше или равна сумме двух оставшихся");
        }

        /// <summary>
        /// Получение периметра треугольника
        /// </summary>
        /// <returns></returns>
        public double getPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        /// <summary>
        /// Получение площади треугольника
        /// </summary>
        /// <returns></returns>
        public double getArea()
        {
            double hp = getPerimeter() / 2.0;
            return Math.Sqrt(hp * (hp - _sideA) * (hp - _sideB) * (hp - _sideC));
        }
    }
}
