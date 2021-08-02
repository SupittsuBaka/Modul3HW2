using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW2.Models;

namespace Modul3HW2.Providers
{
    public class ContactProvider
    {
        private Contact[] _contacts;
        public ContactProvider()
        {
            _contacts = new Contact[]
            {
                new Contact()
                {
                    FirstName = "Oleg",
                    LastName = "Gazmanov",
                    Phone = "91-108-110"
                },
                new Contact()
                {
                    FirstName = "Олег",
                    LastName = "Винник",
                    Phone = "099-122-1321"
                },
                new Contact()
                {
                    FirstName = "106",
                    LastName = string.Empty,
                    Phone = "106-106-106"
                },
                new Contact()
                {
                    FirstName = "Дмитрий",
                    LastName = "Гордон",
                    Phone = "8-800-555-3535"
                },
                new Contact()
                {
                    FirstName = "Wendy",
                    LastName = "Grace",
                    Phone = "777-543"
                },
                new Contact()
                {
                    FirstName = "Garry",
                    LastName = "Potter",
                    Phone = "137-532"
                },
                new Contact()
                {
                    FirstName = "Владимир",
                    LastName = "Владимирович",
                    Phone = "044-674-645"
                }, new Contact()
                {
                    FirstName = "Bro",
                    LastName = string.Empty,
                    Phone = "055-532-46"
                },
                new Contact()
                {
                    FirstName = "(:",
                    LastName = "$^*(",
                    Phone = "111-1111-111"
                },
                new Contact()
                {
                    FirstName = "Game",
                    LastName = "Over",
                    Phone = "01-01-01-01-01"
                }
            };
        }

        public Contact[] Contacts => _contacts;
    }
}
