using MindBoxTestLibraryClass;

namespace MindBoxTestConsoleClass
{
    public class MindBoxTestConsoleClass
    {
        /* Выполните практическое задание ниже.
         * Отклики без выполненного задания не будут рассмотрены.
         * Пожалуйста, не пишите код внутри форм ответов, разместите его на Github и приложите ссылку.
         * Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
         * Задание:
         * +| Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
         * -| Дополнительно к работоспособности оценим:
         * +| Юнит-тесты
         * +| Легкость добавления других фигур
         * -| Вычисление площади фигуры без знания типа фигуры в compile-time
         * +| Проверку на то, является ли треугольник прямоугольным
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру площадь которой вы хотите высчитать:"
                + "\n 1. Треугольник по формуле трех сторон."
                + "\n 2. Круг по радиусу."
                + "\n 3. Объем правильной пирамиды"
                + "\n 4. Площадь прямоугольного треугольника");
            int meaning = Convert.ToInt32(Console.ReadLine());

            if (meaning == 1)
            {
                string triangleSquareResult = TriangleSquareResult();
                if (triangleSquareResult != null)
                    Console.WriteLine("Площадь треугольника равна: " + triangleSquareResult);
            }
            else if (meaning == 2)
            {
                string circleSquareResult = CircleSquareResult();
                if (circleSquareResult != null)
                    Console.WriteLine("Площадь круга равна: " + circleSquareResult);
            }
            else if (meaning == 3)
            {
                string pyramidVolumeResult = PyramidVolumeResult();
                Console.WriteLine("Объем пирамиды равен: " + pyramidVolumeResult);
            }
            else if (meaning == 4)
            {
                string triangleRightSquareResult = RightTriangleSquareResult();
                Console.WriteLine("Площадь прямоугольного треугольника равна: " + triangleRightSquareResult);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для вывода площади треугольника
        /// </summary>
        /// <returns></returns>
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

            if (triangleA + triangleB >= triangleC && triangleB + triangleC >= triangleA && triangleA + triangleC >= triangleB)
            {
                double result = library.TriangleSquare(triangleA, triangleB, triangleC);
                return result.ToString();
            }
            else
            {
                Console.WriteLine("Трегульник с такими сторонами не имеет права не существование!");
                return null;
            }
        }

        /// <summary>
        /// Метод для вывода площади круга
        /// </summary>
        /// <returns></returns>
        public static string CircleSquareResult()
        {
            TestLibrary library = new TestLibrary();

            Console.Write("Введи длину радиуса круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным");
                return null;
            }
            else
            {
                string result = library.CircleSquare(radius).ToString();
                return result;
            }
        }

        /// <summary>
        /// Метод для вывода объема правильной пирамиды с любым количеством граней
        /// </summary>
        /// <returns></returns>
        public static string PyramidVolumeResult()
        {
            TestLibrary library = new TestLibrary();

            Console.Write("Введите значение стороны основания пирамиды: ");
            double pyramidSide = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту пирамиды ");
            double h = Convert.ToDouble(Console.ReadLine());

            string result = library.PiramidVolume(pyramidSide, h).ToString();

            return result;
        }

        /// <summary>
        /// Метод для вывода прямоугольного треугольника
        /// </summary>
        /// <returns></returns>
        public static string RightTriangleSquareResult()
        {
            TestLibrary library = new TestLibrary();

            Console.WriteLine("Введите катеты треугольника: ");

            Console.Write("Катет А: ");
            double triangleA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Катет B: ");
            double triangleB = Convert.ToDouble(Console.ReadLine());

            string result = library.TriangleRightSquare(triangleA, triangleB).ToString();

            return result;
        }
    }
}