using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.SorokinMA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства: «валету» — 11, «даме» — 12,              *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14. Порядковые номера остальных карт            *");
            Console.WriteLine("* соответствуют их названиям («шестерка», «девятка» и т.п.). По заданному *");
            Console.WriteLine("* номеру карты k (6 <=k <= 14) определить достоинство соответствующей     *");
            Console.WriteLine("* карты.                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите достоинство игральной карты:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.FindCardValue(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
