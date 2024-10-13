using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if_yapisi
            //Console.Write("Lütfen şifre giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülke Giriniz: ");
            //country = Console.ReadLine();
            //if(capital=="ankara" && country=="türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayı Giriniz");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) { Console.WriteLine("Sayı Doğru"); }
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //Girilen sayının negatif pozitif olması

            //int enterNumber;
            //Console.Write("Bir sayı giriniz: ");
            //enterNumber = int.Parse(Console.ReadLine());

            //if (enterNumber == 0) { Console.WriteLine("Girilen sayı sıfır"); }
            //else if (enterNumber < 0) { Console.WriteLine("Girilen sayı negatif"); }
            //else { Console.WriteLine("Girilen sayı pozitif"); }

            //  double exam1, exam2, exam3, result;
            //  Console.Write("1. Sınav Notu: ");
            //  exam1 = double.Parse(Console.ReadLine());
            //  Console.Write("2. Sınav Notu: ");
            //  exam2 = double.Parse(Console.ReadLine());
            //  Console.Write("3. Sınav Notu: ");
            //  exam3 = double.Parse(Console.ReadLine());

            //  result = (exam1 + exam2 + exam3) / 3;

            //  Console.WriteLine("Ortalamanız: "+result);

            //  if(result<=45) { Console.WriteLine("Vasat"); }
            //else  if (result <= 70) { Console.WriteLine("İdare Eder"); }
            //  else if (result <= 85) { Console.WriteLine("İyi"); }
            //  else { Console.WriteLine("Başarılı"); }

            string city;
            Console.WriteLine("Lütfen şehir giriniz:");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut");

            }
            else
            {
                Console.WriteLine("Şehir Mevcut Değil");
            }
            #endregion

            Console.Read();
        }
    }
}
