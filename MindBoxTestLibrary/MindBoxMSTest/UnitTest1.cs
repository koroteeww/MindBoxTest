using MindBoxTestLibraryClass;
using System.Runtime.InteropServices;

namespace MindBoxMSTest
{
    [TestClass]
    public class UnitTest1
    {
        //Тесты на треугольник
        [TestMethod]
        public void TriangleSquare1()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = 3;
            double triangleB = 5;
            double triangleC = 7;
            double expented = 6.49519052838329;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare2()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = -3;
            double triangleB = -5;
            double triangleC = -7;
            double expented = 6.49519052838329;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare3()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = 40;
            double triangleB = 95;
            double triangleC = 60;
            double expented = 724.9730598442952;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        //Тесты на круг
        [TestMethod]
        public void CircleSquare1()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CircleSquare2()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CircleSquare3()
        {
            // arrange

            // act

            // assert
        }

        //Тесты на пирамиду
        [TestMethod]
        public void PiramidVolume1()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void PiramidVolume2()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void PiramidVolume3()
        {
            // arrange

            // act

            // assert
        }

        //Тесты на прямоугольный треугольник
        [TestMethod]
        public void TriangleRightSquare1()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void TriangleRightSquare2()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void TriangleRightSquare3()
        {
            // arrange

            // act

            // assert
        }
    }
}