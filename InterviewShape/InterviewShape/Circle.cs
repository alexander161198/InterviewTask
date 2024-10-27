using InterviewShape.Interfaces;

namespace InterviewShape
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IShape
    {
        // радиус окружности
        private double _radius;

        public double Radius 
        {
            get 
            {
                return _radius;
            }
            set 
            {
                checkPossible(value);
                _radius = value;
            } 
        }

        public Circle(double radius)
        {
            checkPossible(radius);
            _radius = radius;
        }

        /// <summary>
        /// Проверка на возможность существования окружности
        /// </summary>
        /// <param name="r"></param>
        /// <exception cref="ArgumentException"></exception>
        private void checkPossible(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Размер радиуса окружности должна быть больше нуля");
            }

            return;
        }

        /// <summary>
        /// Получение площади окружности
        /// </summary>
        /// <returns></returns>
        public double getArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
