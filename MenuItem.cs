using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Studio3
{
    class MenuItem
    {
        public double Price { get; }
        public string Description { get; }
        public char Category { get; }  // A=appetizer, M=Main, D=dessert
        public bool NewItem { get; private set; }

        public MenuItem(double price, string description, char category)
        {
            Price = price;
            Description = description;
            Category = category;
            NewItem = true;
        }

        public void OldItem()
        {
            NewItem = false;
        }
    }
}
