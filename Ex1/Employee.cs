﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Employee
    {
        //properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }

        //constructors
        public Employee(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;

            Salary = 20000m;
        }

        public Employee()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Name : {0} \nAddress {1} \nPhone {2} \n", Name, Address, PhoneNumber);
        }

        public virtual string FileFormat()
        {
            return string.Format("{0},{1},{2}", Name, Address, PhoneNumber);

        }

    }
}
