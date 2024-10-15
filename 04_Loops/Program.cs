using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for_dongusu
            //for(Başlangıç,Bitiş,Artış-Azalış miktarı)
            //int i;
            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("Eğitim Kampı");
            //}

            //for( int i=1;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen sayı giriniz");
            //int finishValue=int.Parse(Console.ReadLine());  

            //for(int i = 1;i<=finishValue;i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion


            #region for_dongusu_karar_yapisi

            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue = totalValue + i;
            //    Console.Write(i);
            //    //Sayıları yan yana yazıp araya + işaretini son sayıya kadar koysun, son sayıda koymasın diye
            //    if (i != 10)  
            //    {
            //        Console.Write("+");
            //    }

            //}
            //Console.Write("="+ totalValue);

            //1 - 20 arası çift sayıların toplamı

            //for (int i = 0; i < 10; i+=2)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // 1 - 50 arası 7 ye tam bölünen kaç sayı var

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            //int hour = 0;
            //ulong total = 1;
            //Console.WriteLine("Saat Giriniz:");
            //hour=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= hour; i++)
            //{
            //    total *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda Sayı: " + total);
            //}

            #endregion

            #region while_dongusu

            // While(şart)
            // işlemler
            // arttırmayı unutma

            //int i = 1;
            //while (i <=10) {
            //    Console.WriteLine("while döngüsü");
            //    i++;
            //}

            //int i = 1;
            //while (i <=10) {
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 0;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;           
            //    i++;
            //}
            //Console.WriteLine("Toplam: "+sum);


            #endregion


            #region ornek_uygulama_sorusu

            //Klavyeden girilen 3 basamaklı sayının bamakları toplamını bulan kod

            int number = 0;

            Console.Write("Sayı Giriniz: ");
            number=int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;

            ones = number % 10;
            tens = (number%100)/ 10;
            hundreds = number / 100;
            Console.WriteLine("Birler Basamağı: "+ones);
            Console.WriteLine("Onlar Basamağı: "+ tens);
            Console.WriteLine("Yüzler Basamağı: "+hundreds);
            Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine("Basamak Toplamı: "+sum);
            #endregion

            Console.Read();
        }
    }
}
