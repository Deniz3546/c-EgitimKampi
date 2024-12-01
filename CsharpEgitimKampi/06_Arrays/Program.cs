using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] dizi = new string[4];
            //dizi[0] = "kırmızı";
            //dizi[1] = "sarı";
            //dizi[2] = "Beyaz";
            //dizi[3] = "Mavi";
            //Console.WriteLine(dizi[0]);
            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);
            //int[] numbers=new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[2]);
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);"kırmızı","
            //    string[] Colors = { "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //    for (int i = 0; i < Colors.Length - 1; i++)
            //    {
            //        Console.WriteLine(Colors[i]);
            //    }
            //int[] numbers = { 4, 85, 96, 105, 126 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    } 
            //}
            //string[] persons = { "ali", "Ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);
            int[] numbers =new int[10];
            for(int i = 1; i <= numbers.Length-1; i++)
            {
                Console.WriteLine($"Dizinin {i} Elmanı Giriniz:");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            for(int i = 0;i <= numbers.Length-1; i++)
            
                {
                Console.WriteLine(numbers[i]);
                }
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
           
                int max = numbers.Max();
            Console.WriteLine(max);
            
        }
    }
}
    
