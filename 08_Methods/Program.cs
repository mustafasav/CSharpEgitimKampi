using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region parametresiz_void_metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Void

            // void CustomerList()
            //{
            //    Console.WriteLine("Mustafa");
            //    Console.WriteLine("Ahmet");
            //    Console.WriteLine("Ayşegül");

            //}
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 5;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion
            #region string_parametreli_void_metotlar
            //void Yazdir(string customerName)
            //{
            //    Console.WriteLine("Hoşgeldin "+ customerName);
            //}

            //Yazdir("Mustafa");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name+" "+surname);
            // }

            //CustomerCard("Mustafa", "Yıldız");
            //CustomerCard("Ayşegül", "Duyan");

            #endregion
            #region int_parametreli_void_metotlar

            //2 Parametre Alan Metot
            //void Topla(int number1, int number2)
            //{
            //    Console.WriteLine($"{number1} + {number2} = {number1+number2}");
            //}

            //Topla(5, 10);

            //3 Parametreli 2 zorunlu 3. isteğe bağlı parametre tanımlama
            //number3 verilirse alır verilmezse 0 alır varsayılan olarak.
            //void Topla2(int number1, int number2, int number3 = 0)
            //{
            //    Console.WriteLine($"{number1} + {number2} + {number3} = {number1 + number2+number3}");
            //}

            //Topla2(5, 10, 15);
            //Topla2(5, 6);//3. parametre verilmezse değeri varsayılan 0 dır.

            #endregion
            #region deger_donduren_metotlar
            //string mesajYaz()
            //{
            //    return "Buse Kaya";
            //}

            //string StudentCard()
            //{
            //    string name = "Ahmet";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion
            #region deger_donduren_parametreli_metotlar
            //string CountryCard(string countryName,string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: "+countryName + " - Başkent: " + capital+" - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string a, b, c;
            //Console.Write("Ülke Adı Giriniz: ");
            //a =Console.ReadLine();
            //Console.Write("Ülke Başkenti Giriniz: ");
            //b = Console.ReadLine();
            //Console.Write("Ülke Bayrak Renkleri Giriniz: ");
            //c = Console.ReadLine();
            //Console.WriteLine(CountryCard(a, b, c));

            //int Topla(int number1, int number2)
            //{

            //    return number1+number2;
            //}

            //int a, b;
            //Console.Write("Enter 1th:");
            //a= int.Parse(Console.ReadLine());
            //Console.Write("Enter 2th:");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Toplamı: "+Topla(a, b));
            #endregion
            #region ornek_exam_uygulamasi
            //string SinavSonuc(string ogrenciAdi, int sinav1 = 0, int sinav2 = 0, int sinav3 = 0)
            //{
            //    int sonuc = (sinav1 + sinav2 + sinav3) / 3;
            //    if (sonuc >= 50)
            //    {
            //        return ogrenciAdi + " isimli öğrenci sınavdan geçti ve Ortalaması:  " + sonuc;
            //    }
            //    else
            //    {
            //        return ogrenciAdi + " isimli öğrenci sınavdan kaldı ve Ortalaması:  " + sonuc;
            //    }
            //}
            //Console.WriteLine(SinavSonuc("Mustafa", 65, 75, 85));
            //Console.WriteLine(SinavSonuc("Elif", 25, 35, 45));


            //string name;
            //int exam1, exam2, exam3;

            //Console.Write("Öğrencinin Adı: ");
            //name= Console.ReadLine();

            //Console.Write("Öğrencinin 1. Sınav Notu: ");
            //exam1 =int.Parse( Console.ReadLine());

            //Console.Write("Öğrencinin 2. Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Öğrencinin 3. Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(SinavSonuc(name, exam1, exam2, exam3));
            #endregion


            Console.Read();

        }
    }
}
