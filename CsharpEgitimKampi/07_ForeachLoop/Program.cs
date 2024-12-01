using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //int[] numbers = { 50, 40, 70, 85, 90, 130, 180, 540, 987 };
            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //int[] numbers = { 50, 40, 70, 85, 90, 130, 180, 540, 987 };

            //foreach (int i in numbers) {

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            List<int> list = new List<int>()
            {
                1,
                2,
                3,
                45,
                7,
                8,
                9,
                20
            };
            foreach (int i in list) { 
            Console.WriteLine
                    (i);
            
            }
        }
    }
}
