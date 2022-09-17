using MindBoxTestLibraryClass;
using System;
using System.Drawing;

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
                + "\n 3. Вычисление любой фигуры");
            int meaning = Convert.ToInt32(Console.ReadLine());

            if (meaning == 1)
            {
                string triangleAreaResult = TriangleAreaResult();
                if (triangleAreaResult != null)
                    Console.WriteLine("Площадь треугольника равна: " + triangleAreaResult);
            }
            else if (meaning == 2)
            {
                string circleAreaResult = CircleAreaResult();
                if (circleAreaResult != null)
                    Console.WriteLine("Площадь круга равна: " + circleAreaResult);
            }else if(meaning == 3)
            {
                string anyFigure = AbstractFigureResult();
                if (anyFigure != null)
                    Console.WriteLine("Площадь фигуры равна " + anyFigure);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для вывода площади треугольника
        /// </summary>
        /// <returns></returns>
        public static string TriangleAreaResult()
        {
            TestLibrary library = new TestLibrary();
            Console.WriteLine("Введите длины сторон треугольника: ");

            Console.Write("Сторона А: ");
            double triangleA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B: ");
            double triangleB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C: ");
            double triangleC = Convert.ToDouble(Console.ReadLine());

            string result = library.TriangleArea(triangleA, triangleB, triangleC);
            return result;
        }

        /// <summary>
        /// Метод для вывода площади круга
        /// </summary>
        /// <returns></returns>
        public static string CircleAreaResult()
        {
            TestLibrary library = new TestLibrary();

            Console.Write("Введи длину радиуса круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            string result = library.CircleArea(radius).ToString();
            return result;
        }

        /// <summary>
        /// Попытка выполнения третьего подпункта
        /// </summary>
        /// <returns></returns>
        public static string AbstractFigureResult()
        {
            TestLibrary library = new TestLibrary();
            int question;

            Console.WriteLine("Является ли выбранная вами фигура окружностью? 1.Да 2.Нет");
            question = Convert.ToInt32(Console.ReadLine());

            if (question == 1)
            {
                string areaCircleResult = CircleAreaResult();
                return areaCircleResult;
            }
            else if (question == 2)
            {
                Console.WriteLine("Выберите тип вашего многоугольника: 1.Правильный 2.Неправильный");
                question = Convert.ToInt32(Console.ReadLine());

                if (question == 1)
                {
                    Console.Write("Вы сделали ПРАВИЛЬНЫЙ выбор.Теперь задайте пожалуйста длину стороны вашего многоугольника: ");
                    double sideRight = Convert.ToDouble(Console.ReadLine());

                    Console.Write("А теперь пожалуйста задайте количество сторон вашего многоугольника: ");
                    int sideCount = Convert.ToInt32(Console.ReadLine());

                    double areaResult = library.N_Angle_Area(sideRight, sideCount);

                    return areaResult.ToString();
                }
                else if (question == 2)
                {
                   Console.WriteLine("Это оказалось сложнее чем я думал." +
                       " Там формула размером с километр и учитывая что она одна на весь интернет я в ней сомеваюсь," +
                       " поэтому тут я умываю руки увы." +
                       "Зато можно попыться расписать, как можно было бы сделать эту задачу:" +
                       "- Создать форму, в которой будет окно с клетками размером с условную единицу." +
                       "- На этом окне начертить две оси. Масштаб окна увеличваеться в зависимости от вводных" +
                       "- Далее даеться возможно выбрать количество сторон нащего многоугольника" +
                       "- А после высвичвается возможность ввести размеры сторон по очереди" +
                       "- После внесения первой стороны на рисуне появляеться отрезок. У отрезка определяються обе координаты" +
                       "- После определения коордиант в рандомном порядке выбирается одна из начал отрезка" +
                       "- От этого отрезка в призвольную сторону будет строиться второй" +
                       "- С соблюдением ряда ограничением так рисуется произвольный многоугольник" +
                       "- После мы применяем формулу вычисление площади произвольного многоугольника по коордианатам. " +
                       "Реализацию подобного проекта счел нецелесообразным");
                }

            }

            return null;
        }
    }
}