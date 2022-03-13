using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{   

     class CustomerManajer
    {
        static void Main(string[] args) 
        { 
        Customer customer1 = new Customer();
         customer1.Name = "Musa";
         customer1.Lastname = "Bayram";
         customer1.Age = 29;
         customer1.id = "001";
         
        Customer customer2 = new Customer();
         customer2.Name = "Nurten";
         customer2.Lastname = "Bayram";
         customer2.Age = 30;
         customer2.id = "002";

        Customer customer3 = new Customer();
         customer3.Name = "Mustafa Sadık";
         customer3.Lastname = "Bayram";
         customer3.Age = 6;
         customer3.id = "003";
            

         Customer[] customers = new Customer[] {customer1,customer2,customer3};


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Lastname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.id);
                Console.WriteLine("-------.Next.-------");
            }

            musterimanajer musterimanajers = new musterimanajer { };
            musterimanajers.add(customer1);
            Console.WriteLine("-------.Next.-------");
            musterimanajers.add(customer2);
            Console.WriteLine("-------.Next.-------");
            musterimanajers.add(customer3);
            Console.WriteLine("-------.Next.-------");
            musterimanajers.list(customer2);
            Console.WriteLine("-------.Next.-------");
            musterimanajers.delete(customer3);
            
        }

    }
}
