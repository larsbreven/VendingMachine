using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Crisps : Products                     // Crisps is the derived class (child) from Products (parent)
    {
        // Fields   
        public int size = 100;
        public string measure = "gram";
        public string brand = "Lays";
        public string useCrisps = "Open the bag and eat the crisps";
        public string recycleCrisps = "When empty, recycle the plastic bag";



    }
}
