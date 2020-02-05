using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAssignment
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }



        public virtual void AddCustomer()
        {
            Console.Write("Enter Id -> ");
            Id = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Enter Name -> ");
            Name = Console.ReadLine();

            Console.Write("Enter Mobile -> ");
            Email = Console.ReadLine();

            Console.Write("Enter Email -> ");
            Email = Console.ReadLine();
        }
        public virtual void PrintCustomer()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Mobile = " + Mobile);
            Console.WriteLine("Email = " + Email);
        }
    }


    class BronzeCustomer: Customer
    {

        public string Discount { get; set; }
        
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.Write("Enter discount -> ");
            Discount = Console.ReadLine();
        }
        public override void PrintCustomer()
        {
            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("Bronze customer has birthday gift with 1 free samples");


        }

    }
    class SilverCustomer : Customer
    {

        public string Discount { get; set; }
        
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.Write("Enter discount -> ");
            Discount = Console.ReadLine();
        }
        public override void PrintCustomer()
        {
            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("Silver customer has birthday gift with 2 free samples");

        }
    }

    class GoldCustomer : Customer
    {
        public string Discount { get; set; }
        
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.Write("Enter discount -> ");
            Discount = Console.ReadLine();
        }
        public override void PrintCustomer()
        {
            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("Gold customer has birthday gift with 3 free samples");
        }
    }
    class PlatinumCustomer : Customer
    {
        public string Discount { get; set; }
        
        public override void AddCustomer()
        {
            base.AddCustomer();
            Console.Write("Enter discount -> ");
            Discount = Console.ReadLine();
        }
        public override void PrintCustomer()
        {
            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("Platinum customer has birthday gift with 4 free samples");
        }
    }
}

