using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class UserTransacions
    {
        User user = new User();
        Seller seller = new Seller();
        Customer customer = new Customer();
        int transaction;

        public static UserTransacions userTransacions = new UserTransacions();  

        public void UserTransactionsMenu()
        {

            while (transaction != 3 && User.login == false)
            {
                Console.WriteLine("1-Login");   //Girş yap
                Console.WriteLine("2-New Creating an Account");   //Hesap oluştur
                Console.WriteLine("3-Continue without logging in");  //Giriş yapmadan devam et
                Console.WriteLine("4-Logout");
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == 1)
                {
                    user.LogIn();
                }
                else if (transaction == 2)
                {
                    user.NewCreatingAnAccount();
                }
                else if (transaction == 3)
                {
                    user.LogoutContiune();
                }
                else if (transaction == 4)
                {
                    user.LogOut();
                    return;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
        }

        public static void SellerUser()
        {
            for (int i = 0; i < User.SellerList.Count; i++)
            {
                if (User.SellerList[i].ID == User.USERID)
                {
                    Console.WriteLine(User.SellerList[i].ToString());
                    return;
                }
            }
            userTransacions.UserTransactionsMenu();
        }

        public static void CustomerUser()
        {
            for (int i = 0; i < User.CustomerList.Count; i++)
            {
                if (User.CustomerList[i].ID == User.USERID)
                {
                    Console.WriteLine(User.CustomerList[i].ToString());
                    return;
                }
            }
            userTransacions.UserTransactionsMenu();
        }
    }
}
