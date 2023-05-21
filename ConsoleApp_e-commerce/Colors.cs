using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public enum ColorType
    {
        Red = 1,        //Kırmızı
        Green = 2,      //yeşil
        Blue = 3,       //mavi
        Black = 4,      //siyah
    }

    class Color
    {
        public static List<String> colorlist = Enum.GetNames(typeof(ColorType)).ToList();

        public static void ColorWrite()
        {
            for (int i =0; i < colorlist.Count; i++)
            {
                Console.WriteLine(i+1+"- "+colorlist[i]);
            }
        }

        public static String ColorFinfing()   //renk bulma
        {
            int index;
            ColorWrite();
            Console.WriteLine("Enter the Color");
            index = Convert.ToInt32(Console.ReadLine());

            return Enum.GetName(typeof(ColorType), index);
        }
    }
}
