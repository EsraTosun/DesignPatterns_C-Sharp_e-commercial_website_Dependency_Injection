using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    //Kumaş tipleri

    public enum FabricType
    {
        Satin,
        Polyester,
        Likra,
        Viskon,
        Cotton,    //pamuk
        Null,
    }

    public class Fabrics
    {
        public static List<String> FabricTypelist = Enum.GetNames(typeof(FabricType)).ToList();

        public static void FabricTypeWrite()
        {
            for (int i = 0; i < FabricTypelist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + FabricTypelist[i]);
            }
        }
        public static String PantsFabricTypeFinding()
        {
            int index;
            FabricTypeWrite();
            Console.WriteLine("Enter the FabricType");
            index = Convert.ToInt32(Console.ReadLine());

            return Enum.GetName(typeof(FabricType), index); 
        }
    }
}
