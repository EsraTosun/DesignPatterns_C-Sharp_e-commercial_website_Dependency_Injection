using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_e_commerce
{
    public enum ProductsType
    {
        allProduct,  //Tüm ürünler
        pants,       //pantolon
        tshirt,      //tişört
        dress        //elbise
    }

    class Products  //Ürünler
    {
        public static List<String> ProductsTypelist = Enum.GetNames(typeof(ProductsType)).ToList();
        public int UserID;
        public int ID;
        public String brand;   //marka
        public int amount;   //tutar
        public String color;
        public String productType;

        public String Patterns;   // boyu
        public String Bodys;      // bedeni
        public String FabricType;          // kumaşı


        BodyChart bodyChart;
        Brands brands;
        Color Color;
        Fabrics fabrics;
        Patterns patterns;
 
        public Products(BodyChart bodyChart,Brands brands,Color color, Fabrics fabrics, Patterns patterns)
        {
            this.fabrics = fabrics;
            this.patterns = patterns;
            this.bodyChart = bodyChart;
            this.brands = brands;
            this.Color = color;
        }

        public Products(BodyChart bodyChart, Brands brands, Color Color, Fabrics fabrics, Patterns patterns,
            int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
        {
            this.fabrics = fabrics;
            this.patterns = patterns;
            this.bodyChart = bodyChart;
            this.brands = brands;
            this.Color = Color;

            this.UserID = UserId;
            this.ID = ID;
            this.brand = brand;
            this.amount = amount;
            this.color = color;
            this.productType = productsType;
            this.Patterns = Patterns;
            this.Bodys = Bodys;
            this.FabricType = FabricType;
        }

        public virtual void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = Seller.productList.Where(x => x.UserID == User.USERID).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public virtual void ProductsList()  //Ürünleri Listele
        {
            for (int i = 0; i < Seller.productList.Count; i++)
            {
                Console.WriteLine(Seller.productList[i]);
            }
        }

        public virtual void FindingDesiredProduct()
        {
            List<Products> result = Seller.productList.Where(x => x.ID == Customer.DesiredID).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public virtual void ProductDelete()
        {
            int index = Seller.productList.FindIndex(r => r.ID == Seller.DesiredID);
            Seller.productList.RemoveAt(index);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ID: " + ID);
            builder.Append(" brand: " + brand);
            builder.Append(" amount:" + amount);
            builder.Append(" color: " + color);
            builder.Append(" productType " + productType);
            return builder.ToString();
        }
    }
}
