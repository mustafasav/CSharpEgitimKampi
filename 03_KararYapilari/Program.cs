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

            //string city;
            //Console.WriteLine("Lütfen şehir giriniz:");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            // }

            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kabul Edilmez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldin "+ username);
            //}


            #endregion


            #region mod_islemleri

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.Write("enter number 1th:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("enter number 2th:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümüne kalan: "+result);

            //Console.WriteLine("Bir sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çift");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tek");
            //}
            #endregion
            //char team;
            //Console.WriteLine("Takım Sembolü giriniz");
            //team = char.Parse(Console.ReadLine());


            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'T' | team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Diğer takım");
            //}



            #region ornekProje
            //Console.WriteLine("C# Eğitim Kafe");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //string secim;
            //Console.WriteLine("Lütfen bir seçim yapınız (1-2-3-4-5)");
            //secim= Console.ReadLine();
            //if(secim=="1")
            //{
            //    Console.Clear();
            //    Console.WriteLine("1-Kebab");
            //    Console.WriteLine("2-Döner");
            //    Console.WriteLine("3-Adana");
            //    Console.WriteLine("4-Köfte");
            //    Console.WriteLine("5-Balık");
            //}

            #endregion

            #region switchcase_yapisi
            //Console.Write("Lütfen ay numarası giriniz");
            //int mounthNumber = int.Parse(Console.ReadLine());

            //switch (mounthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;

            //}


            #endregion

            #region hesap_mak
            int number1, number2;
            char symbol;

            Console.Write("Enter Number 1th: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2th: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("İşlemi seçiniz: (+ - * /)");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine(number1 / number2);
                        }
                        else
                        {
                            Console.WriteLine("Sıfıra bölme yapılamaz");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz"); break;

            }


                    #endregion
                    Console.Read();
            }
        }
    }

    

