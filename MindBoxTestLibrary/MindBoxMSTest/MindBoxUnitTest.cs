using MindBoxTestLibraryClass;
using MindBoxTestConsoleClass;
using System.Runtime.InteropServices;

namespace MindBoxMSTest
{
    [TestClass]
    public class MindBoxUnitTest
    {
        //����� �� �����������
        [TestMethod]
        public void TriangleArea1()
        {
            // arrange
            
            double triangleA = 3;
            double triangleB = 5;
            double triangleC = 7;
            double expented = 6.49519052838329;
            var library = new Triangle(triangleA,triangleB,triangleC);
            // act
            double result = Convert.ToDouble(library.AreaCount()) ;

            // assert
            Assert.AreEqual(expented, result);
        }

        [TestMethod]
        public void TriangleArea2()
        {
            // �������� �� ������� �����
            // arrange
            
            double triangleA = Double.MaxValue;
            double triangleB = Double.MaxValue;
            double triangleC = Double.MaxValue;
            //double expented = 53326.82251925385;
            var library = new Triangle(triangleA, triangleB, triangleC);
            // act
            try
            {
                double result = Convert.ToDouble(library.AreaCount());
            }
            catch (OverflowException ex)
            {
                //��� �� ���� ������� OverflowException

            }
            // assert ��� ����� ���������� �� ������� �����
            //OverflowException
            //Assert.AreEqual(expented, result);
        }


        [TestMethod]
        public void TriangleArea8()
        {
            //�������� �� ������� ��������
            // arrange
            //var library = new TestLibrary();
            //double triangleA = 3.78;
            //double triangleB = 5.69;
            //double triangleC = 4.798;
            //double expented = 8.983965954756508;

            //// act
            //double result = Convert.ToDouble(library.TriangleArea(triangleA, triangleB, triangleC));

            //// assert
            //Assert.AreEqual(expented - result < 0.01);
        }

        //[TestMethod]
        //public void TriangleArea9()
        //{
        //    //�������� �� ������������� �������
        //    // arrange
        //    var library = new TestLibrary();
        //    double triangleA = -3.78;
        //    double triangleB = 5.69;
        //    double triangleC = 4.798;
        //    double expented = 0;

        //    // act
        //    double result = Convert.ToDouble(library.TriangleArea(triangleA, triangleB, triangleC));

        //    // assert
        //    Assert.AreEqual(expented, result);
        //}

        //����� �� ����
        [TestMethod]
        public void CircleArea1()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CircleArea2()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void CircleArea3()
        {
            // arrange

            // act

            // assert
        }
    }
}