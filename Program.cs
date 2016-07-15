using System;
using System.Collections.Generic;
using System.Linq;

namespace DestinationPoints
{
    public class Program
    {
        static void Main(string[] args)
        {
            var source = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Мельбурн", "Кельн"),
                new Tuple<string, string>("Берлин", "Токио"),
                new Tuple<string, string>("Москва", "Париж"),
                new Tuple<string, string>("Кельн", "Москва"),
                new Tuple<string, string>("Париж", "Берлин")
            };

            var result = GetRoute(source);
            foreach (var item in result) Console.WriteLine("{0} - {1}", item.Item1, item.Item2);
            Console.ReadKey();
        }

        //примерная сложность N^2
        public static List<Tuple<string, string>> GetRoute(List<Tuple<string, string>> input)
        {
            var d = input.ToDictionary(x => x.Item1, v => v);
            var first = d.Single(x => d.Values.All(v => v.Item2 != x.Key)).Value;
            var output = new List<Tuple<string, string>> { first };
            var temp = first;
            while (d.TryGetValue(temp.Item2, out temp)) output.Add(temp);
            return output;
        }
    }
}
