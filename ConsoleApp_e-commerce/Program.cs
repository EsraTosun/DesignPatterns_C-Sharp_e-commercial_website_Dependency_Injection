using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
     class Program
    {
        static void Main(string[] args)
        {
            SavedUserData();
            RunAccount();

            Console.ReadLine();
        }

        static void RunAccount()
        {
            UserTransacions userTransactions = new UserTransacions();

            int transaction = -1;

            while (true)
            {
                Console.WriteLine("1- Seller");
                Console.WriteLine("2- Customer");
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == 1)
                {
                    User.userType = UserType.Seller;
                    break;
                }

                else if (transaction == 2)
                {
                    User.userType = UserType.Customer;
                    break;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
            userTransactions.UserTransactionsMenu();

        }

        static void SavedUserData()    //Kayıtlı Kişi Veriler
        {
            User selleruser = new User(200,"Azra","Yağız","123","azra@gmail.com","123","İstanbul");
            User selleruser1 = new User(201, "Mehmet", "Yıldız", "123", "Mehmet@gmail.com", "123", "İstanbul");
            User selleruser2 = new User(202, "Cenk", "Melek", "123", "Cenk@gmail.com", "123", "İstanbul");
            User selleruser3 = new User(203, "Ayşe", "Nehir", "123", "Ayşe@gmail.com", "123", "İstanbul");

            User customerruser = new User(100, "Şaziye", "Dağ", "123", "Şaziye@gmail.com", "123", "İstanbul");
            User customerruser1 = new User(101, "Şeyda", "Açıkgöz", "123", "Şeyda@gmail.com", "123", "İstanbul");
            User customerruser2= new User(102, "Esra", "Tosun", "123", "Esra@gmail.com", "123", "İstanbul");
            User customerruser3 = new User(103, "Bige", "Dua", "123", "Bige@gmail.com", "123", "İstanbul");

            Seller.SellerList.Add(selleruser);
            Seller.SellerList.Add(selleruser1);
            Seller.SellerList.Add(selleruser2);
            Seller.SellerList.Add(selleruser3);

            Seller.CustomerList.Add(customerruser);
            Seller.CustomerList.Add(customerruser1);
            Seller.CustomerList.Add(customerruser2);
            Seller.CustomerList.Add(customerruser3);

            SavedDressData();
            SavedPantsData();
            SavedTshirtData();
        }

        static void SavedDressData()    //Kayıtlı Ürün Veriler
        {
           /* (int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)  */
            Products products = new Products(200,1000, 
                Enum.GetName(typeof(BrandType), 0), 
                100, 
                Enum.GetName(typeof(ColorType), 0), 
                Enum.GetName(typeof(ProductsType), 3),
                Enum.GetName(typeof(PatternsType), 1),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 3));
            Products products1 = new Products(201, 1001,
                Enum.GetName(typeof(BrandType), 0),
                100,
                Enum.GetName(typeof(ColorType), 3),
                Enum.GetName(typeof(ProductsType), 3),
                Enum.GetName(typeof(PatternsType), 4),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 3));
            Products products2 = new Products(202, 1002,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 3),
                Enum.GetName(typeof(PatternsType), 1),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 1));
            Products products3 = new Products(203, 1003,
                Enum.GetName(typeof(BrandType), 2),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 3),
                Enum.GetName(typeof(PatternsType), 2),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 2));
            Products products4 = new Products(200, 1004,
                Enum.GetName(typeof(BrandType), 0),
                100,
                Enum.GetName(typeof(ColorType), 3),
                Enum.GetName(typeof(ProductsType), 3),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 3),
                Enum.GetName(typeof(FabricType), 3));

            Seller.productList.Add(products);
            Seller.productList.Add(products1);
            Seller.productList.Add(products2);
            Seller.productList.Add(products3);
            Seller.productList.Add(products4);
        }

        static void SavedTshirtData()    //Kayıtlı Ürün Veriler
        {
            Products products = new Products(201, 1005,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 1),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 2));
            Products products1 = new Products(202, 1006,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 2));
            Products products2 = new Products(203, 1007,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 3),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 2),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 1));
            Products products3 = new Products(200, 1008,
                Enum.GetName(typeof(BrandType), 0),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 3),
                Enum.GetName(typeof(FabricType), 1));
            Products products4 = new Products(201, 1009,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 0));

            Seller.productList.Add(products);
            Seller.productList.Add(products1);
            Seller.productList.Add(products2);
            Seller.productList.Add(products3);
            Seller.productList.Add(products4);
        }

        static void SavedPantsData()    //Kayıtlı Ürün Veriler
        {

            Products products = new Products(202, 1010,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 1),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 1));
            Products products1 = new Products(203, 1011,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 1),
                Enum.GetName(typeof(PatternsType), 1),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 1));
            Products products2 = new Products(200, 1012,
                Enum.GetName(typeof(BrandType), 2),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 1),
                Enum.GetName(typeof(PatternsType), 2),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 2));
            Products products3 = new Products(201, 1013,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 3),
                Enum.GetName(typeof(ProductsType), 1),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 3),
                Enum.GetName(typeof(FabricType), 4));
            Products products4 = new Products(202, 1014,
                Enum.GetName(typeof(BrandType), 4),
                100,
                Enum.GetName(typeof(ColorType), 4),
                Enum.GetName(typeof(ProductsType), 1),
                Enum.GetName(typeof(PatternsType), 4),
                Enum.GetName(typeof(BodyType), 4),
                Enum.GetName(typeof(FabricType), 4));

            Seller.productList.Add(products);
            Seller.productList.Add(products1);
            Seller.productList.Add(products2);
            Seller.productList.Add(products3);
            Seller.productList.Add(products4);
        }

    }
}
