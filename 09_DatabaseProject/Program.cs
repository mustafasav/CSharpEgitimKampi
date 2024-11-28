using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            string tableNumber;
            Console.WriteLine("**** C# VT Ürün Kategori BS ****");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("-----------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");

            tableNumber = Console.ReadLine();
            string baglantiAdresi = "Data Source=HP; initial Catalog=EgitimKampiDb; integrated security=true";
            SqlConnection connection = new SqlConnection(baglantiAdresi);
            if (connection.State == System.Data.ConnectionState.Closed) //Burada bağlantı açık olup olmadığını kontrol ediyoruz. Açıksa tekrar açmaya çalışmıyoruz.
            {
                connection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * From tblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            if (connection.State == System.Data.ConnectionState.Open) //Burada bağlantı açık olup olmadığını kontrol ediyoruz. Açıksa kapatıyoruz, kapalı ise tekrar kapatmaya çalışmıyoruz.
            {
                connection.Close();

            }

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray) {

                    Console.Write(item.ToString());
                
                }
                Console.WriteLine( );


            }


            Console.Read();
        }
    }
}
