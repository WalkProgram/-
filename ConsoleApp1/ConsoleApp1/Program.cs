using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime нг = new DateTime(2020, 1, 1);
            DateTime сейчас = DateTime.MaxValue;

            TimeSpan tsp = нг - сейчас;
            int days = (int)tsp.TotalDays;

            Console.WriteLine(" Сколько ещё ждать оливье??? - " + days);
            Console.ReadKey();
        }
    }
}
