using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalprogramming
{
    class Function
    {

        public Function()
        {

        }

        public void GetAverage()
        {
            string grades = "1,7,15,35,24,18,1992";
            var numbers = grades.Split(',').Select(Int32.Parse).ToList();
            numbers.Sort();
            double result = (from x in numbers where x > numbers[2] select x).Average();
            Console.WriteLine(result);
        }

        public void GetNameSplit()
        {
            string name = "Llewellyn";
            name = string.Concat(name.ToLower().OrderBy(z => z));
            var letterCount = name.GroupBy(c => c).Select(collect => new { Char = collect.Key, Count = collect.Count() });
            foreach (var x in letterCount) { Console.Write("{0}{1}", x.Char, x.Count); }
        }
    }
}

