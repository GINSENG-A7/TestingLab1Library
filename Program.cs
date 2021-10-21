using System;

namespace TestingLab1Library
{
    public abstract class Figure
    {
        public abstract double Surface();
        public abstract double Perimeter();
        public abstract string getName();
    }
    public class Rectangle : Figure
    {
        int width;
        int height;
        public Rectangle(int height, int width)
        {
            this.width = width;
            this.height = height;
        }
        public override string getName()
        {
            return "Прямоугольник";
        }
        public override double Surface()
        {
            double s = width * height;
            return s;
        }
        public override double Perimeter()
        {
            double p = 2 * width + 2 * height;
            return p;
        }
    }
    public class EquilateralTriangle : Figure
    {
        int length;
        public override string getName()
        {
            return "Равносторонний треугольник";
        }
        public EquilateralTriangle(int length)
        {
            this.length = length;
        }
        public override double Surface()
        {
            double s = Math.Pow(length, 2) * Math.Sqrt(3) / 4;
            return s;
        }
        public override double Perimeter()
        {
            double p = 3 * length;
            return p;
        }
    }
    public class Circle : Figure
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override string getName()
        {
            return "Равносторонний треугольник";
        }
        public override double Surface()
        {
            double s = Math.PI * Math.Pow(radius, 2);
            return s;
        }
        public override double Perimeter()
        {
            double p = 2 * Math.PI * radius;
            return p;
        }
    }
}
