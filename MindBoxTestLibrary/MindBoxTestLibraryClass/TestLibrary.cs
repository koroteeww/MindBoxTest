namespace MindBoxTestLibraryClass;

public class TestLibrary
{
    /// <summary>
    /// Метод для вычисления площади треугольника по трем сторонам
    /// </summary>
    /// <param name="triangleA"></param>
    /// <param name="triangleB"></param>
    /// <param name="triangleC"></param>
    /// <returns></returns>
    public double TriangleSquare(double triangleA, double triangleB, double triangleC)
    {
        // Вычисление полупериметра.
        double halfPerimeter = (triangleA + triangleB + triangleC) / 2;

        //Вычисление площади
        double squareResult = Math.Sqrt(halfPerimeter * (halfPerimeter - triangleA) * (halfPerimeter - triangleB) * (halfPerimeter - triangleC));

        return squareResult;
    }

    /// <summary>
    /// Метод для вычисления площади круга по радиусу
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public double CircleSquare(double radius)
    {

        double squareResult = Math.PI * Math.Pow(radius, 2);

        return squareResult;
    }

    /// <summary>
    /// Метод для вычисления обьема правильной четырехугольной пирамиды
    /// </summary>
    /// <param name="n"></param>
    /// <param name="pyramidSide"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public double PiramidVolume(double pyramidSide, double high)
    {
        double volumeResult = 0.33333 * high * Math.Pow(pyramidSide,2);
        return volumeResult;
    }

    /// <summary>
    /// Метод для вычисления обьема правильной четырехугольной пирамиды
    /// </summary>
    /// <param name="n"></param>
    /// <param name="pyramidSide"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public double TriangleRightSquare(double triangleA, double triangleB)
    {
        double volumeResult = 0.5 * (triangleA * triangleB);
        return volumeResult;
    }
}