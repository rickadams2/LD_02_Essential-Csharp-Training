using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
   public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        } 
        public override string ToString()
        {
            return "There are" + GroceryList.Length + "And they are:" + GroceryList.ToString();  
        }

    }
}
