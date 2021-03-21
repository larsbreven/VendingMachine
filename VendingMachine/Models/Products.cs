using System;
using System.Collections.Generic;
using System.Text;
 
namespace VendingMachine.Models
{
    public class Products // This is the base class (parent) and it should be abstract
    {
        // Fields for all products
        
        public readonly string product1 = "Apple";
        public readonly string product2 = "Beer";
        public readonly string product3 = "Crisps";
        public readonly int price1 = 11;
        public readonly int price2 = 44;
        public readonly int price3 = 22;
        public readonly string currency = "SEK"; 

        // All products should be in one collection only, the list should be here 
    }
}
