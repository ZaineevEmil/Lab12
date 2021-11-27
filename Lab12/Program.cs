using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа с окружностью
            Console.WriteLine("Программа вычисления параметров круга.\n\nВведите параметры круга: радиус, координаты центра круга х0, у0, координаты точки, проверяемой на принадлежность к кругу х, у");
            Console.Write("Радиус - ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nx0 - ");
            double х0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nу0 - ");
            double у0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nx - ");
            double х = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nу - ");
            double у = Convert.ToDouble(Console.ReadLine());
            Circle.Radius = r;
            Console.WriteLine("\nДлина окружности - {0}", Circle.LengthCircle(r));
            Console.WriteLine("\nПлощадь круга - {0}", Circle.SquareCircle(r));
            Console.WriteLine("\nРезультаты проверки принадлежности точки к кругу - {0}", Circle.CheckPoint(r, х0, у0, х, у));
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double radius = 0;
        public static double Radius
        {
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Введено недопустимое значение");
                }
            }
            get
            {
                return radius;
            }
        }
        public static double LengthCircle(double Radius)
        {
            double result = 0;
            if (Radius >= 0)
            { result = 2 * Math.PI * Radius; }
            return result;
        }
        public static double SquareCircle(double Radius)
        {
            double result = 0;
            if (Radius >= 0)
            { result = Math.PI * Radius * Radius; }
            return result;
        }
        public static string CheckPoint(double Radius, double x0, double y0, double x, double y)
        {
            string result = "";
            if (Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y)) <= Radius)
            {
                result = "Точка находится в круге";
            }
            else
            {
                result = "Точка находится вне круга";
            }
            return result;
        }

    }
}
