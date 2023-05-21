using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum PaymentType
    {
        Cash,   //Nakit 
        Card,   //Kart
    }

    enum CargoType
    {
        Yurtiçi,
    }
   
    class Payment
    {
        public static int totalamount = 0;
        public static List<String> paymentList = Enum.GetNames(typeof(PaymentType)).ToList();

        static int cardNumber;
        static int cvd;
        static String date;
        static String nameSurname;

        public static void PaymentListWrite()
        {
            for (int i = 0; i < paymentList.Count; i++)
            {
                Console.WriteLine(i + "- " + paymentList[i]);
            }
        }
        public static void PaymentListFinding()
        {
            TotalAmountCalculate();
            Console.WriteLine("Total Amount: "+totalamount);

            if (IsThereProduct() != -1)
            {
                int index;
                PaymentListWrite();
                Console.WriteLine("Enter the Payment List Enter");
                index = Convert.ToInt32(Console.ReadLine());

                if (index == (int)PaymentType.Card)
                {
                    CardInformation();
                    Console.WriteLine("Your cargo will be delivered to the " + CargoType.Yurtiçi + " cargo");
                    //Kargonuz Yurtiçi kargosuna verilecektir
                }
                else if (index == (int)PaymentType.Cash)
                {
                    OrderCreadted();
                    Console.WriteLine("Your cargo will be delivered to the " + CargoType.Yurtiçi + " cargo");
                }
                else
                {
                    Console.WriteLine("Your transaction did not take place");
                    //İşleminiz gerçekleşmedi
                }
            }
            else
            {
                Console.WriteLine("There are no products in the basket.");
                //Sepette ürün bulunmamaktadır.
            }
        }

        public static void CardInformation()
        {
            Console.WriteLine("Card Number :");
            cardNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CVD : ");
            cvd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad Surname: ");
            nameSurname = Console.ReadLine();
            Console.WriteLine("Expiration date");  //Son kullanım tarihi
            date = Console.ReadLine();

            OrderCreadted();
        }

        public static void OrderCreadted()
        {
            Console.WriteLine("The Order Was Created");
        }

        public static void TotalAmountCalculate()  //Toplam Tutar Hesapla
        {
            for(int i= 0; i < Customer.myBasketList.Count; i++) 
            {
                totalamount += Customer.myBasketList[i].amount;
            }
        }

        public static int IsThereProduct()
        {
            if(totalamount == 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
