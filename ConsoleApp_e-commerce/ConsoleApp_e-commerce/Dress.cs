using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Dress : Products //Elbise
    {
        public DressLengthPatterns dressLengthPatterns;   //Elbise boyu
        public PantsAndDressBodys pantsAndDressBodys;      //Elbise bedeni
        public DressFabricType dressFabricType;          //Elbise kumaşı
        
        public Dress()
            : base()
        {

        }

        public Dress(int UserId, int ID, Brand brand, int amount, ColorType color, 
            ProductsType productsType, DressLengthPatterns dressLengthPatterns,
            PantsAndDressBodys pantsAndDressBodys, DressFabricType dressFabricType
            )
            : base(UserId, ID, brand, amount, color, productsType)
        {

        }  

        public static void SortTheDress()
        {
            for (int i = 0; i < Seller.dressList.Count; i++)
            {
                Console.WriteLine(Seller.dressList[i].ToString());
            }
        }

        public static void SellerSortTheDress()
        {
            for (int i = 0; i < Seller.dressList.Count; i++)
            {
                if (Seller.dressList.ElementAt(i).UserID == User.USERID)
                {
                    Console.WriteLine(Seller.dressList.ElementAt(i));
                }
            }
        }

        public static void FindingDesiredDress(int DesiredID)
        {
            for (int i = 0; i < Seller.dressList.Count; i++)
            {
                if (Seller.dressList[i].ID == DesiredID)
                {
                    Console.WriteLine(Seller.dressList.ElementAt(i));
                }
            }
        }

        public static int FindingPriceDesiredDress(int DesiredID)
        {
            for (int i = 0; i < Seller.dressList.Count; i++)
            {
                if (Seller.dressList[i].ID == DesiredID)
                {
                    return Seller.tshirtsList[i].amount;
                }
            }
            return 0;
        }
    }
}
