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
            int transaction = -1;
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
                    user.SellerUser();
                }
                else if(transaction == (int)SellerAccountType.ViewYourProducts)
                {
                    seller.ViewYourProducts();
                }  
                else if(transaction == (int)SellerAccountType.AddProduct)
                {
                    seller.AddProduct(Seller.productsTypeFinding());
                }
                else if(transaction == (int)SellerAccountType.DeleteProduct)
                {
                    seller.AddProduct(Seller.productsTypeFinding());
                }
                else if(transaction == (int)SellerAccountType.Logout)
                {
                    break;
                }
            }
            /*foreach (User sellerList in SellerList)
            {
                Console.WriteLine(sellerList.ToString());
            }  */           
        }
    }
}
