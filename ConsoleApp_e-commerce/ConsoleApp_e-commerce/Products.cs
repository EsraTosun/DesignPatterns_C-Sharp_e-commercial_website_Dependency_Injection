using System;
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
        public int UserID;
        public int ID;
        public Brand brand;   //marka
        public int amount;   //tutar
        public ColorType color;
        public ProductsType productType;

        int transaction = -1;

        public Products()
        {

        }
        public Products(int UserId,int ID,Brand brand,int amount,ColorType color,ProductsType productsType)
        {
            this.UserID = UserId;
            this.ID = ID;
            this.brand = brand;
            this.amount = amount;
            this.color = color;
            this.productType = productsType;
        }

        public static void SellerProductsList()  //Ürünleri Listele
        {
            Tshirt.SellerSortTheTshirt();
            Dress.SellerSortTheDress();
            Pants.SellerSortThePants();
        }

        public void ProductsList()  //Ürünleri Listele
        {
            Tshirt.SortTheTshirt();
            Dress.SortTheDress();
            Pants.SortThePants();
        }

        public static void FindingDesiredProduct(int DesiredID)
        {
            Pants.FindingDesiredPants(DesiredID);
            Dress.FindingDesiredDress(DesiredID);
            Tshirt.FindingDesiredTshirt(DesiredID);
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
