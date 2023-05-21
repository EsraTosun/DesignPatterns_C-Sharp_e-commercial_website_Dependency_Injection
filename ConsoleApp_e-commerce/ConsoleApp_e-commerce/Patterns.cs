using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public enum TshirtPatterns  //tişört kalıpları
    {
        standard,
        oversize,
        Null,
    }

    public enum PantTrotterPatterns   //Pantolon paça kalıpları
    {
        tightTrotters,        //dar paça
        normalTrotters,       //normal paça
        wideTrotters,         //Geniş paça
        Null,
    }

    public enum DressLengthPatterns  //elbise boy kalıpları
    {
        shortLenght,   //kısa boy
        kneeLength,    //diz boyu
        longLength,    //uzun boy
        Null,
    }

    public class Patterns
    {
        public static List<String> TshirtPatternslist = Enum.GetNames(typeof(TshirtPatterns)).ToList();
        public static List<String> PantTrotterPatternslist = Enum.GetNames(typeof(PantTrotterPatterns)).ToList();
        public static List<String> DressLengthPatternslist = Enum.GetNames(typeof(DressLengthPatterns)).ToList();

        public static void TshirtPatternsWrite()
        {
            for (int i = 0; i < TshirtPatternslist.Count-1; i++)
            {
                Console.WriteLine(i + "- " + TshirtPatternslist[i]);
            }
        }
        public static TshirtPatterns TshirtPatternsFinding()
        {
            int index;
            TshirtPatternsWrite();
            Console.WriteLine("Enter the TshirtPatterns");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)TshirtPatterns.standard)
            {
                return TshirtPatterns.standard;
            }
            else if(index == (int)TshirtPatterns.oversize)
            {
                return TshirtPatterns.oversize;
            }
            else
            {
                return TshirtPatterns.Null;
            }
        }

        public static void PantTrotterPatternsWrite()
        {
            for (int i = 0; i < PantTrotterPatternslist.Count - 1; i++)
            {
                Console.WriteLine(i + "- " + PantTrotterPatternslist[i]);
            }
        }
        public static PantTrotterPatterns PantTrotterPatternsFinding()
        {
            int index;
            PantTrotterPatternsWrite();
            Console.WriteLine("Enter the PantTrotterPatterns");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)PantTrotterPatterns.tightTrotters)
            {
                return PantTrotterPatterns.tightTrotters;
            }
            else if(index == (int)PantTrotterPatterns.normalTrotters)
            {
                return PantTrotterPatterns.normalTrotters;
            }
            else if(index == (int)PantTrotterPatterns.wideTrotters)
            {
                return PantTrotterPatterns.wideTrotters;
            }
            else
            {
                return PantTrotterPatterns.Null;
            }
        }

        public static void DressLengthPatternsWrite()
        {
            for (int i = 0; i < DressLengthPatternslist.Count - 1; i++)
            {
                Console.WriteLine(i + "- " + DressLengthPatternslist[i]);
            }
        }
        public static DressLengthPatterns DressLengthPatternsFinding()
        {
            int index;
            DressLengthPatternsWrite();
            Console.WriteLine("Enter the DressLengthPatterns");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)DressLengthPatterns.shortLenght)
            {
                return DressLengthPatterns.shortLenght;
            }
            else if (index == (int)DressLengthPatterns.kneeLength)
            {
                return DressLengthPatterns.kneeLength;
            }
            else if(index == (int)DressLengthPatterns.longLength)
            {
                return DressLengthPatterns.longLength;
            }
            else
            {
                return DressLengthPatterns.Null;
            }
        }
    }

}
