using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Dress : Products //Elbise
    {     
        public Dress(BodyChart bodyChart, Brands brands, Color color, Fabrics fabrics, Patterns patterns)
            : base(bodyChart, brands, color, fabrics, patterns)
        {

        }

        public Dress(BodyChart bodyChart, Brands brands, Color Color, Fabrics fabrics, Patterns patterns,
            int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
            : base(bodyChart, brands, Color, fabrics, patterns, UserId, ID, brand, amount, color, productsType,Patterns,Bodys,FabricType)
        {

        }

        public override void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = Seller.productList.Where(x => x.UserID == User.USERID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductsList()  //Ürünleri Listele
        {
            List<Products> result = Seller.productList.Where(
             x => x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductDelete()
        {
            int index = Seller.productList.FindIndex(r => r.ID == Seller.DesiredID &&
             r.productType.Equals(Enum.GetName(typeof(ProductsType), 3)));

            if (index >= 0)
                Seller.productList.RemoveAt(index);
        }

        public override void FindingDesiredProduct()
        {
            List<Products> result = Seller.productList.Where(x => x.ID == Customer.DesiredID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
