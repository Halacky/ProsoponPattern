using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace πρόσωπον
{
    public class MedianValue
    {
        /// <summary>
        /// Метод для подсчета Медианы
        /// </summary>
        public void GetMedian(Dictionary<string, List<int>> salary)
        {
            Console.WriteLine("Вычисляется Медиана");
            foreach(var item in salary)
            {
                item.Value.Sort();
                Console.Write(item.Key + ": ");
                if (item.Value.Count % 2 == 0)
                    Console.WriteLine($"{(item.Value[(item.Value.Count - 1) / 2] + item.Value[(item.Value.Count / 2)]) / 2}");
                else
                    Console.WriteLine($"{item.Value[(item.Value.Count - 1) / 2]}");

            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод для подсчета моды
        /// </summary>
        public void GetModa(Dictionary<string, List<int>> salary)
        {
            Console.WriteLine("Вычисляется Мода");

            foreach (var item in salary)
            {
                Console.Write(item.Key + ": ");
                var most = item.Value.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
                Console.WriteLine(most);
            }
            Console.WriteLine();
        }

    }
}
