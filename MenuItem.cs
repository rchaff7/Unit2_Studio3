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
        public string Category { get; }  // appetizer, main, dessert
        public bool NewItem { get; private set; }

        public MenuItem(double price, string description, string category)
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
