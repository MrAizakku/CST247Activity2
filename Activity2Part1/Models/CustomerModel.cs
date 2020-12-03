using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerModel(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}