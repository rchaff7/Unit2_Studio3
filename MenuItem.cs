using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Studio3
{
    class MenuItem
    {
        public string Name { get; }
        public double Price { get; }
        public string Description { get; }
        public string Category { get; }  // appetizer, main, dessert
        public bool NewItem { get; private set; }

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            NewItem = true;
        }

        public void SetItemOld()
        {
            NewItem = false;
        }

        public void PrintItem()
        {
            Console.WriteLine(
                "\n" +
                "Name: " + Name + "\n" +
                "Price: " + Price + "\n" +
                "Description: " + Description + "\n" +
                "Category: " + Category + "\n" +
                "New Item: " + NewItem
            );
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Category == item.Category;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" +
                "Category: " + Category;
        }
    }
}
