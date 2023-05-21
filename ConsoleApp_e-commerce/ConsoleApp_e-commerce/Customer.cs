using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum CustomerAccountType
    {
        AccountInformation = 1,
        Products = 2,
        MyBasket = 3,
        Favorites = 4,
        Payment = 5,
        Logout = 6,
    }
    class Customer:User, ICustomer  //Müşteri
    {
        static Products products = new Products();
        static User user = new User();

        public static List<Products> favoritesList = new List<Products>();
        public static List<Products> myBasketList = new List<Products>();  

        static int transactionID = -1;
        static int transaction = -1;

        public static int desiredProductsIndex = -1;
        public static int desiredProductsAmound = -1;
        public static ProductsType desiredProductsType;

        public void ProductsList()    //Ürünler
        {
            Products products = new Products();
            products.ProductsList();
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - MyBasket Add");
            Console.WriteLine("2 - Favorites Add");
            Console.WriteLine("Enter a number other than 1 and 2 to avoid action");
            //İşlem yapılmaması için 1 ve 2 dışında bir sayı giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            PriceFinding();
            products.amount = desiredProductsAmound;
            products.ID = transactionID;

            if (transaction == 1)
            {
                myBasketList.Add(products);
            }
            else if(transaction == 2)
            {
                favoritesList.Add(products);
            }
            else
            {
                Console.WriteLine("The product has not been added");
                //Ürün eklenmedi
            }
        }

        public void MyBasket()
        {
            for(int i=0; i<myBasketList.Count;  i++)
            {
                Products.FindingDesiredProduct(myBasketList[i].ID);
            }

            Console.WriteLine("If you want to remove it from mybasket, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want-enter the number -1");
            //İstemezseniz 100 sayısını giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            if(transaction >= 0 && transaction < myBasketList.Count) 
                MyBasketDelete();
        }

        public void MyBasketDelete()
        {
            myBasketList.RemoveAt(transaction);
        }

        public void Favorites()
        {
            for (int i = 0; i < favoritesList.Count; i++)
            {
                Products.FindingDesiredProduct(favoritesList[i].ID);
            }

            Console.WriteLine("If you want to remove it from favorites, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want-enter the number 1");
            //İstemezseniz-1 sayısını giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < favoritesList.Count)
                FavoritesDelete();
        }

        public void FavoritesDelete()
        {
            favoritesList.RemoveAt(transaction);
        }

        public void PaymentTransaction()
        {
            Payment.PaymentListFinding();
        }

        public static void PriceFinding()
        {
            if(transactionID >= 300 && transactionID < 400)
            {
                desiredProductsAmound = Pants.FindingPriceDesiredPants(transactionID);
            }
            else if(transactionID >= 400 && transactionID < 500)
            {
                desiredProductsAmound = Tshirt.FindingPriceDesiredTshirt(transactionID);
            }
            else
            {
                desiredProductsAmound = Dress.FindingPriceDesiredDress(transactionID);    
            }
        }
    }
}
