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
            #region temel_dizi_ornekleri
            //Değişken türü []Dizi Adı = new Değişken Türü [elemansayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];
            //cities[0] = "Afyon";
            //cities[1] = "Ankara";
            //cities[2] = "Yozgat";
            //cities[3] = "Ağrı";
            //cities[4] = "İstanbul";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 65;
            //numbers[7] = 778;
            //Console.WriteLine(numbers[6]);

            //string[] cities2 = { "Konya" ,"Bursa","İzmir","Kırşehir"};

            //Console.WriteLine(cities2[2]);
            #endregion
            #region dizi_listeleme

            //string[] colors = {"Sarı","Kırmızı","Siyah","Beyaz","Lacivert","Mor" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 35, 42, 653, 102, 46, 86, 99,2365,1120 };
            ////3e tam bölünenleri alma

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if(numbers[i] %3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c','*','/','-'};

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 6500, 25, 653, 783, 85, 96, 99, 100 };

            //int maxValue=myArray[0];

            //for (int i = 1; i <myArray.Length; i++)
            //{
            //    if (myArray[i] > maxValue) 
            //    { 
            //        maxValue = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxValue);

            //string[] persons = { "mali", "deniz", "ayşe", "emine", "sevim", "buse", "cem" };

            //Console.WriteLine(persons.Length);
            //Array.Sort(persons); // A'dan Z'ye sıralama
            //Console.WriteLine(persons[0]);
            //int[] number = { 100, 32, 8, 25, 20, 3, 4, 50, 6, 7 };

            //Array.Sort(number); //Küçükten Büyüğe Sıralama
            //Console.WriteLine(number[0]);
            //Array.Reverse(number); //Sıralamayı tersine çevirme

            //Console.WriteLine(number[0]);

            #endregion
            #region dizi_metot_ornekler
            //string[] customers = {"serkan","filiz","fatma","mustafa","gökhan","deniz" };
            ////Indexof: Belirtilen elemanın index numarasını verir.
            ////-1 dönerse eleman dizide yok veya bulunamadı demektir.
            //int index = Array.IndexOf(customers, "mustafa");
            //Console.WriteLine(index);
            //int[] number = { 144, 20, 33, 42, 5,5, 6, 65, 42, 34 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + number.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + number.Min());
            //Console.WriteLine("Dizinin Toplamı: "+ number.Sum());
            //Console.WriteLine("Dizi Boyutu: " + number.Rank);
            //Console.WriteLine("Dizinin Ortalaması: " + number.Average());
            #endregion
            #region kullanicidan_deger_alma
            //string[] cities= new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehir İsmi Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //    Console.Clear();
            //}
            //Console.Write("Girilen Şehirler: ");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write(cities[i]+" ");

            //}
            #endregion
            #region metot_kullanmadan_dizi_elemanlari_toplama
            //int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };
            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}

            //Console.WriteLine(total);



            #endregion

            #region dizi_tek_cift_ayirma
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22 };
            int[] oddsNumbers = new int[numbers.Length];
            int[] evenNumbers = new int[numbers.Length];
            int oddsCounter = 0;
            int evenCounter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[evenCounter]=numbers[i];
                    evenCounter++;                   
                }
                else
                {
                    oddsNumbers[oddsCounter] = numbers[i];
                    oddsCounter++;
                }
            }
            Console.Write("Tek Sayılar: ");
            for (int i = 0;i < oddsCounter; i++)
            {
                Console.Write(oddsNumbers[i]+" ");
            }
            Console.WriteLine();
            Console.Write("Çift Sayılar: ");
            for (int i = 0; i < evenCounter; i++)
            {
                Console.Write(evenNumbers[i]+" ");
            }
            #endregion

            Console.Read();

        }
    }
}
