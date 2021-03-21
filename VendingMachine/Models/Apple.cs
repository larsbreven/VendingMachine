using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Apple : Products                  // Apple is the derived class (child) from Products (parent)
    {
        // Fields
        public int size = 80;
        public string measure = "gram";
        public string brand = "Kivik";
        public string useApple = "Please eat the apple";
        public string recycleApple = "Please throw the eaten apple in the bin";

    }
}