using FigureAreaLibrary;
using System;

namespace FigureAreaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureArea figure = new CircleArea(1);
            Console.WriteLine(figure.GetArea());

            figure = new TriangleArea(3, 4, 5);
            Console.WriteLine(figure.GetArea());
        }
    }
}
