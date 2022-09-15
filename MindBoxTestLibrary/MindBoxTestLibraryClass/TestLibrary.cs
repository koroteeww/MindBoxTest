namespace MindBoxTestLibraryClass;

public class TestLibrary
{
    public double TriangleSquare(double triangleA, double triangleB, double triangleC)
    {
        // Вычисление полупериметра.
        double halfPerimeter = (triangleA + triangleB + triangleC) / 2;

        //Вычисление площади
        double squareResult = Math.Sqrt(halfPerimeter * (halfPerimeter - triangleA) * (halfPerimeter - triangleB) * (halfPerimeter - triangleC));

        return squareResult;
    }

    public double CircleSquare(double radius)
    {

        double squareResult = Math.PI * (radius * radius);

        return squareResult;
    }
}