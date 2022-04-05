using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FigureArea triangle = new TriangleArea(6, 6, 12);
            FigureArea circle = new CircleArea(-1);

            Assert.AreEqual(-1, triangle.GetArea());
            Assert.AreEqual(-1, circle.GetArea());
        }
    }
}
