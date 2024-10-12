namespace ConsoleApp1.Exam
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            double _radius = Radius;

            return Math.PI * (_radius * _radius);
        }

        public double GetPerimeter()
        {
            double _radius = Radius;

            return Math.PI * _radius * 2;
        }
    }

}
