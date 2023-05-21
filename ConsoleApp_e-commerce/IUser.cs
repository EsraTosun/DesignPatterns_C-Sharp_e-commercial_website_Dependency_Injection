using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface IUser  //Hesap Ara Yüzü olacak
    {
        void LogIn();  //Giriş Yap
        void NewCreatingAnAccount();   //Hesap Oluşturma
        void LogoutContiune();  //Giriş yapmadan devam et
        void LogOut();  //Çıkış Yap
    }
}
