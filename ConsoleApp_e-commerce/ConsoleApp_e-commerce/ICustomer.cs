using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface ICustomer  //Müşteri
    {
        void MyBasket();  //Sepetim
        void Favorites();  //Favoriler
        void ProductsList();  //Ürünler
        void PaymentTransaction();
    }
}
