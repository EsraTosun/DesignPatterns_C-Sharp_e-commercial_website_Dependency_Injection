using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    //Kumaş tipleri

    public enum PantsFabricType
    {
        Satin,
        Polyester,
        Likra,
        Cotton,
        Null,
    }

    public enum DressFabricType
    {
        Polyester,
        Viskon,
        Cotton,    //pamuk
        Null,
    }

    public enum TshirtFabricType
    {
        Cotton,
        Null,
    }

    public class Fabrics
    {
        public static List<String> PantsFabricTypelist = Enum.GetNames(typeof(PantsFabricType)).ToList();
        public static List<String> DressFabricTypelist = Enum.GetNames(typeof(DressFabricType)).ToList();

        public static void PantsFabricTypeWrite()
        {
            for (int i = 0; i < PantsFabricTypelist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + PantsFabricTypelist[i]);
            }
        }
        public static PantsFabricType PantsFabricTypeFinding()
        {
            int index;
            PantsFabricTypeWrite();
            Console.WriteLine("Enter the PantsFabricType");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)PantsFabricType.Satin)
            {
                return PantsFabricType.Satin;
            }
            else if (index == (int)PantsFabricType.Polyester)
            {
                return PantsFabricType.Polyester;
            }
            else if (index == (int)PantsFabricType.Likra)
            {
                return PantsFabricType.Likra;
            }
            else if (index == (int)PantsFabricType.Cotton)
            {
                return PantsFabricType.Cotton;
            }
            else
            {
                return PantsFabricType.Null;
            }
        }

        public static void DressFabricTypeeWrite()
        {
            for (int i = 0; i < DressFabricTypelist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + DressFabricTypelist[i]);
            }
        }
        public static DressFabricType DressFabricTypeFinding()
        {
            int index;
            DressFabricTypeeWrite();
            Console.WriteLine("Enter the PantsFabricType");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)DressFabricType.Polyester)
            {
                return DressFabricType.Polyester;
            }
            else if (index == (int)DressFabricType.Viskon)
            {
                return DressFabricType.Viskon;
            }
            else if (index == (int)DressFabricType.Cotton)
            {
                return DressFabricType.Cotton;
            }
            else
            { 
                return DressFabricType.Null; 
            }
        }
    }
}
