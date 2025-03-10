﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApplicationDemo
{
    public class Person
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo  
        {
            get
            {
                // "Mark Tagle (mrktgle@gmail.com)"
                return $"{ FirstName } { LastName } ({ EmailAddress })";
            }
        }

    }
}
