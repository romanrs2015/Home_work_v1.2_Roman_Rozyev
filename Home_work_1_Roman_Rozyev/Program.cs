using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Questionnaire // 1.Анкета
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                    <<Анкета>> ");
            Console.WriteLine("");
            Console.WriteLine("Заполните анкету.");
            Console.WriteLine("");
            Console.Write("Имя:      ");
            string name = Console.ReadLine();            
            Console.Write("Фамилия:  ");
            string surname = Console.ReadLine();
            Console.Write("Возраст:  ");
            string age = Console.ReadLine();
            Console.Write("Рост, см: ");
            string growth = Console.ReadLine();
            Console.Write("Вес, кг:  ");
            string weight = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Проверьте данные: "+name+" "+surname+", "+age+" лет, "+growth+" см, "+weight+" кг.");
            Console.ReadLine();
            Console.WriteLine("Приняты данные:   {0} {1}, {2} лет, {3} см, {4} кг.",name,surname,age,growth,weight);
            

            Console.ReadKey();

        }
    }
}
