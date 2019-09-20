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

            customers.Add(new Customer() { Name = "Danjel Kovalskij", PhoneNumber = "070-625 83 29", Email = "danjel.kovalskij@gmail.com", Favorite = true });
            customers.Add(new Customer() { Name = "Bengt Herrmansson", PhoneNumber = "070-323 74 02", Email = "bengt.herrmansson@webbmail.net", Favorite = false });
            customers.Add(new Customer() { Name = "Karl Olsson", PhoneNumber = "070-504 76 62", Email = "karl.olsson@hotmail.se", Favorite = false });
            customers.Add(new Customer() { Name = "Alberto Ramirdez", PhoneNumber = "070-839 67 40", Email = "alberto.ramidez@spainmail.sp", Favorite = true });
            customers.Add(new Customer() { Name = "Lucifer Morningstar", PhoneNumber = "666-666 66 66", Email = "lucifer.morningstar@hell.og", Favorite = true });
            customers.Add(new Customer() { Name = "Groot", PhoneNumber = "080-404 13 37", Email = "iam.groot@grootmail.boss", Favorite = true });
            customers.Add(new Customer() { Name = "Tony Stark", PhoneNumber = "066-724 01 76", Email = "tony.stark@ironmail.pow", Favorite = false });

            Console.WriteLine("===Customer Relation Management Service===\n");
            Console.WriteLine("Hej, är du registrerad?\nJ/N");
            string a = Console.ReadLine();

            string tempName = "";
            if (a[0] == 'j')
            {
                Console.WriteLine("Please input your name.");
                tempName = Console.ReadLine();
                int c = 0;
                foreach (Customer anka in customers)
                {
                    if (tempName == anka.Name)
                    {
                        Console.WriteLine("\nPhonenumber: {0}\nEmail: {1}\nFavourite: {2}", anka.PhoneNumber, anka.Email, anka.Favorite);
                        c++;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("Sorry, that name does not exist in the current context. Maybe a typo?\nTerminating Program . . .");
                }
            }

            else if (a[0] == 'n')
            {
                Console.WriteLine("====================\nYou have ({0}) contacts:", customers.Count);
                foreach (Customer anka in customers)
                {
                    Console.WriteLine("[#]{0}[#]", anka.Name);
                }
                int b = 0;
                foreach (Customer jorgen in customers)
                {
                    if (jorgen.Favorite == true)
                    {
                        b++;
                    }
                }
                
                Console.WriteLine("====================\nYou have ({0}) favorites.", b);
                foreach (Customer peter in customers)
                {
                    if (peter.Favorite == true)
                    {
                        Console.WriteLine("[<3]{0}[<3]", peter.Name);
                    }
                }
                Console.WriteLine("Terminating Program . . .");
            }

            else
            {
                Console.WriteLine("Not an answer......\nTerminating Program . . .");
            }
        }
    }
}
