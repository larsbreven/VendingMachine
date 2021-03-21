using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Beer : Products // Beer is the derived class (child) from Products (parent)
    {
        // Fields
        public int size = 33;
        public string measure = "cl";
        public string brand = "Budweiser";
        public string useBeer = "Open the can and drink the beer";
        public string recycleBeer = "When empty, recycle the can";

    }
}
