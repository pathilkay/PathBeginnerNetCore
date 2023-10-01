using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.MidLevels.FirstAlgorithm
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public double CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Edge {  get; set; }

        public Triangle(double @base, double height, double edge)
        {
            Base = @base;
            Height = height;
            Edge = edge;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculatePerimeter()
        {
            return Base + Height * Edge;
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
