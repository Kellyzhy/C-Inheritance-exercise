using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //BronzeCustomer bronzeCustomer = new BronzeCustomer();
            //bronzeCustomer.AddBronzeCustomer();
            //bronzeCustomer.PrintBronzeCustomer();

            Console.WriteLine("Press 1 to Add Bronze customer");
            Console.WriteLine("Press 2 to Add Silver customer");
            Console.WriteLine("Press 3 to Add Gold customer");
            Console.WriteLine("Press 4 to Add Platinum customer");
            Console.WriteLine("Enter your Option -> ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer();
            switch (choice)
            {
                case 1:
                    customer = new BronzeCustomer();
                    break;
                case 2:
                    customer = new SilverCustomer();
                    break;
                case 3:
                    customer = new GoldCustomer();
                    break;
                case 4:
                    customer = new PlatinumCustomer();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            if (customer != null)
            {
                customer.AddCustomer();
                customer.PrintCustomer();
            }
            Console.Read();
        }
    }
            
}
