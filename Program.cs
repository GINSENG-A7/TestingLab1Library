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
        double width;
        double height;
        public Rectangle(double height, double width)
        {
            if (height > 0 && width > 0 && height < Double.PositiveInfinity && width < Double.PositiveInfinity)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                throw new Exception("Невозможный прямоугольник");
            }
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
        double length;
        public override string getName()
        {
            return "Равносторонний треугольник";
        }
        public EquilateralTriangle(double length)
        {
            if (length > 0 && length < Double.PositiveInfinity)
            {
                this.length = length;
            }
            else
            {
                throw new Exception("Невозможный треугольник");
            }
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
        double radius;
        public Circle(double radius)
        {
            if (radius > 0 && radius < Double.PositiveInfinity)
            {
                this.radius = radius;
            }
            else
            {
                throw new Exception("Невозможный круг");
            }
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

