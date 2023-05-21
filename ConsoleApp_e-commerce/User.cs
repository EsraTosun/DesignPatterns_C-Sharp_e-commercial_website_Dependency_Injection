using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_e_commerce
{
    public enum UserType
    {
        Seller,     //Satıcı
        Customer    //Müşteri
    }

    public enum UserTransactionsType
    {
        Login,              //Giriş yap
        AccountCreating,    //Hesap oluştur
        LogoutContiune,     // Otorum kapalı devam et
        Logout,             //Çıkış yap
    }
    class User : IUser
    {
        public static List<User> CustomerList = new List<User>();
        public static List<User> SellerList = new List<User>();

        public static UserType userType;
        UserTransactionsType userTransactionsType;


        public static int USERID;
        public int ID;
        public string Name;
        public string Surname;
        public string PhoneNumber;
        public string EmailAddress;
        public string Password;
        public string Adress;
        public static bool login = false;

        public User()    //Önceden kayıtlı müşteri ve satıcıları burada ekle
        { 

        }

        public User(int ıD, string name, string surname, string phoneNumber, string emailAddress, string password, string adress)
        {
            ID = ıD;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Password = password;
            Adress = adress;
        }

        public void LogIn()
        {
            Console.WriteLine("Email address your enter"); //E mail adresini giriniz.
            EmailAddress = Console.ReadLine();
            Console.WriteLine("Password your enter");   //şifrenizi giriniz
            Password = Console.ReadLine();

            AccounutControl();
        }

        

        public void LogOut()  //Kullancıya ait tüm verileri nullarız Çünkü oturum kapattıktan sonra 
        {                     //ulaşmasını engellemek için.
            return;
        }

        public void NewCreatingAnAccount()
        {
            User passing = new User();

            Console.WriteLine("Name your enter");
            passing.Name = Console.ReadLine();
            Console.WriteLine("Surname your enter");
            passing.Surname = Console.ReadLine();
            Console.WriteLine("E-mail your enter");
            passing.EmailAddress = Console.ReadLine();
            Console.WriteLine("Password your enter");
            passing.Password = Console.ReadLine();
            Console.WriteLine("Phonename your enter");
            passing.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Adress your enter");
            passing.Adress = Console.ReadLine();
            login = true;

            if(userType.Equals(UserType.Customer))
            {
                passing.ID = CustomerList.Count + 100;
                USERID = CustomerList.Count + 100;
                CustomerList.Add(passing);
            }
            else
            {
                passing.ID = SellerList.Count + 200;
                USERID = SellerList.Count + 200;
                SellerList.Add(passing);
            }

            
            LogoutContiune();
        }

        public void LogoutContiune()
        {
            if (User.userType.Equals(UserType.Customer))
            {
                CustomerProductsTransacitons.CustomerAccount();
            }
            else
            {
                SellerProductsTransactions.SellerAccount();
            }
        }

        public void AccounutControl()
        {
            for (int i = 0; i < User.CustomerList.Count; i++)
            {
                if (User.CustomerList[i].EmailAddress.Equals(EmailAddress)
                    && User.CustomerList[i].Password.Equals(Password))
                {
                    USERID = User.CustomerList[i].ID;
                    login = true;
                    AccountGo();
                    break;
                }
            }

            for (int i = 0; i < User.SellerList.Count; i++)
            {
                if (User.SellerList[i].EmailAddress.Equals(EmailAddress)
                    && User.SellerList[i].Password.Equals(Password))
                {
                    User.USERID = SellerList[i].ID;
                    User.login = true;
                    AccountGo();
                    break;
                }
            }
        }

        public void AccountGo()          //Müşteri hesabına git
        {
            if(userType.Equals(UserType.Customer))
                CustomerProductsTransacitons.CustomerAccount();

            else
                SellerProductsTransactions.SellerAccount();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ID: " + ID);
            builder.Append(" Name: " + Name);
            builder.Append(" Surname:" + Surname);
            builder.Append(" EmailAdress: " + EmailAddress);
            builder.Append(" Phone Number: " + PhoneNumber);
            builder.Append(" Adress: " + Adress);
            return builder.ToString();
        }
    }  
}

