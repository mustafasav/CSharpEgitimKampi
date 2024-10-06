using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam");

            Console.WriteLine("*** Yemek Kategorileri ***");
            Console.WriteLine();
            Console.WriteLine("1- Çorbalar");
            Console.WriteLine("2- Ana Yemekler");
            Console.WriteLine("3- Soğuk Başlangıçlar");
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçecekler");
            Console.WriteLine();

            #endregion

            #region String_Degiskenler


            //DeğiştenTürü DeğişkenAdı;
            string name;
            name = "Mustafa";
            Console.WriteLine(name);


            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;
            customerName = "Mustafa";
            customerSurname = "sav";
            customerPhone = "+90 541 818 00 00";
            customerEmail = "info@mustafasav.com";
            district = "Akdağmadeni";
            city = "Yozgat";

            Console.WriteLine("Rezervasyon Kartı");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            customerName = "Ayşegül";
            Console.WriteLine(customerName);
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 00 00";
            customerEmail = "test@test.com";
            city = "Afyonkarahisar";
            district = "Merkez";
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);

            #endregion

            #region Int_Degiskenler
            int number = 25;
            Console.WriteLine(number);
            int hamburgerPrice = 200;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 55;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***Menü***");
            Console.WriteLine("Kola\t\t:\t" + cokePrice + " TL");
            Console.WriteLine("Hamburger\t:\t" + hamburgerPrice + " TL");
            Console.WriteLine("Su\t\t:\t" + waterPrice + " TL");
            Console.WriteLine("Pizza\t\t:\t" + pizzaPrice + " TL");

            int hamburgerCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int cokeCount;

            int totalPrice = 0;
            hamburgerCount = 1;
            waterCount = 0;
            friesCount = 0;
            pizzaCount = 0;
            lemonadeCount = 0;
            cokeCount = 0;
            totalPrice = hamburgerCount * hamburgerPrice +
                waterCount * waterPrice +
                friesCount * friesPrice +
                pizzaPrice * pizzaCount +
                lemonadePrice * lemonadeCount +
                cokePrice * cokeCount;
            Console.WriteLine("Toplam Tutar : " + totalPrice);
            #endregion
            Console.Read();

        }
    }
}
