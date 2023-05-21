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
        AddProduct = 3,
        DeleteProduct = 4,
        Logout = 5,
    }

    class Seller : User, ISeller
    {
        int transaction = -1;
        int index = 0;

        public static List<Products> productList = new List<Products>();

        public static BodyChart chart = new BodyChart();
        public static Brands Brands = new Brands();
        public static Color Color = new Color();
        public static Fabrics Fabrics = new Fabrics();
        public static Patterns Patterns = new Patterns();
        public static Products products = new Products(chart, Brands, Color, Fabrics, Patterns);

        public static UserTransacions userTransacions = new UserTransacions();

        public static int DesiredID;

        Products Products;
        public Seller(Products Products)
        {
            this.Products = Products;
        }

        public void AccountInformation()
        {
            UserTransacions.SellerUser();         
        }

        public void AddProduct()
        {
          BodyChart chart = new BodyChart();
          Brands Brands = new Brands();
          Color Color = new Color();
          Fabrics Fabrics = new Fabrics();
          Patterns Patterns = new Patterns();
          Products product = new Products(chart, Brands, Color, Fabrics, Patterns);

        product.productType = productsTypeFinding();
            product.ID = productList.Count + 1000;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            product.amount = Convert.ToInt32(Console.ReadLine());
            product.color = Color.ColorFinfing();
            product.brand = Brands.BrandListFinding();
            product.Bodys = BodyChart.BodysFinding();
            product.Patterns = Patterns.PatternsFinding();
            product.FabricType = Fabrics.PantsFabricTypeFinding();
            product.UserID = USERID;
            productList.Add(product);
        }

        public void DeleteProduct()  //Ürün tipi
        {
            Console.WriteLine("Delete ID: ");
            DesiredID = Convert.ToInt32(Console.ReadLine());

            products.ProductDelete();
        }

        public void ViewYourProducts()
        {
            products.SellerProductsList();
        }

        public static String productsTypeFinding()
        {
            int transactions;
            while (true)
            {
                Console.WriteLine("1- " + ProductsType.pants);
                Console.WriteLine("2- " + ProductsType.tshirt);
                Console.WriteLine("3- " + ProductsType.dress);
                transactions = Convert.ToInt32(Console.ReadLine());

                return Products.ProductsTypelist[transactions];
            }
        }
    }
}
