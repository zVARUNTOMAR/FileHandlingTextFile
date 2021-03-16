using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandlingDemo
{
    [Serializable]
    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }

       public Customer() { 
            
        }

        public Customer(string name, int age, string city) {
            this.name = name;
            this.age = age;
            this.city = city;
        }
    }
}
