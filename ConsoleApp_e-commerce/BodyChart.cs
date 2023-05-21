using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    //Body Chart => Beden tablosu
    public enum BodyType  //Pantolon ve elbise bedenleri
    {
        standard = 0,
        thirtsix = 1,
        thirtyeight = 2,
        forty = 3,
        fortytwo = 4,
        xsmall = 5,
        small = 6,
        medium = 7,
        large = 8,
        Null = 9,
    }

    public class BodyChart
    {
        public static List<String> Bodyslist = Enum.GetNames(typeof(BodyType)).ToList();

        public static void BodysWrite()
        {
            for (int i = 0; i < Bodyslist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + Bodyslist[i]);
            }
        }
        public static String BodysFinding()
        {
            int index;
            BodysWrite();
            Console.WriteLine("Enter the Bodys");
            index = Convert.ToInt32(Console.ReadLine());

            return Enum.GetName(typeof(BodyType), index);
        }
    }
}
