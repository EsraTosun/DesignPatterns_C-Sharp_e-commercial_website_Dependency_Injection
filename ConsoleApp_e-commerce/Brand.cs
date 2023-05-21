using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public enum BrandType   //Marka
    {
        Lcwakiki,
        Defacto,
        Mavi,
        Null,
    }

    public class Brands
    {
        public static List<String> brandList = Enum.GetNames(typeof(BrandType)).ToList();

        public static void BrandListWrite()
        {
            for (int i = 0; i < brandList.Count-1; i++)
            {
                Console.WriteLine(i + "- " + brandList[i]);
            }
        }
        public static String BrandListFinding()
        {
            int index;
            BrandListWrite();
            Console.WriteLine("Enter the Brand List Enter");
            index = Convert.ToInt32(Console.ReadLine());

            return Enum.GetName(typeof(BrandType), index);
        }
    }
    }
