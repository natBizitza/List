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
            int counter = 0;
            string number;
            List<string> compra = new List<string>();

            //CreateList(compra);
            //OrderList(compra);
            //ShowList(compra);
            //OrderList(compra);
            //DeleteElement(compra,"manzanas");
            //OrderList(compra);
            //ShowList(compra);
            //CountElements(compra);

            List<double> decimals = new List<double>();
            List<int> ints = new List<int>();

            //Console.WriteLine("Type a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Type a number:");
                number = Console.ReadLine();

                if (number.Contains(".") || number.Contains(","))
                {
                    decimals.Add(Convert.ToDouble(number));
                    counter++;
                    Console.WriteLine("One more to decimals!");
                }
                else if (Convert.ToInt32(number) > 0)
                {
                    //number = Convert.ToInt32(Console.ReadLine);
                    ints.Add(Convert.ToInt32(number));
                    counter++;

                    Console.WriteLine("One more to ints!");
                }

            } while (Convert.ToDouble(number)>0);

            CountInts(ints);

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

            Console.WriteLine("You have " + cuantity + " elements.");
            Console.ReadLine();
        }
    }
}
