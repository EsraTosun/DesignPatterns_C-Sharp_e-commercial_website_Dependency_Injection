using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface ISeller //Satıcı
    {
        void AddProduct(ProductsType IncomingproductType);   //Ürün Ekle
        void DeleteProduct(ProductsType IncomingproductType);  //Ürün Sil
        void ViewYourProducts();   //Ürünlerini görüntüle
    }
}
