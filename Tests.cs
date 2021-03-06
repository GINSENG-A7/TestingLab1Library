using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingLab1Library
{
    [TestFixture]
    class FigureTest
    {
        Rectangle myRect = new Rectangle(7, 10);
        //Rectangle myNullRect = new Rectangle(-1, -1);
        EquilateralTriangle myTriangle = new EquilateralTriangle(6);
        Circle myCircle = new Circle(4);
        Circle myCircle2 = new Circle(5);
        [Test]
        public void RectangleTestNo_1()
        {
            Assert.AreEqual(70, myRect.Surface());
        }
        [Test]
        public void RectangleTestNo_2()
        {
            Assert.AreEqual(34, myRect.Perimeter());
        }
        [Test]
        public void RectangleTestNo_3()
        {
            Assert.IsFalse(120 < myRect.Perimeter() + myRect.Surface()); //not valid
        }
        [Test]
        public void RectangleTestNo_4()
        {
            Assert.Throws<Exception>(() => new Rectangle(-1, -1)); //not valid
        }
        [Test]
        public void RectangleTestNo_5()
        {
            Assert.Throws<Exception>(() => new Rectangle(Double.PositiveInfinity, Double.PositiveInfinity)); //not valid
        }
        [Test]
        public void TriangleTestNo_1()
        {
            Assert.IsNotNull(myTriangle.Surface());
        }
        [Test]
        public void TriangleTestNo_2()
        {
            Assert.IsNotNull(myTriangle.Perimeter());
        }
        [Test]
        public void TriangleTestNo_3()
        {
            Assert.IsNotNull(myTriangle);  //not valid
        }
        [Test]
        public void TriangleTestNo_4()
        {
            Assert.AreEqual(18, myTriangle.Perimeter());
        }
        [Test]
        public void TriangleTestNo_5()
        {
            Assert.AreEqual(15.588457268119894, myTriangle.Surface());
        }
        [Test]
        public void TriangleTestNo_6()
        {
            Assert.Throws<Exception>(() => new EquilateralTriangle(-1)); //not valid
        }
        [Test]
        public void TriangleTestNo_7()
        {
            Assert.Throws<Exception>(() => new EquilateralTriangle(Double.PositiveInfinity)); //not valid
        }

        [Test]
        public void CircleTestNo_1()
        {
            Assert.AreNotSame(myCircle.Surface(), myCircle.Perimeter());
        }
        [Test]
        public void CircleTestNo_2()
        {
            Assert.AreNotSame(myCircle, myCircle2); //not valid
        }
        [Test]
        public void CircleTestNo_3()
        {
            Assert.IsTrue(myCircle.Surface() > myCircle.Perimeter());
        }
        [Test]
        public void CircleTestNo_4()
        {
            Assert.AreEqual(50.26548245743669, myCircle.Surface());
        }
        [Test]
        public void CircleTestNo_5()
        {
            Assert.AreEqual(25.132741228718345, myCircle.Perimeter());
        }
        [Test]
        public void CircleTestNo_6()
        {
            Assert.Throws<Exception>(() => new Circle(-1)); //not valid
        }
        [Test]
        public void CircleTestNo_7()
        {
            Assert.Throws<Exception>(() => new Circle(Double.PositiveInfinity)); //not valid
        }
    }
}