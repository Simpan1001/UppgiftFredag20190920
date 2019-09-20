using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList customers = new System.Collections.ArrayList();

            customers.Add(new Customer() { name = "Danjel Kovalskij", PhoneNumber = "070-625 83 29", Email = "danjel.kovalskij@gmail.com", Favorite = true });
            customers.Add(new Customer() { name = "Bengt Herrmansson", PhoneNumber = "070-323 74 02", Email = "bengt.herrmansson@webbmail.net", Favorite = false });
            customers.Add(new Customer() { name = "Karl Olsson", PhoneNumber = "070-504 76 62", Email = "karl.olsson@hotmail.se", Favorite = false });
            customers.Add(new Customer() { name = "Alberto Ramirdez", PhoneNumber = "070-839 67 40", Email = "alberto.ramidez@spainmail.sp", Favorite = true });

            Console.WriteLine("Hej, är du registrerad?");


        }
    }
}
