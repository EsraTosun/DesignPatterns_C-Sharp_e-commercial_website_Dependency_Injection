using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public enum PatternsType
    {
        standard,
        oversize,
        tightTrotters,        //dar paça
        normalTrotters,       //normal paça
        wideTrotters,         //Geniş paça
        shortLenght,   //kısa boy
        kneeLength,    //diz boyu
        longLength,    //uzun boy
        Null,
    }

    public class Patterns
    {
        public static List<String> Patternslist = Enum.GetNames(typeof(PatternsType)).ToList();

        public static void PatternsWrite()
        {
            for (int i = 0; i < Patternslist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + Patternslist[i]);
            }
        }
        public static String PatternsFinding()
        {
            int index;
            PatternsWrite();
            Console.WriteLine("Enter the Patterns");
            index = Convert.ToInt32(Console.ReadLine());

            return Enum.GetName(typeof(PatternsType), index);   
        }
    }

}
