using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Making_Desicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("sifrenizi giriniz:");
            //string password=Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Sifre yanlis");
            //}
            //string capital, country;

            //Console.Write("Lütfen Başkenti Giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Lütfen ulkenizi Giriniz:");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Yanlıs");
            //}
            //int number;
            //Console.Write("Lütfen sayi giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.Write("Sayı doğru");
            //}
            //else
            //{
            //    Console.Write("Sayi yanlis");
            //}
            //int exam1, exam2, exam3, average;
            //string result;
            //Console.Write("Lütfen 1.Sınav notunu Giriniz:");
            //exam1 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sinav notunu Giriniz:");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sinav notunu Giriniz:");
            //exam3=int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;


            //if(average<0 & average <= 50) {

            //    result = "vasat";
            //    Console.WriteLine(result);
            //}
            //if (average > 50 & average <= 70) {

            //    result = "Sonuc Orta";
            //    Console.WriteLine(result);

            //}
            //if(average>70& average <= 84) {
            //    result = "sonuc iyi";
            //    Console.WriteLine(result);



            //}
            //if (average > 84)
            //{
            //    result = "Sonuc cok iyi";
            //    Console.Write(result);
            //}
            //string city;
            //Console.Write("Lütfen sehir giriniz:");
            //city=Console.ReadLine();
            //if(city=="adana" | city=="ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Sehir Mevcut");
            //}


            //else
            //{
            //    Console.WriteLine("Sehir mevcut değil");
            //}
            //  Console.Write("Kullanici adi Giriniz:");
            //  string username = Console.ReadLine();


            //if(username!="admin"){
            //      Console.WriteLine("hata");

            //  }
            //  else
            //  {
            //      Console.WriteLine("Hosgeldiniz...");
            //  }
            //Console.Write("Lütfen sayıyı Giriniz:");
            //int number=int.Parse(Console.ReadLine());
            //Console.Write("Lutfen 2.sayiyi Giriniz:");
            //int number2=int.Parse(Console.ReadLine());
            //int result = (number % number2);
            //Console.WriteLine("sonuc:" + result);
            //Console.Write("Lütfen sayi giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("çift");
            //}
            //else
            //{
            //    Console.WriteLine("tek");
            //}
            //char team;
            //Console.Write("Takım sembolunu giriniz: ");
            //team=char.Parse(Console.ReadLine());
            //if(team=='g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}if(team=='f'| team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}if(team=='b' | team == 'B')
            //{
            //    Console.WriteLine("Besiktaş");
            //}
            //Console.WriteLine("**** C# Egitim kampi Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-pizzalar");
            //Console.WriteLine("4-içecekler");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("-------------------------------");
            //string item;
            //Console.Write("Menu secimini giriniz:");
            //item = Console.ReadLine();

            //if(item == "1")
            //{
            //    Console.WriteLine("--------------ANA YEMEKLER--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabaği");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine();
            //}
            //if (item == "2")
            //{
            //    Console.WriteLine("--------------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-ezo gelin Çorbalar");
            //    Console.WriteLine("2-Mercimek Çorbalar");
            //    Console.WriteLine("--------------Çorbalar--------------");
            //    Console.WriteLine();
            //}
            //if (item == "3") {
            //    Console.WriteLine("--------------pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdenizpizza");
            //    Console.WriteLine("2-margaritha pizza");
            //    Console.WriteLine("--------------pizzalar--------------");
            //    Console.WriteLine();


            //}
            //if (item == "4")
            //{
            //    Console.WriteLine("--------------pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdenizpizza");
            //    Console.WriteLine("2-margaritha pizza");
            //    Console.WriteLine("--------------pizzalar--------------");
            //    Console.WriteLine();


            //}
            //if (item == "4")
            //{
            //    Console.WriteLine("--------------içecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("--------------içecekler--------------");
            //    Console.WriteLine();


            //}
            //if (item == "5")
            //{
            //    Console.WriteLine("--------------tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliçe");
            //    Console.WriteLine("2-kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("--------------tatlılar--------------");
            //    Console.WriteLine();


            //}
            //int number;
            //number = int.Parse(Console.ReadLine());
            //switch (number) { 
            //        case 1:Console.WriteLine("Ocak");break;
            //        case 2:Console.WriteLine("ŞUBAT");break;
            //        case 3:Console.WriteLine("mART");break;
            //        case 4:Console.WriteLine("NİSAN");break;
            //        case 5:Console.WriteLine("Mayis");break;
            //        case 6:Console.WriteLine("Haziran");break;
            //        case 7:Console.WriteLine("Temmuz");break;
            //        case 8:Console.WriteLine("Ağustos");break;
            //        case 9:Console.WriteLine("Eylül");break;
            //        case 10:Console.WriteLine("Ekim");break;
            //        case 11:Console.WriteLine("Kasım");break;
            //        case 12:Console.WriteLine("Aralık");break;

            //    default:
            //        Console.WriteLine("Hata");
            //        break;
                        
            //            }
            Console.Read();




        }

        



    
    }
}
