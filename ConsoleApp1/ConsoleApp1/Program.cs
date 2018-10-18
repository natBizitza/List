using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FamousSinger f1 = new FamousSinger("MOTION PICTURE CAST RECORDING", "THE GREATEST SHOWMAN");
            FamousSinger f2 = new FamousSinger("GEORGE EZRA", "STAYING AT TAMARA'S");
            FamousSinger f3 = new FamousSinger("", "");

            List<FamousSinger> singers = new List<FamousSinger>();

            singers.Add(f1);
            singers.Add(f2);

            // TODO: method display singers
            string newSinger = "", reply = "";
            Console.WriteLine("List of Famous Singers: ");
            foreach (FamousSinger x in singers)
            {
                Console.WriteLine(x.MostrarDatos());
            }

            do
            {
                Console.WriteLine("Introduce a singer.");
                newSinger = Console.ReadLine();
                Console.WriteLine("Name the best selling album:");
                string newAlbum = Console.ReadLine();
                f3.SetName(newSinger);
                f3.SetbestSellingAlbum(newAlbum);
                singers.Add(f3);

                Console.WriteLine("List of Famous Singers: ");
                foreach (FamousSinger x in singers)
                {
                    Console.WriteLine(x.MostrarDatos());
                }

                Console.WriteLine("Would you like to introduce one more singer? If not - type 'no'.");
                reply = Console.ReadLine();

            } while (reply.ToLower() != "no");
            


            //int counter = 0;
            //string number;
            //List<string> compra = new List<string>();

            //CreateList(compra);
            //OrderList(compra);
            //ShowList(compra);
            //OrderList(compra);
            //DeleteElement(compra,"manzanas");
            //OrderList(compra);
            //ShowList(compra);
            //CountElements(compra);

            //List<double> decimals = new List<double>();
            //List<int> ints = new List<int>();

            //Console.WriteLine("Type a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Type a number:");
            //    number = Console.ReadLine();

            //    if (number.Contains(".") || number.Contains(","))
            //    {
            //        decimals.Add(Convert.ToDouble(number));
            //        counter++;
            //        Console.WriteLine("One more to decimals!");
            //        //TODO: hijack errors 
            //    }
            //    else if (Convert.ToInt32(number) > 0)
            //    {
            //        //number = Convert.ToInt32(Console.ReadLine);
            //        ints.Add(Convert.ToInt32(number));
            //        counter++;

            //        Console.WriteLine("One more to ints!");
            //    }

            //} while (Convert.ToDouble(number)>0);

            //CountInts(ints);

            //CountDecimals(decimals);

            //int sumOfInts =ints.Sum();
            //Console.WriteLine("Sum of ints." + sumOfInts);

            //double sumOfDecimals = decimals.Sum();
            //Console.WriteLine("Sum of decimals." + sumOfDecimals);

            //double sumAll = Convert.ToDouble(sumOfInts) + sumOfDecimals;

            //Console.WriteLine("Sum of all numbers. " + sumAll);

            //double average = sumAll / (ints.Count() + decimals.Count());

            //Console.WriteLine("Average is " + average);

            Console.ReadKey();
        }

        public static void CreateList(List<String> compra)
        {
            compra.Add("manzanas");
            compra.Add("turones");
            compra.Add("aroz");

            Console.WriteLine("You have created your List!");
        }
        public static void ShowList(List<String> compra)
        {
            foreach (string x in compra)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

        public static void OrderList(List<String> compra)
        {
            compra.Sort(); 
        }

        public static void DeleteElement(List<String> compra, string y)
        {
            compra.Remove(y);

            Console.WriteLine("You removed " + y);
            Console.ReadLine();  
        }

        public static void CountElements(List<String> compra)
        {
           int cuantity = compra.Count();

            Console.WriteLine("You have " + cuantity + " elements.");
            Console.ReadLine();
        }

        public static void CountInts(List<int> ints)
        {
            int cuantity = ints.Count();

            Console.WriteLine("You have " + cuantity + " ints.");
            Console.ReadLine();
        }

        public static void CountDecimals(List<double> decimals)
        {
            int cuantity = decimals.Count();

            Console.WriteLine("You have " + cuantity + " decimals.");
            Console.ReadLine();
        }
        public static void ShowSingers(List<FamousSinger> compra)
        {
            foreach (FamousSinger x in compra)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
