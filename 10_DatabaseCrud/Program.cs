using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud - > Create - Read - Update - Delete

            Console.WriteLine("**** Menü Sipariş ****");
            Console.WriteLine();
            Console.WriteLine("---------------");
            #region kategori_ekleme
            //Console.WriteLine("Eklemek istenen kategori adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=HP; initial catalog=EgitimkampiDB; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into tblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarı ile eklendi");
            #endregion

            #region urun_ekleme


            //string productName; decimal productPrice;
            ////bool productStatus;
            //Console.WriteLine("Eklenecek Ürün Adı:");
            //productName=Console.ReadLine();
            //Console.WriteLine("Eklenecek Ürün Fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());
            ////Console.WriteLine("Eklenecek Ürün Durumu (1/0):");
            ////productStatus = bool.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=HP; initial catalog=EgitimkampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("insert into tblProduct (ProductName,ProductPrice,ProductStatus) values " +
            //    "(@productName,@productPrice,@productStatus)",connection);

            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklendi");
            #endregion

            #region urun_listeme
            //SqlConnection connection = new SqlConnection("Data Source=HP; initial catalog=EgitimkampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * from tblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{

            //    Console.WriteLine(row["ProductName"].ToString() +"("+ row["ProductPrice"].ToString() + " TL)");
            //    //Console.WriteLine(row.ItemArray[1].ToString()+"-" +row.ItemArray[2].ToString());
            //  }

            //connection.Close();


            #endregion

            #region urun_silme
            //Console.Write("Silinecek ürün id: ");
            //int productID = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=HP; initial catalog=EgitimkampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete from tblProduct where ProductID=@productID", connection);
            //cmd.Parameters.AddWithValue("@productID", productID);
            //cmd.ExecuteNonQuery();
            //            connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı.");
            #endregion

            #region urun_guncelleme
            //SqlConnection connection = new SqlConnection("Data Source=HP; initial catalog=EgitimkampiDB; integrated security=true");
            //connection.Open();
            //Console.Write("Güncellenecek ürün id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlCommand cmd = new SqlCommand("update tblProduct Set ProductName=@productName," +
            //    " ProductPrice=@productPrice where ProductID=@productID",connection);
            //cmd.Parameters.AddWithValue("@productID", productId);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Ürün güncellendi...");


            //connection.Close();
            #endregion
            Console.Read();




        }
    }
}
