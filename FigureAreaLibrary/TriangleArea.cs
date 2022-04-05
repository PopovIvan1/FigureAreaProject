using System;

namespace FigureAreaLibrary
{
    public class TriangleArea : FigureArea
    {
        private float triangleArea = -1;
        private float a, b, c;

        public TriangleArea(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            sortSides();
            if (checkData()) calculateArea();
        }

        private void sortSides()
        {
            float maxSide = c;
            if (a > maxSide) 
            {
                maxSide = a;
                a = c;
                c = maxSide;
            }
            if (b > maxSide)
            {
                maxSide = b;
                b = c;
                c = maxSide;
            }
        }

        protected override bool checkData()
        {
            if (a + b <= c) return false;
            else if (a < 0 || b < 0 || c < 0) return false;
            else return true;
        }

        protected override void calculateArea()
        {
            if (isRight()) triangleArea = a * b / 2;
            else
            {
                float p = (a + b + c) / 2;
                triangleArea = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        private bool isRight()
        {
            if (a * a + b * b == c * c) return true;
            else return false;
        }

        public override float GetArea()
        {
            return triangleArea;
        }
    }
}
