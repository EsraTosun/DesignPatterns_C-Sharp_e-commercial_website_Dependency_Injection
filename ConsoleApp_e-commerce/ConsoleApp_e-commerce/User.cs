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
        int ID;
        string Name;
        string Surname;
        string PhoneNumber;
        string EmailAddress;
        string Password;
        string Adress;
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

        public void UserTypeLeading()    //Kullanıcı tipi öğrenme 
        {
            if (userType.Equals(UserType.Customer))
            {
                CustomerProductsTransacitons.CustomerAccount();
            }
            else
            {
                SellerProductsTransactions.SellerAccount();
            }
        }

        public void UserTransactions()
        {
            int transaction = -1;

            while (transaction !=3 && login == false)
            {
                Console.WriteLine("1-Login");   //Girş yap
                Console.WriteLine("2-New Creating an Account");   //Hesap oluştur
                Console.WriteLine("3-Continue without logging in");  //Giriş yapmadan devam et
                Console.WriteLine("4-Logout");
                transaction = Convert.ToInt32(Console.ReadLine()); 

                if (transaction == 1)
                {
                    LogIn();
                }
                else if (transaction == 2)
                {
                    NewCreatingAnAccount();
                }
                else if (transaction == 3)
                {
                    UserTypeLeading();
                }
                else if(transaction == 4)
                {
                    LogOut();
                    return;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
        }

        public void LogIn()
        {
            Console.WriteLine("Email address your enter"); //E mail adresini giriniz.
            EmailAddress = Console.ReadLine();
            Console.WriteLine("Password your enter");   //şifrenizi giriniz
            Password = Console.ReadLine();

            if (userType.Equals(UserType.Customer))
            {
                CustomerAccounutControl();
            }
            else
            {
                SellerAccounutControl();
            }
        }

        void CustomerAccounutControl()
        {
            for(int i= 0; i < CustomerList.Count; i++)
            {
                if (CustomerList[i].EmailAddress.Equals(EmailAddress) 
                    && CustomerList[i].Password.Equals(Password))
                {
                    USERID = i;
                    login = true;
                    CustomerAccountGo();
                    break;
                }
            }
        }

        void SellerAccounutControl()
        {
            for (int i = 0; i < SellerList.Count; i++)
            {
                if (SellerList[i].EmailAddress.Equals(EmailAddress)
                    && SellerList[i].Password.Equals(Password))
                {
                    USERID = i;
                    login = true;
                    SellerAccountGo();
                    break;
                }
            }
        }

        public void LogOut()  //Kullancıya ait tüm verileri nullarız Çünkü oturum kapattıktan sonra 
        {                     //ulaşmasını engellemek içim.
            Name = null;
            Surname = null;
            PhoneNumber = null;
            EmailAddress = null;
            Password = null;
            Adress = null;
            login = false;
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

            
            UserTypeLeading();
        }

        void CustomerAccountGo()          //Müşteri hesabına git
        {
            CustomerProductsTransacitons.CustomerAccount();
        }

        void SellerAccountGo()          //Satıcı hesabına git
        {
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

        public void SellerUser()
        {
            for(int i=0;  i<SellerList.Count; i++) 
            {
                if (SellerList[i].ID == USERID)
                {
                    Console.WriteLine(SellerList[i].ToString());
                    break;
                }
            }
        }

        public void CustomerUser()
        {
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (CustomerList[i].ID == USERID) 
                {
                    Console.WriteLine(CustomerList[i].ToString());
                    break;
                }
            }
        }

        public void AccountInformation()
        {
            SellerUser();
            CustomerUser();
        }
    }  
}

