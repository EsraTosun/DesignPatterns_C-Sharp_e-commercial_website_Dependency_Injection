using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Pants : Products   //Pantolon
    {
        public PantTrotterPatterns pantTrotterPatterns;    //Pantolon paça kalıbı
        public PantsAndDressBodys pantsAndDressBodys;      //Pantolon bedeni
        public PantsFabricType pantsFabricType;            //Pantolon kumaşı

        public Pants()
            : base()
        {

        }

        public Pants(int UserId, int ID, Brand brand, int amount, ColorType color, 
            ProductsType productsType, PantTrotterPatterns pantTrotterPatterns,
            PantsAndDressBodys pantsAndDressBodys, PantsFabricType pantsFabricType
            )
            : base(UserId, ID, brand, amount, color, productsType)
        {

        }  

        public static void SellerSortThePants()
        {
            for (int i = 0; i < Seller.pantsList.Count; i++)
            {
                if (Seller.pantsList.ElementAt(i).UserID == User.USERID)
                {
                    Console.WriteLine(Seller.pantsList.ElementAt(i));
                }
            }
        }

        public static void SortThePants()
        {
            for(int i = 0;i < Seller.pantsList.Count;i++)
            {
                Console.WriteLine(Seller.pantsList[i].ToString());
            }
        }

        public static void FindingDesiredPants(int DesiredID)
        {
            for (int i = 0; i < Seller.pantsList.Count; i++)
            {
                if (Seller.pantsList[i].ID == DesiredID)
                {
                    Console.WriteLine(Seller.pantsList.ElementAt(i).ToString());
                }
            }
        }

        public static int FindingPriceDesiredPants(int DesiredID)
        {
            for (int i = 0; i < Seller.pantsList.Count; i++)
            {
                if (Seller.pantsList[i].ID == DesiredID)
                {
                    return Seller.tshirtsList[i].amount;
                }
            }
            return 0;
        }
    }
}
