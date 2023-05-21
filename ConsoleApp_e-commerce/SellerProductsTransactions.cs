using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class SellerProductsTransactions   //Satıcı
    {
        static Seller seller = new Seller();
        static User user = new User();

        public static void SellerAccount()    //Satıcı Hesabı
        {
            int transaction;
            while (true)
            {
                Console.WriteLine("1- Account information"); //Hesap bilgileri
                Console.WriteLine("2- View your products");  //Ürünlerini görüntüle
                Console.WriteLine("3- Add product");   //Ürün ekle
                Console.WriteLine("4- Delete product");   //Ürün Sil
                Console.WriteLine("5- Logout");  //Çıkış yap
                transaction = Convert.ToInt32(Console.ReadLine());

                if(transaction == (int)SellerAccountType.AccountInformation)
                {
                    seller.AccountInformation();
                }
                else if(transaction == (int)SellerAccountType.ViewYourProducts)
                {
                    seller.ViewYourProducts();
                }  
                else if(transaction == (int)SellerAccountType.AddProduct)
                {
                    seller.AddProduct();
                }
                else if(transaction == (int)SellerAccountType.DeleteProduct)
                {
                    seller.ViewYourProducts();
                    seller.DeleteProduct();
                }
                else if(transaction == (int)SellerAccountType.Logout)
                {
                    return;
                }
            }          
        }
    }
}
