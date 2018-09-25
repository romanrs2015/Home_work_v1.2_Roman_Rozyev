using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate_the_length
{
    class Program
    {
        static int xy()
        {
           string ks= Console.ReadLine();
           return Convert.ToInt32(ks);// Не предполагается ввод значения с плавующей запятой!
        }
        static double L(double x1, double y1,double x2,double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("                       << Calculate the length >>");
            Console.WriteLine("");
            Console.WriteLine("Расчет длины отрезка в одной плоскости по исхдным координатам ");
            Console.WriteLine("");
            Console.Write("Введите координаты первой точки по оси x:   ");
            int x1=xy();            
            Console.Write("Введите координаты первой точки по оси y:   ");
            int y1 = xy();             
            Console.WriteLine("");
            Console.Write("Введите координаты второй точки по оси x:   ");
            int x2 = xy();  
            Console.Write("Введите координаты второй точки по оси y:   ");
            int y2 = xy();  
            //double L= Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)); 
            Console.WriteLine("Длина отрезка:  {0:F2}", L(x1,y1,x2,y2));
            
            Console.ReadKey();

        }
    }
}
