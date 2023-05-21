using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerListTransactions
    {
        static int transaction;

        public static  void MyBasketORFavoritesAdd()
        {
            Products products = new Products();

            Console.WriteLine("1 - MyBasket Add");
            Console.WriteLine("2 - Favorites Add");
            Console.WriteLine("Enter a number other than 1 and 2 to avoid action");
            //İşlem yapılmaması için 1 ve 2 dışında bir sayı giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            products.amount = Seller.productList[Customer.transactionID - 1000].amount;
            products.ID = Customer.transactionID;

            if (transaction == 1)
            {
                Customer.myBasketList.Add(products);
            }
            else if (transaction == 2)
            {
                Customer.favoritesList.Add(products);
            }
            else
            {
                Console.WriteLine("The product has not been added");
                //Ürün eklenmedi
            }
        }

        public static void MyBasketDelete()
        {
            Console.WriteLine("If you want to remove it from mybasket, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want-enter the number -1");
            //İstemezseniz 100 sayısını giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < Customer.myBasketList.Count)
                Customer.myBasketList.RemoveAt(transaction);
        }

        public static void FavoritesDelete()
        {
            Console.WriteLine("If you want to remove it from favorites, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want enter the number -1");
            //İstemezseniz-1 sayısını giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < Customer.favoritesList.Count)
                Customer.favoritesList.RemoveAt(transaction);
        }
    }
}
