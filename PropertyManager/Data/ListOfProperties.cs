﻿using System.Collections.Generic;
using PropertyManager.Models;

namespace PropertyManager.Data
{
    public class ListOfProperties
    {
        public List<Property> Properties = new ()
        {
            new Property(){Address = "1232 xyz st", Rent = 1250, Tenant = new Tenant()
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = "11/1/1989",
                Email = "jdoe@gmail.com",
                PhoneNumber = "619-555-5555"
            }, },
            new Property(){Address = "4532 adfa way", Rent = 5000, Tenant = new Tenant()
            {
                FirstName = "Sarah",
                LastName = "Ming",
                BirthDate = "11/1/1989",
                Email = "sming@gmail.com",
                PhoneNumber = "619-555-5555"
            }, },
            new Property(){Address = "3333 aadde st", Rent = 4000, Tenant = new Tenant()
            {
                FirstName = "Bugs",
                LastName = "Bunny",
                BirthDate = "12/1/1989",
                Email = "bb@gmail.com",
                PhoneNumber = "619-555-5555"
            }, },
            
        };
    }
}