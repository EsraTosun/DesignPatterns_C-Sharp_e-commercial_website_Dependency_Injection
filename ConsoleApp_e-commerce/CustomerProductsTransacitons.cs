using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerProductsTransacitons
    {
        public static BodyChart chart = new BodyChart();
        public static Brands Brands = new Brands();
        public static Color Color = new Color();
        public static Fabrics Fabrics = new Fabrics();
        public static Patterns Patterns = new Patterns();
        public static Products products = new Products(chart, Brands, Color, Fabrics, Patterns);
        public static Seller seller = new Seller(products);
        static Customer customer = new Customer(seller);
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
					customer.AccountInformation();
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
					return;
				}
			}
		}
	}
}
