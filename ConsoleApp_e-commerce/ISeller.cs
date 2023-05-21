using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface ISeller //Satıcı
    {
        void AccountInformation();  //Hesap Bilgileri
        void AddProduct();   //Ürün Ekle
        void DeleteProduct();  //Ürün Sil
        void ViewYourProducts();   //Ürünlerini görüntüle
    }
}
