using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Chapter2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryContacts();
        }

        private static void QueryContacts()
        {
            using (var context = new SampleEntities())
            {
                IQueryable<Contact> contacts = context.Contacts.Where(a => a.LastName.StartsWith("A"));

                if (!Object.ReferenceEquals(contacts, null))
                {
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine("{0} {1}", contact.FirstName.Trim(), contact.LastName);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
