using System;
using System.Collections.Generic;
using System.Linq;
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

            //Color.ColorWrite();

            Console.ReadLine();
        }

        static void RunAccount()
        {
            User user = new User();

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

            user.UserTransactions();
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

            Dress dress = new Dress(200,500,Brand.Mavi,100,ColorType.Black,ProductsType.dress,
                DressLengthPatterns.longLength,PantsAndDressBodys.fortytwo,DressFabricType.Cotton);
            Dress dress1 = new Dress(201, 501, Brand.Defacto, 200, ColorType.Red, ProductsType.dress,
                DressLengthPatterns.longLength, PantsAndDressBodys.fortytwo, DressFabricType.Viskon);
            Dress dress2 = new Dress(202, 502, Brand.Lcwakiki, 300, ColorType.Black, ProductsType.dress,
                DressLengthPatterns.longLength, PantsAndDressBodys.forty, DressFabricType.Cotton);
            Dress dress3 = new Dress(203, 503, Brand.Lcwakiki, 400, ColorType.Green, ProductsType.dress,
                DressLengthPatterns.longLength, PantsAndDressBodys.standard, DressFabricType.Polyester);
            Dress dress4 = new Dress(200, 504, Brand.Mavi, 500, ColorType.Red, ProductsType.dress,
                DressLengthPatterns.longLength, PantsAndDressBodys.thirtsix, DressFabricType.Cotton);

            Seller.dressList.Add(dress);
            Seller.dressList.Add(dress1);
            Seller.dressList.Add(dress2);
            Seller.dressList.Add(dress3);
            Seller.dressList.Add(dress4);
        }

        static void SavedTshirtData()    //Kayıtlı Ürün Veriler
        {

            Tshirt tshirt = new Tshirt(2001, 400, Brand.Mavi, 100, ColorType.Black, ProductsType.tshirt,
                TshirtPatterns.oversize, TshirtBodys.small, TshirtFabricType.Cotton);
            Tshirt tshirt1 = new Tshirt(201, 401, Brand.Defacto, 200, ColorType.Red, ProductsType.tshirt,
                TshirtPatterns.oversize, TshirtBodys.small, TshirtFabricType.Cotton);
            Tshirt tshirt2 = new Tshirt(203, 402, Brand.Lcwakiki, 300, ColorType.Black, ProductsType.tshirt,
                TshirtPatterns.oversize, TshirtBodys.small, TshirtFabricType.Cotton);
            Tshirt tshirt3 = new Tshirt(203, 403, Brand.Lcwakiki, 400, ColorType.Green, ProductsType.tshirt,
                TshirtPatterns.oversize, TshirtBodys.small, TshirtFabricType.Cotton);
            Tshirt tshirt4 = new Tshirt(202, 404, Brand.Mavi, 500, ColorType.Red, ProductsType.tshirt,
                TshirtPatterns.oversize, TshirtBodys.small, TshirtFabricType.Cotton);

            Seller.tshirtsList.Add(tshirt);
            Seller.tshirtsList.Add(tshirt1);
            Seller.tshirtsList.Add(tshirt2);
            Seller.tshirtsList.Add(tshirt3);
            Seller.tshirtsList.Add(tshirt4);
        }

        static void SavedPantsData()    //Kayıtlı Ürün Veriler
        {

            Pants pants = new Pants(200, 300, Brand.Mavi, 100, ColorType.Black, ProductsType.pants,
                PantTrotterPatterns.tightTrotters,PantsAndDressBodys.thirtyeight,PantsFabricType.Likra);
            Pants pants1 = new Pants(200, 301, Brand.Lcwakiki, 450, ColorType.Blue, ProductsType.pants,
                PantTrotterPatterns.wideTrotters, PantsAndDressBodys.thirtyeight, PantsFabricType.Satin);
            Pants pants2 = new Pants(203, 302, Brand.Lcwakiki, 150, ColorType.Blue, ProductsType.pants,
                PantTrotterPatterns.normalTrotters, PantsAndDressBodys.thirtyeight, PantsFabricType.Polyester);
            Pants pants3 = new Pants(201, 303, Brand.Defacto, 300, ColorType.Black, ProductsType.pants,
                PantTrotterPatterns.wideTrotters, PantsAndDressBodys.thirtyeight, PantsFabricType.Cotton);
            Pants pants4 = new Pants(202, 304, Brand.Mavi, 200, ColorType.Black, ProductsType.pants,
                PantTrotterPatterns.wideTrotters, PantsAndDressBodys.thirtyeight, PantsFabricType.Cotton);

            Seller.pantsList.Add(pants);
            Seller.pantsList.Add(pants1);
            Seller.pantsList.Add(pants2);
            Seller.pantsList.Add(pants3);
            Seller.pantsList.Add(pants4);
        }

    }
}
