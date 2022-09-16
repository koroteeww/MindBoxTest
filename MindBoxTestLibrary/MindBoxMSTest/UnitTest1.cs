using MindBoxTestLibraryClass;
using MindBoxTestConsoleClass;
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
            double triangleA = 400;
            double triangleB = 300;
            double triangleC = 600;
            double expented = 53326.82251925385;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare4()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = -400;
            double triangleB = -300;
            double triangleC = -600;
            double expented = 53326.82251925385;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare5()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = 4000;
            double triangleB = 3000;
            double triangleC = 6000;
            double expented = 5332682.251925386;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare6()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = -4000;
            double triangleB = -3000;
            double triangleC = -6000;
            double expented = 5332682.251925386;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare7()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = 40000;
            double triangleB = 30000;
            double triangleC = 60000;
            double expented = 533268225.19253856;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare8()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = -40000;
            double triangleB = -30000;
            double triangleC = -60000;
            double expented = 533268225.19253856;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare9()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = 3.78;
            double triangleB = 5.69;
            double triangleC = 4.798;
            double expented = 8.983965954756508;

            // act
            double result = library.TriangleSquare(triangleA, triangleB, triangleC);

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleSquare10()
        {
            // arrange
            var library = new TestLibrary();
            double triangleA = -3.78;
            double triangleB = -5.69;
            double triangleC = -4.798;
            double expented = 8.983965954756508;

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