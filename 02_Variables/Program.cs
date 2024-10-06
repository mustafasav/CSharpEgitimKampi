using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double_degiskenler
            double number;
            number = 4.75;
            Console.WriteLine(number);


            Console.WriteLine("***Fiyat Listesi***");

            double applePrice, orangePrice, patotaPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.35;
            patotaPrice = 9.75;
            tomatoPrice = 6.85;
            Console.WriteLine("---- Elma Fiyatı : " + applePrice);
            Console.WriteLine("---- Portakal Fiyatı : " + orangePrice);
            Console.WriteLine("---- Patates Fiyatı : " + patotaPrice);
            Console.WriteLine("---- Domates Fiyatı : " + tomatoPrice);

            double appleGram, orangeGram, patotaGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            patotaGram = 2.500;
            tomatoGram = 0.750;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            Console.WriteLine("Alınan Ürün Elma - Birim Fiyat:" + applePrice +
                                                "- Gramaj: " + appleGram +
                                                " - Toplam Tutar: " + appleTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün Portakal - Birim Fiyat:" + orangePrice +
                                               "- Gramaj: " + orangeGram +
                                               " - Toplam Tutar: " + orangeTotalPrice + " TL");
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice;
            Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice + " TL");
            #endregion
            #region char_degiskenler
            Console.WriteLine("\n---- Char Değişkenleri ----");
            char karakter;
            karakter = 'a';
            Console.WriteLine(karakter);

            #endregion

            #region Klavyeden_Veri_Girisi_String
            //Console.WriteLine("**** CSharp Hava Yolları *****");
            //string passengerName, passengerSurname, passengerDistrict, passengerAge,
            //     passengerIdentityNumber, passengerCity;

            //Console.Write("Yolcu Adı:");
            //passengerName=Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname =Console.ReadLine();

            //Console.WriteLine(passengerName+" "+passengerSurname);

            #endregion

            #region Klavyeden_Tam_Sayi_Giris_Int

            //int shoePrice, computerPrice, chairPrice, tablePrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tablePrice = 6500;

            //int shoeCount, computerCount, chairCount, tableCount;
            //Console.Write("Ayakkabı Adeti: ");
            //shoeCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bilgisayar Adeti: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sandalye Adeti: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Masa Adeti: ");
            //tableCount = Convert.ToInt32(Console.ReadLine());

            //int shoeTotalPrice = shoeCount * shoePrice;
            //int computerTotalPrice = computerCount * computerPrice;
            //int chairTotalPrice = chairCount * chairPrice;
            //int tableTotalPrice = tableCount * tablePrice;

            //int totalPrice= shoePrice+computerPrice+chairPrice+tablePrice;
            //Console.WriteLine("Toplam Tutar: "+totalPrice);

            #endregion


            #region Klavyeden_Sayi_Girisi_Double

            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notu:");
            //exam1=Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sınav Notu:");
            //exam2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3. Sınav Notu:");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama: " + result);

            #endregion


            #region klavyeden_karakter_girisi
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz (E/K):");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Karakter: " + gender);


            #endregion

            Console.Read();
        }
    }
}
