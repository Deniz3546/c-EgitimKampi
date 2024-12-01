using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriterMethod("Deniz Doğruel");
            //void WriterMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            string CustomerName()
            {
                return "Buse yıldız";
            }
            string name=CustomerName();
            Console.WriteLine(name);
        }
    }
}
