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
        public static UserTransacions userTransacions = new UserTransacions();
        public static User user = new User();
        public static Products products = new Products();

        public static int DesiredID;

        public static List<String> CustomerAccountTypelist = Enum.GetNames(typeof(CustomerAccountType)).ToList();
        public static List<Products> favoritesList = new List<Products>();
        public static List<Products> myBasketList = new List<Products>();  

        public static int transactionID = -1;
        static int transaction = -1;

        public void AccountInformation()
        {
            UserTransacions.CustomerUser();
        }

        public void ProductsList()    //Ürünler
        {
            products.ProductsList();
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            CustomerListTransactions.MyBasketORFavoritesAdd();
        }

        public void MyBasket()
        {

            for (int i=0; i<myBasketList.Count;  i++)
            {
                DesiredID = myBasketList[i].ID;
                products.FindingDesiredProduct();
            }
            
            CustomerListTransactions.MyBasketDelete();
        }

        public void Favorites()
        {
            for (int i = 0; i < favoritesList.Count; i++)
            {
                DesiredID = favoritesList[i].ID;
                products.FindingDesiredProduct();
            }
             CustomerListTransactions.FavoritesDelete();
        }

        public void PaymentTransaction()
        {
            Payment.PaymentListFinding();
        }
    }
}
