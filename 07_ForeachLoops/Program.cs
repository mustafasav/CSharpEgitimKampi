using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region foreach_Dongusu

            //Foreach(1,2,3,4)
            //1-> Değişken Türü
            //2-> Değişken Adı
            //3-> In
            //4-> Liste, Koleksiyon veya Dizi

            //string[] cities = { "Afyon", "Ankara", "Yozgat", "Ağrı", "Denizli", "İzmir", "Samsun" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 12, 26, 30, 42, 65, 4659, 46513, 50, 52 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //int[] numbers = { 12, 26, 30, 42, 65, 2010, 2147, 47, 21, 10, 24, 20, 4659, 46513, 50, 52 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}


            //int[] numbers = { 12, 26, 30, 42, 65, 2010, 2147, 47, 21, 10, 24, 20, 4659, 46513, 50, 52 };
            //int totalValue = 0;
            //foreach (int number in numbers)
            //{
            //    totalValue += number;
            //}
            //Console.WriteLine(totalValue);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,63,65
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba Dünya";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            //Girilen Harfi Saydırma
            //Burada büyük küçük harf duyarlı unutmayalım.
            //int count = 0;
            //string word = "Merhaba Dünya";
            //Console.Write("Aranacak harfi giriniz: ");
            //char karakter =char.Parse(Console.ReadLine());

            //foreach (char x in word)
            //{
            //    if(x == karakter)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"{karakter} harfi {count} adet bulundu.");
            #endregion

            #region ornek_uygulama_sinav_sistemi

            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.Clear();
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. Öğrencinin Adı: ");
                studentNames[i] = Console.ReadLine();
                Console.Clear();
                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{i+1}. öğrencinin ({studentNames[i]}) {j+1}. notunu girin:");
                    totalExamResult += double.Parse(Console.ReadLine());    
                }
                studentExamAvg[i] = totalExamResult / 3;
                Console.Clear();
            }

            string sonucmesaj = "";
            for (int i = 0; i < studentNames.Length; i++)
            {
                sonucmesaj = studentNames[i] + " isimli öğrencinin ortalamsı " + studentExamAvg[i]+" ve öğrenci dersten ";
                if (studentExamAvg[i] >= 50)
                {
                    sonucmesaj += " geçti.";
                }
                else
                {
                    sonucmesaj += " kaldı.";
                }
                Console.WriteLine(sonucmesaj);
            }
            #endregion

            Console.Read();
        }
    }
}
