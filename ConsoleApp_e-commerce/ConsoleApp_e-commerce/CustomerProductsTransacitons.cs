using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerProductsTransacitons
    {
		static Customer customer = new Customer();
		static User user = new User();
		public static void CustomerAccount()    //Müşteri Hesabı
		{
			int transaction = -1;
			while (true)
			{
				Console.WriteLine("1- Account information"); //Hesap bilgileri
				Console.WriteLine("2- Products");  //Ürünlerini görüntüle
				Console.WriteLine("3- My Basket");   //Sepetim
				Console.WriteLine("4- Favorites");   //Favoriler
				Console.WriteLine("5- Payment");  //Ödeme
				Console.WriteLine("6- Logout");  //Çıkış yap
				transaction = Convert.ToInt32(Console.ReadLine());

				if (transaction == (int)CustomerAccountType.AccountInformation)
				{
					if (User.login)
						user.CustomerUser();

					else
						user.UserTransactions();
				}
				else if (transaction == (int)CustomerAccountType.Products)
				{
					customer.ProductsList();
				}
				else if (transaction == (int)CustomerAccountType.MyBasket)
				{
					customer.MyBasket();
				}
				else if (transaction == (int)CustomerAccountType.Favorites)
				{
					customer.Favorites();
				}
                else if (transaction == (int)CustomerAccountType.Payment)
                {
					if(User.login)
						customer.PaymentTransaction();

					else
						Console.WriteLine("Log in");  // Oturum aç
                }
                else if (transaction == (int)CustomerAccountType.Logout)
				{
					break;
				}
			}
		}
	}
}
