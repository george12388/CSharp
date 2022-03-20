using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Tema1
{
    public class Program
    {
        public static void ClientPrint(IEnumerable<Client> clients)
        {
            foreach (Client client in clients)
            {
                Console.WriteLine(client);
            } 
        }

        public static IEnumerable<Client> clientsOver40(IEnumerable<Client> clients)
        {
            IEnumerable<Client> over40 = clients.Where(clients => DateTime.Now.Year - clients.BirthYear > 40);
            return over40;
        }
        
        public static IEnumerable<Client> clientsUnder18(IEnumerable<Client> clients)
        {
            IEnumerable<Client> under18 = clients.Where(clients => DateTime.Now.Year - clients.BirthYear < 18);
            return under18;
        }
        

        public static void Main(string[] args)
        {
            IEnumerable<Client> clients = new List<Client>
            {
                new Client {Id = 1, FirstName = "Ana", LastName = "Popescu", BirthYear = 1984},
                new Client {Id = 2, FirstName = "Mara", LastName = "Radu", BirthYear = 1974},
                new Client {Id = 3, FirstName = "Marius", LastName = "Paun", BirthYear = 1954},
                new Client {Id = 4, FirstName = "Flavia", LastName = "Dumitrescu", BirthYear = 1993},
                new Client {Id = 5, FirstName = "Ioan", LastName = "Vasilescu", BirthYear = 1984},
                new Client {Id = 6, FirstName = "Dana", LastName = "Constantinescu", BirthYear = 2005},
                new Client {Id = 7, FirstName = "Ana", LastName = "Popescu", BirthYear = 2000},
                new Client {Id = 8, FirstName = "Flavia", LastName = " Dumitrescu ", BirthYear = 1993}
            };
                Console.WriteLine("First clients:");
                ClientPrint(clients);
                Console.WriteLine("Clients over 40:");
                ClientPrint(clientsOver40(clients));

                IEnumerable<Client> newclients = new List<Client>
                {
                    new Client {Id = 9, FirstName = "Rares", LastName = "Puiu", BirthYear = 2002},
                    new Client {Id = 10, FirstName = "Ana", LastName = "Arre", BirthYear = 1983},
                    new Client {Id = 11, FirstName = "Fabian", LastName = "Sovav", BirthYear = 1967},
                    new Client {Id = 12, FirstName = "Flavius", LastName = "Dumitrescu", BirthYear = 1999},
                    new Client {Id = 13, FirstName = "Ioana", LastName = "Vasile", BirthYear = 1980},
                };
                IEnumerable<Client> allclients = clients.Union(newclients);
                Console.WriteLine("All clients:");
                ClientPrint(allclients);
               
               Console.WriteLine("order ascended by last name: ");
               ClientPrint(allclients.OrderBy(c => c.LastName));
               Console.WriteLine("Order by birth year: ");
               ClientPrint(allclients.OrderByDescending(c => c.BirthYear));
               
               Console.WriteLine("order ascended by last name and birth year: ");
               ClientPrint(allclients.OrderBy(c => c.LastName).ThenByDescending(c => c.BirthYear));
               Console.WriteLine("Order ascended by first and last name");
               ClientPrint(allclients.OrderBy(c =>c.FirstName).ThenBy(c => c.LastName));
               Console.WriteLine("Clients under 18 years:");
               ClientPrint(clientsUnder18(clients));



        }

    }
}