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
    public string TriangleArea(double triangleA, double triangleB, double triangleC)
    {
        // Вычисление полупериметра.
        double halfPerimeter = (triangleA + triangleB + triangleC) / 2;

        // Вычисление площади
        if (triangleA + triangleB >= triangleC && triangleB + triangleC >= triangleA && triangleA + triangleC >= triangleB)
        {
            double areaResult = halfPerimeter * (halfPerimeter - triangleA) * (halfPerimeter - triangleB) * (halfPerimeter - triangleC);
            areaResult = Math.Sqrt(areaResult);

            // Проверка треугольника на прямой угол
            TriangleRightChecked(triangleA, triangleB, triangleC);

            return areaResult.ToString();
        }
        else
        {
            Console.WriteLine("Трегульник с такими сторонами не имеет права не существование!");
            return null;
        }
    }

    public void TriangleRightChecked(double triangleA, double triangleB, double triangleC)
    {
        if (Math.Pow(triangleA, 2) + Math.Pow(triangleB, 2) == Math.Pow(triangleC, 2) ||
        Math.Pow(triangleA, 2) + Math.Pow(triangleC, 2) == Math.Pow(triangleB, 2) ||
        Math.Pow(triangleB, 2) + Math.Pow(triangleC, 2) == Math.Pow(triangleA, 2))
        {
            Console.WriteLine("Этот треугольник прямоугольный");
        }
        else
        {
            Console.WriteLine("Этот треугольник не прямоугольный");
        }
    }

    /// <summary>
    /// Метод для вычисления площади круга по радиусу
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public string CircleArea(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Радиус не может быть отрицательным");
            return null;
        }
        else
        {
            // Вычисление площади
            double areaResult = Math.PI * Math.Pow(radius, 2);
            return areaResult.ToString();
        }
    }

    public double N_Angle_Area(double sideRight, int sideCount)
    {
        double radius = N_Angle_Area_Radius(sideRight, sideCount);
        double areaTriangle = Convert.ToDouble(TriangleArea(sideRight, radius, radius));

        return areaTriangle * sideCount;
    }

    public double N_Angle_Area_Radius(double sideRight, int sideCount)
    {
        double radian = 180 * Math.PI / 180;
        double radius = sideRight / (2 * Math.Sin(radian / sideCount));

        return radius;
    }
}