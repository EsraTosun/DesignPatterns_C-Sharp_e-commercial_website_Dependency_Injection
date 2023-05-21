using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum SellerAccountType   //Satıcı hesap tipleri
    {
        AccountInformation = 1,
        ViewYourProducts = 2,
        AddProduct = 2,
        DeleteProduct = 3,
        Logout = 4,
    }

    class Seller : User, ISeller
    {
        int transaction = -1;

        public static List<Products> productList = new List<Products>();
        public static List<Dress> dressList = new List<Dress>();
        public static List<Tshirt> tshirtsList = new List<Tshirt>();
        public static List<Pants> pantsList = new List<Pants>();

        Products product = new Products();
        Dress dress = new Dress();
        Pants pants = new Pants();
        Tshirt tshirt = new Tshirt();
        User user = new User();


        public void AddProduct(ProductsType IncomingproductType)  //Ürün tipi
        {
            if (IncomingproductType == ProductsType.pants) 
            {
                PantsProductAdd();
            }
            else if (IncomingproductType == ProductsType.tshirt) 
            {
                TshirtProductAdd();
            }
            else if (IncomingproductType == ProductsType.dress) 
            {
                DressProductAdd();
            }
        }

        void PantsProductAdd()
        {
            pants.productType = ProductsType.pants;
            pants.ID = pantsList.Count + 300;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            pants.amount = Convert.ToInt32(Console.ReadLine());
            pants.color = Color.ColorFinfing();
            pants.brand = Brands.BrandListFinding();
            pants.pantsAndDressBodys = BodyChart.PantsAndDressBodysFinding();
            pants.pantTrotterPatterns = Patterns.PantTrotterPatternsFinding();
            pants.pantsFabricType = Fabrics.PantsFabricTypeFinding();
            pants.UserID = USERID;
            pantsList.Add(pants);

            /* product.ID = pants.ID;
            product.UserID = USERID;
            product.productType = pants.productType;
            product.amount = pants.amount;
            productList.Add(product);  */
        }
        void TshirtProductAdd()
        {
            tshirt.productType = ProductsType.tshirt;
            tshirt.ID = pantsList.Count + 400;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            tshirt.amount = Convert.ToInt32(Console.ReadLine());
            tshirt.color = Color.ColorFinfing();
            tshirt.brand = Brands.BrandListFinding();
            tshirt.tshirtBodys = BodyChart.TshirtBodysFinding();
            tshirt.tshirtPatterns = Patterns.TshirtPatternsFinding();
            tshirt.tshirtFabricType = TshirtFabricType.Cotton;
            tshirt.UserID = USERID;
            tshirtsList.Add(tshirt);

            /*product.ID = pants.ID;
            product.UserID = USERID;
            product.productType = pants.productType;
            product.amount = pants.amount;
            productList.Add(product);  */
        }
        void DressProductAdd()
        {
            dress.productType = ProductsType.pants;
            dress.ID = pantsList.Count + 500;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            dress.amount = Convert.ToInt32(Console.ReadLine());
            dress.color = Color.ColorFinfing();
            dress.brand = Brands.BrandListFinding();    
            dress.pantsAndDressBodys = BodyChart.PantsAndDressBodysFinding();
            dress.dressLengthPatterns = Patterns.DressLengthPatternsFinding();
            dress.dressFabricType = Fabrics.DressFabricTypeFinding();
            dress.UserID = USERID;
            dressList.Add(dress);

            /* product.ID = pants.ID;
            product.UserID = USERID;
            product.productType = pants.productType;
            product.amount = pants.amount;
            productList.Add(product);  */
        }

        public void DeleteProduct(ProductsType IncomingproductType)  //Ürün tipi
        {
            if (IncomingproductType == ProductsType.pants)
            {
                PantsProductDelete();
            }
            else if (IncomingproductType == ProductsType.tshirt)
            {
                TshirtProductDelete();
            }
            else if (IncomingproductType == ProductsType.dress)
            {
                DressProductDelete();
            }
        }

        void PantsProductDelete()
        {
            Pants.SortThePants();
            transaction = Convert.ToInt32(Console.ReadLine());

            pantsList.RemoveAt(transaction - 100);
        }
        void TshirtProductDelete()
        {
            Tshirt.SortTheTshirt();
            transaction = Convert.ToInt32(Console.ReadLine());

            tshirtsList.RemoveAt(transaction - 200);
        }
        void DressProductDelete()
        {
            Dress.SortTheDress();
            transaction = Convert.ToInt32(Console.ReadLine());

            dressList.RemoveAt(transaction - 300);
        }


        public static ProductsType productsTypeFinding()
        {
            int transaction = -1;
            while (true)
            {
                Console.WriteLine("1- " + ProductsType.pants);
                Console.WriteLine("2- " + ProductsType.tshirt);
                Console.WriteLine("3- " + ProductsType.dress);
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == (int)ProductsType.pants)
                {
                    return ProductsType.pants;
                }
                else if (transaction == (int)ProductsType.tshirt)
                {
                    return ProductsType.tshirt;
                }
                else if (transaction == 3)
                {
                    return ProductsType.dress;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
        }

        public void ViewYourProducts()
        {
            Products.SellerProductsList();
        }
    }
}
