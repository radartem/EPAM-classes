using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleUnitTests
{
    [TestClass]
    public class TriangleInequalityUnitTests
    {
        
        [TestMethod]
        public void  TriangleInequality_FirstSideMoreSumOtherTwo_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(10, 5,4 ));
        }

        [TestMethod]
        public void TriangleInequality_SecondSideMoreSumOtherTwo_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, 10, 5));
        }

        [TestMethod]
        public void TriangleInequality_ThirdSideMoreSumOtherTwo_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, 5, 10));
        }

        [TestMethod]
        public void TriangleInequality_NegativeFirstSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(-10, 5, 4));
        }

        [TestMethod]
        public void TriangleInequality_NegativeSecondSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, -10, 5));
        }

        [TestMethod]
        public void TriangleInequality_NegativeThirdSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, 5, -10));
        }

        [TestMethod]
        public void TriangleInequality_NegativeAllSides_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(-9, -5, -7));
        }

        [TestMethod]
        public void TriangleInequality_ZeroFirstSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(0, 5, 4));
        }

        [TestMethod]
        public void TriangleInequality_ZeroSecondSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, 0, 5));
        }

        [TestMethod]
        public void TriangleInequality_ZeroThirdSide_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(4, 5, 0));
        }

        [TestMethod]
        public void TriangleInequality_ZeroAllSides_false()
        {
            Assert.IsFalse(Triangle.Triangle.CheckTriangleInequality(0, 0, 0));
        }

        [TestMethod]
        public void TriangleInequality_EquilateralTriangle_true()
        {
            Assert.IsTrue(Triangle.Triangle.CheckTriangleInequality(10, 10, 10));
        }

        [TestMethod]
        public void TriangleInequality_IsoscelesTriangle_true()
        {
            Assert.IsTrue(Triangle.Triangle.CheckTriangleInequality(10, 10, 9));
        }

        [TestMethod]
        public void TriangleInequality_RectangularTriangle_true()
        {
            Assert.IsTrue(Triangle.Triangle.CheckTriangleInequality(6, 8, 10));
        }

        [TestMethod]
        public void TriangleInequality_CommonTriangle_true()
        {
            Assert.IsTrue(Triangle.Triangle.CheckTriangleInequality(6, 5, 9));
        }
    }

}
