using MindBoxTestLibraryClass;

class Program
{
    /* Выполните практическое задание ниже.
     * Отклики без выполненного задания не будут рассмотрены.
     * Пожалуйста, не пишите код внутри форм ответов, разместите его на Github и приложите ссылку.
     * Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
     * Задание:
     * Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
     * Дополнительно к работоспособности оценим:
     * Юнит-тесты
     * Легкость добавления других фигур
     * Вычисление площади фигуры без знания типа фигуры в compile-time
     * Проверку на то, является ли треугольник прямоугольным
     */
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите фигуру площадь которой вы хотите высчитать: 1. Треугольник по формуле трех сторон. 2. Круг по радиусу. ");
        int meaning = Convert.ToInt32(Console.ReadLine());

        if (meaning == 1)
        {
            string triangleSquareResult = TriangleSquareResult();
            Console.WriteLine("Площадь треугольника равна: " + triangleSquareResult);
        }
        else if (meaning == 2)
        {
            string circleSquareResult = CircleSquareResult();
            Console.WriteLine("Площадь круга равна: " + circleSquareResult);
        }

        Console.ReadKey();
    }

    public static string TriangleSquareResult()
    {
        TestLibrary library = new TestLibrary();
        Console.WriteLine("Введите длины сторон треугольника: ");

        Console.Write("Сторона А: ");
        double triangleA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона B: ");
        double triangleB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона C: ");
        double triangleC = Convert.ToDouble(Console.ReadLine());

        string result = library.TriangleSquare(triangleA, triangleB, triangleC).ToString();
        return result;
    }

    public static string CircleSquareResult()
    {
        TestLibrary library = new TestLibrary();

        Console.Write("Введи длину радиуса круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        string result = library.CircleSquare(radius).ToString();
        return result;
    }
}