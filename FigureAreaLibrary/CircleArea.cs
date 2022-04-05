using System;

namespace FigureAreaLibrary
{
    public class CircleArea : FigureArea
    {
        private float circleArea = -1;
        private float r;

        public CircleArea(float r)
        {
            this.r = r;
            if (checkData()) calculateArea();
        }

        protected override bool checkData()
        {
            if (r < 0) return false;
            else return true;
        }

        protected override void calculateArea()
        {
            circleArea = (float)Math.PI * r * r;
        }

        public override float GetArea()
        {
            return circleArea;
        }
    }
}
